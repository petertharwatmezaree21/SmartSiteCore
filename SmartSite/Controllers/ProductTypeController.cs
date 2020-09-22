using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SmartSite.DAL_Functionality;
using SmartSite.Models;
using SmartSite.ViewModels;
using System;
using System.Collections.Generic;

using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;

namespace SmartSite.Controllers
{
    public class ProductTypeController : Controller
    {
        ProductTypeDAL DAL;
        ApplicationDbContext context;
        IWebHostEnvironment env;
        public ProductTypeController(ApplicationDbContext _context,IWebHostEnvironment _env)
        {
            DAL = new ProductTypeDAL(_context);
            context = _context;
            env = _env;
        }


        //------------------- type details -------------------
        public ActionResult ProductTypeDetails(int? id) // id = type id
        {
            if (id == null)
            {
                return BadRequest();
            }

            ViewData["product"] = DAL.filterProductsByType(id);

            ProductType productType = DAL.GetProductTypeByID(id);
            if (productType != null)
                return View(productType);
            else
                return View("~/Views/Shared/Error.cshtml");
        }

        // ------------------ filter products by type -------
        public ActionResult FilterProductsByType(int? id) // id = type ID
        {
            if (id == null)
            {
                return BadRequest();
            }
            ViewData["ProductType"] = context.ProductType.Find(id).Type;
            IEnumerable<Product> filtereProducts = DAL.filterProductsByType(id);
            return View(filtereProducts);
        }

        // ------------------  all products ---------------
        //[Authorize(Roles = "User")]
        public ActionResult AllProductTypes()
        {
            ViewData["Category"] = new SelectList(context.Category, "ID", "CategoryName");
            List<ProductType> allProductTypes = DAL.GetAllProductTypes().ToList();
            return View(allProductTypes);
        }

        // ------------------ filter product type by category -----------
        public ActionResult FilterProductTypeByCategory(int? id) // id = category ID
        {
            if (id == null)
            {
                return BadRequest();
            }

            ViewBag.category = context.Category.Find(id);
            IEnumerable<ProductType> filteredTypes = DAL.FilterProductTypeByCategory(id);
            return View(filteredTypes);
        }

        [Authorize(Roles = "Admin")]
        // ---------------- create type ------------------
        public ActionResult CreateProductType()
        {
            ViewBag.CategoryID = new SelectList(context.Category, "ID", "CategoryName");
            return View();
        }


        [Authorize(Roles = "Admin")]
        [HttpPost]
        public ActionResult CreateProductType(ProductType createdProductType, IFormFile file)
        {
            if (ModelState.IsValid)
            {
                if (file != null && file.Length > 0)
                {
                    string path = Path.Combine(env.WebRootPath +"\\imageUploads\\TypeImg", file.FileName);
                    file.CopyTo (new FileStream(path,FileMode.Create));
                    createdProductType.Image = file.FileName;

                    bool successfullyCreatedProductType = DAL.CreateProductType(createdProductType);
                    if (successfullyCreatedProductType)
                        return RedirectToAction("FilterProductTypeByCategory", new { id = createdProductType.CategoryID });
                    else
                        return View(createdProductType);
                }
                else
                {
                    ViewBag.Message = "You have not specified a file yet ...";
                }
                
            }

            ViewBag.CategoryID = new SelectList(context.Category, "ID", "CategoryName");
            return View(createdProductType);
        }

        [Authorize(Roles = "Admin")]
        // --------------------- edit type ----------------------
        public ActionResult EditProductType(int? id)
        {
            if (id == null)
            {
                return BadRequest();
            }

            ViewData["Category"] = new SelectList(context.Category, "ID", "CategoryName");

            ProductType updatedProductType = DAL.GetProductTypeByID(id);

            HttpContext.Session.SetString("oldImagePath", (env.WebRootPath + (Path.Combine("~/imageUploads/TypeImg", updatedProductType.Image))).ToString());

            if (updatedProductType != null)
                return View(updatedProductType);
            else
                return View("~/Views/Shared/Error.cshtml");
        }

        [Authorize(Roles = "Admin")]
        [HttpPost]
        public ActionResult EditProductType(ProductType modifiedProductType, string deletingImgPath, IFormFile file)
        {
            if (ModelState.IsValid)
            {
                if (file != null && file.Length > 0)
                {
                    // deleting old image from its path :
                    if (System.IO.File.Exists(deletingImgPath))
                    {
                        System.IO.File.Delete(deletingImgPath);
                    }

                    string path = Path.Combine(env.WebRootPath +"\\imageUploads\\TypeImg", file.FileName);
                    file.CopyTo (new FileStream(path,FileMode.Create));
                    modifiedProductType.Image = file.FileName;

                    context.Entry(modifiedProductType).State = EntityState.Modified;
                    context.SaveChanges();
                    return RedirectToAction("FilterProductTypeByCategory", new { id = modifiedProductType.CategoryID });

                    //bool successfullyModofiedProductType = DAL.EditProductType(modifiedProductType.ID, modifiedProductType);
                    //if (successfullyModofiedProductType)
                    //    return RedirectToAction("FilterProductTypeByCategory", new { id = modifiedProductType.CategoryID });
                    //else
                    //    return View(modifiedProductType);
                }
                else
                {
                    ViewBag.Message = "You have not specified a file yet ...";
                }

            }

            ViewData["Category"] = new SelectList(context.Category, "ID", "CategoryName");
            return View(modifiedProductType);
        }

        [Authorize(Roles = "Admin")]
        // ---------------------- delete Type -------------------
        public ActionResult DeleteProductType(int? id)
        {
            if (id == null)
            {
                return BadRequest();
            }

            ProductType deletedProductType = DAL.GetProductTypeByID(id);

            HttpContext.Session.SetString("oldImagePath", (env.WebRootPath + (Path.Combine("~/imageUploads/NewsImg", deletedProductType.Image))).ToString());

            if (deletedProductType != null)
                return View(deletedProductType);
            else
                return View("~/Views/Shared/Error.cshtml");
        }

        [Authorize(Roles = "Admin")]
        [HttpPost]
        public ActionResult DeleteProductType(ProductType DeletedProductType, string deletingImgPath)
        {
            // deleting old image from its path :
            if (System.IO.File.Exists(deletingImgPath))
            {
                System.IO.File.Delete(deletingImgPath);
            }

            bool successfullyDeletingType = DAL.DeleteProductType(DeletedProductType.ID);
            if (successfullyDeletingType)
                return RedirectToAction("Index","Home");
            else
                return View(DeletedProductType);
        }

    }
}