using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Linq;

namespace tp_synthese
{
    public abstract class Post
    {
        public int Id;
        public DateTime DateTime;
        public int UserId;
        public int Popularity;

        public List<User> UserSeenIDs = new List<User>();

        public User User { get { return App.Current.Users[UserId]; } }
    }
}
