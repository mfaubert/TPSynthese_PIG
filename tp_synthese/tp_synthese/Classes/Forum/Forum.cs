using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace Classes01_Corrige
{
    public class Forum
    {
        public List<ForumThread> Threads = new List<ForumThread>();
        public List<int> ModeratorUserIds = new List<int>();

        public IEnumerable<User> Moderators
        {
            get { return App.Current.Users.Where(x => ModeratorUserIds.Contains(x.Id)); }
        }

        public IEnumerable<ForumThread> MostRecentThreads
        {
            get { return Threads.OrderByDescending(x => x.DateTime); }
        }

        public IEnumerable<ForumThread> MostActiveThreadsToday
        {
            get
            {
                return Threads
                  .Where(x => App.IsToday(x.DateTime))
                  .OrderByDescending(x => x.ForumPosts.Count);
            }
        }

        public IEnumerable<ForumThread> MostActiveThreadsThisWeek
        {
            get
            {
                return Threads
                  .Where(x => App.IsThisWeek(x.DateTime))
                  .OrderByDescending(x => x.ForumPosts.Count);
            }
        }
    }
}
