using Microsoft.EntityFrameworkCore;
using Microsoft.Data.SqlClient;
using Exo.WebApi.Models;

namespace Exo.WebApi.Contexts
{
    public class ExoContext : DbContext
    {
        public ExoContext(DbContextOptions<ExoContext> options) 
            : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost\\SQLEXPRESS;Database=ExoApi;Trusted_Connection=True;");
        }

        public DbSet<Projeto> Projetos { get; set; }
    }
}