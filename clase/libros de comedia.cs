using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio4._1.clase
{
    public class libros_de_comedia
    {


        private string nombre;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public libros_de_comedia(string nombre)
        {
            Nombre = nombre;
        }

        public string Mostrar()
        {
            return "-----libros de comedia-----: " + Nombre;
        }


    }
}
