using System.ComponentModel.DataAnnotations;

namespace P._10_MVC___Variables_de_Sesion.Models
{
    public class Login
    {
        [Key]
        public string? usuario { get; set; }
        public string? contrasena { get; set; }
    }
}
