using System.Collections.Generic;
using Dominio;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Persistencia
{
    public class RepositorioEmpresa: IRepositorioEmpresa
    {
       private readonly AplicacionContext _appContext;

       public RepositorioEmpresa(AplicacionContext appContext){
           _appContext = appContext;


       }

        public Empresa AddEmpresa(Empresa persona)
        {
            var nuevo_persona = _appContext.Add(persona);
            _appContext.SaveChanges();
            return nuevo_persona.Entity;
        }

        public void DeleteEmpresa(int idEmpresa)
        {
            var encontrado_Empresa = _appContext.Empresa.FirstOrDefault(
                p => p.ID == idEmpresa
            );

            if(encontrado_Empresa == null)
            return;
            _appContext.Remove(encontrado_Empresa);
            _appContext.SaveChanges();

        }

        public IEnumerable<Empresa> getAll()
        {
            var listado = _appContext.Empresa.AsNoTracking();
            return listado;
        }

        public Empresa GetEmpresa(int idEmpresa)
        {
            return _appContext.Empresa.FirstOrDefault(
                p => p.ID == idEmpresa 
            );
        }

        public Empresa UpdateEmpresa(Empresa persona)
        {
            var encontrado_Empresa = _appContext.Empresa.FirstOrDefault(
                p => p.ID == persona.ID
            );

            if(encontrado_Empresa != null)
            {
                encontrado_Empresa.Nombre = persona.Nombre;
                encontrado_Empresa.Nit= persona.Nit;
                encontrado_Empresa.Ciudad = persona.Ciudad;
                encontrado_Empresa.Telefono = persona.Telefono;
                
                _appContext.SaveChanges();
            }
            return encontrado_Empresa;
        }
    }
}