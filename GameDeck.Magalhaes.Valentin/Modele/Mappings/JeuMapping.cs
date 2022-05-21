using Modele.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Modele.Mappings
{
    /// <summary>
    /// Represente le mapping de l'entite <see cref="Jeu"/>.
    /// </summary>
    public class JeuMapping : EntityTypeConfiguration<Jeu>
    {
        public JeuMapping()
        {
            ToTable("APP_JEU");
            HasKey(j => j.Id);

            Property(j => j.Id)
                .HasColumnName("JEU_ID")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
                .IsRequired();

            Property(j => j.Nom)
                .HasColumnName("JEU_NOM")
                .HasMaxLength(64)
                .IsRequired();

            Property(j => j.Description)
                .HasColumnName("JEU_DESCRIPTION")
                .HasMaxLength(256)
                .IsRequired();

            Property(j => j.DateSortie)
                .HasColumnName("JEU_DATESORTIE")
                .IsRequired();

            Property(j => j.GenreId)
                .HasColumnName("GENRE_ID")
                .IsRequired();

            Property(j => j.EditeurId)
                .HasColumnName("EDITEUR_ID")
                .IsRequired();

            #region [ Foreign Key ]

            HasRequired(j => j.EditeurObj)
                   .WithMany(e => e.Jeux)
                   .HasForeignKey(j => j.EditeurId);

            HasRequired(j => j.GenreObj)
                .WithMany(g => g.Jeux)
                .HasForeignKey(j => j.GenreId); 

            #endregion
        }
    }
}
