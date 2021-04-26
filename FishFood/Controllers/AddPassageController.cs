using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FishFood.Models;
using FishFood.Data;
using Microsoft.EntityFrameworkCore;

namespace FishFood.Controllers
{
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
                return Redirect("../adminpage");


            }
            return View("../home/addpassage", addPassageViewModel);
        }
        public IActionResult Delete()
        {


            return View();
        }
        [HttpPost]
        public IActionResult Delete(List<GameText> passages)
        {
            foreach (GameText passage in passages)
            {
                context.GameText.Remove(passage);
                context.SaveChanges();
            }
            return Redirect("../adminpage");

            //find option by id, delete
        }
        public IActionResult Edit(AddPassageViewModel addPassageViewModel)
        {

            return View(addPassageViewModel);
        }
        [HttpPost]
        public IActionResult SubmitEditOptionForm(AddPassageViewModel addPassageViewModel)
        {
            // controller code will go here
            if (ModelState.IsValid)
            {


                context.Entry(addPassageViewModel).State = EntityState.Modified;
                context.SaveChanges();
                return Redirect("../adminpage");

            }
            return View("..homes/addoption", addPassageViewModel);
        }

    }
}
