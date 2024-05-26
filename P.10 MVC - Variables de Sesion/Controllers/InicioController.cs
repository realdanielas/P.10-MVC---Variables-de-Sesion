using Microsoft.AspNetCore.Mvc;

namespace P._10_MVC___Variables_de_Sesion.Controllers
{
    public class InicioController : Controller
    {
        private readonly loginDbContext _context;
        public InicioController(loginDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
