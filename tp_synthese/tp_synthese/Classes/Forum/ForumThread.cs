using System;
using System.Collections.Generic;

namespace Classes01_Corrige
{
    public class ForumThread
    {
        public int Id;
        public int UserId;
        public DateTime DateTime;
        public List<ForumPost> ForumPosts = new List<ForumPost>();

        public User User { get { return App.Current.Users[UserId]; } }
    }
}
