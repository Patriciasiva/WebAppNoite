using Microsoft.AspNetCore.Mvc;

namespace WebAppNoite.Controllers
{
    public class LojaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    public IActionResult Carrinho()
        {
            return View();
        }
    }
}

