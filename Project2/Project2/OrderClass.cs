using System;
using System.Collections.Generic;
using System.Text;

namespace Project2
{
    class OrderClass
    {
        private int senderID;
        private int cardNo;
        private int recieverID;
        private string park;
        private int amount;
        private double unitPrice;

        OrderClass()
        {
            this.senderID = 0;
            this.cardNo = cardNo = 0;
            this.recieverID = 0;
            this.park = "N/A";
            this.amount = 0;
            this.unitPrice = 0.0;
        }
        public int getSenderID()
        {
            return this.senderID;
        }
        public void setSenderID(int ID)
        {
            this.senderID = ID;
        }

        public int getcardNo()
        {
            return this.senderID;
        }
        public void setcardNo(int num)
        {
            this.cardNo = num;
        }

        public int getRecieverID()
        {
            return this.recieverID;
        }
        public void setRecieverID(int ID)
        {
            this.recieverID = ID;
        }

        public string getPark()
        {
            return this.park;
        }
        public void setPark(string parkName)
        {
            this.park = parkName;
        }
    }
}
