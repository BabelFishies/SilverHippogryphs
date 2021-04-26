using FishFood.Data;
using FishFood.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FishFood.Controllers
{
    public class AdminPageController : Controller
    {

        private ApplicationDbContext context;

        public AdminPageController(ApplicationDbContext dbContext)
        {
            context = dbContext;
        }
  
        public IActionResult Index()
        {
                List<GameText> gameTextList = context.GameText.ToList();
            ViewBag.GameText = gameTextList;
            List<Option> optionList = context.Option.ToList();
            ViewBag.Option = optionList;
            return View();
        }
    }
}
