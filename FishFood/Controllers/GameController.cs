using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FishFood.Data;
using FishFood.Models;

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
            return View();
        }

        public IActionResult RenderGameBox()
        {
            return View();
        }

        public IActionResult InventoryAdd()
        {
            List<InventoryItem> items = context.InventoryItem.ToList();
            if ( /*button is clicked*/ )
            { 
                /*itemid.hasitem = true*/
            }
            return View();
        }
        
        public IActionResult InventoryDrop()
        {
            if (/*drop button is clicked*/)
            {
                /*itemid.hasitem = false*/
            }
            return View();
        }
    }
}
//TODO: Talk to database, get booleans to activate image after a certain link is clicked.
//TODO: Modify ApplicationDbContext to update database
