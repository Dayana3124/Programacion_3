using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividades.Ejercicios
{
    internal class Usuario
    {
        public static void Ejecutar()
        {
            Console.WriteLine(" - - - - - - - - - - - - - - - - - - - ");
            Console.WriteLine("                          ");

            Console.Write("Ingresa tu Nick: ");
            string nick = Console.ReadLine();




            int nivel;

            Console.Write("Ingresa tu nivel de experiencia (1-100): ");
            while (!int.TryParse(Console.ReadLine(), out nivel) || nivel < 1 || nivel > 100)
            {
                Console.WriteLine("Nivel inválido. Debes ingresar un número entre 1 y 100.");
                Console.Write("Ingresa tu nivel de experiencia (1-100): ");
            }

            if (nivel <= 25)
            {
                Console.WriteLine($"Estás en un nivel principiante ({nivel}).");
            }
            else if (nivel <= 50)
            {
                Console.WriteLine($"Estás en un nivel intermedio ({nivel}).");
            }
            else if (nivel <= 75)
            {
                Console.WriteLine($"Estás en un nivel avanzado ({nivel}).");
            }
            else
            {
                Console.WriteLine($"Felicidades, eres un experto ({nivel}).");
            }



            Console.Write("¿Tienes suscripción Premium? (sí/no): ");
            string respuesta = Console.ReadLine().Trim().ToLower();

            while (respuesta != "si" && respuesta != "sí" && respuesta != "no")
            {
                Console.WriteLine("Respuesta inválida. Por favor escribe 'sí' o 'no'.");
                Console.Write("¿Tienes suscripción Premium? (sí/no): ");
                respuesta = Console.ReadLine().Trim().ToLower();
            }

            bool premium = (respuesta == "si" || respuesta == "sí");

            Console.Clear();
            Console.WriteLine(" - - - - - - - - - - - - -  ");

            Console.WriteLine(" --- Bienvenido a nuestro sistema --- ");
            Console.WriteLine("                          ");
            Console.WriteLine($"¡Hola {nick}! ");

            switch (nivel)
            {
                case int n when (n <= 25):
                    Console.WriteLine($"Estás en un nivel principiante ({nivel}).");
                    if (premium)
                        Console.WriteLine("Gracias por ser usuario Premium.");
                    else
                        Console.WriteLine("Recuerda que con Premium tendrás más beneficios ¡Suscríbete!.");
                    break;

                case int n when (n <= 50):
                    Console.WriteLine($"Estás en un nivel intermedio ({nivel}).");
                    if (premium)
                        Console.WriteLine("¡Excelente! Disfruta tus ventajas Premium.");
                    else
                        Console.WriteLine("Con Premium podrías desbloquear más ventajas en este nivel.");
                    break;

                case int n when (n <= 75):
                    Console.WriteLine($"Estás en un nivel avanzado ({nivel}).");
                    if (premium)
                        Console.WriteLine("¡Eres un usuario Premium, felicidades!");
                    else
                        Console.WriteLine("Suscribete a premium, no desaproveches los beneficios");
                    break;

                default:
                    Console.WriteLine($"Felicidades, eres un experto ({nivel}).");
                    if (premium)
                        Console.WriteLine("¡Eres un experto Premium, impresionante!");
                    else
                        Console.WriteLine("Como experto, Premium te daría aún más ventajas exclusivas.");
                    break;
            }

        }
    }
}
 
