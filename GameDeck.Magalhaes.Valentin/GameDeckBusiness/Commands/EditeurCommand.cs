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
    /// Represente la classe de commande du <see cref="Editeur"/>.
    /// </summary>
    internal class EditeurCommand : BaseCommand<Editeur>
    {
        public EditeurCommand(Context context) : base(context) { }

        /// <summary>
        /// Met à jour un <see cref="Editeur"/> déjà présent en base à partir du contexte
        /// </summary>
        /// <param name="editeur">Editeur à modifier</param>
        public void Update(Editeur editeur)
        {
            Editeur updateEditeur = GetEntityById(editeur.Id);
            if (updateEditeur == null)
                return;

            updateEditeur.Nom = editeur.Nom;
            _context.SaveChanges();
        }
    }
}
