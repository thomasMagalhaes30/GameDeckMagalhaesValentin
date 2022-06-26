using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GameDeckWebApplication.Models
{
    /// <summary>
    /// Represente le viewmodel d'un genre.
    /// </summary>
    public class GenreVM
    {
        /// <summary>
        /// Obtient ou definit l'identifiant du <see cref="GenreVM"/>.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Obtient ou definit le nom du <see cref="GenreVM"/>.
        /// </summary>
        [Required(ErrorMessage = "Le nom du genre est obligatoire.")]
        public string Nom { get; set; }

        /// <summary>
        /// Obtient ou definit la liste de <see cref="JeuVM"/> du <see cref="GenreVM"/>.
        /// </summary>
        public ICollection<JeuVM> Jeux { get; set; } = new List<JeuVM>();
    }
}