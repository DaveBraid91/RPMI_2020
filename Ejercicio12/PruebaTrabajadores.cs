using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio12
{
    static class PruebaTrabajadores
    {
        public static void CreaTrabajadores()
        {
            Trabajador trabajador = new Trabajador();
            Analista analista = new Analista();
            Programador programador = new Programador();
            Ingeniero ingeniero = new Ingeniero();
            IngenieroDeVerdad cualquierCosaMenosInformatico = new IngenieroDeVerdad();

//________________________________________________________________________________________________________________________________

            Trabajador[] trabajadores = new Trabajador[3];
            Analista[] analistas = new Analista[3];
            Ingeniero[] ingenieros = new Ingeniero[3];
            Programador[] programadores = new Programador[3];
            IngenieroDeVerdad[] noInformaticos = new IngenieroDeVerdad[3];
            for (int i = 0; i < trabajadores.Length; i++)
            {
                trabajadores[i] = new Trabajador();
                analistas[i] = new Analista();
                ingenieros[i] = new Ingeniero();
                programadores[i] = new Programador();
                noInformaticos[i] = new IngenieroDeVerdad();
            }

        }
    }
}
