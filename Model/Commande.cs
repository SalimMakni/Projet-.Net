namespace Application_Gestion_Restaurant.Model
{
    public class Commande
    {
        public int Id { get; set; }
        public int ClientId { get; set; } // Référence au client ayant passé la commande
        public DateTime DateCommande { get; set; } = DateTime.Now; // Date de la commande
        public List<Article> Articles { get; set; } = new List<Article>(); // Articles commandés
        public decimal TotalAPayer => CalculerTotal(); // Total à payer pour la commande
        public string Status { get; set; } = "En attente"; // Statut de la commande (En attente, Confirmée, Livrée, etc.)

        // Méthode pour calculer le total de la commande
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