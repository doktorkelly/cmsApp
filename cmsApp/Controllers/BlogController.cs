using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using cmsApp.Services;
using cmsApp.Model;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace cmsApp.Controllers
{
    public class BlogController : Controller
    {
        ICMSService CMSService { get; set; }

        public BlogController(ICMSService cms)
        {
            this.CMSService = cms;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            IEnumerable<Blog> blogs = CMSService.FindAll();
            return View(blogs);
        }
    }
}
