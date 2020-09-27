﻿using System;
using System.Collections.Generic;
using System.Text;

using System.Threading.Tasks;
using System.Threading;

namespace Project2
{
    /// <summary>class
    /// <c>TicketAgency</c>
    /// Orders tickets from the parks based on events triggered by the parks(priceCuts)
    /// </summary>
    class TicketAgency
    {
        private static string senderID;
        /// <summary>method
        /// <c>RetailerFunc</c>
        /// for starting a ticket Agency thread
        /// </summary>
        /// <returns>void</returns>
        public void RetailerFunc()
        {     
            Random rand = new Random();
            LegoLand ticket = new LegoLand();
            DisneyLand ticket1 = new DisneyLand();
            
            for (int i = 0; i < 50; i++)
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
            return -1;//returns -1 if a ticket amount was not created
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
                Console.WriteLine("Price Cut at {1}! Travel Agency {0} will send an order for {2} tickets at ${3} each", senderID, Thread.CurrentThread.Name
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
        public void TicketOnSale(double price, double priceDiff, string park)
        {
            
                eCommerce.rwLock.AcquireWriterLock(300);
                try
                {
                    OrderClass order = CreateOrder(price, priceDiff, park, senderID);
                    eCommerce.buffer.setACell(order);//attempts to set a cell into the buffer, we are getting deadlocks here
                    
                }
                finally
                {
                    eCommerce.rwLock.ReleaseWriterLock();
                }
            
            
            

         
         

            
                
            


                // It prints thread name }

        
        }
    }
}
