namespace Classes01_Corrige
{
    public class ChatMessageCollectibleSticker : Post
    {
        public int CollectibleStickerId;

        public CollectibleSticker CollectibleSticker 
        { 
            get { return App.Current.Collectibles[CollectibleStickerId] as CollectibleSticker; } 
        }
    }
}