﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Project2
{
    class LegoLand
    {
        static Random rng = new Random(); // To generate random numbers 
        public static event priceCutEventLL priceCut; // Link event to delegate 
        private static Int32 ticketPriceLL = 10;
        public Int32 getPrice() { return ticketPriceLL; }
        public static void changePrice(Int32 price)
        {
            if (price < ticketPriceLL)
            {    // a price cut 
                if (priceCut != null)  // there is at least a subscriber
                    priceCut(price);    // emit event to subscribers

                ticketPriceLL = price;
            }
            ticketPriceLL = price;
        }
        public void PricingModel()
        {
            for (Int32 i = 0; i < 50; i++)
            {
                Thread.Sleep(500);
                // Take the order from the queue of the orders; // Decide the price based on the orders
                Int32 p = rng.Next(5, 10); // Console.WriteLine("New Price is {0}", p);
                LegoLand.changePrice(p);
            }
        }
    }
}
