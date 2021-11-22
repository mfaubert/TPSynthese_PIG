namespace Classes01_Corrige
{
    public class ReviewRating
    {
        public int UserId;
        public ReviewRatingType ReviewRatingType;

        public User User { get { return App.Current.Users[UserId]; } }
    }
}
