using System;

namespace ArraysDeObjetos
{
    class Program
    {
        static void Main()
        {
            Animal[] misAnimales = new Animal[3];
            misAnimales[0] = new Perro();
            misAnimales[1] = new Gato();
            misAnimales[2] = new PerroSalchicha();
            string[] nombres = { "Toby", "Spyke", "Ares", "Beethoven", "Reed" };
            Perro[] misPerris = new Perro[5];
            for (int i = 0; i < misPerris.Length; i++)
            {
                misPerris[i] = new Perro(nombres[i]);
                Console.WriteLine("Este Perro se llama: {0}", misPerris[i].nombre);
            }
            Perro perri = new Perro();
        }

        static void AddLibro()
        {

        }
    }
}
