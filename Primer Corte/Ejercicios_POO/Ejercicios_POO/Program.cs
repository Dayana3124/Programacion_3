using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_POO
{
    internal class Program
    {
        static void Main(string[] args)
        {


            string opcion = "";

            while (opcion != "4") 
            {
                Console.Clear();

                Console.WriteLine("              ");
                Console.WriteLine(" - - - - - - -  - - - - - - - -  - - - - - - -  - - - - - - -  ");
                Console.WriteLine("                       MENU PRINCIPAL                     ");
                Console.WriteLine(" - - - - - - -  - - - - - - - -  - - - - - - -  - - - - - - -  ");
                Console.WriteLine("              ");

                Console.WriteLine("1 Ejecutar Cajero automatico ");
                Console.WriteLine("2 Control Inventario");
                Console.WriteLine("3 Calculadora");
                Console.WriteLine("4 Salir del sistema");
                Console.WriteLine("              ");

                Console.Write(" Ingrese una opción: ");
                opcion = Console.ReadLine();
                Console.Clear();    

                switch (opcion)
                {
                    case "1":
                        Actividad.Cuenta.Ejecutar();
                        break;

                    case "2":
                        Actividad.Producto.Ejecutar();
                        
                        break;

                    case "3":
                        Actividad.Estudiante.Ejecutar();

                        break;

                    case "4":
                        Console.WriteLine("              ");
                        Console.WriteLine(" - - - - - - -  - - - - - - - -  - - - - - - -  - - - - - - -  ");
                        Console.WriteLine("                  SALIENDO DEL SISTEMA...                    ");
                        Console.WriteLine(" - - - - - - -  - - - - - - - -  - - - - - - -  - - - - - - -  ");
                        Console.WriteLine("              ");
                        System.Threading.Thread.Sleep(3000);
                        break;

                    default:
                        Console.WriteLine("Opción no válida.");
                        Console.ReadKey();
                        break;
                }
            }
        }
    }
}
