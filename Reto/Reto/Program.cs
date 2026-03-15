using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;

namespace Reto
{
    internal class Program
    {
        private static List<Amigo> amigos = new List<Amigo>();

        static void Main(string[] args)
        {
            Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - - - - - - - - -");
            Console.WriteLine("   BIENVENIDO A NUESTRO SISTEMA GESTOR DE CUMPLEAÑOS ");
            Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - - - - - - - - -");
            Console.WriteLine();

            int opcion;
            do
            {
                MostrarMenu();
                if (!int.TryParse(Console.ReadLine(), out opcion))
                {
                    Console.WriteLine("Debe ingresar un número válido.");
                    continue;
                }

                switch (opcion)
                {
                    case 1:
                        RegistrarAmigo();
                        break;
                    case 2:
                        MostrarAmigos();
                        break;
                    case 3:
                        GuardarEnArchivo();
                        Console.WriteLine("Datos guardados en cumpleaños.txt. Saliendo...");
                        break;
                    default:
                        Console.WriteLine("Opción no válida.");
                        break;
                }
            } while (opcion != 3);
        }

        public static void RegistrarAmigo()
        {
            Console.Write("Ingrese el nombre del amigo: ");
            string nombre = Console.ReadLine();

            Console.Write("Ingrese la fecha de nacimiento (dd/MM/yyyy): ");
            DateTime fechaNacimiento;
            while (!DateTime.TryParseExact(Console.ReadLine(), "dd/MM/yyyy", null,
                DateTimeStyles.None, out fechaNacimiento))
            {
                Console.WriteLine("Fecha inválida. Intente de nuevo (dd/MM/yyyy): ");
            }

            amigos.Add(new Amigo { Nombre = nombre, FechaNacimiento = fechaNacimiento });
            Console.WriteLine("Amigo registrado exitosamente.");
        }

        public static void MostrarAmigos()
        {
            Console.WriteLine("Lista de amigos:");
            if (amigos.Count == 0)
            {
                Console.WriteLine("No hay amigos registrados.");
            }
            else
            {
                foreach (var amigo in amigos)
                {
                    int dias = CalcularDiasParaCumpleaños(amigo.FechaNacimiento);
                    Console.WriteLine($"{amigo.Nombre} - Nació el {amigo.FechaNacimiento:dd/MM/yyyy} - Faltan {dias} días para su próximo cumpleaños");
                }
            }
        }

        public static void MostrarMenu()
        {
            Console.WriteLine("\n--- MENÚ PRINCIPAL ---");
            Console.WriteLine("1. Registrar Amigo");
            Console.WriteLine("2. Mostrar Amigos");
            Console.WriteLine("3. Guardar y Salir");
            Console.Write("Seleccione una opción: ");
        }

        
        public static int CalcularDiasParaCumpleaños(DateTime fechaNacimiento)
        {
            DateTime hoy = DateTime.Today;
            DateTime proximoCumple = new DateTime(hoy.Year, fechaNacimiento.Month, fechaNacimiento.Day);

            if (proximoCumple < hoy)
            {
                proximoCumple = proximoCumple.AddYears(1);
            }

            return (proximoCumple - hoy).Days;
        }

       
        public static void GuardarEnArchivo()
        {
            using (StreamWriter sw = new StreamWriter("cumpleaños.txt"))
            {
                foreach (var amigo in amigos)
                {
                    sw.WriteLine($"{amigo.Nombre};{amigo.FechaNacimiento:dd/MM/yyyy}");
                }
            }
        }
    }

    public class Amigo
    {
        public string Nombre { get; set; }
        public DateTime FechaNacimiento { get; set; }
    }
}
