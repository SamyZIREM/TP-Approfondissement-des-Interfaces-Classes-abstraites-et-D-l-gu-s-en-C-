namespace TP
{
    public class Livre : Publication, IRentable
    {
        public string ISBN { get; set; }
        public int NbPages { get; set; }

        public Livre(string designation, double prix, string isbn, int nbPages) 
            : base(designation, prix)
        {
            ISBN = isbn;
            NbPages = nbPages;
        }

        public double CalculateRent()
        {
            return NbPages * 0.05; // Ex : 0.05€/page
        }

        public override void PublishDetails()
        {
            Console.WriteLine($"Livre - {Designation}, ISBN : {ISBN}, Pages : {NbPages}, Prix : {Prix:0.00}€");
        }

        public override void Afficher()
        {
            base.Afficher();
            Console.WriteLine($"ISBN : {ISBN}, Nombre de pages : {NbPages}");
        }
    }
}
