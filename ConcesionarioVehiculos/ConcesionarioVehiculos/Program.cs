using ConcesionarioVehiculos.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConcesionarioVehiculos.Enums;
using ConcesionarioVehiculos.Modelo;

namespace ConcesionarioVehiculos
{
    internal class Program
    {
        private static List<IVendible> vehiculos = new List<IVendible>();
        private static int siguienteId = 1;

        static void Main(string[] args)
        {
            Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - - - - - - - - -");
            Console.WriteLine("   BIENVENIDO A NUESTRO SISTEMA DE CONCESIONARIO ");
            Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - - - - - - - - -");


            InicializarVehiculosEjemplo();

            int opcion;
            do
            {
                MostrarMenu();
                Console.Write("Ingreses una opción: ");

                if (int.TryParse(Console.ReadLine(), out opcion))
                {
                    ProcesarOpcion(opcion);
                }
                else
                {
                    Console.WriteLine("Opción inválida. Intente nuevamente.");
                }

                Console.WriteLine("\nPresione cualquier tecla para continuar...");
                Console.ReadKey();
                Console.Clear();

            } while (opcion != 6);
        }

        private static void MostrarMenu()
        {
            Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - - - - - - - - -");
            Console.WriteLine("                     MENU PRINCIPAL            ");
            Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - - - - - - - - -");
            Console.WriteLine("1. Agregar Auto");
            Console.WriteLine("2. Agregar Motocicleta");
            Console.WriteLine("3. Agregar Camión");
            Console.WriteLine("4. Mostrar Vehículos");
            Console.WriteLine("5. Realizar Venta");
            Console.WriteLine("6. Salir");
        }

        private static void ProcesarOpcion(int opcion)
        {
            switch (opcion)
            {
                case 1: AgregarAuto(); break;
                case 2: AgregarMotocicleta(); break;
                case 3: AgregarCamion(); break;
                case 4: MostrarVehiculos(); break;
                case 5: RealizarVenta(); break;
                case 6:
                    Console.WriteLine("¡Gracias por usar el Sistema de Concesionario!");
                    break;
                default:
                    Console.WriteLine("Opción inválida.");
                    break;
            }
        }

       
        private static void AgregarAuto()
        {
            Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - - - - - -");
            Console.WriteLine("                 AGREGAR AUTO                   ");
            Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - - - - - -");

            Console.Write("Ingrese la Marca: ");
            string marca = Console.ReadLine();

            Console.Write("Ingrese el modelo: ");
            string modelo = Console.ReadLine();

            Console.Write("Ingrese el Año: ");
            int año = int.Parse(Console.ReadLine());

            Console.Write("Precio Base: ");
            decimal precio = decimal.Parse(Console.ReadLine());

            TipoCombustible combustible = SeleccionarCombustible();
            EstadoVehiculo estado = SeleccionarEstado();

            Console.Write("Número de puertas: ");
            int puertas = int.Parse(Console.ReadLine());

            Console.Write("¿Tiene aire acondicionado? (si/no): ");
            bool aire = Console.ReadLine().ToLower() == "si";

            var auto = new Auto(siguienteId++, marca, modelo, año, precio, combustible, estado, puertas, aire);
            vehiculos.Add(auto);

            Console.WriteLine("¡Auto agregado exitosamente!");
        }

       
        private static void AgregarMotocicleta()
        {
            Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - - - - - -");
            Console.WriteLine("              AGREGAR MOTOCICLETA                ");
            Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - - - - - -");

            Console.Write("Igrese Marca: ");
            string marca = Console.ReadLine();

            Console.Write("Ingrese Modelo: ");
            string modelo = Console.ReadLine();

            Console.Write("Ingrese Año: ");
            int año = int.Parse(Console.ReadLine());

            Console.Write("Ingrese Precio Base: ");
            decimal precio = decimal.Parse(Console.ReadLine());

            TipoCombustible combustible = SeleccionarCombustible();
            EstadoVehiculo estado = SeleccionarEstado();

            Console.Write("Cilindraje: ");
            int cilindraje = int.Parse(Console.ReadLine());

            Console.Write("¿Es deportiva? (si/no): ");
            bool deportiva = Console.ReadLine().ToLower() == "si";

            var moto = new Motocicleta(siguienteId++, marca, modelo, año, precio, combustible, estado, cilindraje, deportiva);
            vehiculos.Add(moto);

            Console.WriteLine("¡Motocicleta agregada exitosamente!");
        }

       
        private static void AgregarCamion()
        {
            Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - - - - - -");
            Console.WriteLine("                 AGREGAR CAMIÓN                  ");
            Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - - - - - -");

            Console.Write("Ingrese Marca: ");
            string marca = Console.ReadLine();

            Console.Write("Ingrese Modelo: ");
            string modelo = Console.ReadLine();

            Console.Write("Ingrese Año: ");
            int año = int.Parse(Console.ReadLine());

            Console.Write("Ingrese Precio Base: ");
            decimal precio = decimal.Parse(Console.ReadLine());

            TipoCombustible combustible = SeleccionarCombustible();
            EstadoVehiculo estado = SeleccionarEstado();

            Console.Write("Capacidad de carga (toneladas): ");
            decimal carga = decimal.Parse(Console.ReadLine());

            Console.Write("Número de ejes: ");
            int ejes = int.Parse(Console.ReadLine());

            var camion = new Camion(siguienteId++, marca, modelo, año, precio, combustible, estado, carga, ejes);
            vehiculos.Add(camion);

            Console.WriteLine("¡Camión agregado exitosamente!");
        }

       
        private static void MostrarVehiculos()
        {
            Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - - - - - -");
            Console.WriteLine("                 MOSTRAR VEHÍCULOS            ");
            Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - - - - - -");

            if (vehiculos.Count == 0)
            {
                Console.WriteLine("No hay vehículos disponibles.");
                return;
            }

            for (int i = 0; i < vehiculos.Count; i++)
            {
                Console.WriteLine($"\n- - - - Vehículo {i + 1} - - - -");
                ((Vehiculo)vehiculos[i]).MostrarInformacion(); 
            }
        }

        
        private static void RealizarVenta()
        {
            Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - - - - - -");
            Console.WriteLine("                    REALIZAR VENTA                ");
            Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - - - - - -");

            if (vehiculos.Count == 0)
            {
                Console.WriteLine("No hay vehículos disponibles para vender.");
                return;
            }

            MostrarVehiculos();

            Console.Write("\nIngrese el ID del vehículo a vender: ");
            int seleccion = int.Parse(Console.ReadLine());

            var vendido = vehiculos[seleccion - 1];

            Console.WriteLine("\nVENTA REALIZADA EXITOSAMENTE");
            vendido.GenerarFacturaVenta();

            vehiculos.RemoveAt(seleccion - 1);
        }

        
        private static TipoCombustible SeleccionarCombustible()
        {
            Console.WriteLine("\nTipo de combustible:");
            var valores = Enum.GetValues(typeof(TipoCombustible));
            for (int i = 0; i < valores.Length; i++)
                Console.WriteLine($"{i + 1}. {valores.GetValue(i)}");

            int op = int.Parse(Console.ReadLine()) - 1;
            return (TipoCombustible)valores.GetValue(op);
        }

        private static EstadoVehiculo SeleccionarEstado()
        {
            Console.WriteLine("\nEstado del vehículo:");
            var valores = Enum.GetValues(typeof(EstadoVehiculo));
            for (int i = 0; i < valores.Length; i++)
                Console.WriteLine($"{i + 1}. {valores.GetValue(i)}");

            int op = int.Parse(Console.ReadLine()) - 1;
            return (EstadoVehiculo)valores.GetValue(op);
        }

        private static void InicializarVehiculosEjemplo()
        {
            var auto1 = new Auto(siguienteId++, "Mazda", "CX-5", 2024, 28000,
                TipoCombustible.Gasolina, EstadoVehiculo.Nuevo, 4, true);

            var moto1 = new Motocicleta(siguienteId++, "Honda", "CBR500R", 2023, 12000,
                TipoCombustible.Gasolina, EstadoVehiculo.Nuevo, 500, true);

            var camion1 = new Camion(siguienteId++, "Mercedes", "Actros", 2022, 80000,
                TipoCombustible.Diesel, EstadoVehiculo.Nuevo, 18, 6);

            vehiculos.Add(auto1);
            vehiculos.Add(moto1);
            vehiculos.Add(camion1);
        }

    }
}
    
