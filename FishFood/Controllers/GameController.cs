﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FishFood.Controllers
{
    public class GameController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult RenderGameBox()
        {
            string result = requestStream.ReadToEnd(); 
            
            return Content(result);
        }

    }
}
/* TODO: Render a view that contains: 
 *      a box with the game in it
 *      nav buttons at top? of page
 *      
 * 
 */