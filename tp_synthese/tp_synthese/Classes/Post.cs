using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Linq;

namespace tp_synthese
{
    public class Post
    {
        public int Id;
        public DateTime DateTime;
        public int UserId;
        public string Title;
        public string Description;
        public string ImageUrl;

        public Restriction Restriction;

        public List<Reaction> Reactions = new List<Reaction>();
        public List<User> UserSeenIDs = new List<User>();

        public User User { get { return App.Current.Users[UserId]; } }
        public int Popularity { get {
                int pop = 0;
                foreach (Reaction rea in Reactions){
                    if (rea == Reaction.Like)
                        pop += 3;
                    if (rea == Reaction.Love)
                        pop += 5;
                    if (rea == Reaction.Sad)
                        pop += 1;
                    if (rea == Reaction.Angry)
                        pop += 1;
                }
                return pop; } }
        public IEnumerable<Comment> AllComments
        {
            get
            {
                var comments = App.Current.Comments.Values
                                 .Where(
                                    x => x.PostId == Id);

                return comments.Cast<Comment>();
            }
        }



    }
}
