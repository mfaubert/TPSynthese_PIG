namespace Classes01_Corrige
{
    public abstract class Collectible
    {
        public int Id;
        public int ProductId;
        public string Name;
        public string Url;

        public Product Product { get { return App.Current.Products[ProductId]; } }
    }
}
