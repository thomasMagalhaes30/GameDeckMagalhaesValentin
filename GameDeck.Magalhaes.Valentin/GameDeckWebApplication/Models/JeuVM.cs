using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace GameDeckWebApplication.Models
{
    /// <summary>
    /// Represente le viewmodel d'un jeu.
    /// </summary>
    public class JeuVM : BaseVM
    {
        /// <summary>
        /// Obtient ou definit l'identifiant du <see cref="JeuVM"/>.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Obtient ou definit le nom du <see cref="JeuVM"/>.
        /// </summary>
        [Required(ErrorMessage = "Le nom du jeu est obligatoire.")]
        public string Nom { get; set; }

        /// <summary>
        /// Obtient ou definit la descriptio du <see cref="JeuVM"/>.
        /// </summary>
        [Required(ErrorMessage = "La description du jeu est obligatoire.")]
        public string Description { get; set; }

        /// <summary>
        /// Obtient ou definit la date de sortie du <see cref="JeuVM"/>.
        /// </summary>
        [DisplayName("Date de sortie")]
        [Required(ErrorMessage = "La date de sorti du jeu est obligatoire.")]
        [Range(typeof(DateTime), "1/1/1970", "31/12/9999", ErrorMessage = "Le champ {0} doit être compris {1:MM/dd/yyyy} et {2:MM/dd/yyyy}")]
        public DateTime DateSortie { get; set; }

        /// <summary>
        /// Obtient ou definit l'identifiant du <see cref=GenreVM"/> du <see cref="JeuVM"/>.
        /// </summary>
        [DisplayName("Genre")]
        [Required(ErrorMessage = "Le genre du jeu est obligatoire.")]
        [Range(1, int.MaxValue)]
        public int GenreId { get; set; }

        /// <summary>
        /// Obtient ou definit l'identifiant de l'<see cref="EditeurVM"/> du <see cref="JeuVM"/>.
        /// </summary>
        [DisplayName("Editeur")]
        [Required(ErrorMessage = "L'éditeur du jeu est obligatoire.")]
        [Range(1, int.MaxValue)]
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