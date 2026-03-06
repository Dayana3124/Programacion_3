using ConcesionarioVehiculos.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConcesionarioVehiculos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - -");
            Console.WriteLine("     BIENVENIDO A NUESTROS SISTEMA  ");
            Console.WriteLine("      CONCESIONARIO DE VEHICULOS  ");
            Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - -");

            List<IVendible> vehiculos = new List<IVendible>();

            bool continuar = true;

            while (continuar)
            {
                Console.WriteLine("\n----------- MENU PRINCIPAL -----------");
                Console.WriteLine("1. Agregar Auto");
                Console.WriteLine("2. Agregar Motocicleta");
                Console.WriteLine("3. Agregar Camion");
                Console.WriteLine("4. Mostrar Vehiculos");
                Console.WriteLine("5. Generar Facturas");
                Console.WriteLine("6. Salir");
            }
        }
    }
}
