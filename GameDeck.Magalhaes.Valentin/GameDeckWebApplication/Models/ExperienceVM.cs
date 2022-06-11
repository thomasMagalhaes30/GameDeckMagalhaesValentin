using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GameDeckWebApplication.Models
{
    /// <summary>
    /// Represente le viewmodel d'une experience.
    /// </summary>
    public class ExperienceVM
    {
        /// <summary>
        /// Obtient ou definit l'identifiant de l'<see cref="ExperienceVM"/>.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Obtient ou definit le joueur de l'<see cref="ExperienceVM"/>.
        /// </summary>
        public string Joueur { get; set; }

        /// <summary>
        /// Obtient ou definit le temps de jeu de l'<see cref="ExperienceVM"/>.
        /// </summary>
        public TimeSpan TempsJeu { get; set; }

        /// <summary>
        /// Obtient ou definit le pourcentage de l'<see cref="ExperienceVM"/>.
        /// </summary>
        public float Pourcentage { get; set; }

        /// <summary>
        /// Obtient ou definit l'identifiant du <see cref="JeuVM"/> de l'<see cref="ExperienceVM"/>.
        /// </summary>
        public int JeuId { get; set; }

        /// <summary>
        /// Obtient ou definit le <see cref="JeuVM"/> du jeu de l'<see cref="ExperienceVM"/>.
        /// </summary>
        public JeuVM JeuObj { get; set; }
    }
}