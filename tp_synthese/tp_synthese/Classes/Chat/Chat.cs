using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace Classes01_Corrige
{
    public abstract class Chat
    {
        public int Id;
        public List<int> UserIds = new List<int>();
        public List<ChatMessage> ChatMessages = new List<ChatMessage>();

        public IEnumerable<User> Users
        {
            get { return App.Current.Users.Values.Where(x => UserIds.Contains(x.Id)); }
        }
    }
}
