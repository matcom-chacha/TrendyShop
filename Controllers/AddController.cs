﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TrendyShop.Data;
using TrendyShop.ViewModels;
using TrendyShop.Models;
using TrendyShop.Controllers;
using Microsoft.EntityFrameworkCore;
using System.Web;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using System.IO;

namespace TrendyShop.Controllers
{
    public class AddController : Controller
    {
        private EFDbContext context;
        private IWebHostEnvironment webHostEnvironment;
        public AddController(EFDbContext ctx, IWebHostEnvironment hostEnvironment)
        {
            webHostEnvironment = hostEnvironment;
            context = ctx;
        }
        public IActionResult Index()
        {
            var vm = new AddIndexViewModel
            {
                Categories = context.Categories.ToList(),
                Adds = context.Adds.Include(a => a.User).Include(a => a.Article).ToList()

            };

            return View(vm);
        }

        public IActionResult ConditionFilter(bool isNew)
        {
            var vm = new AddIndexViewModel
            {
                Categories = context.Categories.ToList()
            };

            if (isNew)
            {
                vm.Adds = context.Adds.Include(a => a.Article).Include(a => a.User).Where(a => a.Article.IsNew).ToList();
                return View("Index", vm);
            }

            vm.Adds = context.Adds.Include(a => a.Article).Include(a => a.User).Where(a => !a.Article.IsNew).ToList();
            return View("Index", vm);
        }

        public IActionResult CategoryFilter(int categoryId)
        {
            var vm = new AddIndexViewModel
            {
                Categories = context.Categories.ToList(),
                Adds = context.Adds.Include(a => a.Article).Include(a => a.User).Where(a => a.Article.CategoryId == categoryId).ToList()
            };

            return View("Index", vm);
        }

        public IActionResult PriceFilter(float minp, float maxp)
        {
            var vm = new AddIndexViewModel
            {
                Categories = context.Categories.ToList(),
                Adds = context.Adds.Include(a => a.Article).Include(a => a.User).Where(a => (a.Article.Price >= minp && a.Article.Price <= maxp)).ToList()
            };

            return View("Index", vm);
        }

        public IActionResult Search(string search)
        {
            var vm = new AddIndexViewModel
            {
                Categories = context.Categories.ToList(),
                Adds = context.Adds.Include(a => a.Article).Include(a => a.User).Where(a => a.Article.Name.Contains(search)).ToList()
            };

            return View("Index", vm);
        }

        public IActionResult Details(int id)
        {
            var add = context.Adds.Find(id);

            context.Entry(add).Reference(a => a.User).Load();
            context.Entry(add).Reference(a => a.Article).Load();

            var result = new AddViewModel
            {
                Article = add.Article,
                UserName = add.User.Alias,
                Amount = add.Amount,
                AddDescription = add.Description,
                User = add.User
            };

            return View(result);
        }

        public ViewResult NewAdd()
        {
            var categories = context.Categories.ToList();
            var model = new NewAddViewModel
            {
                Add = new Add(),
                Categories = categories
            };
            return View(model);
        }

        [HttpPost]
        public ActionResult CreateNewAdd(NewAddViewModel viewModel)
        {
            if (!ModelState.IsValid)
            {
                NewAddViewModel newViewModel = new NewAddViewModel
                {
                    Add = viewModel.Add,
                    Categories = context.Categories.ToList()
                };
                newViewModel.Add.User = GetUser(User.Identity.Name); //returns null if user not found
                newViewModel.Add.UserId = User.Identity.Name;
                return View("NewAdd", newViewModel);
            }
            viewModel.Add.User = GetUser(User.Identity.Name); //returns null if user not found
            viewModel.Add.UserId = User.Identity.Name;

            viewModel.Add.Article.Image = UploadedFile(viewModel.Image);
            context.Adds.Add(viewModel.Add);//this already updates User and Article
            context.SaveChanges();

            return RedirectToAction("Index", "Add");
        }

        private string UploadedFile(IFormFile image)
        {
            string uniqueFileName = null;

            if (image != null)
            {
                string uploadsFolder = Path.Combine(webHostEnvironment.WebRootPath, "images");
                uniqueFileName = Guid.NewGuid().ToString() + "_" + image.FileName;

                string filePath = Path.Combine(uploadsFolder, uniqueFileName);

                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    image.CopyTo(fileStream);
                }
            }

            return uniqueFileName;
        }

        //[HttpPost]    
        public ActionResult Edit(int aid, string uid)
        {
            var add = context.Adds.Include(a => a.Article).SingleOrDefault(a => a.ArticleId == aid && a.UserId == uid);

            //I dont understand the purpose of this line and it was throwing an error so i commented it to be able to work on the view
            //context.Entry(add).Reference(a => a.Article).Load();

            if (add == null)
            {
                return RedirectToAction("Index");
            }

            var viewModel = new EditAddViewModel
            {
                Add = add,
                UserId = uid,
                Categories = context.Categories.ToList()
            };

            return View(viewModel);
        }


        [HttpPost]
        public ActionResult SaveEdition(EditAddViewModel editAddViewModel)
        {
            if (!ModelState.IsValid)
            {
                EditAddViewModel newEditAddViewModel = new EditAddViewModel
                {
                    UserId = editAddViewModel.Add.UserId,
                    Add = editAddViewModel.Add,
                    Categories = context.Categories.ToList()
                };
                return View("Edit", newEditAddViewModel);
            }

            //.Include(a => a.User).Include(a => a.Article)
            var addInDbContext = context.Adds.Include(a => a.Article)
                .SingleOrDefault(a => a.UserId == editAddViewModel.Add.UserId && a.ArticleId == editAddViewModel.Add.ArticleId);

            //update article
            addInDbContext.Article.Name = editAddViewModel.Add.Article.Name;
            addInDbContext.Article.Brand = editAddViewModel.Add.Article.Brand;
            addInDbContext.Article.Price = editAddViewModel.Add.Article.Price;
            addInDbContext.Article.Description = editAddViewModel.Add.Article.Description;
            addInDbContext.Article.Category = editAddViewModel.Add.Article.Category;
            addInDbContext.Article.IsNew = editAddViewModel.Add.Article.IsNew;

            //update add
            addInDbContext.Amount = editAddViewModel.Add.Amount;
            addInDbContext.Description = editAddViewModel.Add.Description;
            addInDbContext.LastModified = DateTime.Today;

            context.SaveChanges();

            return RedirectToAction("Index", "Add");
        }

        public ActionResult Delete(int aid, string uid)
        {
            var add = context.Adds.Include(a => a.Article).Include(a => a.User)
                .Single(a => a.UserId == uid && a.ArticleId == aid);

            context.Articles.Remove(add.Article);
            context.Adds.Remove(add);
            context.SaveChanges();

            return RedirectToAction("Index", "Add");
        }

        public User GetUser(string UserId)
        {
            var users = context.Users;
            foreach (var u in users)
            {
                if (string.Compare(u.UserName, UserId) == 0)
                {
                    return u;
                }
            }
            throw new Exception("User " + UserId + " not found");
        }

    }
}