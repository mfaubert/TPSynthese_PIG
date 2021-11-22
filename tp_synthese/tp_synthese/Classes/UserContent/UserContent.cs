using System;
using System.Collections.Generic;

namespace Classes01_Corrige
{
    public abstract class UserContent
    {
        public int Id;
        public int UserId;
        public int ProductId;
        public DateTime DateTime;
        public string Title;
        public List<int> UserThumbsUp = new List<int>();
        public List<UserContentComment> UserContentComments = new List<UserContentComment>();

        public User User { get { return App.Current.Users[UserId]; } }
        public Product Product { get { return App.Current.Products[ProductId]; } }
    }
}
