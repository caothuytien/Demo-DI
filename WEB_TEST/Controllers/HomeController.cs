using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WEB_TEST.DI;


// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WEB_TEST.Controllers
{
    public class HomeController : Controller
    {
        private  IUserRepository _userRepo;
        // GET: /<controller>/

        public HomeController(IUserRepository userRepo)
        {
            _userRepo = userRepo;
        }

        [HttpGet]
        public IActionResult Index()
        {
            //var repository = HttpContext.RequestServices.GetService(typeof(IUserRepository)); - Service Locator
            return View(_userRepo.GetAll());
        }
    }
}
