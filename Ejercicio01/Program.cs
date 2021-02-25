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
            /*Libro[] libros = new Libro[1000];
            int cantidadLibros = 0;*/
            Documento[] documentos = new Documento[1000];
            int cantidadDocumentos = 0;
            bool salir = false;

            while(!salir)
            {
                switch (Menu())
                {
                    case 1:
                        AddLibro(documentos, ref cantidadDocumentos);
                        break;
                    case 2:
                        ShowLibros(documentos, cantidadDocumentos);
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

        public static void AddLibro(Documento[] documentos, ref int cantidadDocumentos)
        {
            bool esLibro = EsLibro();
            string autor = RecogerDatos("autor");
            string titulo = RecogerDatos("título");
            documentos[cantidadDocumentos] = esLibro ? new Libro(autor, titulo) : new Documento(autor, titulo);
            cantidadDocumentos++;
        }

        public static void ShowLibros(Documento[] documentos, int cantidadDocumentos)
        {
            Console.Clear();
            Console.WriteLine(" ------------------------------------------------------------");
            Console.WriteLine("|                    LISTA DE LIBROS                         |");
            Console.WriteLine("|                                                            |");
            for (int i = 0; i < cantidadDocumentos; i++)
            {
                Console.WriteLine("| TÍTULO: {0}", documentos[i].titulo);
                Console.WriteLine("| AUTOR: {0}", documentos[i].autor);
                Console.WriteLine("| UBICACIÓN: {0}s", documentos[i].ubicacion);
                Console.WriteLine("|                                                            |");
            }
            Console.WriteLine("|                                                            |");
            Console.WriteLine("|                                                            |");
            Console.WriteLine(" ------------------------------------------------------------");
            Console.WriteLine("\n Pulsa ENTER para continuar");
            Console.ReadLine();
        }

        public static bool EsLibro()
        {
            Console.Write("¿Qué desea añadir?\n" +
                "1.- Libro\n" +
                "2.- Documento\n");
            return (Console.ReadLine() == "1") ? true : false;
        }
    }
}
