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
    /// Represente la classe de requête de l'<see cref="Editeur"/>.
    /// </summary>
    internal class EditeurQuery : BaseQuery<Editeur>
    {
        public EditeurQuery(Context context) : base(context) { }

        public new Editeur Add(Editeur editeur) => base.Add(editeur);
    }
}
