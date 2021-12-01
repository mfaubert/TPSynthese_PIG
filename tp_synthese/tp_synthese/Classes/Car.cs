using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace tp_synthese
{
    public class Car : Offer
    {
        public string Fabricant;
        public string Marque;
        public int Annee;
        public int Odometre;

        public Car(string f, string m, int a, int o, string i, DateTime d, int p) : base(i, d, p)
        {
            Fabricant = f;
            Marque = m;
            Annee = a;
            Odometre = o;
        }

        public IEnumerable<Offer> SearchRecent(DateTime Dmin, DateTime Dmax,
            string fab = null, string marque = null,
            int anneeMin = int.MinValue, int anneeMax = int.MaxValue,
            int odomin = int.MinValue, int odomax = int.MaxValue,
            int Pmin = 0, int Pmax = int.MaxValue)
        {

            var group = App.Current.market.Cars
            .Where(
            x => x.price >= Pmin && x.price <= Pmax && x.Date >= Dmin && x.Date <= Dmax).OrderByDescending(x => x.Date);

            if (fab != null)
            {
                group = (IOrderedEnumerable<Car>)group.Where(x => x.Fabricant == fab);
            }

            if (marque != null)
            {
                group = (IOrderedEnumerable<Car>)group.Where(x => x.Marque == marque);
            }

            if (anneeMin != int.MinValue)
            { group = (IOrderedEnumerable<Car>)group.Where(x => x.Annee >= anneeMin); }
            if (anneeMax != int.MaxValue)
            { group = (IOrderedEnumerable<Car>)group.Where(x => x.Annee <= anneeMax); }

            if (odomin != int.MinValue)
            { group = (IOrderedEnumerable<Car>)group.Where(x => x.Odometre >= odomin); }
            if (odomax != int.MaxValue)
            { group = (IOrderedEnumerable<Car>)group.Where(x => x.Odometre <= odomax); }

            return group.Cast<Offer>();
        }

        public IEnumerable<Offer> SearchCheap(DateTime Dmin, DateTime Dmax,
            string fab = null, string marque = null,
            int anneeMin = int.MinValue, int anneeMax = int.MaxValue,
            int odomin = int.MinValue, int odomax = int.MaxValue,
            int Pmin = 0, int Pmax = int.MaxValue)
        {

            var group = App.Current.market.Cars
            .Where(
            x => x.price >= Pmin && x.price <= Pmax && x.Date >= Dmin && x.Date <= Dmax).OrderByDescending(x => x.price);

            if (fab != null)
            {
                group = (IOrderedEnumerable<Car>)group.Where(x => x.Fabricant == fab);
            }

            if (marque != null)
            {
                group = (IOrderedEnumerable<Car>)group.Where(x => x.Marque == marque);
            }

            if (anneeMin != int.MinValue)
            { group = (IOrderedEnumerable<Car>)group.Where(x => x.Annee >= anneeMin); }
            if (anneeMax != int.MaxValue)
            { group = (IOrderedEnumerable<Car>)group.Where(x => x.Annee <= anneeMax); }

            if (odomin != int.MinValue)
            { group = (IOrderedEnumerable<Car>)group.Where(x => x.Odometre >= odomin); }
            if (odomax != int.MaxValue)
            { group = (IOrderedEnumerable<Car>)group.Where(x => x.Odometre <= odomax); }

            return group.Cast<Offer>();
        }
    }
}
