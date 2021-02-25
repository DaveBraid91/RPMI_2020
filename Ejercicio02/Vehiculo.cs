using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio02
{
    class Vehiculo
    {
        protected string marca, modelo;
        protected int cilindrada, cantidadDeRuedas;
        protected float potencia, velocidad;

        public void SetRuedas(int ruedas)
        {
            cantidadDeRuedas = ruedas;
        }

        public int GetRuedas()
        {
            return cantidadDeRuedas;
        }

        public void Circular()
        {
            velocidad = 50;
        }
        
        public void Circular(float nVelocidad)
        {
            velocidad = nVelocidad;
        }
    }
}
