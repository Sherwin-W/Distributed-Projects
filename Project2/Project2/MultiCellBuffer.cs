using System;
using System.Threading;

namespace ParkingProject
{
    public class MultiCellBuffer
    {
        private readonly Order[] bufferCells;
        private readonly Semaphore semaphore;
        private readonly object[] cellLocks;//array of lock objects, one for each cell

        public MultiCellBuffer(int cellCount)
        {
            bufferCells = new Order[cellCount];
            semaphore = new Semaphore(cellCount, cellCount);
            cellLocks = new object[cellCount];

            for (int i = 0; i < cellCount; i++)
            {
                cellLocks[i] = new object();//initialize lock objects
            }
        }

        public void setOneCell(int cellIndex, Order order)
        {
            semaphore.WaitOne();

            lock (cellLocks[cellIndex])//lock the appropriate cell for writing
            {
                bufferCells[cellIndex] = order;
            }

            semaphore.Release();//release the semaphore permit when done
        }

        public Order getOneCell(int cellIndex)
        {
            semaphore.WaitOne();

            lock (cellLocks[cellIndex])
            {
                Order order = bufferCells[cellIndex];
                semaphore.Release();
                return order;
            }
        }
    }
}
