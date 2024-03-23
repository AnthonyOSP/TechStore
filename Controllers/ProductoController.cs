using Microsoft.AspNetCore.Mvc;
using TechStore.Models; 

namespace TechStore.Controllers
{
    public class ProductoController : Controller
    {
        public IActionResult Agregar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Guardar(ProductoViewModel model)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("ProductoGuardado");
            }
            return View("Agregar", model);
        }
        public IActionResult ProductoGuardado()
        {
            return View();
        }
    }
}
