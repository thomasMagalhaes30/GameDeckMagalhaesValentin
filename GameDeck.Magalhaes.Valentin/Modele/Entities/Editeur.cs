using System.Collections.Generic;

namespace Modele.Entities
{
    /// <summary>
    /// Represente un <see cref="Editeur"/> (APP_EDITEUR).
    /// </summary>
    public class Editeur : BaseEntity
    {
        /// <summary>
        /// Obtient ou definit le nom de l'<see cref="Editeur"/>.
        /// </summary>
        public string Nom { get; set; }

        /// <summary>
        /// Obtient ou definit la liste de <see cref="Jeu"/> de l'<see cref="Editeur"/>.
        /// </summary>
        public ICollection<Jeu> Jeux { get; set; } = new List<Jeu>();
    }
}
