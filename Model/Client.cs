namespace Application_Gestion_Restaurant.Model
{
    public class Client
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
       // public Client? customer { get; set; }
        public List<Article> Articles { get; set; } = new List<Article>();
        public decimal TotalAPayer => CalculerTotal();
        public DateTime DateCommande { get; set; } = DateTime.Now;
        public string Status { get; set; } = "En attente";

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
