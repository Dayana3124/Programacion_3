using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_POO.Actividad
{
    class Cuenta
    {

        public string titular { get; set; }
        public decimal saldoInicial { get; private set; }



        public Cuenta(string titular, decimal saldoInicial)
        {
            this.titular = titular;
            this.saldoInicial = saldoInicial;

        }


        public void ConsultarSaldo()
        {
            Console.WriteLine("              ");
            Console.WriteLine(" - - - - - - -  - - - - - - - -  - - - - - - -  - - - - - - -  ");
            Console.WriteLine("                       CONSULTAR SALDO                    ");
            Console.WriteLine(" - - - - - - -  - - - - - - - -  - - - - - - -  - - - - - - -  ");
            Console.WriteLine("              ");

            Console.WriteLine($" Su saldo actual de la cuenta a nombre de {titular} es: {saldoInicial:C}");
        }

        public void Depositar(decimal Cantidad)
        {



            if (Cantidad > 0)
            {
                saldoInicial += Cantidad;
                Console.WriteLine("              ");
                Console.WriteLine($" Se ha depositado {Cantidad:C} en la cuenta de {titular}.");

            }
            else
            {
                Console.WriteLine("              ");
                Console.WriteLine(" La cantidad a depositar debe ser mayor que cero.");

            }
        }

        public void Retirar(decimal Cantidad)
        {


            if (Cantidad > 0)
            {

                if (Cantidad <= saldoInicial)
                {
                    saldoInicial -= Cantidad;

                    Console.WriteLine("              ");
                    Console.WriteLine($" Se ha retirado {Cantidad:C} de la cuenta de {titular}.");
                }
                else
                {
                    Console.WriteLine("              ");
                    Console.WriteLine(" Fondos insuficientes para realizar el retiro.");
                }
            }
            else
            {
                Console.WriteLine("              ");
                Console.WriteLine(" La cantidad a retirar debe ser mayor que cero.");
            }
        }

        public static void Ejecutar()
        {
            Console.WriteLine("              ");
            Console.WriteLine(" - - - - - - -  - - - - - - - -  - - - - - - -  - - - - - - -  ");
            Console.WriteLine("                       CAJERO AUTOMATICO                    ");
            Console.WriteLine(" - - - - - - -  - - - - - - - -  - - - - - - -  - - - - - - -  ");
            Console.WriteLine("              ");

            Console.Write("Ingrese el nombre del titular: ");
            string titular = Console.ReadLine();

            Console.Write("Ingrese el saldo inicial: ");
            decimal SaldoInicial = decimal.Parse(Console.ReadLine());

            Cuenta cuenta = new Cuenta(titular, SaldoInicial);

            Console.Clear();

            string opcion = "";

           
               

                Console.WriteLine("              ");
                Console.WriteLine(" - - - - - - -  - - - - - - - -  - - - - - - -  - - - - - - -  ");
                Console.WriteLine($"                       Bienvenido {cuenta.titular}                  ");
                Console.WriteLine(" - - - - - - -  - - - - - - - -  - - - - - - -  - - - - - - -  ");
                Console.WriteLine("              ");

                Console.WriteLine("1 Consultar Saldo ");
                Console.WriteLine("2 Depositar ");
                Console.WriteLine("3 Retirar ");
                Console.WriteLine("4 Salir  ");
                Console.WriteLine("              ");

                Console.Write(" Ingrese una opción: ");
                opcion = Console.ReadLine();

                
                switch (opcion)
                {
                    case "1":
                        cuenta.ConsultarSaldo();
                       System.Threading.Thread.Sleep(3000);
                       break;
                    case "2":
                        Console.WriteLine("              ");
                        Console.WriteLine(" - - - - - - -  - - - - - - - -  - - - - - - -  - - - - - - -  ");
                        Console.WriteLine("                       DEPOSITAR                    ");
                        Console.WriteLine(" - - - - - - -  - - - - - - - -  - - - - - - -  - - - - - - -  ");
                        Console.WriteLine("              ");

                        Console.Write("Ingrese la cantidad a depositar: ");
                        decimal deposito = decimal.Parse(Console.ReadLine());
                        cuenta.Depositar(deposito);
                        System.Threading.Thread.Sleep(3000);
                        break;
                    case "3":
                        Console.WriteLine("              ");
                        Console.WriteLine(" - - - - - - -  - - - - - - - -  - - - - - - -  - - - - - - -  ");
                        Console.WriteLine("                       RETIRAR                    ");
                        Console.WriteLine(" - - - - - - -  - - - - - - - -  - - - - - - -  - - - - - - -  ");
                        Console.WriteLine("              ");

                        Console.Write("Ingrese la cantidad a retirar: ");
                        decimal retiro = decimal.Parse(Console.ReadLine());
                        cuenta.Retirar(retiro);
                        System.Threading.Thread.Sleep(3000);
                        break;
                    case "4":
                        Console.WriteLine("              ");
                        Console.WriteLine(" - - - - - - -  - - - - - - - -  - - - - - - -  - - - - - - -  ");
                        Console.WriteLine("                       SALIENDO DEL CAJERO AUTOMATICO...                   ");
                        Console.WriteLine(" - - - - - - -  - - - - - - - -  - - - - - - -  - - - - - - -  ");
                        Console.WriteLine("              ");
                        System.Threading.Thread.Sleep(3000);
                       break;
                    default:
                        Console.WriteLine("Opción no válida.");
                        break;
                }



            
        }
    }
}
        
        
        
        
       
