using Microsoft.EntityFrameworkCore;
using Dominio;
namespace Persistencia
{
    public class AplicacionContext: DbContext
    {
        public DbSet<Cliente> Clientes{get;set;}
        private const string connectionString = @"Data Source=localhost\sqlexpress;Initial Catalog = Premios_India_Calalina;Integrated Security = True";
           protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder){
            if(!optionsBuilder.IsConfigured){
                optionsBuilder
                .UseSqlServer(connectionString);
            }
        }
    }
}