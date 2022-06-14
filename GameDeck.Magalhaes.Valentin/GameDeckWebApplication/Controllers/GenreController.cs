using GameDeckBusiness;
using GameDeckDto;
using GameDeckWebApplication.Models;
using GameDeckWebApplication.Models.Converters;
using GameDeckWebApplication.Models.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GameDeckWebApplication.Controllers
{
    public class GenreController : Controller
    {
        public ActionResult Index()
        {
            List<GenreDto> dtos = Manager.GetInstance().GetAllGenres();
            return View(GenreAdapter.ConvertToVM(dtos));
        }

        /// <summary>
        /// Obtient tous les editeurs au format json.
        /// </summary>
        public ActionResult GetJsonGenres()
        {
            List<GenreDto> dtos = Manager.GetInstance().GetAllGenres();

            return Json(GenreAdapter.ConvertToVM(dtos).Select(vm => new DropDownItem
            {
                Value = vm.Id,
                Name = vm.Nom,
            }).ToList(), JsonRequestBehavior.AllowGet);
        }
    }
}