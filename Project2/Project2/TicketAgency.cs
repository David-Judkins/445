using System;
using System.Collections.Generic;
using System.Text;

using System.Threading.Tasks;
using System.Threading;

namespace Project2
{
    class TicketAgency
    {
        private string senderID;
        public void RetailerFunc()
        { //for starting thread 
            Random rand = new Random();
            LegoLand ticket = new LegoLand();
            DisneyLand ticket1 = new DisneyLand();
            
            for (int i = 0; i < 10; i++)
            {
                
                    Thread.Sleep(1000);
                    int p = ticket.getPrice();
                    int p1 = ticket1.getPrice();
                    Console.WriteLine("DisneyLand{0} has everyday low price: ${1} each", Thread.CurrentThread.Name, p);
                    Console.WriteLine("LegoLand{0} has everyday low price: ${1} each", Thread.CurrentThread.Name, p);
                    senderID = Thread.CurrentThread.Name;
            }

        }
        public int CreditCardNum()
        {
            Random rand = new Random();
            string cardNum = null;
            int part1 = rand.Next(1000, 9999);
            int part2 = rand.Next(1000, 9999);
            
            cardNum = part1.ToString();
            cardNum += part2.ToString();
            
            
            return Int32.Parse(cardNum);
        }
        public int TicketAmount(int priceDiff, string parkName) {
            Random rand = new Random();
            if (parkName == "LegoLand") {
                if(priceDiff <= 10){
                    return rand.Next(40, 75);
                } else if (priceDiff > 10 && priceDiff < 35) {
                    return rand.Next(40, 100);
                } else if (priceDiff >= 35 && priceDiff < 100) {
                    return rand.Next(150, 275);
                } else if (priceDiff >= 100) {
                    return rand.Next(276, 500);
                }
            }
            else if(parkName == "DisneyLand") {
                if (priceDiff <= 10){
                    return rand.Next(40, 75);
                }
                else if (priceDiff > 10 && priceDiff < 35){
                    return rand.Next(40, 146);
                }
                else if (priceDiff >= 35 && priceDiff < 100){
                    return rand.Next(150, 275);
                }else if(priceDiff >= 100){
                    return rand.Next(276, 500);
                }
            }
            return -1;
        }
        public OrderClass CreateOrder(double unitPrice, int priceDiff, string park, string senderID)
        {
            int cardNum;
            int ticketAmount;
            ticketAmount = TicketAmount(priceDiff, park);
            cardNum = CreditCardNum();
            if(ticketAmount != -1)
            {
                Console.WriteLine("Price Cut! Travel Agency {0} will send an order to {1} for {2} tickets at ${3} each", senderID, Thread.CurrentThread.Name
                , ticketAmount, unitPrice);
                OrderClass newOrder = new OrderClass(senderID, cardNum, park, ticketAmount, unitPrice);
                return newOrder;
            }
            
            return null;

        }   
        public void TicketOnSale(double price, int priceDiff, string park)
        { // Event handler // order chickens from chicken farm – send order into queue
            OrderClass order = CreateOrder(price, priceDiff, park, senderID);
            eCommerce.rwLock.AcquireWriterLock(300);
           
            try
            {
                eCommerce.buffer.setACell(order);
            }
            finally
            {
                eCommerce.rwLock.ReleaseWriterLock();
            }
           

            
                
            


                // It prints thread name }

        
        }
    }
}
