using TP;

class Program
{
    static void Main(string[] args)
    {
        // ------------------ EXERCICE 1 : Interfaces ------------------
        Console.WriteLine("=== EXERCICE 1 : Interfaces ===\n");

        List<Article> articles = new List<Article>
        {
            new Livre("C# avancé", 25.99, "12345", 300),
            new Disque("Album Rock", 15.50, "Universal Music"),
            new Video("Film d'action", 12.99, 120)
        };

        foreach (var article in articles)
        {
            article.Afficher();

            if (article is IRentable rentable)
            {
                Console.WriteLine($"Coût de location : {rentable.CalculateRent():0.00}€");
            }

            Console.WriteLine(new string('-', 40));
        }

        // ------------------ EXERCICE 2 : Classes Abstraites ------------------
        Console.WriteLine("\n=== EXERCICE 2 : Classes Abstraites ===\n");

        List<Publication> publications = new List<Publication>
        {
            new Livre("Les Misérables", 30.50, "98765", 1200),
            new Disque("Classical Collection", 20.00, "Sony Music"),
            new Video("Documentaire Nature", 18.75, 90)
        };

        foreach (var publication in publications)
        {
            publication.PublishDetails();
            Console.WriteLine(new string('-', 40));
        }

        // ------------------ EXERCICE 3 : Délégués ------------------
        Console.WriteLine("\n=== EXERCICE 3 : Délégués ===\n");

        DiscountStrategy fixedDiscount = DiscountCalculator.FixedPercentageDiscount;
        DiscountStrategy bookDiscount = DiscountCalculator.BookDiscount;
        DiscountStrategy videoDiscount = DiscountCalculator.VideoDiscount;

        foreach (var article in articles)
        {
            Console.WriteLine($"Article : {article.Designation}");
            Console.WriteLine($"Prix initial : {article.Prix:0.00}€");

            // Appliquer une stratégie de remise et afficher le résultat
            double discount = fixedDiscount(article);
            Console.WriteLine($"Remise fixe (10%) : {discount:0.00}€");
            Console.WriteLine($"Prix après remise fixe : {(article.Prix - discount):0.00}€");

            discount = bookDiscount(article);
            Console.WriteLine($"Remise pour livre (15%) : {discount:0.00}€");
            Console.WriteLine($"Prix après remise livre : {(article.Prix - discount):0.00}€");

            discount = videoDiscount(article);
            Console.WriteLine($"Remise pour vidéo (fixe 5€) : {discount:0.00}€");
            Console.WriteLine($"Prix après remise vidéo : {(article.Prix - discount):0.00}€");

            Console.WriteLine(new string('-', 40));
        }
    }
}
