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

        /// <summary>
        /// Met à jour un <see cref="Evaluation"/> déjà présent en base à partir du contexte
        /// </summary>
        /// <param name="evaluation">Evaluation à modifier</param>
        public void Update(Evaluation evaluation)
        {
            Evaluation updateEvaluation = GetEntityById(evaluation.Id);
            if (updateEvaluation == null)
                return;

            updateEvaluation.NomEvaluateur = evaluation.NomEvaluateur;
            updateEvaluation.Date = evaluation.Date;
            updateEvaluation.Note = evaluation.Note;
            updateEvaluation.JeuId = evaluation.JeuId;
            _context.SaveChanges();
        }
    }
}
