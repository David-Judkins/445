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

        
        public static void orderProcessing(OrderClass orderObject, double ticketPrice)
        {

            if(!checkCredit(orderObject.getcardNo()))
            {
                Console.WriteLine("{0} is not a valid card number");
            }
            else
            {
                double total = Convert.ToDouble(1.08 * (ticketPrice * orderObject.getAmount()));
                OrderProcess(orderObject.getSenderID(), total, ticketPrice, orderObject.getAmount());
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
