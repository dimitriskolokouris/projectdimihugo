using Microsoft.AspNetCore.Mvc;
using projectdimihugo.Models;
using System.Diagnostics;
using MySql.Data;

namespace projectdimihugo.Controllers
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

        public IActionResult Films()
        {
            return View();
        }

        public IActionResult FilmsKinderen()
        {
            return View();
        }

        public IActionResult FilmsJongeren()
        {
            return View();
        }

        public IActionResult FilmsVolwassenen()
        {
            return View();
        }

        public IActionResult Tickets()
        {
            return View();
        }

        public IActionResult Vacatures()
        {
            return View();
        }

        public IActionResult Informatie()
        {
            return View();
        }
         
        public IActionResult Contact()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Contact(Person person)
        {
            // hebben we alles goed ingevuld? Dan sturen we de gebruiker door naar de succes pagina
            if (ModelState.IsValid)
                return Redirect("/succes");

            // niet goed? Dan sturen we de gegevens door naar de view zodat we de fouten kunnen tonen
            return View(person);
        }

        public IActionResult SolliciteerKok()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SolliciteerKok(Person person)
        {
            // hebben we alles goed ingevuld? Dan sturen we de gebruiker door naar de succes pagina
            if (ModelState.IsValid)
                return Redirect("/succes");

            // niet goed? Dan sturen we de gegevens door naar de view zodat we de fouten kunnen tonen
            return View(person);
        }

        public IActionResult SolliciteerKassa()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SolliciteerKassa(Person person)
        {
            // hebben we alles goed ingevuld? Dan sturen we de gebruiker door naar de succes pagina
            if (ModelState.IsValid)
                return Redirect("/succes");

            // niet goed? Dan sturen we de gegevens door naar de view zodat we de fouten kunnen tonen
            return View(person);
        }

        public IActionResult SolliciteerSchoonmaak()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SolliciteerSchoonmaak(Person person)
        {
            // hebben we alles goed ingevuld? Dan sturen we de gebruiker door naar de succes pagina
            if (ModelState.IsValid)
                return Redirect("/succes");

            // niet goed? Dan sturen we de gegevens door naar de view zodat we de fouten kunnen tonen
            return View(person);
        }

        [Route("succes")]
        public IActionResult Succes()
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