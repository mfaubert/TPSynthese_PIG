using System;

namespace Classes01_Corrige
{
    public class UserContentComment
    {
        public int UserId;
        public DateTime DateTime;
        public string Text;

        // Find user image and name by using User
        public User User { get { return App.Current.Users[UserId]; } }
    }
}
