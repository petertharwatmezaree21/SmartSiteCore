﻿using Microsoft.AspNetCore.Mvc;
using SmartSite.DAL_Functionality;
using SmartSite.Models;
using SmartSite.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;



namespace SmartSite.Controllers
{
    public class HomeController : Controller
    {
        CategoryDAL DAL;
        ApplicationDbContext Context;
        public HomeController(ApplicationDbContext _Context)
        {
            DAL = new CategoryDAL(_Context);
            Context = _Context;
        }

        public ActionResult navbarPartial()
        {
            ViewBag.layoutVM = new navbarVM(Context);
            return PartialView("_navLayout", ViewData["layoutVM"]);
        }

        public ActionResult footerPartial()
        {
            ViewBag.layoutVM = new navbarVM(Context);
            return PartialView("_footerLayout", ViewBag.layoutVM.GetLastNews());
        }

        public ActionResult Index()
        {
            IEnumerable<Category> allCategories = DAL.GetAllCategories();

            // random product :
            ViewBag.shownProducts = Get3Products();
            ViewBag.safetyCatID = Context.Category.FirstOrDefault(c => c.CategoryName == "Safety" || c.CategoryName=="safety").ID;

            navbarVM vm = new navbarVM(Context);
            ViewBag.displayedNews = vm.GetLastNews();

            return View(allCategories);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public List<Product> Get3Products()
        {
            if (Context.Product != null && Context.Product.Count() > 2)
            {
                return Context.Product.Take(3).ToList();
            }
            else
            {
                return Context.Product.ToList();
            }
        }
 
    }
}