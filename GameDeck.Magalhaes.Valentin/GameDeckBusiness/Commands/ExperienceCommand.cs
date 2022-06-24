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
    /// Represente la classe de commande du <see cref="Experience"/>.
    /// </summary>
    internal class ExperienceCommand : BaseCommand<Experience>
    {
        public ExperienceCommand(Context context) : base(context) { }

        public override void changeEntiteBddWithEntite(Experience entiteBdd, Experience newEntite)
        {
            entiteBdd.Joueur = newEntite.Joueur;
            entiteBdd.TempsJeu = newEntite.TempsJeu;
            entiteBdd.Pourcentage = newEntite.Pourcentage;
            entiteBdd.JeuId = newEntite.JeuId;
        }
    }
}
