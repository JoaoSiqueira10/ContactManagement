using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace ContactManagement.Models
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options)
        {
        }

        public DbSet<Contact> Contact { get; set; }

        //verifica se a URL esta direcionada para o banco de dados
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(ObterStringConexao());
                base.OnConfiguring(optionsBuilder);
            }
        }
        public string ObterStringConexao()
        {
            return "Data Source=DESKTOP-S42DPI7;Initial Catalog=ContactManagement;Integrated Security=True;TrustServerCertificate=True"; // Evitar
        }
    }
}
