using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GameDeckWebApplication.Models
{
    /// <summary>
    /// Represente le viewmodel de base.
    /// </summary>
    public class BaseVM
    {
        /// <summary>
        /// Obtient ou definit l'url precedent.
        /// </summary>
        public String PreviousUrl { get; set; }
    }
}