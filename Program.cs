/*• Se requiere definir una lista de libros
disponibles en una biblioteca
*/
using Ejercicio4._1.clase;
using Ejercicio4._1.Interfaces;
using System;
using System.Collections.Generic;
namespace Ejercicio4._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Libros LibrosPersonalizados = new Libros();
            Librosconautografos Autores = new Librosconautografos(LibrosPersonalizados);
            Librosforrados Detallados = new Librosforrados(Autores);
            Console.WriteLine("*****los libros tienen las siguentes caracteristicas adicionales*****:\n ");
            Console.WriteLine(Detallados.obtenerDescripcion());

            libros_de_terror tipodelibro1 = new libros_de_terror("Frankesnstein o el moderno Prometeo");
            libros_de_terror tipodelibro2 = new libros_de_terror("El fantasma de la ópera");
            libros_de_terror tipodelibro3 = new libros_de_terror("El exorcista ");
            ///////////////
            libros_de_comedia tipodelibro4 = new libros_de_comedia("Cuentos sin plumas");
            libros_de_comedia tipodelibro5 = new libros_de_comedia("Cuentos sin plumas");
            libros_de_comedia tipodelibro6 = new libros_de_comedia(" La conjura de los necios");
            /////////////////
            libros_educativo tipodelibro7 = new libros_educativo("Nuevas tecnologías aplicadas a la educación");
            libros_educativo tipodelibro8 = new libros_educativo("rEDUvolution. Hacer la revolución en la educación ");
            libros_educativo tipodelibro9 = new libros_educativo("Todos los niños pueden ser Einstein: un método eficaz para motivar la inteligencia");
            ////////////////////////////

            singleton.Instancia.LibrosT = new List<libros_de_terror>();
            singleton.Instancia.LibrosT.Add(tipodelibro1);
            singleton.Instancia.LibrosT.Add(tipodelibro2);
            singleton.Instancia.LibrosT.Add(tipodelibro3);
            ////////////////////
            singleton.Instancia.LibrosC = new List<libros_de_comedia>();
            singleton.Instancia.LibrosC.Add(tipodelibro4);
            singleton.Instancia.LibrosC.Add(tipodelibro5);
            singleton.Instancia.LibrosC.Add(tipodelibro6);
            ////////////////////
            singleton.Instancia.Libros = new List<libros_educativo>();
            singleton.Instancia.Libros.Add(tipodelibro7);
            singleton.Instancia.Libros.Add(tipodelibro8);
            singleton.Instancia.Libros.Add(tipodelibro9);

            Console.WriteLine("**************BIBLIOTECA************\n" + "******libros disponibles*****");

            foreach (libros_de_terror item in singleton.Instancia.LibrosT)
            {
                Console.WriteLine(item.Mostrar());
            }



            //////////////////////////////
            foreach (libros_de_comedia item1 in singleton.Instancia.LibrosC)
            {
                Console.WriteLine(item1.Mostrar());
            }
            /////////////////////////

            foreach (libros_educativo item2 in singleton.Instancia.Libros)
            {
                Console.WriteLine(item2.Mostrar());
            }
            Console.ReadKey();


        }
    }
}

