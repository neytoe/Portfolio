using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using NetoPortfolio.Models;

namespace NetoPortfolio.Controllers
{
    public class HomeController : Controller
    {
        
        //instance of the IpersonRepositiory
        private IPersonRepository _personRepository;

        public HomeController( IPersonRepository PersonRepo)
        {
            //injecting into the constructor
           this._personRepository = PersonRepo;
        }

        public IActionResult Index()
        {
            var model = _personRepository.GetPortfolio();
            //return the model to the view
            return View(model);
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
