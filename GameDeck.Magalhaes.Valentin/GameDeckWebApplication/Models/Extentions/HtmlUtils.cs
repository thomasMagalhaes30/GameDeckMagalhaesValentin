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

        public static HtmlString CustomDropDownList(this HtmlHelper htmlHelper, string propertyName, string url, string data)
        {
            string htmlString = $"<select class='form-control' id='{propertyName}' name='{propertyName}'></select>";

            htmlString += "" +
                "<script>" +
                    "$(document).ready(function() {" +
                        " $.ajax({" +
                            "type: \"GET\"," +
                            "url: \"" + url + "\"," +
                            "data: \"{" + data + "}\"," +
                            "success: function(data) {" +
                                "var content = '<option value=\"-1\">Aucune selection</option>';" +
                                "for (var i = 0; i < data.length; i++){" +
                                    " content += `<option value = \"${data[i].Value}\">${ data[i].Name}</option>`;" +
                                "}" +
                                "$(\"#"+ propertyName +"\").html(content);" + 
                            "}" +
                        "});" +
                    " });" + 
                "</script>";

            return new HtmlString(htmlString);
        }

        /// <summary>
        /// Helpeur permettant d'afficher du code html pour un loadeur custom
        /// </summary>
        /// <param name="htmlHelper"></param>
        public static HtmlString CustomLoading(this HtmlHelper htmlHelper)
        {
            string htmlString = @"
            <?xml version='1.0' encoding='utf-8'?>
            <svg xmlns='http://www.w3.org/2000/svg' xmlns:xlink='http://www.w3.org/1999/xlink' style='margin: auto; background: rgb(255, 255, 255); display: block; shape-rendering: auto;'
                        width='200px' height='200px' viewBox='0 0 100 100' preserveAspectRatio='xMidYMid'>
            <g>
              <circle cx='60' cy='50' r='4' fill='#e15b64'>
                <animate attributeName='cx' repeatCount='indefinite' dur='1s' values='95;35' keyTimes='0;1' begin='-0.67s'></animate>
                <animate attributeName='fill-opacity' repeatCount='indefinite' dur='1s' values='0;1;1' keyTimes='0;0.2;1' begin='-0.67s'></animate>
              </circle>
              <circle cx='60' cy='50' r='4' fill='#e15b64'>
                <animate attributeName='cx' repeatCount='indefinite' dur='1s' values='95;35' keyTimes='0;1' begin='-0.33s'></animate>
                <animate attributeName='fill-opacity' repeatCount='indefinite' dur='1s' values='0;1;1' keyTimes='0;0.2;1' begin='-0.33s'></animate>
              </circle>
              <circle cx='60' cy='50' r='4' fill='#e15b64'>
                <animate attributeName='cx' repeatCount='indefinite' dur='1s' values='95;35' keyTimes='0;1' begin='0s'></animate>
                <animate attributeName='fill-opacity' repeatCount='indefinite' dur='1s' values='0;1;1' keyTimes='0;0.2;1' begin='0s'></animate>
              </circle>
            </g><g transform='translate(-15 0)'>
              <path d='M50 50L20 50A30 30 0 0 0 80 50Z' fill='#feee32' transform='rotate(90 50 50)'></path>
              <path d='M50 50L20 50A30 30 0 0 0 80 50Z' fill='#feee32'>
                <animateTransform attributeName='transform' type='rotate' repeatCount='indefinite' dur='1s' values='0 50 50;45 50 50;0 50 50' keyTimes='0;0.5;1'></animateTransform>
              </path>
              <path d='M50 50L20 50A30 30 0 0 1 80 50Z' fill='#feee32'>
                <animateTransform attributeName='transform' type='rotate' repeatCount='indefinite' dur='1s' values='0 50 50;-45 50 50;0 50 50' keyTimes='0;0.5;1'></animateTransform>
              </path>
            </g>
            </svg>
            <p class='fs-5 fw-bold text-info'>Chargement en cours</p>
                ";

            return new HtmlString(htmlString);
        }

    }
}