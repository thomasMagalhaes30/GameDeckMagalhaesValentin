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
    /// Represente la classe de requête de l'<see cref="Experience"/>.
    /// </summary>
    internal class ExperienceQuery : BaseQuery<Experience>
    {
        public ExperienceQuery(Context context) : base(context) { }
    }
}
