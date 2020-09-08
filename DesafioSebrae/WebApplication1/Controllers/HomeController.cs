using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Eventos()
        {
            return View();
        }

        public IActionResult FormularioSerMentora()
        {
            return View();
        }

        public IActionResult GestaoTempo()
        {
            return View();
        }

        public IActionResult MaisInformacoes()
        {
            return View();
        }

        public IActionResult Mentorias()
        {
            return View();
        }

        public IActionResult MinhasAnotacoes()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult SugerirEvento()
        {
            return View();
        }

        public IActionResult Voluntaria()
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
