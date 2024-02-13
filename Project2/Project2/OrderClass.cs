using System;
using System.Threading;

namespace ParkingProject
{
    public class Order
    {
        private string senderId;
        private int cardNo;
        private int quantity;
        private int unitPrice;

        public Order(string senderId, int cardNo, int quantity, int unitPrice)
        {
            this.senderId = senderId;
            this.cardNo = cardNo;
            this.quantity = quantity;
            this.unitPrice = unitPrice;
        }

        public string GetSenderId()
        {
            return senderId;
        }
        public void SetSenderId(string value)
        {
            senderId = value;
        }
        public int GetCardNo()
        {
            return cardNo;
        }
        public void SetCardNo(int value)
        {
            cardNo = value;
        }
        public int GetQuantity()
        {
            return quantity;
        }
        public void SetQuantity(int value)
        {
            quantity = value;
        }
        public int GetUnitPrice()
        {
            return unitPrice;
        }
        public void SetUnitPrice(int value)
        {
            unitPrice = value;
        }
    }
}
