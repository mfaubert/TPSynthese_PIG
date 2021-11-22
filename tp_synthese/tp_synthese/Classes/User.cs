﻿using System;
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

        public IEnumerable<User> Friends
        {
            get { return App.Current.Users.Values.Where(x => FriendIds.Contains(x.Id)); }
        }

        public IEnumerable<User> FriendsByAlphabeticalOrder
        {
            get
            {
                return Friends.OrderBy(x => x.Firstname);
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
                var group = App.Current.Groups.Values
                 .Where(
                    x => x.AdminIDs.Contains(Id));

                return group.Cast<Group>();
            }
        }
    }
}