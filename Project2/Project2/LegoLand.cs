using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Project2
{
    public delegate void priceCutEventLL(double pr, int pDiff, string parkName); // Define a delegate 
    class LegoLand
    {
        static Random rng = new Random(); // To generate random numbers 
        public static event priceCutEventLL priceCut; // Link event to delegate 
        private OrderProcessor OP = new OrderProcessor();
        private static int ticketPrice = 10;
        private static int priceCutCount = 0;
        private static int priceDiff;
        public int getPrice() { return ticketPrice; }
        public int getPriceDiff() { return priceDiff; }
        public static void changePrice(int price)
        {
            if (price < ticketPrice)
            {    // a price cut 
                if (priceCut != null)
                {// there is at least a subscriber
                    priceDiff = ticketPrice - price;
                    priceCut(price, priceDiff, "LegoLand");    // emit event to subscribers
                   
                    ticketPrice = price;
                    priceCutCount++;
                }
            }
            ticketPrice = price;
        }
        public void PricingModel()
        {
            while(priceCutCount < 20)
            {
                Thread.Sleep(500);
                OrderClass order = null;
                eCommerce.rwLock.AcquireReaderLock(300);
                try
                {
                    order = eCommerce.buffer.getACell();
                }
                finally
                {
                    eCommerce.rwLock.ReleaseReaderLock();
                }
                
                // Take the order from the queue of the orders; // Decide the price based on the orders
                int p = rng.Next(80, 300); // Console.WriteLine("New Price is {0}", p);
                LegoLand.changePrice(p);
            }
            
            
        }
    }
}
