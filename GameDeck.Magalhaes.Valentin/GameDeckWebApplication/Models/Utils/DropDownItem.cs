using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GameDeckWebApplication.Models.Utils
{
    /// <summary>
    /// Répresente la classe des drop down item.
    /// </summary>
    public class DropDownItem
    {
        /// <summary>
        /// Obtient on défini la valeur de l'item de la drop down.
        /// </summary>
        public int Value { get; set; }

        /// <summary>
        /// Obtient on défini le nom de l'item de la drop down.
        /// </summary>
        public String Name { get; set; }
    }
}