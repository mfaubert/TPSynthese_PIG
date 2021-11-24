using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Linq;

namespace tp_synthese
{
    public class Group
    {
        public int Id;
        public string Name;
        public string Description;
        public string ImageUrl;

        //Invites are awaiting acceptation
        public List<int> AdminIDs = new List<int>();
        public List<int> MemberIDs = new List<int>();
        public List<User> Members = new List<User>();
        public List<User> Invites = new List<User>();

        public List<Post> Wall = new List<Post>();
        public List<Event> Events = new List<Event>();

        public IEnumerable<User> AllUsers
        {
            get
            {
                var Users = new List<User>();
                Users.AddRange(Members);
                return Users;
            }
        }

        public IEnumerable<Post> MostRecentPosts
        {
            get { return Wall.OrderByDescending(x => x.DateTime); }
        }

        public IEnumerable<Post> MostPopularPostsThisWeek
        {
            get
            {
                return Wall
                  .Where(x => App.IsThisWeek(x.DateTime))
                  .OrderByDescending(x => x.Popularity);
            }
        }

        public IEnumerable<Event> UpcomingEvents
        {
            get
            {
                return Events
                  .Where(x => App.IsUpcoming(x.Date))
                  .OrderByDescending(x => x.Date);
            }
        }

        public IEnumerable<Event> PastEventsOrdered
        {
            get
            {
                return Events
                  .Where(x => App.IsPast(x.Date))
                  .OrderByDescending(x => x.Date);
            }
        }
    }
}
