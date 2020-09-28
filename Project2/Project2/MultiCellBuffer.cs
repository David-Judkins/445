using System;
using System.Threading;


namespace Project2
{
    /// <summary>class
    /// <c>MultiCellBuffer</c>
    /// contains and locks the list of orders from concurrent reading and writing
    /// Receives orders from ticket agency and sends them to the respective park
    /// </summary>
    public class MultiCellBuffer
    {
        private Semaphore mutex = new Semaphore(0, 3);
        private OrderClass[] orderBuffer = new OrderClass[3];
        /// <summary>contructor
        /// <c>MultiCellBuffer</c>
        /// sets and empty list and sets the semaphore to represent a full list
        /// </summary>
        public MultiCellBuffer()
        {
            for (int i = 0; i < 3; i++)
            {
                orderBuffer[i] = null;
            }
            mutex.Release(3);
        }


        /// <summary>method
        /// <c>getACell</c>
        /// when allowed gets an order from the buffer
        /// </summary>
        /// <returns>OrderClass</returns>
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
        /// <summary>method
        /// <c>setACell</c>
        /// when allowed adds an order to the buffer 
        /// </summary>
        /// <returns>void</returns>
        public void setACell(OrderClass order)
        {
            mutex.WaitOne();
            lock (orderBuffer)
            {
                for (int i = 0; i < 3; i++)
                {
                    if(orderBuffer[i] == null)
                    {
                        Console.WriteLine("The order has been sent to buffer cell " + i + " for " + order.getReceiverID() + "\n");
                        orderBuffer[i] = order;
                        i = 3;
                    }
                }
                
                
            }
            
            
        }
        
        /// <summary>method
        /// <c>eraseACell</c>
        /// erases cells as needed
        /// </summary>
        /// <returns>void</returns>
        public void eraseACell(OrderClass order)
        {
            for(int i = 0; i < 3; i++)
            {
                 if(orderBuffer[i] == order)
                {
                    mutex.Release();
                    Console.WriteLine("An order from buffer cell " + i + " has been received by " + orderBuffer[i].getReceiverID() + "\n");
                    orderBuffer[i] = null;
                    i = 3;
                }
            }
        }
    }
}

