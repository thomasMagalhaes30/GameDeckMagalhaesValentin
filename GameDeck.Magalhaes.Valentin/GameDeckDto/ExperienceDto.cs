using System;

namespace GameDeckDto
{
    /// <summary>
    /// Represente le dto de l'entite <see cref="Experience"/>.
    /// </summary>
    public class ExperienceDto
    {
        /// <summary>
        /// Obtient ou definit l'identifiant de l'<see cref="ExperienceDto"/>.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Obtient ou definit le joueur de l'<see cref="ExperienceDto"/>.
        /// </summary>
        public string Joueur { get; set; }

        /// <summary>
        /// Obtient ou definit le temps de jeu de l'<see cref="ExperienceDto"/>.
        /// </summary>
        public TimeSpan TempsJeu { get; set; }

        /// <summary>
        /// Obtient ou definit le pourcentage de l'<see cref="ExperienceDto"/>.
        /// </summary>
        public float Pourcentage { get; set; }

        /// <summary>
        /// Obtient ou definit l'identifiant du <see cref="JeuDto"/> de l'<see cref="ExperienceDto"/>.
        /// </summary>
        public int JeuId { get; set; }

        /// <summary>
        /// Obtient ou definit le <see cref="JeuDto"/> du jeu de l'<see cref="ExperienceDto"/>.
        /// </summary>
        public JeuDto JeuObj { get; set; }
    }
}
