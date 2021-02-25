using System;
using System.Collections.Generic;
using System.Text;

namespace ArraysDeObjetos
{
    class Animal
    {
        public string nombre;
        public Animal()
        {
            nombre = "Sparky";
            Console.WriteLine("Ha nacido un animal");
        }

        public Animal(string nuevoNombre)
        {
            nombre = nuevoNombre;
        }
    }
}
