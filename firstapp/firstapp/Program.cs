using firstapp.Negocio;
using System;

namespace firstapp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Ingresa un saludo");
            //String saludo = Console.ReadLine();
            //Console.WriteLine(saludo);
            clsPersona clsP = new clsPersona();
            clsP.saludo();

        }
    }
}
