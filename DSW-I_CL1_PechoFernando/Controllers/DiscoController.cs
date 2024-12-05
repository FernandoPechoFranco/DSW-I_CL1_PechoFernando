using Microsoft.AspNetCore.Mvc;
using DSW_I_CL1.Models;

namespace DSW_I_CL1.Controllers
{
    public class DiscoController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Calcular(int disco)
        {
            var model = new Calcular { Disco = disco };
            model.CalcularCds();
            return View("Resultado", model);
        }
    }
}
