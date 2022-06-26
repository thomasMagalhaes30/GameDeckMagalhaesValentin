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
    /// Represente la classe de requête du <see cref="Jeu"/>.
    /// </summary>
    internal class JeuQuery : BaseQuery<Jeu>
    {
        public JeuQuery(Context context) : base(context) { }
    }
}
