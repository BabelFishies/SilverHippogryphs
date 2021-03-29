using Microsoft.AspNetCore.Mvc;
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

        public IActionResult LoadIntialView()
        {
            //take us to the saved most recent passage, or in mvp for monday, render one passage from the db
            return View();
        }

        public IActionResult LoadNextView()
        {
            //when link is clicked, find next view and save current page to database
            return View();
        }

    }
}
/* TODO: Render a view that contains: 
 *      a box with the game in it
 *      nav buttons at top? of page
 *      
 */
