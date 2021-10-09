using System.Collections.Generic;
using Dominio;
using System.Linq;

namespace Persistencia
{
    public class RepositorioPersona: IRepositorioPersona
    {
       private readonly AplicacionContext _appContext;

       public RepositorioPersona(AplicacionContext appContext){
           _appContext = appContext;


       }

        public Persona AddPersona(Persona persona)
        {
            var nuevo_persona = _appContext.Add(persona);
            _appContext.SaveChanges();
            return nuevo_persona.Entity;
        }

        public void DeletePersona(int idPersona)
        {
            var encontrado_Persona = _appContext.Personas.FirstOrDefault(
                p => p.ID == idPersona
            );

            if(encontrado_Persona == null)
            return;
            _appContext.Remove(encontrado_Persona);
            _appContext.SaveChanges();

        }

        public IEnumerable<Persona> getAll()
        {
            return _appContext.Personas;
        }

        public Persona GetPersona(int idPersona)
        {
            return _appContext.Personas.FirstOrDefault(
                p => p.ID == idPersona 
            );
        }

        public Persona UpdatePersona(Persona persona)
        {
            var encontrado_Persona = _appContext.Personas.FirstOrDefault(
                p => p.ID == persona.ID
            );

            if(encontrado_Persona != null)
            {
                encontrado_Persona.Nombre = persona.Nombre;
                encontrado_Persona.Apellido = persona.Apellido;
                encontrado_Persona.Cedula = persona.Cedula;
                
                _appContext.SaveChanges();
            }
            return encontrado_Persona;
        }
    }
}