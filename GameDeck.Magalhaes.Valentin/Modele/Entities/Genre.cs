using System.Collections.Generic;

namespace Modele.Entities
{
    /// <summary>
    /// Represente un <see cref="Genre"/> (APP_GENRE).
    /// </summary>
    public class Genre : BaseEntity
    {
        /// <summary>
        /// Obtient ou definit le nom du <see cref="Genre"/>.
        /// </summary>
        public string Nom { get; set; }

        /// <summary>
        /// Obtient ou definit la liste de <see cref="Jeu"/> du <see cref="Genre"/>.
        /// </summary>
        public ICollection<Jeu> Jeux { get; set; } = new List<Jeu>();
    }
}
