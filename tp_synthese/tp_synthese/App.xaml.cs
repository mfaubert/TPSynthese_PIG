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
    /// Logique d'interaction pour App.xaml
    /// </summary>
    public partial class App : Application
    {
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

        public static new App Current
        {
            get { return Application.Current as App; }
        }

        public Dictionary<int, User> Users = new Dictionary<int, User>();
        public Dictionary<int, Developer> Developers = new Dictionary<int, Developer>();
        public Dictionary<int, Product> Products = new Dictionary<int, Product>();
        public Dictionary<int, Promotion> Promotions = new Dictionary<int, Promotion>();
        public Dictionary<int, Collectible> Collectibles = new Dictionary<int, Collectible>();
        public Dictionary<int, Chat> Chats = new Dictionary<int, Chat>();
        public Dictionary<int, UserContent> UserContents = new Dictionary<int, UserContent>();
        public Dictionary<int, Forum> Forums = new Dictionary<int, Forum>();

        public IEnumerable<CollectibleBackground> CollectibleBackground
        {
            get
            {
                return Collectibles.Values.Where(x => x is CollectibleBackground)
                  .Select(x => x as CollectibleBackground);
            }
        }

        public IEnumerable<CollectibleEmoticon> CollectibleEmoticon
        {
            get
            {
                return Collectibles.Values.Where(x => x is CollectibleEmoticon)
                  .Select(x => x as CollectibleEmoticon);
            }
        }

        public IEnumerable<CollectibleFrame> CollectibleFrame
        {
            get
            {
                return Collectibles.Values.Where(x => x is CollectibleFrame)
                  .Select(x => x as CollectibleFrame);
            }
        }

        public IEnumerable<CollectibleSticker> CollectibleStickers
        {
            get
            {
                return Collectibles.Values.Where(x => x is CollectibleSticker)
                      .Select(x => x as CollectibleSticker);
            }
        }

        public IEnumerable<User> UsersWithMoreThan300Products
        {
            get
            {
                return Users.Values.Where(u => u.ProductIds.Count >= 300);
            }
        }
    }
}
