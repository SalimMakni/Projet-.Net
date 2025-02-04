namespace Application_Gestion_Restaurant.Model
{
    public class Article
    {
        public int Id { get; set; }
        public string Nom { get; set; } = string.Empty;
        public decimal Prix { get; set; }
        public int CategorieId { get; set; }
        public Categorie? Categorie { get; set; }
    }
}
