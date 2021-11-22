using System.Collections.Generic;

namespace Classes01_Corrige
{
    public class UserContentGuide : UserContent
    {
        public string Description;
        public string ImageUrl;
        public List<UserContentGuideSection> Sections = new List<UserContentGuideSection>();
    }
}
