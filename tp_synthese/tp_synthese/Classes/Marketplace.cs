using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace tp_synthese
{
    public class Marketplace
    {
        public List<Offer> Offers = new List<Offer>();

        public Marketplace()
        {
            Offers.Add(new Offer());
        }

        public IEnumerable<Car> Cars
        {
            get
            {
                return (IEnumerable<Car>)Offers.Where(x => x.Type == OfferType.Car);
            }
        }

        public IEnumerable<Property> Properties
        {
            get
            {
                return (IEnumerable<Property>)Offers.Where(x => x.Type == OfferType.Property);
            }
        }

        public IEnumerable<Appliance> Appliances
        {
            get
            {
                return (IEnumerable<Appliance>)Offers.Where(x => x.Type == OfferType.Appliance);
            }
        }
    }
}
