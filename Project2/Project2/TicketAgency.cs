using System;
using System.Collections.Generic;
using System.Text;


using System.Threading;

namespace Project2
{
    class TicketAgency
    {
        public void RetailerFunc()
        { //for starting thread 
            Random rand = new Random();
            LegoLand ticket = new LegoLand();
            DisneyLand ticket1 = new DisneyLand();
            for (Int32 i = 0; i < 15; i++)
            {
                if (rand.Next(2) == 0)
                {
                    Thread.Sleep(1000);
                    Int32 p = ticket.getPrice();

                    

                    Console.WriteLine("DisneyLand{0} has everyday low price: ${1} each", Thread.CurrentThread.Name, p);
                }
                else
                {
                    Thread.Sleep(1000);
                    Int32 p = ticket1.getPrice();
                    Console.WriteLine("LegoLand{0} has everyday low price: ${1} each", Thread.CurrentThread.Name, p);
                }


            }

        }

        public void TicketAmount(Int32 ticketPrice) {
            LegoLand ticket = new LegoLand();
            DisneyLand ticket1 = new DisneyLand();
            
           

        }
        public void createOrder(Int32 senderID, Int32 cardNo, Int32 revieverID)
        {

        }
        public void TicketOnSale(Int32 p)
        { // Event handler // order chickens from chicken farm – send order into queue
                Console.WriteLine("Tickets are on sale: as low as ${0} each", Thread.CurrentThread.Name, p);
                OrderClass newOrder = new OrderClass();
                newOrder.setUnitPrice(p);
            


                // It prints thread name }

        
        }
    }
}
