using System;
using System.Collections.Generic;
using System.Text;

namespace Project2
{
    /// <summary>class
    /// <c>OrderClass</c>
    /// used as order objects
    /// </summary>
    /// 
    public class OrderClass
    {
        private string senderID;
        private int cardNo;
        private string recieverID;
        private int amount;
        private double unitPrice;
           
        public OrderClass(string sID, int cNum, string recID, int tAmount, double uPrice)
        {
            this.senderID = sID;
            this.cardNo = cardNo = cNum;
            this.recieverID = recID;
        
            this.amount = tAmount;
            this.unitPrice = uPrice;
        }
        public string getSenderID()
        {
            return senderID;
        }
        public void setSenderID(string ID)
        {
            this.senderID = ID;
        }
        public int getcardNo()
        {
            return cardNo;
        }
        public void setcardNo(int num)
        {
            this.cardNo = num;
        }

        public string getReceiverID()
        {
            return recieverID;
        }
        public void setReceiverID(string ID)
        {
            this.recieverID = ID;
        }
        public int getAmount()
        {
            return amount;
        }
        public void setAmount(int amount)
        {
            this.amount = amount;
        }
        public double getUnitPrice()
        {
            return unitPrice;
        }
        public void setUnitPrice(double price)
        {
            this.unitPrice = price;
        }
    }
}
