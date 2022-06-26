using System.Collections.Generic;

namespace GameDeckDto
{
    /// <summary>
    /// Represente le dto de l'entite <see cref="Editeur"/>.
    /// </summary>
    public class EditeurDto
    {
        /// <summary>
        /// Obtient ou definit l'identifiant de l'<see cref="EditeurDto"/>.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Obtient ou definit le nom de l'<see cref="EditeurDto"/>.
        /// </summary>
        public string Nom { get; set; }

        /// <summary>
        /// Obtient ou definit la liste de <see cref="JeuDto"/> de l'<see cref="EditeurDto"/>.
        /// </summary>
        public ICollection<JeuDto> Jeux { get; set; }
    }
}
