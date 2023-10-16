using Microsoft.AspNetCore.Mvc;
using Web_24BM.Models;

namespace Web_24BM.Controllers
{
    public class EjemploController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.Texto = "Esto es un texto desde controlador";
            TempData["Texto2"] = "Esto es un texto temporal";


            Ejemplo model = new Ejemplo();
            model.Titulo = "Esto es un texto desde el controlador";
            model.Parrafo = "Esto es un parrafo";

            return View(model);

        }
        [HttpPost]
        public IActionResult Index(Ejemplo ejemplo)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("Index");
            }
            else
            {

                return RedirectToAction("Index", "Home");

            }
            return RedirectToAction("Index");

        }
    }
}

