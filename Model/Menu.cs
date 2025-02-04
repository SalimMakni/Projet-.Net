namespace Application_Gestion_Restaurant.Model
{
    public class Menu
    {
        public int Id { get; set; }
        public List<Article> Articles { get; set; } = new List<Article>();
    }
}
