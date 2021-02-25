using System;
using System.Collections.Generic;
using System.Text;

namespace Clases
{
    class Humano
    {
        protected string especie, nombre, apellido;
        private int manos;
        public int edad;
       
       

        public Humano()
        {
            especie = "Orangután";
            nombre = "Pili";
            apellido = "Vanilli";
            edad = 45;
        }

        public Humano(string es)
        {
            especie = es;
            nombre = "Pili";
            apellido = "Vanilli";
            edad = 45;
        }

        public Humano(string es, string nom)
        {
            especie = es;
            nombre = nom;
            apellido = "Vanilli";
            edad = 45;
        }

        public Humano(string es, string nom, string ape)
        {
            especie = es;
            nombre = nom;
            apellido = ape;
            edad = 45;
        }

        public Humano(string es, string nom, string ape, int age)
        {
            especie = es;
            nombre = nom;
            apellido = ape;
            edad = age;
        }
        public void SetNombre(string nuevoNombre)
        {
            nombre = nuevoNombre;
        }

        public string GetNombre()
        {
            return nombre;
        }

        public void Nacer()
        {
            Console.WriteLine("{0} ha nacido.", nombre);
        }

        public void Morir()
        {
            Console.WriteLine("{0} ha muerto.", nombre);
        }
    }
}
