using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio01
{
    class Libro : Documento
    {
        int paginas;

        public Libro(string nuevoAutor, string nuevoTitulo, string nuevaUbicacion)
        {
            autor = nuevoAutor;
            titulo = nuevoTitulo;
            ubicacion = nuevaUbicacion;
        }

        public Libro(string nuevoAutor, string nuevoTitulo)
        {
            autor = nuevoAutor;
            titulo = nuevoTitulo;
            ubicacion = "No detallada";
        }

        public Libro()
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
    }
}
