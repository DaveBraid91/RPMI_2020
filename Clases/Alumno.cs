using System;
using System.Collections.Generic;
using System.Text;

namespace Clases
{
    class Alumno : Humano
    {
        public float nota;
        public int numeroExpediente;
        public string titulacion;

        void Atender()
        {
            nota++;
            
        }

        void Suspender()
        {

        }

        void IrAClase()
        {

        }
    }
}
