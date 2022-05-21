using Modele.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Modele.Mappings
{
    /// <summary>
    /// Represente le mapping de l'entite <see cref="Evaluation"/>.
    /// </summary>
    public class EvaluationMapping : EntityTypeConfiguration<Evaluation>
    {
        public EvaluationMapping()
        {
            ToTable("APP_EVALUATION");
            HasKey(e => e.Id);

            Property(e => e.Id)
                .HasColumnName("EVAL_ID")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
                .IsRequired();

            Property(e => e.NomEvaluateur)
                .HasColumnName("EVAL_NOMEVALUATEUR")
                .HasMaxLength(128)
                .IsRequired();

            Property(e => e.Date)
                .HasColumnName("EVAL_DATE")
                .IsRequired();

            Property(e => e.Note)
                .HasColumnName("EVAL_NOTE")
                .IsRequired();

            Property(e => e.JeuId)
                .HasColumnName("JEU_ID")
                .IsRequired();

            #region [ Foreign Key ]

            HasRequired(e => e.JeuObj)
                .WithMany(j => j.Evaluations)
                .HasForeignKey(j => j.JeuId);

            #endregion
        }
    }
}
