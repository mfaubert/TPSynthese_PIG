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

        public Dictionary<int, User> Users { get => _user; }
        private Dictionary<int, User> _user = new Dictionary<int, User>()
        {
            { 1001, new User() { Id = 1001, Firstname = "Tom", Lastname = "Richards", PrincImage="/Assets/Users/user1.jpg", FriendIds = new List<int>(){ 1002, 1003, 1004 } } },
            { 1002, new User() { Id = 1002, Firstname = "Elliot", Lastname = "Hart", PrincImage="/Assets/Users/user2.jpg", FriendIds = new List<int>(){ 1001 } } },
            { 1003, new User() { Id = 1003, Firstname = "Rachel", Lastname = "Chapman", PrincImage="/Assets/Users/user3.jpg", FriendIds = new List<int>(){ 1001 } } },
            { 1004, new User() { Id = 1004, Firstname = "Myriam", Lastname = "Leblanc", PrincImage="/Assets/Users/user4.jpg", FriendIds = new List<int>(){ 1001, 1003 } } },
            { 1005, new User() { Id = 1005, Firstname = "Paul", Lastname = "Burnham", PrincImage="/Assets/Users/user5.jpg"  } },
        };

        public int Id;
        public DateTime DateTime;
        public int UserId;
        public string Title;
        public string Description;
        public string ImageUrl;

        public Restriction Restriction;
        public Dictionary<int, Post> Posts { get => _posts; }
        private Dictionary<int, Post> _posts = new Dictionary<int, Post>()
        {
            { 01, new Post() { Id = 01,
                UserId = 1001, 
                Title = "Nice snack with a book",
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Cras id consectetur quam. Nam rutrum non dui et feugiat. Morbi a mattis leo. Phasellus efficitur nulla dignissim ipsum commodo, in maximus leo dignissim. Donec venenatis posuere justo quis pulvinar. Etiam eu neque nibh. Vivamus egestas sollicitudin dictum. Nunc tempus orci vel enim facilisis, sit amet rhoncus mi bibendum. Donec vel venenatis orci. Fusce ultricies libero id nulla dignissim, non molestie nunc placerat. Vestibulum hendrerit mi aliquet ante feugiat, a semper augue volutpat. Aenean leo est, sagittis non enim quis, aliquam vestibulum odio. Sed et suscipit orci.", 
                ImageUrl = "/Assets/Posts/post1.jpg",
                DateTime = new DateTime(2021, 11, 20, 7, 0, 0),
                Restriction = Restriction.Public } },
            { 02, new Post() { Id = 01,
                UserId = 1002,
                Title = "Relaxing night at the beach",
                Description = "Aenean vehicula ligula id nisl dapibus auctor. Aliquam ornare, libero eu pulvinar aliquam, sem lorem fermentum nisl, sed convallis lacus sem ut nulla. Suspendisse potenti. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer at rutrum dui. Ut at dolor leo. Maecenas id fringilla diam. Curabitur aliquet efficitur diam sed iaculis. Sed vulputate faucibus facilisis. Quisque tincidunt libero sit amet est dignissim, vitae egestas dui rutrum. Etiam non nisi quis elit consequat pretium non quis ante. Phasellus nec leo est. Vestibulum porttitor ac mauris sit amet tincidunt.",
                ImageUrl = "/Assets/Posts/post2.jpg",
                DateTime = new DateTime(2021, 11, 21, 10, 30, 0),
                Restriction = Restriction.Public } },
            { 03, new Post() { Id = 01,
                UserId = 1003,
                Title = "Trekking in the woods",
                Description = "Fusce tincidunt lorem mauris, id cursus nunc bibendum quis. Etiam sed malesuada arcu, ut tempus ligula. Ut quis erat non augue molestie scelerisque vel eu lectus. Sed et sapien blandit, iaculis tortor id, cursus nisl. Quisque facilisis congue iaculis. Ut bibendum, orci",
                ImageUrl = "/Assets/Posts/post3.jpg",
                DateTime = new DateTime(2021, 11, 22, 16, 30, 0), 
                Restriction = Restriction.Public } },
            { 04, new Post() { Id = 01,
                UserId = 1004,
                Title = "King of the world!",
                Description = "Phasellus viverra sed ante et egestas. Ut rhoncus ac enim id iaculis. Pellentesque elementum elit orci, nec molestie tellus ornare et. Nam pulvinar laoreet lobortis. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos. Integer",
                ImageUrl = "/Assets/Posts/post4.jpg",
                DateTime = new DateTime(2021, 11, 23, 21, 0, 0), 
                Restriction = Restriction.Public } },
            { 05, new Post() { Id = 01,
                UserId = 1005,
                Title = "After work",
                Description = "Nulla tincidunt eros eros, eget pulvinar massa suscipit eu. In eu leo enim. Aliquam sed feugiat magna. Nunc aliquet mauris dapibus, eleifend sapien quis, lobortis lectus. In hac habitasse platea dictumst. Mauris nec fermentum mauris. Maecenas eleifend tincidunt",
                ImageUrl = "/Assets/Posts/post5.jpg",
                DateTime = new DateTime(2021, 11, 24, 12, 0, 0), 
                Restriction = Restriction.Public } },
            { 06, new Post() { Id = 01,
                UserId = 1001,
                Title = "New Zealand 2017",
                Description = "Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos. Quisque varius malesuada tellus ut tincidunt. Sed porta suscipit tortor. Ut faucibus felis eu aliquet scelerisque. Nunc ut diam ornare, auctor felis pharetra, placerat lectus.",
                ImageUrl = "/Assets/Posts/post6.jpg",
                DateTime = new DateTime(2021, 11, 25, 1, 0, 0),
                Restriction = Restriction.FriendsOnly } },
            { 07, new Post() { Id = 01,
                UserId = 1001,
                Title = "Sweden 2018",
                Description = "Donec venenatis aliquet lectus, a tempor ex convallis vel. Mauris eros eros, iaculis non volutpat id, pulvinar ac sapien. In auctor, orci blandit accumsan tristique, quam ipsum tempor ante, sed condimentum nunc lectus non massa. Nunc fermentum nunc ipsum, nec",
                ImageUrl = "/Assets/Posts/post7.jpg",
                DateTime = new DateTime(2021, 11, 26, 9, 0, 0), 
                Restriction = Restriction.FriendsExcept } },
            { 08, new Post() { Id = 01,
                UserId = 1001,
                Title = "Internet cafe Sundays",
                Description = "In ullamcorper pulvinar ex eget fringilla. Ut luctus sed ante vitae posuere. Quisque quis tortor pharetra, tincidunt risus nec, tincidunt dui. Phasellus sagittis sollicitudin tellus. Morbi volutpat tristique dapibus. Ut ut felis facilisis, scelerisque sem sit amet, ultrices felis. Cras rhoncus diam ac leo mattis tristique. Sed vel vestibulum eros. Fusce at iaculis arcu, et porttitor eros.",
                ImageUrl = "/Assets/Posts/post8.jpg",
                DateTime = new DateTime(2021, 11, 27, 11, 30, 0), 
                Restriction = Restriction.SpecificFriends } },
            { 09, new Post() { Id = 01,
                UserId = 1002,
                Title = "Surprise!",
                Description = "Duis quis sapien ex. Nam in est eget nisi ultricies scelerisque nec vitae metus. Aenean pulvinar ut dui et rhoncus. Nam dolor ipsum, vulputate in sapien nec, pellentesque feugiat nulla. Proin aliquet tempus tincidunt. Phasellus id faucibus velit. Nullam non nisi lectus. Praesent in arcu eget urna aliquet egestas eu eget nibh. Sed bibendum eget magna id pretium.",
                ImageUrl = "/Assets/Posts/post9.jpg",
                DateTime = new DateTime(2021, 11, 28, 14, 30, 0), 
                Restriction = Restriction.FriendsOnly } },
            { 10, new Post() { Id = 01,
                UserId = 1002,
                Title = "Secret painting",
                Description = "Cras sit amet dictum arcu, sit amet tempus ante. Aliquam nisi augue, pharetra nec erat vitae, aliquam fermentum arcu. Duis viverra arcu ac magna cursus bibendum. Etiam laoreet semper felis, tincidunt tristique lorem placerat vel. Nam leo nisl, tempor ut facilisis fermentum, maximus at odio. Donec et laoreet sem, non mattis sem. Sed accumsan at sem non egestas. Donec ultricies libero ultricies tellus euismod, eu sollicitudin nisl dictum. Quisque non consequat purus, sit amet dignissim justo. Ut placerat dolor vel tellus viverra, malesuada tempus ante sodales. Nullam dignissim at nulla vel volutpat. Phasellus egestas ultrices scelerisque. Integer tellus enim, convallis ut elit vel, pretium facilisis orci. Mauris fringilla velit metus, sed gravida elit blandit at.",
                ImageUrl = "/Assets/Posts/post10.jpg",
                DateTime = new DateTime(2021, 11, 29, 17, 30, 0), 
                Restriction = Restriction.OnlyMe } },
        };

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

        public Dictionary<int, Friend> Friends = new Dictionary<int, Friend>();
        public Dictionary<int, Group> Groups = new Dictionary<int, Group>();
        public Dictionary<int, Comment> Comments = new Dictionary<int, Comment>();
        public Dictionary<int, Event> Events = new Dictionary<int, Event>();

        
    }
}
