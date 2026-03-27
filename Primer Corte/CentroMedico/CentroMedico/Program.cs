using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentroMedico
{
    internal class Program
    {
        static CitaMedica[] citas = new CitaMedica[5];
        static int contador = 0;
        static void Main(string[] args)
        {
            int opcion;

            do
            {
                Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -  ");
                Console.WriteLine("                        CENTRO MEDICO HEALTHTECH            ");
                Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -  ");
                Menu();
                Console.Write("Ingrese: ");
                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        AgendarCita();
                        break;
                    case 2:
                        VerFactura();
                        break;
                    case 3:
                        CambiarEspecialidad();
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
            Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - - - - -  ");
            Console.WriteLine("                        MENU PRINCIPAL            ");
            Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - - - - -  ");
            Console.WriteLine("1. Agendar Cita");
            Console.WriteLine("2. Ver Factura");
            Console.WriteLine("3. Cambiar Especialidad");
            Console.WriteLine("0. Salir");
        }

        
        public enum Especialidad
        {
            General,
            Pediatria,
            Odontologia
        }

       
        public interface IPrioritario
        {
            double AplicarDescuento();
        }

        
        public class CitaMedica : IPrioritario
        {
            public string Paciente { get; set; }
            public Especialidad EspecialidadCita { get; set; }
            public double CostoBase { get; set; }

            public CitaMedica(string paciente, Especialidad especialidad, double costoBase)
            {
                Paciente = paciente;
                EspecialidadCita = especialidad;
                CostoBase = costoBase;
            }

            public double AplicarDescuento()
            {
                if (EspecialidadCita == Especialidad.Pediatria)
                {
                    return CostoBase * 0.8; 
                }
                return CostoBase;
            }
        }

        
        static void AgendarCita()
        {
            if (contador >= 5)
            {
                Console.WriteLine("No hay más espacio.");
                return;
            }

            Console.Write("Nombre del paciente: ");
            string paciente = Console.ReadLine();

            Console.WriteLine("Especialidad:");
            Console.WriteLine("0. General");
            Console.WriteLine("1. Pediatría");
            Console.WriteLine("2. Odontología");

            int tipo;
            Console.Write("Seleccione: ");
            while (!int.TryParse(Console.ReadLine(), out tipo) || tipo < 0 || tipo > 2)
            {
                Console.Write("Error. Ingrese 0, 1 o 2: ");
            }

            double costo;
            Console.Write("Costo base: ");
            while (!double.TryParse(Console.ReadLine(), out costo))
            {
                Console.Write("Error. Ingrese un número válido: ");
            }

            citas[contador] = new CitaMedica(paciente, (Especialidad)tipo, costo);
            contador++;

            Console.WriteLine("Cita registrada correctamente.");
        }

        
        static void VerFactura()
        {
            if (contador == 0)
            {
                Console.WriteLine("No hay citas registradas.");
                return;
            }

            Console.Write("Nombre del paciente: ");
            string nombre = Console.ReadLine();

            foreach (var cita in citas)
            {
                if (cita != null && cita.Paciente.Equals(nombre, StringComparison.OrdinalIgnoreCase))
                {
                    double total = cita.AplicarDescuento();

                    Console.WriteLine("\n--- FACTURA ---");
                    Console.WriteLine($"Paciente: {cita.Paciente}");
                    Console.WriteLine($"Especialidad: {cita.EspecialidadCita.ToString().ToUpper()}");
                    Console.WriteLine($"Costo Original: ${cita.CostoBase}");

                    if (cita.EspecialidadCita == Especialidad.Pediatria)
                    {
                        Console.WriteLine($">> TOTAL A PAGAR (Con Desc. Pediatría): ${total}");
                    }
                    else
                    {
                        Console.WriteLine($">> TOTAL A PAGAR: ${total}");
                    }

                    return;
                }
            }

            Console.WriteLine("Paciente no encontrado.");
        }

        
        static void CambiarEspecialidad()
        {
            Console.Write("Nombre del paciente: ");
            string nombre = Console.ReadLine();

            foreach (var cita in citas)
            {
                if (cita != null && cita.Paciente.Equals(nombre, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("Nueva especialidad:");
                    Console.WriteLine("0. General");
                    Console.WriteLine("1. Pediatría");
                    Console.WriteLine("2. Odontología");

                    int nueva;
                    Console.Write("Seleccione: ");
                    while (!int.TryParse(Console.ReadLine(), out nueva) || nueva < 0 || nueva > 2)
                    {
                        Console.Write("Error. Ingrese 0, 1 o 2: ");
                    }

                    cita.EspecialidadCita = (Especialidad)nueva;

                    Console.WriteLine("Especialidad actualizada.");
                    return;
                }
            }

            Console.WriteLine("Paciente no encontrado.");
        }
    }
}
       
    

