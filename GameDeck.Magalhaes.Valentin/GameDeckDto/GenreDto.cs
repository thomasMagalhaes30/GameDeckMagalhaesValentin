using System.Collections.Generic;

namespace GameDeckDto
{
    /// <summary>
    /// Represente le dto de l'entite <see cref="Genre"/>.
    /// </summary>
    public class GenreDto
    {
        /// <summary>
        /// Obtient ou definit l'identifiant du <see cref="GenreDto"/>.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Obtient ou definit le nom du <see cref="GenreDto"/>.
        /// </summary>
        public string Nom { get; set; }

        /// <summary>
        /// Obtient ou definit la liste de <see cref="JeuDto"/> du <see cref="GenreDto"/>.
        /// </summary>
        public ICollection<JeuDto> Jeux { get; set; } = new List<JeuDto>();
    }
}
