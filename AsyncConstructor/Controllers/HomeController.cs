using AsyncConstructor.Models;
using AsyncConstructor.Service;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace AsyncConstructor.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly MyTestService _testService;
        private readonly IMyFundamentalType _myFundamentalType;
        private readonly MySecTestService _mySecTestService;

        public HomeController(ILogger<HomeController> logger, IMyFundamentalType myFundamentalType)
        {
            _logger = logger;
            _myFundamentalType = myFundamentalType;
        }

        public IActionResult Index()
        {
            //_testService.Print();
            //_mySecTestService.Print();

            Console.WriteLine(_myFundamentalType.Number);
            ;
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
    }
}