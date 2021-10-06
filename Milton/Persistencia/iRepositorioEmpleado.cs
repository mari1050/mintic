using Dominio;
using System.Collections.Generic;
namespace Persistencia
{
    public interface iRepositorioEmpleado
    {
         IEnumerable<Empleado> getAll();
         
         void AddEmpleado(Empleado empleado);

         Empleado UpdateEmpleado(Empleado empleado);

         void DeleteEmpleado(int idEmpleado);

         Empleado GetEmpleado(int idEmpleado);
    }
}