namespace TP
{
    public abstract class Article
    {
        public string Designation { get; set; }
        public double Prix { get; set; }

        public Article(string designation, double prix)
        {
            Designation = designation;
            Prix = prix;
        }

        public virtual void Afficher()
        {
            Console.WriteLine($"Désignation : {Designation}, Prix : {Prix:0.00}€");
        }
    }
}
