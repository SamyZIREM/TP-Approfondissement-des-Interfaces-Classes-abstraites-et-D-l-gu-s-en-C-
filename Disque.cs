namespace TP
{
    public class Disque : Publication, IRentable
    {
        public string Label { get; set; }

        public Disque(string designation, double prix, string label) 
            : base(designation, prix)
        {
            Label = label;
        }

        public double CalculateRent()
        {
            return Prix * 0.10; // Ex : 10% du prix comme coût de location
        }

        public override void PublishDetails()
        {
            Console.WriteLine($"Disque - {Designation}, Label : {Label}, Prix : {Prix:0.00}€");
        }

        public override void Afficher()
        {
            base.Afficher();
            Console.WriteLine($"Label : {Label}");
        }
    }
}
