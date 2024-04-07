using Lab1.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Lab1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public  IActionResult Task1()
        {
            return View();
        }

        [HttpPost]
        public string Task1(int n, int m)
        {
            try
            {
				if (n % m == 0)
				{
					return $"Число {n} кратно числу {m}";
				}
				return $"Число {n} некратно числу {m}";
			}
            catch
            {

            }
			return "Ведите корректные данные";
		}

		[HttpGet]
		public IActionResult Task2()
        {
            return View();
        }

        [HttpPost]
        public string Task2(string text)
        {
			string count = "";
			try
			{ 
				foreach (char c in text)
                {
					if (char.IsDigit(c))
                    {
                        count += c + " ";
					}
				}
			}
			catch
			{

			}
			return count;
		}

        public IActionResult Profile()
        {
            return View();
        }
    }
}
