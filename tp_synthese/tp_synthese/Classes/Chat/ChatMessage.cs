namespace Classes01_Corrige
{
    public abstract class ChatMessage
    {
        public int Id; // why not!
        public int UserId;

        public User User { get { return App.Current.Users[UserId]; } }
    }
}