using System;
using System.Collections.Generic;

namespace GameDeckWebApplication.Models
{
    /// <summary>
    /// Represente le viewmodel d'un jeu.
    /// </summary>
    public class JeuVM
    {
        /// <summary>
        /// Obtient ou definit l'identifiant du <see cref="JeuVM"/>.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Obtient ou definit le nom du <see cref="JeuVM"/>.
        /// </summary>
        public string Nom { get; set; }

        /// <summary>
        /// Obtient ou definit la descriptio du <see cref="JeuVM"/>.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Obtient ou definit la date de sortie du <see cref="JeuVM"/>.
        /// </summary>
        public DateTime DateSortie { get; set; }

        /// <summary>
        /// Obtient ou definit l'identifiant du <see cref=GenreVM"/> du <see cref="JeuVM"/>.
        /// </summary>
        public int GenreId { get; set; }

        /// <summary>
        /// Obtient ou definit l'identifiant de l'<see cref="EditeurVM"/> du <see cref="JeuVM"/>.
        /// </summary>
        public int EditeurId { get; set; }

        /// <summary>
        /// Obtient ou definit l'<see cref="EditeurVM"/> du <see cref="JeuVM"/>.
        /// </summary>
        public EditeurVM EditeurObj { get; set; }

        /// <summary>
        /// Obtient ou definit le <see cref=GenreVM"/> du <see cref="JeuVM"/>.
        /// </summary>
        public GenreVM GenreObj { get; set; }

        /// <summary>
        /// Obtient ou definit la liste de <see cref="EvaluationVM"/> du <see cref="JeuVM"/>.
        /// </summary>
        public ICollection<EvaluationVM> Evaluations { get; set; } = new List<EvaluationVM>();

        /// <summary>
        /// Obtient ou definit la liste de <see cref="ExperienceVM"/> du <see cref="JeuVM"/>.
        /// </summary>
        public ICollection<ExperienceVM> Experiences { get; set; } = new List<ExperienceVM>();
    }
}