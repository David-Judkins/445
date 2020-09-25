using System;
using System.Collections.Generic;
using System.Text;

using System.Threading;

namespace Project2
{
    class TicketAgency
    {
        public void retailerFunc()
        { //for starting thread 
            LegoLand chicken = new LegoLand();
            for (Int32 i = 0; i < 10; i++)
            {
                Thread.Sleep(1000);
                Int32 p = chicken.getPrice();
                Console.WriteLine("Store{0} has everyday low price: ${1} each", Thread.CurrentThread.Name, p);
            }
        }
        public void TicketOnSale(Int32 p)
        { // Event handler // order chickens from chicken farm – send order into queue
            Console.WriteLine("chickens are on sale: as low as ${1} each", Thread.CurrentThread.Name, p);
            // It prints thread name }
        }
    }
}
