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

        public override void changeEntiteBddWithEntite(Jeu entiteBdd, Jeu newEntite)
        {
            entiteBdd.Nom = newEntite.Nom;
            entiteBdd.Description = newEntite.Description;
            entiteBdd.DateSortie = newEntite.DateSortie;
            entiteBdd.GenreId = newEntite.GenreId;
            entiteBdd.EditeurId = newEntite.EditeurId;
        }
    }
}
