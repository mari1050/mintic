using System.Collections.Generic;
using System.Linq;
using Dominio;
namespace Persistencia
{
    public class RepositorioEmpleado : IRepositorioEmpleado
    {
        private readonly AplicacionContext _appContext;
        public RepositorioEmpleado(AplicacionContext appContext)
        {
            _appContext = appContext;
        }

        public Empleado AddEmpleado(Empleado empleado)
        {
            var nuevo_empleado = _appContext.Add(empleado);
            _appContext.SaveChanges();
            return nuevo_empleado.Entity;
        }

    }
}