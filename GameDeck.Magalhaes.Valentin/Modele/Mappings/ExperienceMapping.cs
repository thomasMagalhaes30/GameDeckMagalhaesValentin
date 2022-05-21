using Modele.Entities;
using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;

namespace Modele.Mappings
{
    /// <summary>
    /// Represente le mapping de l'entite <see cref="Experience"/>.
    /// </summary>
    public class ExperienceMapping : EntityTypeConfiguration<Experience>
    {
        public ExperienceMapping()
        {
            ToTable("APP_EXPERIENCE");
            HasKey(e => e.Id);

            Property(e => e.Id)
                .HasColumnName("EXPERIENCE_ID")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
                .IsRequired();

            Property(e => e.Joueur)
                .HasColumnName("EXPERIENCE_JOUEUR")
                .HasMaxLength(128)
                .IsRequired();

            Property(e => e.TempsJeu)
                .HasColumnName("EXPERIENCE_TEMPSJEU")
                .IsRequired();

            Property(e => e.Pourcentage)
                .HasColumnName("EXPERIENCE_POURCENTAGE")
                .IsRequired();

            Property(e => e.JeuId)
                .HasColumnName("JEU_ID")
                .IsRequired();

            #region [ Foreign Key ]

            HasRequired(e => e.JeuObj)
                .WithMany(j => j.Experiences)
                .HasForeignKey(j => j.JeuId);

            #endregion
        }
    }
}
