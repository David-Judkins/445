using System;
using System.Threading;

namespace Project2
{
    public delegate void priceCutEventDL(double pr, double pDiff, string parkName); // Define a delegate 
    /// <summary>class
    /// <c>DisneyLand</c>
    /// represents disneyland park
    /// </summary>
    
    public class DisneyLand
    {
        static Random rng = new Random(); // To generate random numbers 
        public static event priceCutEventDL priceCut;
        private OrderProcessor OP = new OrderProcessor();
        private static double ticketPrice = 10;
        private static int priceCutCount = 0;
        private static double priceDiff;
        
        

        public double getPrice() { return ticketPrice; }

        public double getPriceDiff() { return priceDiff;}
        /// <summary>method
        /// <c>changePrice</c>
        /// changes the price and triggering a price cut event if neccessary
        /// </summary>
        /// <returns>void</returns>
        public static void changePrice(double price)
        {

            if (price < ticketPrice)
            {    
                if (priceCut != null)
                {  
                    priceDiff = ticketPrice - price;
                    
                    priceCut(price, priceDiff, "DisneyLand");//calls ticket on sale in the ticket agencies
                    

                    ticketPrice = price;
                    priceCutCount++;
                }
            }
            ticketPrice = price;
        }
        /// <summary>method
        /// <c>NewPrice</c>
        /// creates a new price based on current price and ticket amount
        /// </summary>
        /// <returns>void</returns>
        public double NewPrice(double Price, int Amount)
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
                Thread.Sleep(2000);
                OrderClass order = null;
               
                    eCommerce.rwLock.AcquireReaderLock(Timeout.Infinite);
                    try
                    {
                        order = eCommerce.buffer.getACell();
                        
                    }
                    finally
                    {
                        eCommerce.rwLock.ReleaseReaderLock();
                    }

                if (order != null)
                {
                    if ("DisneyLand" == order.getReceiverID())
                    {

                        OrderProcessor orderProc = new OrderProcessor();
                        Thread orderProcessorThread = new Thread(new ThreadStart(() => orderProc.orderProcessing(order)));
                        orderProcessorThread.Start();
                        eCommerce.buffer.eraseACell(order);
                        

                    }

                }

                double p = rng.NextDouble() * (300 - 80) + 80;
                DisneyLand.changePrice(p);
            }
            if(priceCutCount == 20)
            {
                Console.WriteLine("DisneyLand is closed");
            }
        }
    }
}
