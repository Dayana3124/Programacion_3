using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace Parcial_Programacion_KarolVargas
{
    
    internal class Program
    {
        static string ruta = "pacientes.csv";

        static void Main(string[] args)
        {
            int opcion;

            do
            {
                Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -  ");
                Console.WriteLine("                    CONTROL VETERINARIA PETS             ");
                Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -  ");
                Menu();
                Console.Write("Ingrese: ");
                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        CrearPaciente();
                        break;
                    case 2:
                        Listar();
                        break;
                    case 3:
                        ModificarPaciente();
                        break;
                    case 4:
                        EliminarPaciente();
                        break;
                    case 5:
                        Console.WriteLine("Saliendo...");
                        break;
                    default:
                        Console.WriteLine("Opción inválida");
                        break;
                }

            } while (opcion != 5);
        }

        public enum Especie
        {
            Perro,
            Gato,
            Ave
        }

        public class Paciente
        {
            public int Id { get; set; }
            public string Nombre { get; set; }
            public int Edad { get; set; }
            public Especie Especie { get; set; }

            public override string ToString()
            {
                return $"{Id},{Nombre},{Edad},{Especie}";
            }

            public static Paciente FromCsv(string linea) // Método para convertir una línea CSV en un objeto Paciente
            {
                var datos = linea.Split(',');
                return new Paciente
                {
                    Id = int.Parse(datos[0]),
                    Nombre = datos[1],
                    Edad = int.Parse(datos[2]),
                    Especie = (Especie)Enum.Parse(typeof(Especie), datos[3])
                };
            }
        }

        //MENU
        public static void Menu()
        {
            Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - - -  ");
            Console.WriteLine("                MENU PRINCIPAL               ");
            Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - - -  ");

            Console.WriteLine("1. Crear paciente");
            Console.WriteLine("2. Listar pacientes");
            Console.WriteLine("3. Modificar paciente");
            Console.WriteLine("4. Eliminar paciente");
            Console.WriteLine("5. Salir");
        }

        //Crear paciente
        static void CrearPaciente()
        {
            Console.Write("Ingrese ID: ");
            int id = int.Parse(Console.ReadLine());

            Console.Write("Ingrese nombre: ");
            string nombre = Console.ReadLine();

            Console.Write("Ingrese edad: ");
            int edad = int.Parse(Console.ReadLine());

            Console.Write("Ingrese especie (Perro/Gato/Ave): ");
            string texto = Console.ReadLine();
            Especie especie = (Especie)Enum.Parse(typeof(Especie), texto, true);

            string linea = $"{id},{nombre},{edad},{especie}";
            File.AppendAllText(ruta, linea + Environment.NewLine); // Agrega la nueva línea al archivo  

            Console.WriteLine("Paciente guardado.");
        }

        //Listar pacientes  
        static void Listar()
        {
            if (!File.Exists(ruta))
            {
                Console.WriteLine("No hay pacientes registrados.");
                return;
            }

            string[] lineas = File.ReadAllLines(ruta); // Lee todas las líneas del archivo

            foreach (var linea in lineas)
            {
                Paciente p = Paciente.FromCsv(linea);
                Console.WriteLine($"ID: {p.Id} | Nombre: {p.Nombre} | Edad: {p.Edad} | Especie: {p.Especie}"); // Muestra los datos del paciente
            }
        }

        //Modificar paciente    
        static void ModificarPaciente()
        {
            if (!File.Exists(ruta))
            {
                Console.WriteLine("No hay datos.");
                return;
            }

            Console.Write("Ingrese ID a modificar: ");
            int id = int.Parse(Console.ReadLine());

            List<Paciente> pacientes = new List<Paciente>(); // Crea una lista para almacenar los pacientes

            foreach (var linea in File.ReadAllLines(ruta))
            {
                pacientes.Add(Paciente.FromCsv(linea)); // Agrega cada paciente a la lista a partir de las líneas del archivo
            }

            bool encontrado = false;

            foreach (var p in pacientes)
            {
                if (p.Id == id)
                {
                    Console.Write("Nuevo nombre: ");
                    p.Nombre = Console.ReadLine();

                    Console.Write("Nueva edad: ");
                    p.Edad = int.Parse(Console.ReadLine());

                    Console.Write("Nueva especie: ");
                    string texto = Console.ReadLine();
                    p.Especie = (Especie)Enum.Parse(typeof(Especie), texto, true);

                    encontrado = true;
                }
            }

            if (!encontrado)
            {
                Console.WriteLine("Paciente no encontrado.");
                return;
            }

            StreamWriter sw = new StreamWriter(ruta); // Crea un StreamWriter para escribir en el archivo   

            foreach (var p in pacientes)
            {
                sw.WriteLine(p.ToString());
            }

            sw.Close();

            Console.WriteLine("Paciente modificado.");
        }


        static void EliminarPaciente()
        {
            if (!File.Exists(ruta)) // Verifica si el archivo existe antes de intentar eliminar un paciente 
            {
                Console.WriteLine("No hay datos.");
                return;
            }

            Console.Write("Ingrese ID a eliminar: ");
            int id = int.Parse(Console.ReadLine());

            List<Paciente> pacientes = new List<Paciente>(); // Crea una lista para almacenar los pacientes 

            foreach (var linea in File.ReadAllLines(ruta))
            {
                pacientes.Add(Paciente.FromCsv(linea)); // Agrega cada paciente a la lista a partir de las líneas del archivo   
            }

            Paciente eliminar = null;

            foreach (var p in pacientes)
            {
                if (p.Id == id)
                {
                    eliminar = p;
                }
            }

            if (eliminar == null)
            {
                Console.WriteLine("Paciente no encontrado.");
                return;
            }

            pacientes.Remove(eliminar);

            StreamWriter sw = new StreamWriter(ruta);

            foreach (var p in pacientes)
            {
                sw.WriteLine(p.ToString());
            }

            sw.Close(); // Cierra el StreamWriter después de escribir en el archivo

            Console.WriteLine("Paciente eliminado.");
        }
    }
}