﻿using SmartSite.DAL_Functionality;
using SmartSite.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

using System.Net;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;

namespace SmartSite.Controllers
{
    public class NewsController : Controller
    {
        NewsDAL DAL;
        IWebHostEnvironment env;
        IHttpContextAccessor _httpContextAccessor;
        public NewsController(ApplicationDbContext Context, IWebHostEnvironment _env, IHttpContextAccessor httpContextAccessor)
        {
            DAL = new NewsDAL(Context);
            env = _env;
            _httpContextAccessor = httpContextAccessor;
        }
        public ActionResult GetAllNews()
        {
            IEnumerable<News> allNews = DAL.GetAllNews().ToList();
            return View(allNews);
        }

        public ActionResult NewsDetails(int? id) // id = news ID
        {
            if (id == null)
            {
                return BadRequest();
            }

            News news = DAL.GetNewsByID(id);
            if(news != null)
                return View(news);
            else
                return View("~/Views/Shared/Error.cshtml");
        }

        [Authorize(Roles = "Admin")]
        public ActionResult CreateNews()
        {
            return View();
        }

        [Authorize(Roles = "Admin")]
        [HttpPost]
        public ActionResult CreateNews(News createdNews, IFormFile UploadImg)
        {
            if (ModelState.IsValid)
            {
                if (UploadImg != null && UploadImg.Length > 0)
                {
                    string ImgPath = Path.Combine(env.WebRootPath+"\\imageUploads\\NewsImg", UploadImg.FileName);
                    UploadImg.CopyTo(new FileStream(ImgPath,FileMode.Create));
                    createdNews.Image = UploadImg.FileName;

                    bool successfullyCreatingNews = DAL.CreateNews(createdNews);
                    if (successfullyCreatingNews)
                        return RedirectToAction("GetAllNews");
                    else
                        return View(createdNews);
                }
                else
                {
                    ViewBag.Message = "You have not specified a file yet ...";
                }
            }
            return View(createdNews);
        }

        [Authorize(Roles = "Admin")]
        public ActionResult EditNews(int? id) // id = news ID
        {
            if (id == null)
            {
                return BadRequest();
            }

            if (DAL.GetNewsByID(id) == null)
            {
                return NotFound();
            }


            News modifiedNews = DAL.GetNewsByID(id);

            HttpContext.Session.SetString("oldImagePath", (env.WebRootPath + (Path.Combine("\\imageUploads\\NewsImg", modifiedNews.Image))).ToString());
            HttpContext.Session.SetString("Image", modifiedNews.Image);

            if (modifiedNews != null)
                return View(modifiedNews);
            else
                return View("~/Views/Shared/Error.cshtml");
        }

        [Authorize(Roles = "Admin")]
        [HttpPost]
        public ActionResult EditNews(News EditedNews, IFormFile UploadImg , string deletingImgPath)
        {
            if (ModelState.IsValid)
            {
                if (UploadImg != null && UploadImg.Length > 0)
                {
                    // deleting old image from its path :
                    if (System.IO.File.Exists(deletingImgPath))
                    {
                        System.IO.File.Delete(deletingImgPath);
                    }

                    string ImgPath = Path.Combine(env.WebRootPath+"\\imageUploads\\NewsImg", UploadImg.FileName);
                    UploadImg.CopyTo (new FileStream(ImgPath,FileMode.Create));

                    
                    EditedNews.Image = UploadImg.FileName;

                    bool successfullyEditingNews = DAL.EditExistedNews(EditedNews.ID, EditedNews);
                    if (successfullyEditingNews)
                        return RedirectToAction("GetAllNews");
                    else
                        return View(EditedNews);
                }
                else
                    ViewBag.Message = "You have not specified a file yet ...";

            }
            return View(EditedNews);
        }

        [Authorize(Roles = "Admin")]
        public ActionResult DeleteNews(int? id) // id = news ID
        {
            if (id == null)
            {
                return BadRequest();
            }

            News deletedNews = DAL.GetNewsByID(id);

         HttpContext.Session.SetString("oldImagePath",(env.WebRootPath+ (Path.Combine("/imageUploads/NewsImg", deletedNews.Image))).ToString());

            if (deletedNews != null)
                return View(deletedNews);
            else
                return View("~/Views/Shared/Error.cshtml");
        }

        [Authorize(Roles = "Admin")]
        [HttpPost]
        public ActionResult DeleteNews(News deletedNews, string deletingImgPath)
        {
            // deleting old image from its path :
            if (System.IO.File.Exists(deletingImgPath))
            {
                System.IO.File.Delete(deletingImgPath);
            }


            bool successfullyDeletingNew = DAL.DeleteNews(deletedNews.ID);
            if (successfullyDeletingNew)
                return RedirectToAction("GetAllNews");
            else
                return View(deletedNews);
        }
    }
}