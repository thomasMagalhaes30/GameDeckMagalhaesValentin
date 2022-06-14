using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GameDeckWebApplication.Models
{
    /// <summary>
    /// Represente le viewmodel d'un edituer.
    /// </summary>
    public class EditeurVM
    {
        /// <summary>
        /// Obtient ou definit l'identifiant de l'<see cref="EditeurVM"/>.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Obtient ou definit le nom de l'<see cref="EditeurVM"/>.
        /// </summary>
        [Required(ErrorMessage = "Le nom de l'editeur est obligatoire.")]
        public string Nom { get; set; }

        /// <summary>
        /// Obtient ou definit la liste de <see cref="JeuVM"/> de l'<see cref="EditeurVM"/>.
        /// </summary>
        public ICollection<JeuVM> Jeux { get; set; } = new List<JeuVM>();

        /// <summary>
        /// Obtient ou definit l'url precedent.
        /// </summary>
        public String PreviousUrl { get; set; }
    }
}