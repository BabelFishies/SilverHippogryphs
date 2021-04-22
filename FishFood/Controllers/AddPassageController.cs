using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FishFood.Models;
using FishFood.Data;
using Microsoft.AspNetCore.Authorization;

namespace FishFood.Controllers
{
    [Authorize(Roles = "Admin")]
    public class AddPassageController : Controller
    {
        private ApplicationDbContext context;

        public AddPassageController(ApplicationDbContext dbContext)
        {
            context = dbContext;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Add()
        {


            AddPassageViewModel addPassageViewModel = new AddPassageViewModel();

            return View(addPassageViewModel);
        }


        public IActionResult ProcessAddPassageForm(AddPassageViewModel addPassageViewModel)
        {
            if (ModelState.IsValid)
            {

                GameText newPassage = new GameText()
                {

                    StoryPassage = addPassageViewModel.StoryPassage,
                    Title = addPassageViewModel.Title,
                    IsAWinner = addPassageViewModel.IsAWinner,
                    IsALoser = addPassageViewModel.IsALoser


                };

                context.GameText.Add(newPassage);
                context.SaveChanges();
                return Redirect("../add");


            }
            return View("../home/addpassage", addPassageViewModel);
        }

    }
}
