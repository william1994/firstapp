using System;
using System.Collections.Generic;
using System.Text;

namespace firstapp.Dominio
{
    class Persona
    {
        private String nombre;
        private String apellido;
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }

        public override string ToString()
        {
            return this.nombre +" "+ this.apellido;
        }
    }
}
