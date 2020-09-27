using System;

using System.Threading;
namespace Project2

{
    //V1 starting point
    
    public class eCommerce
    {
        public static MultiCellBuffer buffer = new MultiCellBuffer();
        public static ReaderWriterLock rwLock = new ReaderWriterLock();

        static void Main(string[] args)
        {


            
            LegoLand ticketLL = new LegoLand();
            DisneyLand ticketDL = new DisneyLand();
            Thread legoland = new Thread(new ThreadStart(ticketLL.PricingModel)); 
            Thread disneyland = new Thread(new ThreadStart(ticketDL.PricingModel)); 
            
            legoland.Name = "LegoLand"; 
            disneyland.Name = "DisneyLand";
            disneyland.Start();
            legoland.Start();
            TicketAgency ticketAgency = new TicketAgency();
            LegoLand.priceCut += new priceCutEventLL(ticketAgency.TicketOnSale);
            DisneyLand.priceCut += new priceCutEventDL(ticketAgency.TicketOnSale);
            Thread[] ticketAgencies = new Thread[5];
            for (int i = 0; i < 5; i++)
            {
                // Start N retailer threads
                ticketAgencies[i] = new Thread(new ThreadStart(ticketAgency.RetailerFunc));
                ticketAgencies[i].Name = (i + 1).ToString();
                ticketAgencies[i].Start();
                

            
            }
        }
    }
}

    

