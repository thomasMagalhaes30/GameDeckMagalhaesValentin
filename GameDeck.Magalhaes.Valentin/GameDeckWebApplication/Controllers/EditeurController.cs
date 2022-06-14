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
    public class EditeurController : Controller
    {
        public ActionResult Index()
        {
            List<EditeurDto> dtos = Manager.GetInstance().GetAllEditeurs();
            return View(EditeurAdapter.ConvertToVM(dtos));
        }

        public ActionResult Edit(int? id)
        {
            EditeurDto dto = new EditeurDto();
            if (id.HasValue)
            {
                dto = Manager.GetInstance().GetOneEditeur(id.Value);
            }

            EditeurVM vm = EditeurAdapter.ConvertToVM(dto);
            // récupérer l'url précédente et la stocker dans le viewmodel
            vm.PreviousUrl = System.Web.HttpContext.Current.Request.UrlReferrer?.LocalPath;

            return View(vm);
        }

        [HttpPost]
        public ActionResult Edit(EditeurVM vm)
        {
            if (vm == null || !ModelState.IsValid)
            {
                return Json(new { success = false, errors = ModelState.Keys.SelectMany(key => ModelState[key].Errors).Select(msg => msg.ErrorMessage) });
            }

            if (vm.Id > 0) // modification
            {
                Manager.GetInstance().UpdateEditeur(EditeurAdapter.ConvertToDto(vm));
            }
            else // création
            {
                vm.Id = Manager.GetInstance().AddEditeur(EditeurAdapter.ConvertToDto(vm));
            }
           

            return Redirect(vm.PreviousUrl);
        }

        /// <summary>
        /// Obtient tous les editeurs au format json.
        /// </summary>
        public ActionResult GetJsonEditeurs()
        {
            List<EditeurDto> dtos = Manager.GetInstance().GetAllEditeurs();

            return Json(EditeurAdapter.ConvertToVM(dtos).Select(vm => new DropDownItem
            {
                Value = vm.Id,
                Name = vm.Nom,
            }).ToList(), JsonRequestBehavior.AllowGet);

        }
    }
}