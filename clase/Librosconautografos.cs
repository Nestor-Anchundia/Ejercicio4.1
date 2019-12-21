using System;
using System.Collections.Generic;
using System.Text;
using Ejercicio4._1.clase;
using Ejercicio4._1.Interfaces;

namespace Ejercicio4._1.clase
{
    public class Librosconautografos : Decoradordelibro
    { 


        public Librosconautografos(ILibro libros) : base(libros)
    {
    }

    public override string obtenerDescripcion()
    {
        return this.libros.obtenerDescripcion() + "***ACCESORIO ADICIONAL***: Libros con autogràfos del autor \n";
    }


}
}
