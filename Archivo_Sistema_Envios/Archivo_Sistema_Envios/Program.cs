using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;    

namespace Archivo_Sistema_Envios
{
    internal class Program
    {
        static string ruta = "envios.csv";

        static void Main(string[] args)
        {
            int opcion;

            do
            {
                Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -  ");
                Console.WriteLine("                          SISTEMA GLOBALSHIP              ");
                Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -  ");
                Menu();
                Console.Write("Ingrese: ");
                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        CrearEnvio();
                        break;
                    case 2:
                        ReporteCarga();
                        break;
                    case 3:
                        BuscarPorGuia();
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

        public class Paquete
        {
            public int Guia { get; set; }
            public string Destinatario { get; set; }
            public double Peso { get; set; }
            public Tipo TipoEnvio { get; set; }

            public Paquete(int guia, string destinatario, double peso, Tipo tipoEnvio)
            {
                Guia = guia;
                Destinatario = destinatario;
                Peso = peso;
                TipoEnvio = tipoEnvio;
            }
        }

        public enum Tipo
        {
            Nacional,
            Internacional
        }

       
        static void Menu()
        {
            Console.WriteLine("- - - - - - - - - - - - - - - - - - ");
            Console.WriteLine("          MENU PRINCIPAL           "); 
            Console.WriteLine("- - - - - - - - - - - - - - - - - - ");
            Console.WriteLine("1. Agregar Nuevo Envío");
            Console.WriteLine("2. Ver Peso Total");
            Console.WriteLine("3. Buscar por Guía");
            Console.WriteLine("0. Salir");
        }

        
        static void CrearEnvio()
        {
            Console.Write("Ingrese Guía: ");
            int guia = int.Parse(Console.ReadLine());

            Console.Write("Destinatario: ");
            string destinatario = Console.ReadLine();

            Console.Write("Peso (kg): ");
            double peso = double.Parse(Console.ReadLine());

            Console.Write("Tipo (0: Nacional, 1: Internacional): ");
            int tipo = int.Parse(Console.ReadLine());

            Paquete paquete = new Paquete(guia, destinatario, peso, (Tipo)tipo);

            
            string linea = $"{paquete.Guia};{paquete.Destinatario};{paquete.Peso};{paquete.TipoEnvio}";
            File.AppendAllText(ruta, linea + Environment.NewLine);

            Console.WriteLine(" ¡ENVÍO GUARDADO EN ARCHIVO! ");
        }

       
        static void ReporteCarga()
        {
            if (!File.Exists(ruta))
            {
                Console.WriteLine("No hay datos.");
                return;
            }

            string[] lineas = File.ReadAllLines(ruta);
            double total = 0;

            foreach (var linea in lineas)
            {
                string[] datos = linea.Split(';');
                double peso = double.Parse(datos[2]);
                total += peso;
            }

            Console.WriteLine($"Peso total: {total} kg");
        }

        
        static void BuscarPorGuia()
        {
            if (!File.Exists(ruta))
            {
                Console.WriteLine("No hay datos.");
                return;
            }

            Console.Write("Ingrese la guía a buscar: ");
            int guiaBuscar = int.Parse(Console.ReadLine());

            string[] lineas = File.ReadAllLines(ruta);
            bool encontrado = false;

            foreach (var linea in lineas)
            {
                string[] datos = linea.Split(';');
                int guia = int.Parse(datos[0]);

                if (guia == guiaBuscar)
                {
                    Console.WriteLine("\n--- PAQUETE ENCONTRADO ---");
                    Console.WriteLine($"Guía: {datos[0]}");
                    Console.WriteLine($"Destinatario: {datos[1]}");
                    Console.WriteLine($"Peso: {datos[2]} kg");
                    Console.WriteLine($"Tipo: {datos[3]}");
                    encontrado = true;
                }
            }

            if (!encontrado)
            {
                Console.WriteLine("No se encontró el paquete.");
            }
        }
    }
}
