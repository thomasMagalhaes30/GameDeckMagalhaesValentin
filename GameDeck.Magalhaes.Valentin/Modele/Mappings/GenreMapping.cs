using Modele.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Modele.Mappings
{
    /// <summary>
    /// Represente le mapping de l'entite <see cref="Genre"/>.
    /// </summary>
    public class GenreMapping : EntityTypeConfiguration<Genre>
    {
        public GenreMapping()
        {
            ToTable("APP_GENRE");
            HasKey(g => g.Id);

            Property(g => g.Id)
                .HasColumnName("GENRE_ID")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
                .IsRequired();

            Property(g => g.Nom)
                .HasColumnName("GENRE_NOM")
                .HasMaxLength(64)
                .IsRequired();
        }
    }
}
