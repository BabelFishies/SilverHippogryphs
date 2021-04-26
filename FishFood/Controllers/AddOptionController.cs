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
    public class AddOptionController : Controller
    {
        private ApplicationDbContext context;

        public AddOptionController(ApplicationDbContext dbContext)
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
                return Redirect("../adminpage");


            }
            return View("../home/addoption", addOptionViewModel);
        }
        public IActionResult Delete()
        {
           

            return Redirect("../adminpage");
        }
        [HttpPost]
        public IActionResult ProcessDelete(List<Option> options)
        {
            foreach (Option option in options)
            {
                context.Option.Remove(option);
                context.SaveChanges();
            }
            return Redirect("../adminpage");

            //find option by id, delete
        }
        public IActionResult Edit(AddOptionViewModel addOptionViewModel)
        {
            List<GameText> gameTextList = context.GameText.ToList();
            ViewBag.GameText = gameTextList;
            List<Option> optionList = context.Option.ToList();
            ViewBag.Option = optionList;

            return View(addOptionViewModel);
        }
        [HttpPost]
        public IActionResult SubmitEditOptionForm(Option option)
        {
                // controller code will go here
                if (ModelState.IsValid)
                {

                
                context.Entry(option).State = EntityState.Modified;
                context.SaveChanges();
                return Redirect("../adminpage");

                }
                return View("..homes/addoption", option);
            }
        }
    }

