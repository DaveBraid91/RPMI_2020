using System;

namespace Clases
{
    class Program
    {
        static void Main()
        {
            Humano human = new Humano();
            Humano han = new Humano("Chimpancé", "Julián", "Patricio", 99);
            Alumno alumno = new Alumno();
            //human.SetNombre("Julito");
            //human.SetNombre(RecogerDatos("un nombre"));
            human.Nacer();
            human.Morir();
            alumno.edad = 7;
            alumno.SetNombre("Victorsito");
            Console.WriteLine("Nombre: " + han.GetNombre());
            
        }


        static string RecogerDatos(string dato)
        {
            Console.Write("Introduce {0}: ", dato);
            return Console.ReadLine();
        }
    }

    /*
    1.- Para guardar información sobre libros, vamos a comenzar por crear una
    clase "Libro", que contendrá atributos "autor", "titulo", "ubicacion" (todos ellos
    strings) y métodos Get y Set adecuados para leer su valor y cambiarlo. Prepara
    también un Main, que cree un objeto de la clase Libro, dé
    valores a sus tres atributos y luego los muestre.

    2.- Crea una clase "Coche", con atributos "marca" (texto), "modelo" (texto),
    "cilindrada" (número entero), potencia (número real). No hace falta que crees un
    Main de prueba.

    4.- Amplía el proyecto del ejercicio 1 (Libro): crea una clase "Documento",
    de la que Libro heredará todos sus atributos y métodos. Ahora la clase Libro
    contendrá sólo un atributo "paginas", número entero, con sus correspondientes
    Get y Set.

    5.- Amplía el proyecto de la clase Coche (ejercicio 2): Crea una clase
    "Vehiculo", de la que heredarán "Coche" y una nueva clase "Moto". La clase
    Vehiculo contendrá todos los atributos y métodos que antes estaban en Coche, y
    tanto Coche como Moto heredarán de ella.

    6.- Retoca el proyecto del ejercicio 4 (Libro): los atributos de la clase
    Documento y de la clase Libro serán "protegidos".

    7.- Mejora el proyecto de la clase Coche (ejercicio 5): todos los atributos
    serán "protegidos" y los métodos serán "públicos".

    8.- Amplía el proyecto del ejercicio 6 (Libro): la clase Libro tendrá un
    constructor que permita dar valores al autor, el título y la ubicación.

    9.- Mejora el proyecto de la clase Coche (ejercicio 7): añade un atributo
    "cantidadDeRuedas" a la clase Vehiculo, junto con sus Get y Set. El constructor de
    la clase Coche le dará el valor 4 y el constructor de la clase Moto le dará el valor 2.

    10.- Amplía el proyecto del ejercicio 8 (Libro): la clase Libro tendrá un
    segundo constructor que permita dar valores al autor y el título, pero no a la
    ubicación, que tomará el valor por defecto "No detallada".

    11.- Crea dos nuevos métodos en la clase Vehiculo (ejercicio 9): uno llamado
    Circular, que fijará su "velocidad" (un nuevo atributo) a 50, y otro Circular(v), que
    fijará su velocidad al valor que se indique como parámetro.

    12.- Crea un único fuente que contenga las siguientes clases:
         Una clase Trabajador, cuyo constructor escriba en pantalla "Soy un
        trabajador".

         Una clase Programador, que derive de Trabajador, cuyo constructor escriba
        en pantalla "Soy programador".

         Una clase Analista, que derive de Trabajador, cuyo constructor escriba en
        pantalla "Soy analista".

         Una clase Ingeniero, que derive de Trabajador, cuyo constructor escriba en
        pantalla "Soy ingeniero".

         Una clase IngenieroInformatico, que derive de Ingeniero, cuyo constructor
        escriba en pantalla "Soy ingeniero informático".

         Una clase "PruebaDeTrabajadores", que cree un objeto perteneciente a
        cada una de esas clases.

    13.- Crea una versión ampliada del ejercicio 12 (clase Trabajador y
    relacionadas), en la que no se cree un único objeto de cada clase, sino un array de
    tres objetos.

    14.- Amplía el proyecto Libro (ejercicio 10), de modo que permita guardar
    hasta 1.000 libros. Main mostrará un menú que permita añadir un nuevo libro o
    ver los datos de los ya existentes.

    15.- A partir del ejemplo y del ejercicio 13 (clase Trabajador y
    relacionadas), crea un array de trabajadores en el que no sean todos de la misma
    clase.

    16.- Amplía el proyecto Libro (ejercicio 14), de modo que permita guardar
    1000 documentos de cualquier tipo. A la hora de añadir un documento, se
    preguntará al usuario si desea guardar un documento genérico o un libro, para
    usar el constructor adecuado.
     */

}
