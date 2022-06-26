using System;
using System.Collections.Generic;

namespace GameDeckDto
{
    /// <summary>
    /// Represente le dto de l'entite <see cref="Jeu"/>.
    /// </summary>
    public class JeuDto
    {
        /// <summary>
        /// Obtient ou definit l'identifiant du <see cref="JeuDto"/>.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Obtient ou definit le nom du <see cref="JeuDto"/>.
        /// </summary>
        public string Nom { get; set; }

        /// <summary>
        /// Obtient ou definit la descriptio du <see cref="JeuDto"/>.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Obtient ou definit la date de sortie du <see cref="JeuDto"/>.
        /// </summary>
        public DateTime DateSortie { get; set; }

        /// <summary>
        /// Obtient ou definit l'identifiant du <see cref=GenreDto"/> du <see cref="JeuDto"/>.
        /// </summary>
        public int GenreId { get; set; }

        /// <summary>
        /// Obtient ou definit l'identifiant de l'<see cref="EditeurDto"/> du <see cref="JeuDto"/>.
        /// </summary>
        public int EditeurId { get; set; }

        /// <summary>
        /// Obtient ou definit l'<see cref="EditeurDto"/> du <see cref="JeuDto"/>.
        /// </summary>
        public EditeurDto EditeurObj { get; set; }

        /// <summary>
        /// Obtient ou definit le <see cref=GenreDto"/> du <see cref="JeuDto"/>.
        /// </summary>
        public GenreDto GenreObj { get; set; }

        /// <summary>
        /// Obtient ou definit la liste de <see cref="EvaluationDto"/> du <see cref="JeuDto"/>.
        /// </summary>
        public ICollection<EvaluationDto> Evaluations { get; set; }

        /// <summary>
        /// Obtient ou definit la liste de <see cref="ExperienceDto"/> du <see cref="JeuDto"/>.
        /// </summary>
        public ICollection<ExperienceDto> Experiences { get; set; }
    }
}
