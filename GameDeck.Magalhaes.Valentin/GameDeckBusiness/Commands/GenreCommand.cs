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
    /// Represente la classe de commande du <see cref="Genre"/>.
    /// </summary>
    internal class GenreCommand : BaseCommand<Genre>
    {
        public GenreCommand(Context context) : base(context) { }

        public override void changeEntiteBddWithEntite(Genre entiteBdd, Genre newEntite)
        {
            entiteBdd.Nom = newEntite.Nom;
        }

    }
}
