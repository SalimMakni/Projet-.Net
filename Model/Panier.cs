namespace Application_Gestion_Restaurant.Model
{
    public class Panier
    {
        public int Id { get; set; }
        public List<Article> Articles { get; set; } = new List<Article>();
        public decimal Total => CalculerTotal();

        private decimal CalculerTotal()
        {
            decimal total = 0;
            foreach (var article in Articles)
            {
                total += article.Prix;
            }
            return total;
        }
    }
}
