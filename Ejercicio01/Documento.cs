using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio01
{
    class Documento
    {
        public string autor, titulo, ubicacion;

        public Documento(string nuevoAutor, string nuevoTitulo)
        {
            autor = nuevoAutor;
            titulo = nuevoTitulo;
            ubicacion = "No detallada";
        }
        public string GetAutor()
        {
            return autor;
        }
        public void SetAutor(string nuevoAutor)
        {
            autor = nuevoAutor;
        }

        public string GetTitulo()
        {
            return titulo;
        }
        public void SetTitulo(string nuevoTitulo)
        {
            titulo = nuevoTitulo;
        }

        public string GetUbicacion()
        {
            return ubicacion;
        }
        public void SetUbicacion(string nuevoUbicacion)
        {
            ubicacion = nuevoUbicacion;
        }

        public void PreguntarPorAutor()
        {
            SetAutor(Program.RecogerDatos("un autor"));
        }
    }
}
