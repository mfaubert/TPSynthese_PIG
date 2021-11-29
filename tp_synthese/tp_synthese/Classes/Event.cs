using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Linq;

namespace tp_synthese
{
    public abstract class Event
    {
        public int Id;
        public int GroupId;
        public string Titre;
        public string Description;
        public DateTime Date;
        public TimeSpan Duree;
        public Post Post;
        public string Adresse;
        public string ImageUrl;

        public EventCategory EventCategory;
        public InterestStatus InterestStatus;
        public EventRestriction EventRestriction;

        public List<int> InterestedUsersIds = new List<int>();
        public List<int> GoingUsersIds = new List<int>();

        public IEnumerable<User> interestedUsers
        {
            get { return App.Current.Users.Values.Where(x => InterestedUsersIds.Contains(x.Id)); }
        }

        public IEnumerable<User> goingUsers
        {
            get { return App.Current.Users.Values.Where(x => GoingUsersIds.Contains(x.Id)); }
        }

    }
}
