using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Archivos_Bitacora_Personal
{
    class Program
    {
        static string archivo = "diario.txt";
        static string usuario;

        static void Main(string[] args)
        {
            Console.WriteLine("- - - - - - - - - - - - - - - - - - ");
            Console.WriteLine("  BIENVENIDO  TU BITACORA PERSONAL ");
            Console.WriteLine("- - - - - - - - - - - - - - - - - - ");
            Console.WriteLine("                                   ");


            Console.Write("Ingresa tu nombre: ");
            usuario = Console.ReadLine();

            Menu();
        }

        static void Menu()
        {
            int opcion;

            do
            {
                Console.WriteLine("\n--- MENÚ ---");
                Console.WriteLine("1. Agregar entrada");
                Console.WriteLine("2. Ver última entrada");
                Console.WriteLine("3. Ver todo el diario");
                Console.WriteLine("4. Salir");
                Console.Write("Elige una opción: ");

                opcion = Convert.ToInt32(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        EscribirEntrada();
                        break;

                    case 2:
                        VerUltimaEntrada();
                        break;

                    case 3:
                        MostrarTodo();
                        break;

                    case 4:
                        Console.WriteLine("Saliendo del programa...");
                        break;

                    default:
                        Console.WriteLine("Opción no válida.");
                        break;
                }

            } while (opcion != 4);
        }

        static void EscribirEntrada()
        {
            Console.Write("Escribe tu pensamiento o actividad del día :");
            string mensaje = Console.ReadLine();

            string fechaHora = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

            string entrada = $"[{fechaHora}] - {usuario}: {mensaje}\n";

            File.AppendAllText(archivo, entrada);

            Console.WriteLine("Entrada guardada correctamente.");
        }

        static void VerUltimaEntrada()
        {
            Console.WriteLine("\n--- Última entrada ---");

            if (File.Exists(archivo))
            {
                string[] lineas = File.ReadAllLines(archivo);

                if (lineas.Length > 0)
                {
                    Console.WriteLine(lineas[lineas.Length - 1]);
                }
                else
                {
                    Console.WriteLine("El diario está vacío.");
                }
            }
            else
            {
                Console.WriteLine("El archivo aún no existe.");
            }
        }

        static void MostrarTodo()
        {
            Console.WriteLine("\n--- Todo el diario ---");

            if (File.Exists(archivo))
            {
                string contenido = File.ReadAllText(archivo);
                Console.WriteLine(contenido);
            }
            else
            {
                Console.WriteLine("El diario está vacío.");
            }
        }
    }
}
