using GameDeckBusiness;
using GameDeckDto;
using GameDeckWebApplication.Models;
using GameDeckWebApplication.Models.Converters;
using GameDeckWebApplication.Models.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace GameDeckWebApplication.Controllers
{
    public class EvaluationController : Controller
    {
        public async Task<ActionResult> LastEvaluations(int nbEval = 5)
        {
            List<EvaluationDto> dtos = await Manager.GetInstance().LastEvaluationAsync(nbEval);
            return PartialView("_List", EvaluationAdapter.ConvertToVM(dtos));
        }
    }
}