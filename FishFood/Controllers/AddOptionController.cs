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
            List<GameText> gameTextList = context.GameText.ToList();
            ViewBag.GameText = gameTextList;
            List<Option> optionList = context.Option.ToList();
            ViewBag.Option = optionList;


            return Redirect("../adminpage");
        }
        [HttpPost]
        public IActionResult ProcessDelete(int option)
        {
            var data = context.Option.FirstOrDefault(x => x.Id == option);
            if (ModelState.IsValid)
            {
                context.Option.Remove(data);
                context.SaveChanges();
                return RedirectToAction("../adminpage");
            }
            else
                return View("../adminpage");
        }
    
        public IActionResult Edit(int optionId)
        {
            List<GameText> gameTextList = context.GameText.ToList();
            ViewBag.GameText = gameTextList;
            List<Option> optionList = context.Option.ToList();
            ViewBag.Option = optionList;


            var data = context.Option.Where(x => x.Id == optionId).SingleOrDefault();
            return View(data);

           
        }
        [HttpPost]
        public IActionResult SubmitEditOptionForm(int optionId, AddOptionViewModel option)
        {
            List<GameText> gameTextList = context.GameText.ToList();
            ViewBag.GameText = gameTextList;
            List<Option> optionList = context.Option.ToList();
            ViewBag.Option = optionList;


            var data = optionList[optionId];
                // controller code will go here
                if (ModelState.IsValid)
                {
                data.Text = option.Text;
                data.GameTextId = option.GameTextId;
                data.LinkId = option.LinkId;
                
                //context.Entry(option).State = EntityState.Modified;
                    context.SaveChanges();
                   return Redirect("../adminpage");

                }else 
                     return View("..homes/addoption", option);
            }
        }
    }

