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

        public IEnumerable<User> Friends
        {
            get { return App.Current.Users.Values.Where(x => FriendIds.Contains(x.Id)); }
        }

        public IEnumerable<User> FriendsByAlphabeticalOrder
        {
            get { 
                return Friends.OrderBy(x => x.Firstname); 
            }
        }


        /*
        public List<int> ProductIds = new List<int>();
        public List<int> CollectibleIds = new List<int>();
        

        public IEnumerable<Product> Products
        {
            get
            {
                // IEnumerable<Product>
                IEnumerable<Product> enumerable =
                  App.Current.Products.Values
                    .Where(
                    product
                    =>
                    ProductIds.Contains(product.Id));

                // Impossible, transofrm en List avec .ToList()
                //Product test = enumerable[0];
                List<Product> list = enumerable.ToList();
                Product test2 = list[0];

                // return IEnumerable<Product>
                return enumerable;
            }
        }

        public IEnumerable<Product> ProductsOrderedByName
        {
            get
            {
                var products = Products;
                var enumerable = products.OrderBy(product => product.Name);
                return enumerable;
            }
        }

        public IEnumerable<Product> ProductsOrderedByReleaseDate
        {
            get
            {
                var enumerable = App.Current
                    .Products
                    .Values
                    .Where(p => ProductIds.Contains(p.Id))
                    .OrderBy(p => p.ReleaseDate)
                    .ThenBy(p => p.Name);
                return enumerable;
            }
        }

        public IEnumerable<Product> ProductsOrderedByReleaseDateDescending
        {
            get
            {
                var products = Products;
                var enumerable = products.OrderByDescending(product => product.ReleaseDate);
                return enumerable;
            }
        }

        public IEnumerable<User> Friends
        {
            get { return App.Current.Users.Values.Where(x => FriendIds.Contains(x.Id)); }
        }

        public IEnumerable<Collectible> Collectibles
        {
            get { return App.Current.Collectibles.Values.Where(x => CollectibleIds.Contains(x.Id)); }
        }

        public IEnumerable<CollectibleBackground> CollectibleBackground
        {
            get
            {
                return Collectibles.Where(x => x is CollectibleBackground)
                  .Select(x => x as CollectibleBackground);
            }
        }

        public IEnumerable<CollectibleEmoticon> CollectibleEmoticon
        {
            get
            {
                return Collectibles.Where(x => x is CollectibleEmoticon)
                  .Select(x => x as CollectibleEmoticon);
            }
        }

        public IEnumerable<CollectibleFrame> CollectibleFrame
        {
            get
            {
                return Collectibles.Where(x => x is CollectibleFrame)
                  .Select(x => x as CollectibleFrame);
            }
        }

        public IEnumerable<CollectibleSticker> CollectibleStickers
        {
            get
            {
                return Collectibles.Where(x => x is CollectibleSticker)
                      .Select(x => x as CollectibleSticker);
            }
        }

        public IEnumerable<FriendChat> FriendChats
        {
            get
            {
                var chats = App.Current.Chats.Values
                 .Where(
                    x => x is FriendChat
                    && x.UserIds.Contains(Id));

                return chats.Cast<FriendChat>();
            }
        }

        public IEnumerable<GroupChat> GroupChats
        {
            get
            {
                var chats = App.Current.Chats.Values
                 .Where(
                    x => x is GroupChat
                    && x.UserIds.Contains(Id));

                return chats.Cast<GroupChat>();
            }
        }

        public FriendChat GetFriendChat(int friendUserId)
        {
            if (!FriendIds.Contains(friendUserId))
                return null;

            var chat = App.Current.Chats.Values
                 .FirstOrDefault(
                    x => x is FriendChat
                    && x.UserIds.Contains(friendUserId)
                    && x.UserIds.Contains(Id));

            return chat as FriendChat;
        }

        public IEnumerable<UserContent> UserContents
        {
            get { return App.Current.UserContents.Values.Where(x => x.UserId == Id); }
        }

        public IEnumerable<UserContent> FriendsUserContents
        {
            get { return App.Current.UserContents.Values.Where(x => FriendIds.Contains(x.UserId)); }
        }

        public IEnumerable<UserContent> MostPopularUserContentForOwnedProductsToday
        {
            get
            {
                return App.Current.UserContents.Values
                    .Where(x => ProductIds.Contains(x.ProductId)
                        && App.IsToday(x.DateTime))
                    .OrderByDescending(x => x.UserThumbsUp.Count);
            }
        }

        public IEnumerable<UserContent> MostPopularUserContentForOwnedProductsThisWeek
        {
            get
            {
                return App.Current.UserContents.Values
                    .Where(x => ProductIds.Contains(x.ProductId)
                        && App.IsThisWeek(x.DateTime))
                    .OrderByDescending(x => x.UserThumbsUp.Count);
            }
        }

        public IEnumerable<UserContent> MostPopularUserContentForOwnedProductsThisMonth
        {
            get
            {
                return App.Current.UserContents.Values
                    .Where(x => ProductIds.Contains(x.ProductId)
                        && App.IsThisMonth(x.DateTime))
                    .OrderByDescending(x => x.UserThumbsUp.Count);
            }
        }

        public IEnumerable<Forum> ModeratedForums
        {
            get { return App.Current.Forums.Values.Where(x => x.ModeratorUserIds.Contains(Id); }
        }
        */
    }
}
