using System;
using System.Collections.Generic;
using System.Text;
using Ejercicio4._1.clase;
using Ejercicio4._1.Interfaces;

namespace Ejercicio4._1.clase
{
    public abstract class Decoradordelibro : ILibro
    {


        protected ILibro libros;

        public Decoradordelibro(ILibro libros) { this.libros = libros; }

        public abstract string obtenerDescripcion();

    }
}
