using Microsoft.Extensions.Diagnostics.HealthChecks;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.SqlServer;
using Microsoft.EntityFrameworkCore;

namespace P._10_MVC___Variables_de_Sesion.Models
{

    public class Users
    {
        [Key]
        public int id { get; set; }
        public string? usuario { get; set; }
        [JsonIgnore]
        public string? clave { get; set; }
        public string? correo { get; set; }
        public string? estado { get; set; } = "A";
        public DateTime fechaCreacion { get; set; } = DateTime.Now;
    }
}
