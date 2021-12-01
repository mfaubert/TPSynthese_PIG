using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace tp_synthese
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public Marketplace market = new Marketplace();
        public static bool IsToday(DateTime dateTime)
        {
            TimeSpan timeSpan = DateTime.Today - dateTime;
            return timeSpan.Days < 0;
        }

        public static bool IsThisWeek(DateTime dateTime)
        {
            TimeSpan timeSpan = DateTime.Today - dateTime;
            return timeSpan.Days < 7;
        }

        public static bool IsThisMonth(DateTime dateTime)
        {
            TimeSpan timeSpan = DateTime.Today - dateTime;
            return timeSpan.Days < 30;
        }

        public static bool IsUpcoming(DateTime dateTime)
        {
            return dateTime > DateTime.Today;
        }

        public static bool IsPast(DateTime dateTime)
        {
            return dateTime < DateTime.Today;
        }

        public static new App Current
        {
            get { return Application.Current as App; }
        }

        public Dictionary<int, User> Users = new Dictionary<int, User>();
        public Dictionary<int, Friend> Friends = new Dictionary<int, Friend>();
        public Dictionary<int, Group> Groups = new Dictionary<int, Group>();
        public Dictionary<int, Comment> Comments = new Dictionary<int, Comment>();
        public Dictionary<int, Post> Posts = new Dictionary<int, Post>();
        public Dictionary<int, Event> Events = new Dictionary<int, Event>();

        
    }
}
