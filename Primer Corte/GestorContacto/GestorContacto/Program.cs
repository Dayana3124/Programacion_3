using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace GestorContacto
{
    internal class Program
    {

        static string Ruta = "contactos.csv";

        static void Main(string[] args)
        {
            int opcion;

            do
            {
                Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -  ");
                Console.WriteLine("                        GESTOR DE CONTACTOS            ");
                Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -  ");
                Menu();

                Console.Write("Seleccione: ");
                while (!int.TryParse(Console.ReadLine(), out opcion))
                {
                    Console.Write("Ingrese un número válido: ");
                }

                switch (opcion)
                {
                    case 1:
                        Contacto contacto = CrearContacto();
                        GuardarContacto(contacto);
                        break;
                    case 2:
                        ListarContactos();
                        break;
                    case 0:
                        Console.WriteLine("Saliendo...");
                        break;
                    default:
                        Console.WriteLine("Opción inválida");
                        break;
                }

            } while (opcion != 0);
        }

        
        static void Menu()
        {
            Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - - - -   ");
            Console.WriteLine("                MENU PRINCIPAL             ");
            Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - - - -   ");
            Console.WriteLine("1. Agregar contacto");
            Console.WriteLine("2. Listar contactos");
            Console.WriteLine("0. Salir");
        }

        
        public class Contacto
        {
            public string Nombre { get; set; }
            public string Telefono { get; set; }
            public string Correo { get; set; }

            public Contacto(string nombre, string telefono, string correo)
            {
                Nombre = nombre;
                Telefono = telefono;
                Correo = correo;
            }

            public string ToCSV()
            {
                return $"{Nombre};{Telefono};{Correo}";
            }
        }

        
        static Contacto CrearContacto()
        {
            Console.Write("Nombre: ");
            string nombre = Console.ReadLine();

            Console.Write("Teléfono: ");
            string telefono = Console.ReadLine();

            Console.Write("Correo: ");
            string correo = Console.ReadLine();

            
            correo = correo.Trim().ToLower();

            return new Contacto(nombre, telefono, correo);
        }

        static void GuardarContacto(Contacto c)
        {
            File.AppendAllText(Ruta, c.ToCSV() + Environment.NewLine);
            Console.WriteLine("\n>> Contacto guardado correctamente.");
        }

        static void ListarContactos()
        {
            if (!File.Exists(Ruta))
            {
                Console.WriteLine("No hay contactos guardados.");
                return;
            }

            string[] lineas = File.ReadAllLines(Ruta);

            if (lineas.Length == 0)
            {
                Console.WriteLine("No hay contactos registrados.");
                return;
            }

            Console.WriteLine("\n--- LISTA DE CONTACTOS ---");
            Console.WriteLine("NOMBRE\t\tTELÉFONO\t\tCORREO");

            foreach (var linea in lineas)
            {
                string[] datos = linea.Split(';');

                if (datos.Length == 3)
                {
                    Console.WriteLine($"{datos[0]}\t\t{datos[1]}\t\t{datos[2]}");
                }
            }
        }

    }
}
    

