using Modele;
using Modele.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDeckBusiness.Queries
{
    /// <summary>
    /// Represente la classe de requête de l'<see cref="Evaluation"/>.
    /// </summary>
    internal class EvaluationQuery : BaseQuery<Evaluation>
    {
        public EvaluationQuery(Context context) : base(context) { }
    }
}
