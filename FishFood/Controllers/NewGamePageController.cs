using FishFood.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FishFood.Controllers
{
    public class NewGamePageController : Controller
    {
        public IActionResult NewGame()
        {
            return View();
        }
    }

}


//[HttpGet]
//[Route("/NewGame")]
//public IActionResult NewGame()
//{
//    return View();
//} 
//public class RedirectController : Controller
//{

//    [Authorize]
//    [HttpGet]
//    [Route("/Game")]
//    public IActionResult StartGame()
//    {
//        return RedirectToAction("Index", "Game");
//    }
//}

/* 
      if (User.Identity.IsAuthenticated)
        {
         return RedirectToAction("Index", "Game");
        }
      else
        {
         return View();
          
        }


 public IActionResult NewGame()
        {
            if (User.Identity.IsAuthenticated)
            {
                return RedirectToAction("Index", "Game");
            }
            else
            {
                return View("/NewGame");
            }
        }
    }
 */