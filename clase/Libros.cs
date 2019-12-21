using System;
using System.Collections.Generic;
using System.Text;
using Ejercicio4._1.clase;
using Ejercicio4._1.Interfaces;

namespace Ejercicio4._1.clase
{
    public class Libros : ILibro
    {
        public Libros()
        {
        }

        public string obtenerDescripcion()
        {
            return "***DESCRIPCION ADICIONAL***: año que fue creado \n-***DESCRICION ADICIONAL***: Autor del libro \n";
        }
    }
}
