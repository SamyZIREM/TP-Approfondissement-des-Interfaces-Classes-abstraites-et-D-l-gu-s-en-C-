namespace TP
{
    public static class DiscountCalculator
    {
        // Remise fixe de 10%
        public static double FixedPercentageDiscount(Article article)
        {
            return article.Prix * 0.10; // 10% de remise
        }

        // Remise spécifique pour les livres
        public static double BookDiscount(Article article)
        {
            if (article is Livre)
                return article.Prix * 0.15; // 15% de remise pour les livres
            return 0.0;
        }

        // Remise spécifique pour les vidéos
        public static double VideoDiscount(Article article)
        {
            if (article is Video)
                return 5.0; // Remise fixe de 5€
            return 0.0;
        }
    }
}
