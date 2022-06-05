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
    /// Represente la classe de commande du <see cref="Jeu"/>.
    /// </summary>
    internal class JeuCommand : BaseCommand<Jeu>
    {
        public JeuCommand(Context context) : base(context) { }

        /// <summary>
        /// Met à jour un <see cref="Jeu"/> déjà présent en base à partir du contexte
        /// </summary>
        /// <param name="Jeu">jeu à modifier</param>
        public void Update(Jeu jeu)
        {
            Jeu updateJeu = GetEntityById(jeu.Id);
            if (updateJeu == null)
                return;

            updateJeu.Nom = jeu.Nom;
            updateJeu.Description = jeu.Description;
            updateJeu.DateSortie = jeu.DateSortie;
            updateJeu.GenreId = jeu.GenreId;
            updateJeu.EditeurId = jeu.EditeurId;

            _context.SaveChanges();
        }
    }
}
