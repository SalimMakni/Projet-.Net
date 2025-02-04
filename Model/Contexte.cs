//using Application_Gestion_Restaurant.Model.Repository;
using Microsoft.AspNetCore.Identity;
//using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;//Base de données et les tables
using System;
//Contenance du modéle La déclaration du modéles (les classes)
//Cette classe contexte est utilisée pour configurer
//et gérer la connexion à la base de données ainsi que pour effectuer des opérations sur les entités dans la base de données.
namespace Application_Gestion_Restaurant.Model
{
    public class Contexte : DbContext//Sécuriser les API
    {//Seulement Update pour versionnage
        
        public Contexte(DbContextOptions<Contexte> options) : base(options)
        {
        }
        //public DbSet<Employee> Employees { get; set; }
        //Chaque DbSet<T> correspond à une table de la base de données,
        //et chaque entité représente une ligne dans cette table.
        public DbSet<Article> Articles { get; set; }
        public DbSet<Categorie> Categories { get; set; }
        public DbSet<Commande> Commandes { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Paiement> Paiements { get; set; }
    }
}

