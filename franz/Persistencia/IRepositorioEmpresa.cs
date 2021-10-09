using Dominio;
using System.Collections.Generic;
namespace Persistencia
{
    public interface IRepositorioEmpresa
    {
         IEnumerable<Empresa> getAll();
         
         Empresa AddEmpresa(Empresa empresa);

         Empresa UpdateEmpresa(Empresa empresa);

         void DeleteEmpresa(int idEmpresa);

         Empresa GetEmpresa(int idEmpresa);
    }
}