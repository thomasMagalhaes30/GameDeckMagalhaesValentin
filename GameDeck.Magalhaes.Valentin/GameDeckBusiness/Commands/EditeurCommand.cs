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

        public override void changeEntiteBddWithEntite(Editeur entiteBdd, Editeur newEntite)
        {
            entiteBdd.Nom = newEntite.Nom;
        }
    }
}
