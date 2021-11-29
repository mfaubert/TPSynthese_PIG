using System;
using System.Collections.Generic;
using System.Text;

namespace tp_synthese
{
    public class Offer
    {
        public int Id;
        public int UserId;
        public int price;
        public DateTime Date;
        public string Title;
        public string Description;
        public string imageURL;
        public PropType Type;

        public IEnumerable<Offer> Search(int Pmin = 0, int Pmax = int.MaxValue, DateTime Dmin = 0, )
        {



        }

    }
}
