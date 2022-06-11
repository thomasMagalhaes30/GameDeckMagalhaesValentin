﻿using GameDeckBusiness;
using GameDeckDto;
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
    }
}