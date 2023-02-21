﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ims.Controllers
{
    [Authorize(Roles = Pages.MainMenu.ProductType.RoleName)]
    public class ProductTypeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}