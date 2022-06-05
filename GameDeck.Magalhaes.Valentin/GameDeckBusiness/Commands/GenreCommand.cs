using Modele;
using Modele.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDeckBusiness.Commands
{
    /// <summary>
    /// Represente la classe de commande du <see cref="Genre"/>.
    /// </summary>
    internal class GenreCommand : BaseCommand<Genre>
    {
        public GenreCommand(Context context) : base(context) { }

        /// <summary>
        /// Met à jour un <see cref="Genre"/> déjà présent en base à partir du contexte
        /// </summary>
        /// <param name="genre">Genre à modifier</param>
        public void Update(Genre genre)
        {
            Genre updateGenre = GetEntityById(genre.Id);
            if (updateGenre == null)
                return;

            updateGenre.Nom = genre.Nom;
            _context.SaveChanges();
        }
    }
}
