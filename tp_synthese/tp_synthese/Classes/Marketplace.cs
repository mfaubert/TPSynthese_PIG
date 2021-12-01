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
            Offers.Add(new Car("Honda", "Accord", 2014, 170, "car1.jpg", new DateTime(2021, 11, 19), 6000));
            Offers.Add(new Car("Toyota", "Camry", 2015, 200, "car2.jpg", new DateTime(2021, 11, 19), 5000));
            Offers.Add(new Car("Nissan", "Leaf", 2013, 210, "car3.jpg", new DateTime(2021, 11, 21), 8000));
            Offers.Add(new Car("Toyota", "Yaris", 2021, 20, "car4.jpg", new DateTime(2021, 11, 21), 10000));
            Offers.Add(new Car("Honda", "Civic", 2001, 350, "car5.jpg", new DateTime(2021, 11, 23), 1000));
            Offers.Add(new Car("Honda", "Civic", 2011, 140, "car6.jpg", new DateTime(2021, 11, 23), 6000));
            Offers.Add(new Car("Toyota", "Camry", 2021, 10, "car7.jpg", new DateTime(2021, 11, 25), 20000));
            Offers.Add(new Car("Nissan", "Infiniti", 2015, 150, "car8.jpg", new DateTime(2021, 11, 25), 7000));
            Offers.Add(new Car("Nissan", "Infiniti", 2016, 170, "car9.jpg", new DateTime(2021, 11, 27), 9000));
            Offers.Add(new Car("Honda", "Accord", 2018, 90, "car10.jpg", new DateTime(2021, 11, 27), 12000));
            Offers.Add(new Car("Toyota", "Yaris", 2013, 210, "car11.jpg", new DateTime(2021, 11, 29), 5000));
            Offers.Add(new Car("Nissan", "Altima", 2003, 320, "car12.jpg", new DateTime(2021, 11, 29), 2000));
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
