using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Diplomado_MVC_HTML_Helps_Persona.Models
{
    public class MantenimientoPersona
    {

        List<Persona> ListaPersonas = new List<Persona>()
        {
            new Persona(){  Codigo =1,
                            Nombre = "Julio Jose Martinez",
                            Peso =90.0f,
                            Tabaja = true,
                            FechaNacimiento = new DateTime(1976,12,25)},
              new Persona(){  Codigo =2,
                            Nombre = "Miguel Antonio Cuevas",
                            Peso =56.9f,
                            Tabaja = true,
                            FechaNacimiento = new DateTime(1986,12,25)},
                new Persona(){  Codigo =3,
                            Nombre = "Federico Cuevas",
                            Peso =89.0f,
                            Tabaja = false,
                            FechaNacimiento = new DateTime(1976,12,25)}
        };

        public Persona Retornar(int Codig)
        {
            foreach (var Person in ListaPersonas)
                if (Person.Codigo ==Codig)
                    return Person;
                return null;
        }

       
    }

  
}