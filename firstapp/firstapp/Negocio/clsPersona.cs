using firstapp.Dominio;
using System;
using System.Collections.Generic;
using System.Text;

namespace firstapp.Negocio
{
    class clsPersona 
    {
        Persona persona = new Persona();
        public void saludo() {
            persona.Nombre = "William";
            persona.Apellido = "Diaz";
            Console.WriteLine(persona.ToString());
        }
        
    }
}
