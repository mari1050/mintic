using System.Collections.Generic;
using Dominio;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Persistencia
{
    public class RepositorioEmpleado: IRepositorioEmpleado
    {
       private readonly AplicacionContext _appContext;

       public RepositorioEmpleado(AplicacionContext appContext){
           _appContext = appContext;


       }

        public Empleado AddEmpleado(Empleado empleado)
        {
            var nuevo_empleado = _appContext.Add(empleado);
            _appContext.SaveChanges();
            return nuevo_empleado.Entity;
        }

        public void DeleteEmpleado(int idEmpleado)
        {
            var encontrado_Empleado = _appContext.Empleados.FirstOrDefault(
                p => p.ID == idEmpleado
            );

            if(encontrado_Empleado == null)
            return;
            _appContext.Remove(encontrado_Empleado);
            _appContext.SaveChanges();

        }

        public IEnumerable<Empleado> getAll()
        {
            var listado = _appContext.Empleados.AsNoTracking();
            return listado;
        }

        public Empleado GetEmpleado(int idEmpleado)
        {
            return _appContext.Empleados.FirstOrDefault(
                p => p.ID == idEmpleado 
            );
        }

        public Empleado UpdateEmpleado(Empleado empleado)
        {
            var encontrado_Empleado = _appContext.Empleados.FirstOrDefault(
                p => p.ID == empleado.ID
            );

            if(encontrado_Empleado != null)
            {
                encontrado_Empleado.Nombre = empleado.Nombre;
                encontrado_Empleado.Apellido = empleado.Apellido;
                encontrado_Empleado.Cedula = empleado.Cedula;
                encontrado_Empleado.Tipo_empleado = empleado.Tipo_empleado;
                encontrado_Empleado.Cantidad_subordinados = empleado.Cantidad_subordinados;
                
                _appContext.SaveChanges();
            }
            return encontrado_Empleado;
        }
    }
}