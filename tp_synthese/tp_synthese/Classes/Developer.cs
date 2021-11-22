using System.Collections.Generic;
using System.Linq;

namespace Classes01_Corrige
{
    public class Developer
    {
        public int Id;
        public string Name;

        public IEnumerable<Product> Products
        {
           get { return App.Current.Products.Values.Where(p => p.DeveloperIds.Contains(Id)); }
        }
    }
}
