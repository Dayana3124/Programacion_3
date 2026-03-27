using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividades.Ejercicios
{
    internal class Correo
    {
        public static void Ejecutar()
        {
            Console.WriteLine(" - - - - - - - - - - - - - - - - - - - ");
            Console.WriteLine("                          ");

            Console.Write("Ingrese su nombre : ");
            string nombre = Console.ReadLine();

            Console.WriteLine("                          ");

            Console.Write("Ingrese su apellido : ");
            string apellido = Console.ReadLine();

            nombre = nombre.ToLower();
            apellido = apellido.ToLower();

            Console.Clear();
            Console.WriteLine(" - - - - - - - - - - - - - - - - - - - ");
            Console.WriteLine("                          ");

            string correo = $"{nombre}.{apellido}@empresa.com";

            Console.WriteLine("Su correo corporativo es: " + correo);
        }

    }
}
