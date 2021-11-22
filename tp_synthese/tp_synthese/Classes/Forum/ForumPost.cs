using System;
using System.Collections.Generic;

namespace Classes01_Corrige
{
    public class ForumPost
    {
        public int UserId;
        public DateTime DateTime;
        public string Title;
        public string Text;
        public List<string> FileUrls = new List<string>();

        public User User { get { return App.Current.Users[UserId]; } }
    }
}
