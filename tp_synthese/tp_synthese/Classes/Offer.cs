using System;
using System.Collections.Generic;
using System.Text;

namespace tp_synthese
{
    public abstract class Offer
    {

        public Offer(string i,DateTime d,int p){
            imageURL = i;
            price = p;
            Date = d;
        }

        public int Id;
        public int UserId;

        public string Title;
        public string Description;
        public string imageURL;

        public int price;
        public DateTime Date;

        public OfferType Type;
        public Car car;
        public Appliance app;
        public Property prop;

    }
}
