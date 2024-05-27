using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.SqlServer;
using Microsoft.EntityFrameworkCore;

namespace P._10_MVC___Variables_de_Sesion.Models
{
    public class Login
    {
        [Key]
        public string? usuario { get; set; }
        public string? contrasena { get; set; }
    }
}
