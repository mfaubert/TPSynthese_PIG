using System;
using System.Collections.Generic;
using System.Linq;

namespace tp_synthese
{
    public class User
    {
        public int Id;
        public string Firstname;
        public string Lastname;
        public string Password;
        public string Email;
        public string PrincImage;
        public string BannerImage;

        public List<int> FriendIds = new List<int>();
        public List<int> SentFriendRequests = new List<int>();
        public List<int> EventPosts = new List<int>();
        public List<int> EventIds = new List<int>();

        public IEnumerable<Friend> Friends
        {
            get { return App.Current.Friends.Values.Where(x => FriendIds.Contains(x.Id)); }
        }

        public IEnumerable<User> FriendsByAlphabeticalOrder
        {
            get { return Friends.OrderBy(x => x.Firstname); }
        }

        public IEnumerable<User> FriendsByDate
        {
            get { return Friends.OrderBy(x => x.DateAdded).OrderByDescending(x => x.DateAdded); }
        }

        public IEnumerable<Event> PastEventsOrdered
        {
            get
            {
                return Events.Where(x => App.IsPast(x.Date) && x.InterestStatus == InterestStatus.Going).OrderByDescending(x => x.Date);
            }
        }

        public IEnumerable<Event> Events
        {
            get { return App.Current.Events.Values.Where(x => EventIds.Contains(x.Id)); }
        }

        public IEnumerable<Event> EventsPosts
        {
            get
            {
                var listEvent = Events.Where(x => x.InterestStatus == InterestStatus.Going || x.InterestStatus == InterestStatus.Interested);

                foreach (var item in listEvent)
                {
                    EventPost post = new EventPost();
                    post.UserId = this.Id;
                    post.Name = item.Titre;
                    post.Date = item.Date;
                    post.ImageUrl = item.ImageUrl;
                }

                return listEvent;
            }
        }

        public IEnumerable<Group> Groups
        {
            get
            {
                var group = App.Current.Groups.Values
                 .Where(
                    x => x.MemberIDs.Contains(Id));

                return group.Cast<Group>();
            }
        }

        public IEnumerable<Group> GroupsIsAdmin
        {
            get
            {
                var group = App.Current.Groups.Values.Where(x => x.AdminIDs.Contains(Id));

                return group.Cast<Group>();
            }
        }

        public IEnumerable<Event> UpcomingEvents
        {
            get
            {
                return Events.Where(x => App.IsUpcoming(x.Date)).OrderByDescending(x => x.Date);
            }
        }

        public IEnumerable<Event> PastEventsOrdered
        {
            get
            {
                return Events.Where(x => App.IsPast(x.Date)).OrderByDescending(x => x.Date);
            }
        }

        public IEnumerable<Event> FriendsUpcomingEvents
        {
            get { 
                    var listEvent = Friends.SelectMany(x => x.Events);
                    return listEvent.Where(x => App.IsUpcoming(x.Date));
                }
                
        }

        public IEnumerable<Offer> ThisUserOffers
        {
            get
            {
                var group = App.Current.market.Offers
                .Where(
                x => x.UserId == Id);

                return group.Cast<Offer>();
            }
        }
        public IEnumerable<Offer> FriendsOffers
        {
            get
            {
                var group = App.Current.market.Offers
                .Where(
                x => FriendIds.Contains(x.UserId));

                return group.Cast<Offer>();
            }
        }

        public IEnumerable<Offer> AnotherUserOffers(User Bernard)
        {

            var group = App.Current.market.Offers
            .Where(
            x => x.UserId == Bernard.Id);

            return group.Cast<Offer>();
        }

        public IEnumerable<Event> UpcomingEvents
        {
            get
            {
                return Events.Where(x => App.IsUpcoming(x.Date) && x.InterestStatus == InterestStatus.Going || x.InterestStatus == InterestStatus.Interested).OrderByDescending(x => x.Date);   
            }
        }

        public IEnumerable<Event> TodaysEvents
        {
            get
            {
                return Events.Where(x => App.IsUpcoming(x.Date) && App.IsToday(x.Date));
            }
        }

        public IEnumerable<Event> WeeksEvents
        {
            get
            {
                return Events.Where(x => App.IsUpcoming(x.Date) && App.IsThisWeek(x.Date));
            }
        }

        public IEnumerable<Event> MonthsEvents
        {
            get
            {
                return Events.Where(x => App.IsUpcoming(x.Date) && App.IsThisMonth(x.Date));
            }
        }

        public IEnumerable<Event> PastEventsOrdered
        {
            get
            {
                return Events.Where(x => App.IsPast(x.Date) && x.InterestStatus == InterestStatus.Going).OrderByDescending(x => x.Date);
            }
        }

        public IEnumerable<Event> FriendsUpcomingEvents
        {
            get { 
                    var listEvent = Friends.SelectMany(x => x.Events);
                    return listEvent.Where(x => App.IsUpcoming(x.Date));
                }
                
        }

        public IEnumerable<Event> FriendsPastEvents
        {
            get
            {
                var listEvent = Friends.SelectMany(x => x.Events);
                return listEvent.Where(x => App.IsPast(x.Date) && x.InterestStatus == InterestStatus.Going);
            }

        }
    }
}
