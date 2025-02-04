namespace Application_Gestion_Restaurant.Model;
using System.Collections.Generic;

public class Categorie
{
    
// Classe représentant une catégorie d'articles

        public int Id { get; set; }
        public string Nom { get; set; } = string.Empty;
        public List<Article> Articles { get; set; } = new List<Article>();
    }



