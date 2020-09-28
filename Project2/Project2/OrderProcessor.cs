using System;
using System.Collections.Generic;
using System.Text;

namespace Project2
{
    public delegate void orderSuccess(string senderID, double total, double ticketPrice, int numTickets);
    public class OrderProcessor
    {
         public static event orderSuccess OrderProcess;
        public static void ProcessComplete(string senderID, double total, double ticketPrice, int numTickets)
        {
            Console.WriteLine("Order Processed! Ticket Agency {0} order is processed. The total amount that has been charged is $" + total + ". A total of " + numTickets + "have been bought for a unit price of " + ticketPrice, senderID);
        }
        public static void orderProcessing(OrderClass orderObject)
        {

            if(!checkCredit(orderObject.getcardNo()))
            {
                Console.WriteLine("{0} is not a valid card number");
            }
            else
            {
                double total = Convert.ToInt32(1.08 * (orderObject.getUnitPrice() * orderObject.getAmount()));
                ProcessComplete(orderObject.getSenderID(), total, orderObject.getUnitPrice(), orderObject.getAmount());
            }
        }

        private static Boolean checkCredit(Int64 cardNum)
        {
            if (cardNum <= 10000000 && cardNum >= 99999999)
                return true;
            else
                return false;
        }
    }
}
