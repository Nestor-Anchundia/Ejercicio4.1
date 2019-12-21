using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio4._1.clase
{
    
        public sealed class singleton
    {
        private static singleton instancia = null;
        public singleton()
        {
        }


        public static singleton Instancia
        {
            get
            {
                if (instancia == null)
                {
                    Console.WriteLine("Se instancia");
                    instancia = new singleton();
                }

                return instancia;
            }

        }

        private List<libros_educativo> libros;

        public List<libros_educativo> Libros
        {
            get { return libros; }
            set { libros = value; }

        }

        private List<libros_de_comedia> librosC;

        public List<libros_de_comedia> LibrosC
        {
            get { return librosC; }
            set { librosC = value; }

        }
        private List<libros_de_terror> librosT;

        public List<libros_de_terror> LibrosT
        {
            get { return librosT; }
            set { librosT = value; }

        }

    }

}