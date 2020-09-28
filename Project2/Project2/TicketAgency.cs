using System;
using System.Threading;

namespace Project2
{
    class TicketAgency
    {

        private static string senderID;
        /// <summary>method
        /// <c>RetailerFunc</c>
        /// for starting a thread
        /// </summary>
        /// <returns>void</returns>
        public void RetailerFunc()
        { 
            
            for (int i = 0; i < 100; i++)
            {
                
                    Thread.Sleep(500);
                    senderID = Thread.CurrentThread.Name; // checks what ticket agency is running every 500 ms 10 seconds
                    



            }

        }
       
        
        /// <summary>method
        /// <c>CreditCardNum</c>
        /// Randomizes a credit card number for each order
        /// </summary>
        /// <returns>int</returns>
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
        /// <summary>method
        /// <c>TicketAmount</c>
        /// calculates the ticket amount based off the price difference of each price cut
        /// </summary>
        /// <returns>int</returns>
        public int TicketAmount(double priceDiff, string parkName) {
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
        /// <summary>method
        /// <c>CreateOrder</c>
        /// Creates and returns and order
        /// </summary>
        /// <returns>OrderClass</returns>
        public OrderClass CreateOrder(double unitPrice, double priceDiff, string park, string senderID)
        {
            int cardNum;
            int ticketAmount;
            ticketAmount = TicketAmount(priceDiff, park);
            cardNum = CreditCardNum();
            if(ticketAmount != -1)
            {
                Console.WriteLine("Price Cut at {1}! Travel Agency {0} will send an order for {2} tickets at ${3} each\n", senderID, Thread.CurrentThread.Name
                , ticketAmount, unitPrice);
                OrderClass newOrder = new OrderClass(senderID, cardNum, park, ticketAmount, unitPrice);
                return newOrder;
            }
            
            return null;

        }
        
        /// <summary>method
        /// <c>TicketOnSale</c>
        /// uses readerwriterlock to add an order when a pricecut happens
        /// </summary>
        /// <returns>void</returns>
        /// 

        public void TicketOnSale(double price, double priceDiff, string park)
        { // Event handler // order chickens from chicken farm – send order into queue
            
                eCommerce.rwLock.AcquireWriterLock(300);
                try
                {
                    OrderClass order = CreateOrder(price, priceDiff, park, senderID);
                    eCommerce.buffer.setACell(order);

                }
                finally
                {
                    eCommerce.rwLock.ReleaseWriterLock();
                }
         
        }

        /// <summary>
        /// Takes in parameters and prints them in a statements to declare that the order has been prcocessed.
        /// </summary>
        /// <param name="senderID"></param>
        /// <param name="total"></param>
        /// <param name="ticketPrice"></param>
        /// <param name="numTickets"></param>
        public void OrderSuccess(string senderID, double total, double ticketPrice, int numTickets)
        {
            Console.WriteLine("Order Processed! Ticket Agency {0} order is processed. The total amount that has been charged is $" + total +
                ". A total of " + numTickets + "have been bought for a unit price of " + ticketPrice + "\n", senderID);
        }

    }
}
