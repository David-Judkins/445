using System;
using System.Threading;

namespace Project2
{
    public delegate void orderSuccess(string senderID, double total, double ticketPrice, int numTickets); //create delegae
    /// <summary>
    /// OrderProcessor class checks the credit card validity, if it fails it prints an error message.
    /// If credit card is valid it calls ProcessComplete
    /// </summary>
    public class OrderProcessor
    {
        public static event orderSuccess OrderProcess; //create event

        ///<summary>method
        /// <c>ProcessComplete</c>
        /// Process is called by the orderProcessing class to print parameters in a statement.
        /// </summary>
        /// <param name="senderID"></param>
        /// <param name="total"></param>
        /// <param name="ticketPrice"></param>
        /// <param name="numTickets"></param>
        public void ProcessComplete(string senderID, double total, double ticketPrice, int numTickets)
        {
            Console.WriteLine("Order Processed! Ticket Agency {0} order is processed. The total amount that has been charged is $" + total + ". A total of " + numTickets + " have been bought for a unit price of $" + ticketPrice + "\n", senderID);
        }

        ///<summary>method
        /// <c>orderProcessing</c>
        /// Method takes in an order object and uses the card validty to process the order.
        /// If the card is invalid it prints an error message.
        /// If the card is valid it calculates the total price that the agency is buying based on the orders price and ticket numbers and calls ProcessComplete, 
        /// </summary>
        /// <param name="orderObject"></param>
        public void orderProcessing(OrderClass orderObject)
        {

            if(!checkCredit(orderObject.getcardNo())) //check card validity
            {
                Console.WriteLine("{0} is not a valid card");
            }
            else // runs if card it valid
            {
                double total = Convert.ToDouble(1.08 * (orderObject.getUnitPrice() * orderObject.getAmount()));
                ProcessComplete(orderObject.getSenderID(), total, orderObject.getUnitPrice(), orderObject.getAmount()); 
            }
        }

        /// <summary>method
        /// <c>checkCredit</c>
        /// </summary>
        /// <param name="cardNum"></param>
        /// <returns>boolean</returns>
        private Boolean checkCredit(int cardNum)
        {
            if (cardNum >= 10000000 && cardNum <= 99999999) // card is an 8 digit number
                return true;
            else
                return false;
        }
    }
}
