using GameDeckBusiness;
using GameDeckDto;
using GameDeckWebApplication.Models;
using GameDeckWebApplication.Models.Converters;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace GameDeckWebApplication.Controllers
{
    public class JeuController : Controller
    {
        public ActionResult Index()
        {
            List<JeuDto> dtos = Manager.GetInstance().GetAllJeux();
            return View(JeuAdapter.ConvertToVM(dtos));
        }

        public ActionResult Edit(int? id)
        {
            JeuDto dto = new JeuDto();
            if (id.HasValue)
            {
                dto = Manager.GetInstance().GetOneJeu(id.Value);
            }

            // on remplit les view bag qui seront utilisés dans les dropdown
            IEnumerable<SelectListItem> lesEditeurs = Manager.GetInstance().GetAllEditeurs().Select(edi => new SelectListItem {
                Value = edi.Id.ToString(),
                Text = edi.Nom,
            });
            ViewData["Editeurs"] = new SelectList(lesEditeurs, "Value", "Text");

            IEnumerable <SelectListItem> lesGenres = Manager.GetInstance().GetAllGenres().Select(genre => new SelectListItem
            {
                Value = genre.Id.ToString(),
                Text = genre.Nom,
            });
            ViewData["Genres"] = new SelectList(lesGenres, "Value", "Text");

            JeuVM vm = JeuAdapter.ConvertToVM(dto);
            // récupérer l'url précédente et la stocker dans le viewmodel
            vm.PreviousUrl = System.Web.HttpContext.Current.Request.UrlReferrer?.LocalPath;

            return View(vm);
        }

        [HttpPost]
        public ActionResult Edit(JeuVM vm)
        {
            if (vm == null || !ModelState.IsValid)
            {
                return Json(new { success = false, errors = ModelState.Keys.SelectMany(key => ModelState[key].Errors).Select(msg => msg.ErrorMessage) });
            }

            if (vm.Id > 0) // modification
            {
                Manager.GetInstance().UpdateJeu(JeuAdapter.ConvertToDto(vm));
            }
            else // création
            {
                vm.Id = Manager.GetInstance().AddJeu(JeuAdapter.ConvertToDto(vm));
            }

            
            return Redirect(vm.PreviousUrl ?? "/");
        }

        public ActionResult Search(string searchText)
        {
            if (searchText == null)
            {
                searchText = Request.QueryString["search"];
            }
            List<JeuDto> dtos = Manager.GetInstance().FindJeuxByName(searchText);
            return View(JeuAdapter.ConvertToVM(dtos));
        }
    }
}