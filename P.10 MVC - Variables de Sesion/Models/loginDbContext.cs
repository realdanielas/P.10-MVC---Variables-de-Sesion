using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.SqlServer;
using Microsoft.EntityFrameworkCore;

namespace P._10_MVC___Variables_de_Sesion.Models
{
    public class loginDbContext : DbContext
    {
        public loginDbContext(DbContextOptions<loginDbContext> options) : base(options)
        { }

        public DbSet<Login> login { get; set; }
    }
}
