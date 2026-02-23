using Actividades.Ejercicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividades
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int opcion;
            do
            {
                Console.Clear();

                Console.WriteLine(" - - - - - - - - - - - - - - - - - - - ");
                Console.WriteLine("                          ");

                Console.WriteLine("===== MENÚ PRINCIPAL =====");
                Console.WriteLine("1. Ejecutar Usuario");
                Console.WriteLine("2. Ejecutar Calculadora");
                Console.WriteLine("3. Ejecutar Aforo");
                Console.WriteLine("4. Ejecutar Correo");
                Console.WriteLine("5. Ejecutar Semáforo");
                Console.WriteLine("0. Salir");
                Console.Write("Selecciona una opción: ");

                if (!int.TryParse(Console.ReadLine(), out opcion))
                {
                    opcion = -1;
                }
                Console.Clear();

                switch (opcion)
                {
                    case 1:
                        Usuario.Ejecutar();
                        Console.WriteLine("\nPresiona cualquier tecla para volver al menú...");
                        Console.ReadKey();
                        break;

                    case 2:
                        Calculadora.Ejecutar();
                        Console.WriteLine("\nPresiona cualquier tecla para volver al menú...");
                        Console.ReadKey();
                        break;

                    case 3:
                        Aforo.Ejecutar();
                        Console.WriteLine("\nPresiona cualquier tecla para volver al menú...");
                        Console.ReadKey();
                        break;

                    case 4:
                        Correo.Ejecutar();
                        Console.WriteLine("\nPresiona cualquier tecla para volver al menú...");
                        Console.ReadKey();
                        break;

                    case 5:
                        Semaforo.Ejecutar();
                        Console.WriteLine("\nPresiona cualquier tecla para volver al menú...");
                        Console.ReadKey();
                        break;

                    case 0:
                        Console.WriteLine("Saliendo del programa...");
                        break;

                    default:
                        Console.WriteLine("Opción inválida. Intenta de nuevo.");
                        Console.ReadKey();
                        break;
                }

            } while (opcion != 0);
        }
        
    }
}

