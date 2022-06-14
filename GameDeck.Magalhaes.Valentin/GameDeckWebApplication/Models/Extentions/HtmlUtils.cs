using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GameDeckWebApplication.Models.Extentions
{
    /// <summary>
    /// Represente une classe d'extention de l'<see cref="HtmlHelper"/>.
    /// </summary>
    public static class HtmlUtils
    {
        /// <summary>
        /// Indique si un lien est actif ou non.
        /// </summary>
        /// <param name="actionName">le nom de l'action</param>
        /// <param name="controllerName">le nom du controlleur</param>
        /// <returns>"active" si il est actif, "" sinon </returns>
        public static string IsActive(this HtmlHelper html, string actionName, string controllerName)
        {
            var routeData = html.ViewContext.RouteData;

            var routeAction = (string)routeData.Values["action"];
            var routeControl = (string)routeData.Values["controller"];

            // must match both
            var returnActive = controllerName == routeControl &&
                               actionName == routeAction;

            return returnActive ? "active" : "";
        }
    }
}