using Modele.Entities;
using Modele.Mappings;
using System.Data.Entity;

namespace Modele
{
    /// <summary>
    /// Représente le contexte EF héritant de la classe DbContext.
    /// </summary>
    public class Context : DbContext
    {
        public Context() : base("name=ConnexionString")
        {
            // A remplacer par DropCreateDatabaseIfModelChanges puis par null
            //Database.SetInitializer<Context>(new DropCreateDatabaseAlways<Context>());
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<Context>());
        }

        /// <summary>
        /// Les editeurs.
        /// </summary>
        public DbSet<Editeur> Editeurs { get; set; }

        /// <summary>
        /// Les evaluations.
        /// </summary>
        public DbSet<Evaluation> Evaluations { get; set; }

        /// <summary>
        /// Les experiences.
        /// </summary>
        public DbSet<Experience> Experiences { get; set; }

        /// <summary>
        /// Les genres.
        /// </summary>
        public DbSet<Genre> Genres { get; set; }

        /// <summary>
        /// Les jeux.
        /// </summary>
        public DbSet<Jeu> Jeux { get; set; }

        /// <summary>
        /// Surcharge du OnModelCreating pour ajouter la configuration Fluent.
        /// </summary>
        /// <param name="modelBuilder"></param>
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.HasDefaultSchema("dbo");

            modelBuilder.Configurations.Add(new EditeurMapping());
            modelBuilder.Configurations.Add(new EvaluationMapping());
            modelBuilder.Configurations.Add(new ExperienceMapping());
            modelBuilder.Configurations.Add(new GenreMapping());
            modelBuilder.Configurations.Add(new JeuMapping());

            // Pour un fonctionnement automatique par l'assembly
            // modelBuilder.Configurations.AddFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
