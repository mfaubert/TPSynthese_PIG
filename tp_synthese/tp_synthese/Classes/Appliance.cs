using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace tp_synthese
{
    public class Appliance : Offer
    {
        public string Marque;
        public AppType AppType;

        public Appliance(string f, string m, int a, int o, string i, DateTime d, int p) : base(i, d, p)
        {
            
        }


        public IEnumerable<Offer> SearchRecent(DateTime Dmin, DateTime Dmax,
            string marque = null, AppType type = AppType.None,
            int Pmin = 0, int Pmax = int.MaxValue)
        {

            var group = App.Current.market.Appliances
            .Where(
            x => x.price >= Pmin && x.price <= Pmax && x.Date >= Dmin && x.Date <= Dmax).OrderByDescending(x => x.Date);

            if (marque != null)
            {
                group = (IOrderedEnumerable<Appliance>)group.Where(x => x.Marque == marque);
            }

            if (type != AppType.None)
            {
                group = (IOrderedEnumerable<Appliance>)group.Where(x => x.AppType == type);
            }

            return group.Cast<Offer>();
        }

        public IEnumerable<Offer> SearchCheap(DateTime Dmin, DateTime Dmax,
            string marque = null, AppType type = AppType.None,
            int Pmin = 0, int Pmax = int.MaxValue)
        {

            var group = App.Current.market.Appliances
            .Where(
            x => x.price >= Pmin && x.price <= Pmax && x.Date >= Dmin && x.Date <= Dmax).OrderByDescending(x => x.Date);

            if (marque != null)
            {
                group = (IOrderedEnumerable<Appliance>)group.Where(x => x.Marque == marque);
            }

            if (type != AppType.None)
            {
                group = (IOrderedEnumerable<Appliance>)group.Where(x => x.AppType == type);
            }

            return group.Cast<Offer>();
        }
    }
}
