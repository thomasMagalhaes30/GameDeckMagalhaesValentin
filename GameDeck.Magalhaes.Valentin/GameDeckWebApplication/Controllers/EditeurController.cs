using GameDeckBusiness;
using GameDeckDto;
using GameDeckWebApplication.Models;
using GameDeckWebApplication.Models.Converters;
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

            return View(EditeurAdapter.ConvertToVM(dto));
        }

        [HttpPost]
        public ActionResult Edit(EditeurVM vm)
        {
            if (vm == null || !ModelState.IsValid)
            {
                return Json(new { success = false, errors = ModelState.Keys.SelectMany(key => ModelState[key].Errors).Select(msg => msg.ErrorMessage) });
            }

            vm.Id = Manager.GetInstance().AddEditeur(EditeurAdapter.ConvertToDto(vm));

            return View(vm);
        }
    }
}