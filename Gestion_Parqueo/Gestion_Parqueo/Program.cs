using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_Parqueo
{
    internal class Program
    {
        static Vehiculo[] parqueadero = new Vehiculo[5];
        static int contador = 0;
        static void Main(string[] args)
        {


            int opcion;

            do
            {
                Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -  ");
                Console.WriteLine("                        GESTION DE PARQUEADERO             ");
                Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -  ");
                Menu();
                Console.Write("Ingrese: ");
                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        RegistrarEntrada();
                        break;
                    case 2:
                        BuscarPorPlaca();
                        break;
                    case 3:
                        ListarTodo();
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
            Console.WriteLine("                 MENU PRINCIPAL              ");
            Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - - - - -  ");
            Console.WriteLine("1. Registrar Entrada");
            Console.WriteLine("2. Buscar por Placa");
            Console.WriteLine("3. Listar Todo");
            Console.WriteLine("0. Salir");
        }


        static void RegistrarEntrada()
        {
            if (contador >= 5)
            {
                Console.WriteLine("Parqueadero lleno.");
                return;
            }

            Console.Write("Placa: ");
            string placa = Console.ReadLine();

            Console.Write("Marca: ");
            string marca = Console.ReadLine();


            int tipo;
            Console.Write("Tipo (1: Carro, 2: Moto): ");
            while (!int.TryParse(Console.ReadLine(), out tipo) || (tipo != 1 && tipo != 2))
            {
                Console.Write("Error. Ingrese 1 para Carro o 2 para Moto: ");
            }

            if (tipo == 1)
            {
                int puertas;
                Console.Write("Número de puertas: ");
                while (!int.TryParse(Console.ReadLine(), out puertas))
                {
                    Console.Write("Error. Ingrese un número válido: ");
                }

                parqueadero[contador] = new Carro(placa, marca, puertas);
            }
            else if (tipo == 2)
            {
                int cilindraje;
                Console.WriteLine("Ingrese el cilindraje de la moto (ej: 150) ");
                Console.Write("Cilindraje: ");
                while (!int.TryParse(Console.ReadLine(), out cilindraje))
                {
                    Console.Write("Error. Ingrese un número válido: ");
                }

                parqueadero[contador] = new Moto(placa, marca, cilindraje);
            }

            contador++;
            Console.WriteLine("Vehículo registrado correctamente.");
        }


        static void BuscarPorPlaca()
        {
            Console.Write("Ingrese placa: ");
            string placaBuscar = Console.ReadLine();

            foreach (var v in parqueadero)
            {
                if (v != null && v.Placa.Equals(placaBuscar, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("\n--- VEHÍCULO ENCONTRADO ---");
                    Console.WriteLine($"Placa: {v.Placa}");
                    Console.WriteLine($"Marca: {v.Marca}");

                    int tarifa = ((ICobrable)v).CalcularTarifa(60);
                    Console.WriteLine($"Tarifa por 60 min: ${tarifa}");
                    return;
                }
            }

            Console.WriteLine("Vehículo no encontrado.");
        }

        static void ListarTodo()
        {
            if (contador == 0)
            {
                Console.WriteLine("\nNo hay vehículos registrados aún.");
                return;
            }

            Console.WriteLine("\n--- LISTA DE VEHÍCULOS ---");

            foreach (var v in parqueadero)
            {
                if (v != null)
                {
                    Console.WriteLine($"PLACA: {v.Placa.ToUpper()} | MARCA: {v.Marca.ToUpper()}");
                }
            }
        }


    }
}


public abstract class Vehiculo
{
    public string Placa { get; set; }
    public string Marca { get; set; }

    public Vehiculo(string placa, string marca)
    {
        Placa = placa;
        Marca = marca;
    }
}

public interface ICobrable
{
    int CalcularTarifa(int minutos);
}


public class Carro : Vehiculo, ICobrable
{
    public int NroPuertas { get; set; }

    public Carro(string placa, string marca, int nroPuertas)
        : base(placa, marca)
    {
        NroPuertas = nroPuertas;
    }

    public int CalcularTarifa(int minutos)
    {
        return minutos * 100;
    }
}

public class Moto : Vehiculo, ICobrable
{
    public int Cilindraje { get; set; }

    public Moto(string placa, string marca, int cilindraje)
        : base(placa, marca)
    {
        Cilindraje = cilindraje;
    }

    public int CalcularTarifa(int minutos)
    {
        return minutos * 50;
    }
}
            

