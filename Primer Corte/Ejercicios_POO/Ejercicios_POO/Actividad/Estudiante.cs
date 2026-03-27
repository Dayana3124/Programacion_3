using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_POO.Actividad
{
    class Estudiante
    {
        public string nombre { get; set; }
        public string materia { get; set; }

        private double nota1;
        private double nota2;
        private double nota3;

        public Estudiante(string nombre, string materia, double nota1, double nota2, double nota3)
        {
            this.nombre = nombre;
            this.materia = materia;
            this.nota1 = nota1;
            this.nota2 = nota2;
            this.nota3 = nota3;
        }

        public double CalcularPromedio()
        {
            return (nota1 + nota2 + nota3) / 3;
        }

        public string EstadoFinal()
        {
            double promedio = CalcularPromedio();
            return promedio >= 3.0 ? "Aprobado" : "Reprobado";
        }

        public static void Ejecutar()
        {
            Console.WriteLine("              ");
            Console.WriteLine(" - - - - - - -  - - - - - - - -  - - - - - - -  - - - - - - -  ");
            Console.WriteLine("                       CALCULADORA DE CALIFICACIONES                   ");
            Console.WriteLine(" - - - - - - -  - - - - - - - -  - - - - - - -  - - - - - - -  ");
            Console.WriteLine("              ");

            Console.Write("Ingrese el nombre del estudiante: ");
            string nombre = Console.ReadLine();

            Console.Write("Ingrese la materia: ");
            string materia = Console.ReadLine();

            Console.Write("Ingrese la nota 1: ");
            double nota1 = double.Parse(Console.ReadLine());

            Console.Write("Ingrese la nota 2: ");
            double nota2 = double.Parse(Console.ReadLine());

            Console.Write("Ingrese la nota 3: ");
            double nota3 = double.Parse(Console.ReadLine());

            Estudiante estudiante = new Estudiante(nombre, materia, nota1, nota2, nota3);

            string opcion = "";

           
            Console.Clear();
            Console.WriteLine("              ");
            Console.WriteLine(" - - - - - - -  - - - - - - - -  - - - - - - -  - - - - - - -  ");
            Console.WriteLine("                       BIENVENIDO                   ");
            Console.WriteLine(" - - - - - - -  - - - - - - - -  - - - - - - -  - - - - - - -  ");

            Console.WriteLine($"Estudiante: {estudiante.nombre}");
            Console.WriteLine($"Materia: {estudiante.materia}");
            Console.WriteLine("              ");
           
           
            Console.WriteLine(" - - - - - - -  - - - - - - - -  - - - - - - -  - - - - - - -  ");
            Console.WriteLine("              ");
            Console.WriteLine("1. Calcular Promedio");
            Console.WriteLine("2. Ver Estado Final");
            Console.WriteLine("3. Salir");
            Console.WriteLine(" - - - - - - -  - - - - - - - -  - - - - - - -  - - - - - - -  ");

            Console.Write("Ingrese una opción: ");
                opcion = Console.ReadLine();

                Console.Clear();

                switch (opcion)
                {
                    case "1":
                    Console.WriteLine("              ");
                    Console.WriteLine(" - - - - - - -  - - - - - - - -  - - - - - - -  - - - - - - -  ");
                    Console.WriteLine("                       PROMEDIO                   ");
                    Console.WriteLine(" - - - - - - -  - - - - - - - -  - - - - - - -  - - - - - - -  ");
                    Console.WriteLine("              ");
                    Console.WriteLine($"El promedio es: {estudiante.CalcularPromedio():F2}");
                        System.Threading.Thread.Sleep(3000);
                        break;

                    case "2":
                    Console.WriteLine("              ");
                    Console.WriteLine(" - - - - - - -  - - - - - - - -  - - - - - - -  - - - - - - -  ");
                    Console.WriteLine("                       ESTADO FINAL                    ");
                    Console.WriteLine(" - - - - - - -  - - - - - - - -  - - - - - - -  - - - - - - -  ");
                    Console.WriteLine("              ");
                    Console.WriteLine($"El estudiante está: {estudiante.EstadoFinal()}");
                        System.Threading.Thread.Sleep(3000);
                        break;

                    case "3":
                    Console.WriteLine("              ");
                    Console.WriteLine(" - - - - - - -  - - - - - - - -  - - - - - - -  - - - - - - -  ");
                    Console.WriteLine("                     SALIENDO..                    ");
                    Console.WriteLine(" - - - - - - -  - - - - - - - -  - - - - - - -  - - - - - - -  ");
                    Console.WriteLine("              ");
                    System.Threading.Thread.Sleep(3000);
                        break;

                    default:
                        Console.WriteLine("Opción no válida.");
                        System.Threading.Thread.Sleep(3000);
                        break;
                }
            
        }
    }
}
    
