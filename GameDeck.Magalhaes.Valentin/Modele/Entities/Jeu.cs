using System;
using System.Collections.Generic;

namespace Modele.Entities
{
    /// <summary>
    /// Represente un <see cref="Jeu"/> (APP_JEU).
    /// </summary>
    public class Jeu : BaseEntity
    {
        /// <summary>
        /// Obtient ou definit le nom du <see cref="Jeu"/>.
        /// </summary>
        public string Nom { get; set; }

        /// <summary>
        /// Obtient ou definit la descriptio du <see cref="Jeu"/>.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Obtient ou definit la date de sortie du <see cref="Jeu"/>.
        /// </summary>
        public DateTime DateSortie { get; set; }

        /// <summary>
        /// Obtient ou definit l'identifiant du <see cref=Genre"/> du <see cref="Jeu"/>.
        /// </summary>
        public int GenreId { get; set; }

        /// <summary>
        /// Obtient ou definit l'identifiant de l'<see cref="Editeur"/> du <see cref="Jeu"/>.
        /// </summary>
        public int EditeurId { get; set; }

        /// <summary>
        /// Obtient ou definit l'<see cref="Editeur"/> du <see cref="Jeu"/>.
        /// </summary>
        public Editeur EditeurObj { get; set; }

        /// <summary>
        /// Obtient ou definit le <see cref=Genre"/> du <see cref="Jeu"/>.
        /// </summary>
        public Genre GenreObj { get; set; }

        /// <summary>
        /// Obtient ou definit la liste de <see cref="Evaluation"/> du <see cref="Jeu"/>.
        /// </summary>
        public ICollection<Evaluation> Evaluations { get; set; } = new List<Evaluation>();

        /// <summary>
        /// Obtient ou definit la liste de <see cref="Experience"/> du <see cref="Jeu"/>.
        /// </summary>
        public ICollection<Experience> Experiences { get; set; } = new List<Experience>();
    }
}
