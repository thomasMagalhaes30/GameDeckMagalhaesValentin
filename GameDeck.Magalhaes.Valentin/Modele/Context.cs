using Modele.Entities;
using Modele.Mappings;
using System.Data.Entity;
using System.Reflection;

namespace Modele
{
    public class Context : DbContext
    {
        public Context() : base("name=ConnexionString")
        {
            // A remplacer par DropCreateDatabaseIfModelChanges puis par null
            Database.SetInitializer(new DropCreateDatabaseAlways<Context>());
        }

        public DbSet<Editeur> Editeurs { get; set; }
        public DbSet<Evaluation> Evaluations { get; set; }
        public DbSet<Experience> Experiences { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Jeu> Jeux { get; set; }

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
