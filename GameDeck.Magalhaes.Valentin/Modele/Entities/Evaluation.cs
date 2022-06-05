using System;

namespace Modele.Entities
{
    /// <summary>
    /// Represente une <see cref="Evaluation"/> (APP_EVALUATION).
    /// </summary>
    public class Evaluation : BaseEntity
    {
        /// <summary>
        /// Obtient ou definit le nom de l'evaluateur de l'<see cref="Evaluation"/>.
        /// </summary>
        public string NomEvaluateur { get; set; }

        /// <summary>
        /// Obtient ou definit la date de l'<see cref="Evaluation"/>.
        /// </summary>
        public DateTime Date { get; set; }

        /// <summary>
        /// Obtient ou definit la note de l'<see cref="Evaluation"/>.
        /// </summary>
        public float Note { get; set; }

        /// <summary>
        /// Obtient ou definit l'identifiant du <see cref="Jeu"/> de l'<see cref="Evaluation"/>.
        /// </summary>
        public int JeuId { get; set; }

        /// <summary>
        /// Obtient ou definit le <see cref="Jeu"/> de l'<see cref="Evaluation"/>.
        /// </summary>
        public Jeu JeuObj { get; set; }
    }
}
