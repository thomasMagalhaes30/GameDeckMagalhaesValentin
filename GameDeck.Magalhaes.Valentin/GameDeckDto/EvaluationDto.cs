using System;

namespace GameDeckDto
{
    /// <summary>
    /// Represente le dto de l'entite <see cref="Evaluation"/>.
    /// </summary>
    public class EvaluationDto
    {
        /// <summary>
        /// Obtient ou definit l'identifiant de l'<see cref="EvaluationDto"/>.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Obtient ou definit le nom de l'evaluateur de l'<see cref="EvaluationDto"/>.
        /// </summary>
        public string NomEvaluateur { get; set; }

        /// <summary>
        /// Obtient ou definit la date de l'<see cref="EvaluationDto"/>.
        /// </summary>
        public DateTime Date { get; set; }

        /// <summary>
        /// Obtient ou definit la note de l'<see cref="EvaluationDto"/>.
        /// </summary>
        public float Note { get; set; }

        /// <summary>
        /// Obtient ou definit l'identifiant du <see cref="Jeu"/> de l'<see cref="EvaluationDto"/>.
        /// </summary>
        public int JeuId { get; set; }

        /// <summary>
        /// Obtient ou definit le <see cref="Jeu"/> de l'<see cref="EvaluationDto"/>.
        /// </summary>
        public JeuDto JeuObj { get; set; }
    }
}
