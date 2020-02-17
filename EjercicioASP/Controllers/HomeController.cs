using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using EjercicioASP.Models;

namespace EjercicioASP.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index(Data Datos)
        {
            if (ModelState.IsValid)
            {


                double n1 = Datos.number1;
                double n2 = Datos.number2;
                int op = Datos.op.GetHashCode();
                double resultado = 0;

                switch (op)
                {
                    case 0:
                        resultado = n1 + n2;
                        break;
                    case 1:
                        resultado = n1 - n2;
                        break;
                    case 2:
                        resultado = n1 * n2;
                        break;
                    case 3:
                        resultado = n1 / n2;
                        break;
                    case 4:
                        resultado = Math.Pow(n1,n2);
                        break;
                    case 5:
                        resultado = Math.Sqrt(n1);
                        
                        break;
                }



                ViewData["resultado"] = resultado;

            }

            return View("Index");
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
