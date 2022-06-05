using System;

namespace Modele.Entities
{
    /// <summary>
    /// Represente une <see cref="Experience"/> (APP_EXPERIENCE).
    /// </summary>
    public class Experience : BaseEntity
    {
        /// <summary>
        /// Obtient ou definit le joueur de l'<see cref="Experience"/>.
        /// </summary>
        public string Joueur { get; set; }

        /// <summary>
        /// Obtient ou definit le temps de jeu de l'<see cref="Experience"/>.
        /// </summary>
        /// <remarks>Total en secondes</remarks>
        public double TempsJeu { get; set; }

        /// <summary>
        /// Obtient ou definit le pourcentage de l'<see cref="Experience"/>.
        /// </summary>
        public float Pourcentage { get; set; }

        /// <summary>
        /// Obtient ou definit l'identifiant du <see cref="Jeu"/> de l'<see cref="Experience"/>.
        /// </summary>
        public int JeuId { get; set; }

        /// <summary>
        /// Obtient ou definit le <see cref="Jeu"/> du jeu de l'<see cref="Experience"/>.
        /// </summary>
        public Jeu JeuObj { get; set; }
    }
}
