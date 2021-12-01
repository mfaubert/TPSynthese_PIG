using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace tp_synthese
{
    public class Property : Offer
    {
        public int Chambres;
        public int SallesDeBains;
        public PropType propType;

        public IEnumerable<Offer> SearchRecent(DateTime Dmin, DateTime Dmax,
            int chambres = int.MaxValue, int bains = int.MaxValue,
            PropType type = PropType.None,
            int Pmin = 0, int Pmax = int.MaxValue)
        {

            var group = App.Current.market.Properties
            .Where(
            x => x.price >= Pmin && x.price <= Pmax && x.Date >= Dmin && x.Date <= Dmax).OrderByDescending(x => x.Date);

            if (chambres != int.MaxValue)
            {
                group = (IOrderedEnumerable<Property>)group.Where(x => x.Chambres == chambres);
            }

            if (bains != int.MaxValue)
            {
                group = (IOrderedEnumerable<Property>)group.Where(x => x.SallesDeBains == bains);
            }

            if (type != PropType.None)
            {
                group = (IOrderedEnumerable<Property>)group.Where(x => x.propType == type);
            }

            return group.Cast<Offer>();
        }

        public IEnumerable<Offer> SearchCheap(DateTime Dmin, DateTime Dmax,
            int chambres = int.MaxValue, int bains = int.MaxValue,
            PropType type = PropType.None,
            int Pmin = 0, int Pmax = int.MaxValue)
        {

            var group = App.Current.market.Properties
            .Where(
            x => x.price >= Pmin && x.price <= Pmax && x.Date >= Dmin && x.Date <= Dmax).OrderBy(x => x.price);

            if (chambres != int.MaxValue)
            {
                group = (IOrderedEnumerable<Property>)group.Where(x => x.Chambres == chambres);
            }

            if (bains != int.MaxValue)
            {
                group = (IOrderedEnumerable<Property>)group.Where(x => x.SallesDeBains == bains);
            }

            if (type != PropType.None)
            {
                group = (IOrderedEnumerable<Property>)group.Where(x => x.propType == type);
            }

            return group.Cast<Offer>();
        }
    }
}
