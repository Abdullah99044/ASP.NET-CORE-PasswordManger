 
using Business_Layer.Services;
using Data_Access_Layer.Models;
using Microsoft.AspNetCore.Mvc;
using passwordManger.Models;
using System.Diagnostics;

namespace passwordManger.Controllers
{
    //To do for tommorw
    //Javascript methds
    //Inputs validation
    //Identity core
   
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private readonly IPassWordsServics _services;
        public HomeController(ILogger<HomeController> logger, IPassWordsServics servics)
        {
            _logger = logger;
            _services = servics;
        }

        public class indexModel
        {
            public List<passwords> passwordDTOs { get; set; }
            public passwords createPassword { get; set; } 
        }


        [HttpGet]
        public async Task<ActionResult<indexModel>> Index()
        {

            List<passwords> obj = await _services.GetPasswords();

            var model = new indexModel
            {
                passwordDTOs = obj
            };

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> CreateNewPassword(indexModel obj)
        {
            await _services.CreatePassword(obj.createPassword);
            return RedirectToAction("Index");
        }


        [HttpPost]
        public async Task<IActionResult> DeletePassword(indexModel obj)
        {
            await _services.DeletePassword(obj.createPassword.Id);
            return RedirectToAction("Index");
        }


        [HttpGet]
        public async Task<ActionResult<passwords>> UpdatePassword(int Id)
        {

            var obj = await _services.GetAPassword(Id);
           
            return View(obj);
        }


        [HttpPost]
        public async Task<IActionResult> UpdatePassword(passwords obj)
        {

            await _services.UpdatePassword(obj);

            return RedirectToAction("Index");
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
    }
}
