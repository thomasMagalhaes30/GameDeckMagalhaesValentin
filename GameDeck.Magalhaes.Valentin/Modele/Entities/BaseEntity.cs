using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modele.Entities
{
    /// <summary>
    /// Represente la classe de base d'une entite.
    /// </summary>
    public abstract class BaseEntity
    {
        /// <summary>
        /// Obtient ou definit l'identifiant de l'entite.
        /// </summary>
        public int Id { get; set; }
    }
}
