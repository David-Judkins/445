using System;
using System.Threading;
namespace Project2

{
    public delegate void priceCutEventDL(Int32 pr); // Define a delegate 
    public delegate void priceCutEventLL(Int32 pr); // Define a delegate 


    //V1 starting point
    
    public class eCommerce
    {
        static void Main(string[] args)
        {
            LegoLand ticketLL = new LegoLand();
            DisneyLand ticketDL = new DisneyLand();
            Thread legoland = new Thread(new ThreadStart(ticketLL.PricingModel)); 
            legoland.Start();
            Thread disneyland = new Thread(new ThreadStart(ticketDL.PricingModel)); 
            disneyland.Start();
            // Start LegoLand and DisneyLand Threads
            legoland.Name = "LegoLand"; 
            disneyland.Name = "DisneyLand"; 
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

    

