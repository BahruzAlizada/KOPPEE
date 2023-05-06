﻿using KOPPEE.DAL;
using KOPPEE.Helper;
using KOPPEE.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace KOPPEE.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class ProductsController : Controller
    {
        private readonly AppDbContext _db;
        private readonly IWebHostEnvironment _env;

        public ProductsController(AppDbContext db,IWebHostEnvironment env)
        {
            _db = db;
            _env = env;
        }

        public async Task<IActionResult> Index()
        {
            List<Product> products = await _db.Products.Include(x => x.Category).ToListAsync();
            return View(products);
        }

        public async Task<IActionResult> Create()
        {
            ViewBag.Categories = await _db.Categories.ToListAsync();
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]

        public async Task<IActionResult> Create(Product product,int categoryId)
        {
            ViewBag.Categories = await _db.Categories.ToListAsync();

            if (product.Name == null)
            {
                ModelState.AddModelError("Title", "Title can not be null");
                return View();
            }

            #region PhotoSave
            if (product.Photo == null)
            {
                ModelState.AddModelError("Photo", "Photo can not be null");
                return View();
            }

            if (!product.Photo.IsImage())
            {
                ModelState.AddModelError("Photo", "Selecet Image Type");
                return View();
            }

            if (product.Photo.IsOlder216Kb())
            {
                ModelState.AddModelError("Photo", "Max 216Kb");
                return View();
            }

            string folder = Path.Combine(_env.WebRootPath, "img");
            product.Image = await product.Photo.SaveFileAsync(folder);
            #endregion

            product.CategoryId = categoryId;
            await _db.Products.AddAsync(product);
            await _db.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Update(int? id)
        {
            ViewBag.Categories = await _db.Categories.ToListAsync();

            if (id == null)
                return NotFound();
            Product dbproduct = await _db.Products.FirstOrDefaultAsync(x => x.Id == id);
            if (dbproduct == null)
                return BadRequest();

            return View(dbproduct);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]

        public async Task<IActionResult> Update(int? id, Product product,int categoryId)
        {
            ViewBag.Categories = await _db.Categories.ToListAsync();

            if (id == null)
                return NotFound();
            Product dbproduct = await _db.Products.FirstOrDefaultAsync(x => x.Id == id);
            if (dbproduct == null)
                return BadRequest();

            bool isExist = await _db.Products.AnyAsync(x => x.Name == product.Name && x.Id != id);
            if (isExist)
            {
                ModelState.AddModelError("Name", "This Name already is exist!");
                return View();
            }

            #region Photo
            if(product.Photo != null)
            {
                if (!product.Photo.IsImage())
                {
                    ModelState.AddModelError("Photo", "Select image type");
                    return View();
                }

                if (product.Photo.IsOlder216Kb())
                {
                    ModelState.AddModelError("Photo", "Max 216Kb");
                    return View();
                }

                string folder = Path.Combine(_env.WebRootPath, "img");
                product.Image = await product.Photo.SaveFileAsync(folder);
                string path = Path.Combine(_env.WebRootPath, dbproduct.Image);
                if (System.IO.File.Exists(path))
                    System.IO.File.Delete(path);
                dbproduct.Image = product.Image;
            }

            #endregion

            dbproduct.Name = product.Name;
            dbproduct.Price=product.Price;
            dbproduct.Description = product.Description;
            product.CategoryId = categoryId;

            await _db.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Detail(int? id)
        {
            if (id == null)
                return NotFound();
            Product dbproduct = await _db.Products.FirstOrDefaultAsync(x => x.Id == id);
            if (dbproduct == null)
                return BadRequest();

            return View(dbproduct);
        }

        public async Task<IActionResult> Activity(int? id)
        {
            if (id == null)
                return NotFound();
            Product dbproduct = await _db.Products.FirstOrDefaultAsync(x => x.Id == id);
            if (dbproduct == null)
                return BadRequest();

            if (dbproduct.IsDeactive)
                dbproduct.IsDeactive = false;
            else
                dbproduct.IsDeactive = true;

            await _db.SaveChangesAsync();
            return RedirectToAction("Index");
        }


    }
}
