using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab2.Controllers
{
    public class CategoriesController : Controller
    {
        // GET: Categories
        public ActionResult Index()
        {
            var categories = new List<Category>();

            Category category = new Category();
            category.Name = "Food";
            category.Name = "Tech";
            category.Name = "Sports";
            categories.Add(Category);

            return View(Category);
        }
    }
}