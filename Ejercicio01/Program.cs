using System;

namespace Ejercicio01
{
    class Program
    {
        static void Main()
        {
            /*            int paginas;
                        Libro libro = new Libro();
                        libro.PreguntarPorAutor();
                        libro.SetTitulo("La muchacha que tenía algo por la criaturas mitológicas inmaduras");
                        libro.SetUbicacion("El gusto musical de Marcos (osea, imaginario)");
                        Console.WriteLine("Título: {0}\nAutor: {1}\nUbicación: {2}",
                            libro.GetTitulo(), libro.GetAutor(), libro.GetUbicacion());
                        libro.GetPaginas(out paginas);
                        paginas = libro.GetPaginas();*/
            Libro[] libros = new Libro[1000];
            int cantidadLibros = 0;
            bool salir = false;

            while(!salir)
            {
                switch (Menu())
                {
                    case 1:
                        AddLibro(libros, ref cantidadLibros);
                        break;
                    case 2:
                        ShowLibros(libros, cantidadLibros);
                        break;
                    case 3:
                        salir = true;
                        break;
                    default:
                        Console.WriteLine("\nOpción no válida\n");
                        break;
                }

            }
        }

            

        public static string RecogerDatos(string dato)
        {
            Console.Write("Introduce {0}: ", dato);
            return Console.ReadLine();
        }

        public static int Menu()
        {
            int opcion = 0;
            bool valido = false;
            while (!valido)
            {
                Console.Clear();
                Console.WriteLine(" ------------------------------------------------------------");
                Console.WriteLine("|                            MENÚ                            |");
                Console.WriteLine("|                                                            |");
                Console.WriteLine("|                                                            |");
                Console.WriteLine("| 1.- Añadir libro                                           |");
                Console.WriteLine("| 2.- Mostrar libros                                         |");
                Console.WriteLine("| 3.- Salir                                                  |");
                Console.WriteLine("|                                                            |");
                Console.WriteLine("|                                                            |");
                Console.WriteLine(" ------------------------------------------------------------");
                Console.Write("\n\nElige una opción (1-3): ");
                valido = Int32.TryParse(Console.ReadLine(), out opcion);
                valido &= (opcion > 0 && opcion < 4);
            }

            return opcion;
        }

        public static void AddLibro(Libro[] libros, ref int cantidadLibros)
        {
            string autor = RecogerDatos("autor");
            string titulo = RecogerDatos("título");
            libros[cantidadLibros] = new Libro(autor, titulo);
            cantidadLibros++;
        }

        public static void ShowLibros(Libro[] libros, int cantidadLibros)
        {
            Console.Clear();
            Console.WriteLine(" ------------------------------------------------------------");
            Console.WriteLine("|                    LISTA DE LIBROS                         |");
            Console.WriteLine("|                                                            |");
            for (int i = 0; i < cantidadLibros; i++)
            {
                Console.WriteLine("| TÍTULO: {0}", libros[i].titulo);
                Console.WriteLine("| AUTOR: {0}", libros[i].autor);
                Console.WriteLine("| UBICACIÓN: {0}s", libros[i].ubicacion);
                Console.WriteLine("|                                                            |");
            }
            Console.WriteLine("|                                                            |");
            Console.WriteLine("|                                                            |");
            Console.WriteLine(" ------------------------------------------------------------");
            Console.WriteLine("\n Pulsa ENTER para continuar");
            Console.ReadLine();
        }
    }
}
