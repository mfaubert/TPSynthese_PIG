using System;
using System.Collections.Generic;
using System.Linq;

namespace Classes01_Corrige
{
    public abstract class Product
    {
        public int Id;
        public string Name;
        public string Description;
        public DateTime ReleaseDate;
        public float Price;
        public string ThumbnailUrl;
        public List<string> MediaUrls = new List<string>();
        public List<int> DeveloperIds = new List<int>();
        public List<int> PublisherIds = new List<int>();

        // To force only one Review per user, don't save globally in App.cs
        // Dictionary<UserId, Review>
        public Dictionary<int, Review> Reviews = new Dictionary<int, Review>();

        public IEnumerable<Review> MostRecentReviews
        {
            get { return Reviews.Values.OrderByDescending(x => x.DateTime); }
        }

        public IEnumerable<Review> MostUsefulPositiveReviews
        {
            get
            {
                return Reviews.Values
                  .Where(x => x.ReviewType == ReviewType.Positive)
                  .OrderByDescending(x => x.UsefulRatingCount);
            }
        }

        public IEnumerable<Review> MostUsefulNegativeReviews
        {
            get
            {
                return Reviews.Values
                  .Where(x => x.ReviewType == ReviewType.Negative)
                  .OrderByDescending(x => x.UsefulRatingCount);
            }
        }

        public IEnumerable<Review> LeastUsefulReviews
        {
            get
            {
                return Reviews.Values
                  .OrderByDescending(x => x.NotUsefulRatingCount);
            }
        }

        public IEnumerable<Review> MostFunnyReviews
        {
            get
            {
                return Reviews.Values
                  .OrderByDescending(x => x.FunnyRatingCount);
            }
        }

        public Forum Forum
        {
            get { return App.Current.Forums.Where(x => x.ProductId == Id); }
        }
    }
}
