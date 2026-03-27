using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividades.Ejercicios
{
    internal class Semaforo
    {
        public static void Ejecutar()
        {
            Console.WriteLine(" - - - - - - - - - - - - - - - - - - - ");
            Console.WriteLine("                      ");
            Console.WriteLine(" Buenos dias querido usuario ");
            Console.Write(" Digite el color del semaforo (rojo, amarillo o verde) : ");

            string color = Console.ReadLine().ToLower();
            Console.Clear();

            Console.WriteLine(" - - - - - - - - - - - - - - - - - - - ");
            Console.WriteLine("                      ");

            switch (color)
            {
                case "rojo":
                    Console.WriteLine(" ¡Distensión! ");
                    break;
                case "amarillo":
                    Console.WriteLine("Prepárate para frenar");
                    break;
                case "verde":
                    Console.WriteLine("Sigue adelante");
                    break;
                default:
                    Console.WriteLine("Color no reconocido. Por favor, ingresa una opción válida rojo, amarillo o verde.");
                    break;
            }

        }
    }
}
