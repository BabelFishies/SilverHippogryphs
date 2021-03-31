using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FishFood.Models;
using FishFood.Data;

namespace FishFood.Controllers
{


    public class GameController : Controller
    {
        private ApplicationDbContext context;

        public GameController(ApplicationDbContext dbContext)
        {
            context = dbContext;
        }

        public IActionResult Index()
        {
            //List<Employer> employers = context.Employers.ToList();
            List<GameText> currentPassage = context.GameText.ToList();

            //look for id query string
            return View(currentPassage);
        }

      


    }
}
/* TODO: Render a view that contains: 
 *      a box with the game in it
 *      nav buttons at top? of page
 *      
 */
