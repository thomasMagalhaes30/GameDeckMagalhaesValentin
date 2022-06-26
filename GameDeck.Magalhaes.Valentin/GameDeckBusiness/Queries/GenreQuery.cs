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
    /// Represente la classe de requête du <see cref="Genre"/>.
    /// </summary>
    internal class GenreQuery : BaseQuery<Genre>
    {
        public GenreQuery(Context context) : base(context) { }
    }
}
