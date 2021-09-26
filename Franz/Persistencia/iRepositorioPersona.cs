using Dominio;
using System.Collections.Generic;
namespace Persistencia
{
    public interface iRepositorioPersona
    {
         IEnumerable<Persona> getAll();
         
         Persona AddPersona(Persona persona);

         Persona UpdatePersona(Persona persona);

         void DeletePersona(int idPersona);

         Persona GetPersona(int idPersona);
    }
}