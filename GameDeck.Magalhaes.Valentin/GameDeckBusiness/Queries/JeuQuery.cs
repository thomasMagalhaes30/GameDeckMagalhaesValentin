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
    /// 
    /// </summary>
    internal class JeuQuery : BaseQuery<Jeu>
    {
        public JeuQuery(Context context) : base(context) { }

        public List<Jeu> GetAllFull()
        {
            return GetDbSet().Include(j => j.Evaluations).Include(j => j.Experiences).ToList();
        }

        public new Jeu Add(Jeu jeu) => base.Add(jeu);
    }
}
