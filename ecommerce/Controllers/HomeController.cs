using ecommerce.Data;
using ecommerce.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ecommerce.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly AppDBcontext _appDBcontext;

        public HomeController(ILogger<HomeController> logger , AppDBcontext appDBcontext)
        {
            _logger = logger;
            _appDBcontext = appDBcontext;
        }

        public  IActionResult Index()

        {
            ViewBag.data=_appDBcontext.login.ToList();
            return View();
        }
        [HttpPost]
        public IActionResult SaveData(login login)
        {
            if (!ModelState.IsValid)
            {
                try
                {
                    _appDBcontext.Add(login);
                    _appDBcontext.SaveChanges();
                    ViewBag.Message = "data saved successfully";
                }
                catch(Exception ex)
                {
                    ViewBag.Message = "There is an error";

                }

            }
           
            return View("index");
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult Products()
        {
            return View();
        }
        public IActionResult Client()
        {
            return View();
        }
        public IActionResult Contact()
        {
            return View();
        }





        public IActionResult Privacy()
        {

            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult second()
        {
            return View("third");
        }
    }
}