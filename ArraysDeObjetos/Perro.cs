using System;
using System.Collections.Generic;
using System.Text;

namespace ArraysDeObjetos
{
    class Perro : Animal
    {
        public Perro()
        {
            Console.WriteLine("Ha nacido un perro");
        }

        public Perro(string nuevoNombre)
        {
            nombre = nuevoNombre;
            Console.WriteLine("Ha nacido el perro {0}", nombre);
        }

        public override void Hablar()
        {
            Console.WriteLine("Woof!");
        }
    }
}
