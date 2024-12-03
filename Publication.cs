namespace TP
{
    public abstract class Publication : Article
    {
        public Publication(string designation, double prix) : base(designation, prix) { }

        public abstract void PublishDetails();
    }
}
