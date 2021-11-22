using System.Collections.Generic;

namespace Classes01_Corrige
{
    public class BundlePromotion : Promotion
    {
        public List<int> ProductIds = new List<int>();
        public float Price;

        public List<Product> Products { get { return null; } }
    }
}
