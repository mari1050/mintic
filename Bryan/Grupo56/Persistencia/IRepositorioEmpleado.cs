using Dominio;
using System.Collections.Generic;
namespace Persistencia
{
    public interface IRepositorioEmpleado
    {
        Empleado AddEmpleado(Empleado empleado);
    }
}