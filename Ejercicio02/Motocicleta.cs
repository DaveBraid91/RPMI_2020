using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio02
{
    class Motocicleta : Vehiculo
    {
        public Motocicleta()
        {
            SetRuedas(2);
        }
        void SetCilindrada(int nuevaCilindrada)
        {
            cilindrada = nuevaCilindrada;
        }
    }
}
