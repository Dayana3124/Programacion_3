using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Diario_Personal_Bitácora
{
    internal class Program
    {
        static void Main(string[] args)
        {





        }

        public void AgregarEntrada()
        {
            Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - - - - - - ");
            Console.WriteLine("    BIENVENIDO A TU DIARIO PERSONAL CON BITACORA ");
            Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - - - - - -");
            Console.WriteLine(" Ingresa tu nombre: ");
            string nombre = Console.ReadLine();

            DateTime Fecha = DateTime.Now;



            Console.WriteLine($" Hola {nombre} ¿Cómo te sientes hoy? (Feliz, Triste, Enojado, etc.)");
            string Estado = Console.ReadLine();

            string Diario = "Diario.txt";
            string Linea = $"Fecha: {Fecha} - Nombre: {nombre} - Estado de ánimo: {Estado}";
            Console.WriteLine(" Tu entrada ha sido guardada en tu diario personal. ¡Gracias por compartir tus sentimientos! ");

        }

    }

}
           
        
    

