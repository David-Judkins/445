using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Project2
{
    public delegate void orderSuccess(string senderID, double total, double ticketPrice, int numTickets);
    public class OrderProcessor
    {
        public static event orderSuccess OrderProcess;
        public  void ProcessComplete(string senderID, double total, double ticketPrice, int numTickets)
        {
            Console.WriteLine("Order Processed! Ticket Agency {0} order is processed. The total amount that has been charged is $" + total + ". A total of " + numTickets + " have been bought for a unit price of $" + ticketPrice + "\n", senderID);
        }
        public void orderProcessing(OrderClass orderObject)
        {

            if(!checkCredit(orderObject.getcardNo()))
            {
                Console.WriteLine("{0} is not a valid card number");
            }
            else
            {
                double total = Convert.ToDouble(1.08 * (orderObject.getUnitPrice() * orderObject.getAmount()));
                ProcessComplete(orderObject.getSenderID(), total, orderObject.getUnitPrice(), orderObject.getAmount());
            }
        }

        private Boolean checkCredit(int cardNum)
        {
            if (cardNum >= 10000000 && cardNum <= 99999999)
                return true;
            else
                return false;
        }
    }
}
