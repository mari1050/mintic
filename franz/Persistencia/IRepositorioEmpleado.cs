using Dominio;
using System.Collections.Generic;
namespace Persistencia
{
    public interface IRepositorioEmpleado
    {
         IEnumerable<Empleado> getAll();
         
         Empleado AddEmpleado(Empleado empleado);

         Empleado UpdateEmpleado(Empleado empleado);

         void DeleteEmpleado(int idEmpleado);

         Empleado GetEmpleado(int idEmpleado);
    }
}