using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial_KarolVargas_2punto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -");
            Console.WriteLine("                FINANCIAMIENTO AUTOYA");
            Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -");

            Console.Write("Ingrese el valor del vehículo: ");
            double valor = double.Parse(Console.ReadLine());

            Console.Write("Ingrese el interés mensual (%): ");
            double interes = double.Parse(Console.ReadLine()) / 100;

            Console.Write("Ingrese la cantidad de cuotas: ");
            int cuotas = int.Parse(Console.ReadLine());

            double saldo = valor;

            
            double cuota = valor * (interes * Math.Pow(1 + interes, cuotas)) /
                           (Math.Pow(1 + interes, cuotas) - 1); // Fórmula de amortización  


            Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -");
            Console.WriteLine("                           TABLA             ");
            Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -");

            Console.WriteLine("Mes\tFecha Pago\tCapital\t\tInterés\t\tSaldo");

            DateTime fecha = DateTime.Today;

            double totalIntereses = 0;
            double totalPagado = 0;

            
        }
    }
}




        



      

