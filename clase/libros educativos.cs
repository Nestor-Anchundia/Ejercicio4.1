using System;
using System.Collections.Generic;
using System.Text;
using Ejercicio4._1.clase;
using Ejercicio4._1.Interfaces;

namespace Ejercicio4._1.clase
{
    public class libros_educativo
    {


        private string nombre;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public libros_educativo(string nombre)
        {
            Nombre = nombre;
        }

        public string Mostrar()
        {
            return "-----libros educativos-----:  " + Nombre;
        }



    }
}

