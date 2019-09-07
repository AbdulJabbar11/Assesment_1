using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assesment_1.Models;
using Microsoft.AspNetCore.Mvc;

namespace Assesment_1.Controllers
{
    public class PostController : Controller
    {
        private Asses_1Context orm = null;
        public PostController(Asses_1Context _orm)
        {
            orm = _orm;
        }
        public IActionResult Index()
        {
            
            return View();
        }
        [HttpGet]
        public IActionResult CreatePost()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreatePost(Post P)
        {
            orm.Post.Add(P);
            orm.SaveChanges();

            return View();
        }
    }
}