using System;
using System.Threading;

namespace Project2
{
    public delegate void priceCutEventLL(double pr, double pDiff, string parkName); // Define a delegate 
    /// <summary>class
    /// <c>LegoLand</c>
    /// represents legoland park
    /// </summary>
    public class LegoLand
    {
        static Random rng = new Random(); // To generate random numbers 
        public static event priceCutEventLL priceCut; // Link event to delegate 
        private static double ticketPrice = 10;
        private static int priceCutCount = 0;
        private static double priceDiff;
       
        
        public double getPrice() { return ticketPrice; }
        public double getPriceDiff() { return priceDiff; }
        /// <summary>method
        /// <c>changePrice</c>
        /// changes the price and triggering a price cut event if neccessary
        /// </summary>
        /// <returns>void</returns>
        public static void changePrice(double price)
        {
            if (price < ticketPrice)
            {    // a price cut 
                if (priceCut != null)
                {
                    priceDiff = ticketPrice - price;
                    priceCut(price, priceDiff, "LegoLand"); //calls ticket on sale in the ticket agencies

                    ticketPrice = price;
                    priceCutCount++;
                }
            }
            ticketPrice = price;
        }
        public double NewPrice(double price, int amount)
        {
            Random rand = new Random();
            double p = rand.NextDouble() * (300 - 80) + 80;
            return p;
        }
        /// <summary>method
        /// <c>PricingModel</c>
        /// receives/processes orders in order to set the next unit price
        /// </summary>
        /// <returns>void</returns>
        public void PricingModel()
        {

            while(priceCutCount < 20)
            {
                Thread.Sleep(300);
                OrderClass order = null;
                //locks out other readers from the buffer  
                eCommerce.rwLock.AcquireReaderLock(Timeout.Infinite);
                try
                {
                    order = eCommerce.buffer.getACell();
                        
                }
                finally
                {
                    //lets go of the lock on other readers to the buffer
                    eCommerce.rwLock.ReleaseReaderLock();
                }
                if (order != null)
                {
                    if ("LegoLand" == order.getReceiverID())
                    {
                        
                        OrderProcessor orderProc = new OrderProcessor();//creates a new OrderProcessor object to access its methods
                        Thread orderProcessorThread = new Thread(new ThreadStart(() => orderProc.orderProcessing(order)));//starts a new order process thread with the orderProcessing method 
                        orderProcessorThread.Start();
                        eCommerce.buffer.eraseACell(order);//erases the cell that was gotten while the reader lock was acquired

                    }

                }




                double p = rng.NextDouble() * (300 - 80) + 80;
                LegoLand.changePrice(p);
            }
            if (priceCutCount == 20)
            {
                Console.WriteLine("LegoLand is closed");
            }


        }
    }
}
