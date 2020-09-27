using System;
using System.Collections.Generic;
using System.Text;

namespace Project2
{
    public delegate void orderSuccess(string senderID, Int32 total, Int32 ticketPrice, Int32 numTickets);
    public class OrderProcessor
    {
         public static event orderSuccess OrderProcess;

        public static void orderProcessing(OrderClass orderObject, Int32 ticketPrice)
        {

            if(!checkCredit(orderObject.getcardNo()))
            {
                Console.WriteLine("{0} is not a valid card number");
            }
            else
            {
                Int32 total = Convert.ToInt32(1.08 * (ticketPrice * orderObject.getAmount()));
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
