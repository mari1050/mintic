using Microsoft.EntityFrameworkCore;
using Dominio;
namespace Persistencia
{
    public class AplicacionContext : DbContext
    {

    public DbSet<Cliente> Clientes {get;set;}
    public DbSet<Empresa> Empresa {get;set;}
    public DbSet<Persona> Personas {get;set;}
    public DbSet<Empleado> Empleados {get;set;}
    

    private const string connectionString = @"Data Source=localhost\grupo1; Initial Catalog = Grupo56;Integrated Security = True";
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder){
        if(!optionsBuilder.IsConfigured){
            optionsBuilder.UseSqlServer(connectionString);
        }    
        }
    }
}