using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividades.Ejercicios
{
    internal class Calculadora
    {
        public static void Ejecutar()

        {
            Console.WriteLine(" - - - - - - - - - - - - - - - - - - - ");
            Console.WriteLine("                          ");

            Console.Write("Ingresa el total de la cuenta: ");
            decimal totalCuenta;
            while (!decimal.TryParse(Console.ReadLine(), out totalCuenta) || totalCuenta <= 0)
            {
                Console.WriteLine("Valor inválido. Ingresa un número mayor que 0.");
                Console.Write("Ingresa el total de la cuenta: ");
            }

            Console.Write("Ingresa el porcentaje de propina que desea pagar (10, 15 o 20): ");
            int porcentaje;
            while (!int.TryParse(Console.ReadLine(), out porcentaje) || (porcentaje != 10 && porcentaje != 15 && porcentaje != 20))
            {
                Console.WriteLine("Por favor, ingrese un valor dentro del rango 10, 15 o 20.");
                Console.Write("Ingresa el porcentaje de propina (10, 15 o 20): ");
            }


            decimal propina = totalCuenta * porcentaje / 100;
            decimal totalConPropina = totalCuenta + propina;

            Console.Clear();

            Console.WriteLine(" - - - Cuenta - - - ");
            Console.WriteLine($"Total de la cuenta: ${totalCuenta:N0}");
            Console.WriteLine($"Porcentaje de propina: {porcentaje}%");
            Console.WriteLine($"Propina: ${propina:N0}");
            Console.WriteLine($"Total a pagar: ${totalConPropina:N0}");

            if (totalConPropina > 100000)
            {
                Console.WriteLine("¡Gracias por tu generosidad! Ten un lindo dia");
            }
        }
    }
}
