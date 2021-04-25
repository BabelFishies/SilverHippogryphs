using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FishFood.Models;
using FishFood.Data;


namespace FishFood.Controllers
{
    public class AddOptionController : Controller
    {
        private ApplicationDbContext context;

        public AddOptionController(ApplicationDbContext dbContext)
        {
            context = dbContext;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Add()
        {
            AddOptionViewModel addOptionViewModel = new AddOptionViewModel();

            return View(addOptionViewModel);
        }
        public IActionResult ProcessAddOptionForm(AddOptionViewModel addOptionViewModel)
        {
            if (ModelState.IsValid)
            {

                Option newOption = new Option()
                {

                    Text = addOptionViewModel.Text,
                    GameTextId = addOptionViewModel.GameTextId,
                    LinkId = addOptionViewModel.LinkId

                    


                };

                context.Option.Add(newOption);
                context.SaveChanges();
                return Redirect("../addoption");


            }
            return View("../home/addoption", addOptionViewModel);
        }
    }
}
