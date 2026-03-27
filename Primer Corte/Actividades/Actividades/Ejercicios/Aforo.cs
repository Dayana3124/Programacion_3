using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividades.Ejercicios
{
    internal class Aforo
    {
        public static void Ejecutar()
        {
            const int aforoMaximo = 50;
            Console.WriteLine(" - - - - - - - - - - - - ");
            Console.WriteLine("                          ");


            int ocupacionActual = 20;

            Console.Write("¿Cuántas personas quieren entrar a la discoteca? ");
            int personas;
            while (!int.TryParse(Console.ReadLine(), out personas) || personas <= 0)
            {
                Console.WriteLine("Error. Ingresa un número mayor que 0.");
                Console.Write("¿Cuántas personas quieren entrar a la discoteca? ");
            }

            Console.Clear();

            Console.WriteLine(" - - - - - - - - - - - - - - - - - - - ");
            Console.WriteLine("                          ");

            Console.WriteLine(" --- Control de seguridad --- ");
            Console.WriteLine("                          ");
            Console.WriteLine($"Aforo máximo permitido: {aforoMaximo} personas");
            Console.WriteLine($"Ocupación actual: {ocupacionActual} personas");
            Console.WriteLine($"Personas que desean entrar: {personas}");


            Console.WriteLine("                          ");




            if (ocupacionActual + personas <= aforoMaximo)
            {
                ocupacionActual += personas;
                Console.WriteLine("¡Bienvenidos! Disfruten de la noche.");
                Console.WriteLine($"Ahora hay {ocupacionActual} personas dentro.");

            }
            else
            {
                int exceso = (ocupacionActual + personas) - aforoMaximo;
                Console.WriteLine("Lo sentimos, no hay cupo suficiente.");
                Console.WriteLine($"Deben salir {exceso} personas para que puedan entrar.");

            }



        }
    }
}
