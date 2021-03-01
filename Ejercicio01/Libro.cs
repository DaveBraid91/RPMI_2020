using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio01
{
    class Libro : Documento
    {
        int paginas;

        public Libro(string nuevoAutor, string nuevoTitulo, string nuevaUbicacion, int nuevasPaginas) 
            : base(nuevoAutor, nuevoTitulo)
        {
            ubicacion = nuevaUbicacion;
            paginas = nuevasPaginas;
        }

        public Libro(string nuevoAutor, string nuevoTitulo) : base(nuevoAutor, nuevoTitulo)
        {
            //Pasos adicionales
        }

        public Libro() : base()
        {
            autor = "No detallado";
            titulo = "No detallado";
            ubicacion = "No detallada";
        }
        public void SetPaginas(int numeroPaginas)
        {
            paginas = numeroPaginas;
        }

        public int GetPaginas()
        {
            return paginas;
        }

        public void GetPaginas(out int numeroPaginas)
        {
            numeroPaginas = paginas;
        }

        public new string GetAutor()
        {
            Console.WriteLine("El autor ha sido comunicado");
            return base.GetAutor();            
        }
    }
}
