using System;
using System.Threading;

namespace ParkingProject
{
    public delegate void priceCutEvent(Int32 pr);
    public class ParkingStructure
    {
        static Random rng = new Random();
        public static event priceCutEvent priceCut;
        private MultiCellBuffer multiCellBuffer;

        private static Int32 parkingPrice = rng.Next(10, 41);//start price is between 10 and 41
        private static Int32 t = 0;//keeps track of price cuts
        private static double tax = Math.Round((0.08 + (rng.NextDouble() * (0.12 - 0.08))), 2);//random tax generated
        private static int location = rng.Next(2, 8);//random location charge
        public Int32 getPrice() { return parkingPrice; }

        public ParkingStructure()
        {
            multiCellBuffer = new MultiCellBuffer(3);
        }
        public static void changePrice(Int32 price)
        {
            if (price < parkingPrice)
            {
                if (priceCut != null)
                {
                    priceCut(price);
                    t++;
                }
            }
            parkingPrice = price;
        }
        public void PricingModel()
        {
            while(t < 20)
            {
                Thread.Sleep(500);
                int p = parkingPrice;

                double decreaseProbability = CalculateDecreaseProbability(p);
                double direction = rng.NextDouble();//increasing or decreasing trend

                if (direction < decreaseProbability)
                {
                    p -= rng.Next(1, 5);
                }
                else
                {
                    p += rng.Next(1, 5);
                }

                if (p < 10)
                {
                    p = 10;
                }
                else if (p > 40)
                {
                    p = 40;
                }
                ParkingStructure.changePrice(p);
            }
        }
        private double CalculateDecreaseProbability(int currentPrice)
        {
            return 0.033 * (currentPrice-10);//higher change to decrease when nearing 40
        }

        public void ProcessOrder(Order order)
        {
            //new thread to process order
            Thread orderThread = new Thread(() => ProcessOrderThread(order));
            orderThread.Start();
        }

        private void ProcessOrderThread(Order order)
        {
            if (order.GetCardNo() >= 5000 && order.GetCardNo() <= 7000)
            {
                double total = Math.Round((order.GetQuantity() * order.GetUnitPrice() * tax + location), 2);
                Console.WriteLine("Order processed: Agent{0} - Card No:{1} bought {2} parking spaces for: ${3} \nLocation Charge: ${4} Tax: {5}", order.GetSenderId(), order.GetCardNo(), order.GetQuantity(), total, location, tax);
            }
            else
            {
                Console.WriteLine("Order failed: Agent{0} - Card No:{1}", order.GetSenderId(), order.GetCardNo());//if fail credit card verification
            }
        }

        public class ParkingAgent
        {
            Boolean promo = false;
            int promotionalPrice = 0;
            ManualResetEvent promoEvent = new ManualResetEvent(false);

            ParkingStructure structure = new ParkingStructure();
            private MultiCellBuffer multiCellBuffer;
            public ParkingAgent(MultiCellBuffer multiCellBuffer)
            {
                this.multiCellBuffer = multiCellBuffer;
            }
            public void agentFunc()
            {
                while(t < 20)
                {
                    if(promo == true)
                    {
                        promoEvent.WaitOne();
                        Order order = GenerateOrder();
                        order.SetQuantity(determineQuantity(promotionalPrice));

                        int cellIndex = GetAvailableCellIndex();
                        if (cellIndex != -1)
                        {
                            //set the Order object in the selected cell
                            multiCellBuffer.setOneCell(cellIndex, order);

                            //signal the ParkingStructure that an order is available
                            structure.ProcessOrder(order);
                            promo = false;
                        }
                    }               
                }
            }

            private int GetAvailableCellIndex()
            {
                for (int cellIndex = 0; cellIndex < 3; cellIndex++)
                {
                    if (structure.multiCellBuffer.getOneCell(cellIndex) == null)
                    {
                        //returns first cell available
                        return cellIndex;
                    }
                }

                return -1;//signifies no available cells
            }
            public void parkingPromo(Int32 p)
            {
                promo = true;
                promotionalPrice = p;
                Console.WriteLine("Promotional Event! Parking only ${1} each", Thread.CurrentThread.Name, p);

                promoEvent.Set();
            }

            public Order GenerateOrder()
            {
                int cardNo = rng.Next(5000, 7000);//card has to be between 5000 and 7000 to be valid
                int quantity = determineQuantity(promotionalPrice);

                Order order = new Order(Thread.CurrentThread.Name, cardNo, quantity, promotionalPrice);
                return order;
            }

            private int determineQuantity(int price)
            {
                double calculatedValue = 100 - (price-10)*3.33;//agents will buy more if price is lower but not over 100
                return (int)Math.Round(calculatedValue);
            }

        }


        public class myApplication
        {
            static void Main(string[] args)
            {
                int N = 5;//5 agents set
                int K = 1;//1 parking structure
                ParkingStructure[] structures = new ParkingStructure[K];

                // Create and start threads for each ParkingStructure
                for (int i = 0; i < K; i++)
                {
                    structures[i] = new ParkingStructure();
                    Thread model = new Thread(new ThreadStart(structures[i].PricingModel));
                    model.Start();
                }

                ParkingAgent agent = new ParkingAgent(new MultiCellBuffer(3));
                ParkingStructure.priceCut += new priceCutEvent(agent.parkingPromo);

                Thread[] agents = new Thread[N];
                for (int i = 0; i < N; i++)
                {
                    agents[i] = new Thread(() => agent.agentFunc());
                    agents[i].Name = (i + 1).ToString();
                    agents[i].Start();
                }
            }
        }
    }
}
