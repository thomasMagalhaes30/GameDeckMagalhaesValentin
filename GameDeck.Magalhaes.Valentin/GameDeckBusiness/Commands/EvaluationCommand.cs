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
    /// Represente la classe de commande du <see cref="Evaluation"/>.
    /// </summary>
    internal class EvaluationCommand : BaseCommand<Evaluation>
    {
        public EvaluationCommand(Context context) : base(context) { }

        public override void changeEntiteBddWithEntite(Evaluation entiteBdd, Evaluation newEntite)
        {
            entiteBdd.NomEvaluateur = newEntite.NomEvaluateur;
            entiteBdd.Date = newEntite.Date;
            entiteBdd.Note = newEntite.Note;
            entiteBdd.JeuId = newEntite.JeuId;
        }
    }
}
