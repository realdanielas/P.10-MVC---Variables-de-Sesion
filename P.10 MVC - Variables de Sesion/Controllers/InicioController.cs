using Microsoft.AspNetCore.Mvc;
using P._10_MVC___Variables_de_Sesion.Models;
using System.Text.Json;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;

namespace P._10_MVC___Variables_de_Sesion.Controllers
{
    public class InicioController : Controller
    {
        private readonly loginDbContext _context;
        public InicioController(loginDbContext context)
        {
            _context = context;
        }
        
        public IActionResult Login()
        {
            return View();
        }
        public IActionResult ValidarUsuario(Login credenciales)
        {
            Users? usuario = (from user in _context.Users
                              where user.usuario == credenciales.usuario
                              && user.clave == credenciales.contrasena
                              select user).FirstOrDefault();

            if (usuario == null)
            {
                ViewBag.Mensaje = "Credenciales incorrectas.";
                return View("Index");
            }

            string datosUsuario = JsonSerializer.Serialize(usuario);

            HttpContext.Session.SetString("user", datosUsuario);

            return RedirectToAction("Index", "Home");
        }
    }
}
