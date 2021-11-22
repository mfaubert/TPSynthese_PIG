using System.Collections.Generic;

namespace Classes01_Corrige
{
    public class Mod : Product
    {
        public int BaseGameId;

        public List<GameCategory> GameCategories = new List<GameCategory>();

        public Game Game { get { return null; } }
    }
}
