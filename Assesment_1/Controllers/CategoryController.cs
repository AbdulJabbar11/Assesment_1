using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assesment_1.Models;
using Microsoft.AspNetCore.Mvc;

namespace Assesment_1.Controllers
{
    public class CategoryController : Controller
    {

        private Asses_1Context orm1 = null;
        public CategoryController(Asses_1Context _orm1)
        {
            orm1 = _orm1;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult CreateCategory()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateCategory(Category C)
        {
            orm1.Category.Add(C);
            orm1.SaveChanges();

            return View();
        }
    }
}