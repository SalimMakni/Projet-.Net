namespace Application_Gestion_Restaurant.Model
{
    public class Paiement
    {
        public int Id { get; set; }
        public int CommandeId { get; set; }
       // public Commande? Commande { get; set; }
        public string Methode { get; set; } = string.Empty;
        public bool EstReussi { get; set; } = false;
        public DateTime DatePaiement { get; set; } = DateTime.Now;
    }
}
