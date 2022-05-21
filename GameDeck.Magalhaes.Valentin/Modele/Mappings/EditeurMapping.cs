using Modele.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Modele.Mappings
{
    /// <summary>
    /// Represente le mapping de l'entite <see cref="Editeur"/>.
    /// </summary>
    public class EditeurMapping : EntityTypeConfiguration<Editeur>
    {
        public EditeurMapping()
        {
            ToTable("APP_EDITEUR");
            HasKey(e => e.Id);

            Property(e => e.Id)
                .HasColumnName("EDITEUR_ID")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
                .IsRequired();

            Property(e => e.Nom)
                .HasColumnName("EDITEUR_NOM")
                .HasMaxLength(64)
                .IsRequired();
        }
    }
}
