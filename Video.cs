namespace TP
{
    public class Video : Publication, IRentable
    {
        public int Duree { get; set; } // Durée en minutes

        public Video(string designation, double prix, int duree) 
            : base(designation, prix)
        {
            Duree = duree;
        }

        public double CalculateRent()
        {
            return Duree * 0.20; // Ex : 0.20€/minute
        }

        public override void PublishDetails()
        {
            Console.WriteLine($"Vidéo - {Designation}, Durée : {Duree} min, Prix : {Prix:0.00}€");
        }

        public override void Afficher()
        {
            base.Afficher();
            Console.WriteLine($"Durée : {Duree} minutes");
        }
    }
}
