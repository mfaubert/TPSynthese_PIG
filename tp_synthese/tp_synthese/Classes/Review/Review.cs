using System;
using System.Collections.Generic;
using System.Linq;

namespace Classes01_Corrige
{
    public abstract class Review
    {
        public int Id;
        public int ProductId;
        public int UserId;
        public DateTime DateTime;
        public ReviewType ReviewType;
        public Dictionary<int, ReviewRating> ReviewRatings = new Dictionary<int, ReviewRating>();

        public Product Product { get { return App.Current.Products[ProductId]; } }
        public User User { get { return App.Current.Users[UserId]; } }
        public bool UserOwnsProduct { get { return User.ProductIds.Contains(ProductId); } }
        public int UsefulRatingCount { get { return ReviewRatings.Values.Count(x => x.ReviewRatingType == ReviewRatingType.Useful); } }
        public int NotUsefulRatingCount { get { return ReviewRatings.Values.Count(x => x.ReviewRatingType == ReviewRatingType.NotUseful); } }
        public int FunnyRatingCount { get { return ReviewRatings.Values.Count(x => x.ReviewRatingType == ReviewRatingType.Funny); } }
    }
}
