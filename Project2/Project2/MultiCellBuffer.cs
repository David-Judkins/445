using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;


namespace Project2
{
    public class MultiCellBuffer
    {
        private Semaphore mutex = new Semaphore(0, 3);
        private OrderClass[] orderBuffer = new OrderClass[3];
        public MultiCellBuffer()
        {
            for (int i = 0; i < 3; i++)
                orderBuffer[i] = null;
            mutex.Release(3);
        }
        public void setACell(OrderClass order)
        {
            mutex.WaitOne();
            lock (orderBuffer)
            {
                for (int i = 0; i < 3; i++)
                {
                    if(orderBuffer[i] == null)
                    {
                        Console.WriteLine("Set cell " + i + " with " + order.getSenderID());
                        orderBuffer[i] = order;
                        i = 4;
                    }
                }
            }
        }
        public OrderClass getACell()
        {
            lock (orderBuffer)
            {
                for (int i = 0; i < 3; i++)
                {
                    if (orderBuffer[i] != null)
                    {
                        OrderClass tmp = orderBuffer[i];
                        return tmp;
                    }
                }
            }
            return null;
        }
        public void eraseACell(OrderClass order)
        {
            for(int i = 0; i < 3; i++)
            {
                 if(orderBuffer[i] == order)
                {
                    mutex.Release();
                    orderBuffer[i] = null;
                    i = 4;
                }
            }
        }
    }
}

