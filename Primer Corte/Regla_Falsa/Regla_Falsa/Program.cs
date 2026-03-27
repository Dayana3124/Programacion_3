using NCalc;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Regla_Falsa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("========================================");
            Console.WriteLine("        METODO DE LA REGLA FALSA        ");
            Console.WriteLine("========================================\n");

            Console.WriteLine("Ejemplos válidos:");
            Console.WriteLine("x^2 - 2");
            Console.WriteLine("4*x^4 - 9*x^2 + 1");
            Console.WriteLine("arctan(x) + x - 1");
            Console.WriteLine("sqrt(x) - 2");
            Console.WriteLine("ln(x) + x^2 - 3");
            Console.WriteLine("sin(x) + cos(x)");
            Console.WriteLine("exp(x) - 3");

            Console.Write("\nIngrese la función: ");
            string funcion = Console.ReadLine().ToLower();

            double a = LeerDouble("Ingrese el valor de a: ");
            double b = LeerDouble("Ingrese el valor de b: ");

            if (Evaluar(funcion, a) * Evaluar(funcion, b) > 0)
            {
                Console.WriteLine("\nNo hay cambio de signo en el intervalo.");
                return;
            }
            
            Console.Write("\n¿Desea usar tolerancia? (si/no): ");
            bool usarTolerancia = Console.ReadLine().ToLower() == "si";

            double tolerancia = 0;
            if (usarTolerancia)
                tolerancia = LeerDouble("Ingrese la tolerancia (%): ");

            EjecutarReglaFalsa(funcion, a, b, usarTolerancia, tolerancia);

            Console.Write("\n¿Desea generar la gráfica en Excel? (si/no): ");
            if (Console.ReadLine().ToLower() == "si")
            {
                GenerarCSV(funcion, a, b);
            }


        }

        static double Evaluar(string f, double x)
        {
            try
            {
                f = f.ToLower();

                f = f.Replace("arctan", "atan");
                f = f.Replace("arcsin", "asin");
                f = f.Replace("arccos", "acos");
                f = f.Replace("ln", "log");

                f = Regex.Replace(f, @"(\w+)\^(\d+)", "Pow($1,$2)");

                NCalc.Expression exp = new NCalc.Expression(f);

                exp.Parameters["x"] = x;

                exp.EvaluateFunction += (name, args) =>
                {
                    double val = Convert.ToDouble(args.Parameters[0].Evaluate());

                    switch (name)
                    {
                        case "sin": args.Result = Math.Sin(val); break;
                        case "cos": args.Result = Math.Cos(val); break;
                        case "tan": args.Result = Math.Tan(val); break;

                        case "asin":
                            if (val < -1 || val > 1) throw new Exception();
                            args.Result = Math.Asin(val);
                            break;

                        case "acos":
                            if (val < -1 || val > 1) throw new Exception();
                            args.Result = Math.Acos(val);
                            break;

                        case "atan":
                            args.Result = Math.Atan(val);
                            break;

                        case "sqrt":
                            if (val < 0) throw new Exception();
                            args.Result = Math.Sqrt(val);
                            break;

                        case "log":
                            if (val <= 0) throw new Exception();
                            args.Result = Math.Log(val);
                            break;

                        case "log10":
                            if (val <= 0) throw new Exception();
                            args.Result = Math.Log10(val);
                            break;

                        case "exp":
                            args.Result = Math.Exp(val);
                            break;

                        case "pow":
                            double baseVal = Convert.ToDouble(args.Parameters[0].Evaluate());
                            double expVal = Convert.ToDouble(args.Parameters[1].Evaluate());
                            args.Result = Math.Pow(baseVal, expVal);
                            break;
                    }
                };

                return Math.Round(Convert.ToDouble(exp.Evaluate()), 4);
            }
            catch
            {
                Console.WriteLine("Error en la función.");
                return 0;
            }
        }

        static void EjecutarReglaFalsa(string f, double a, double b, bool usarTolerancia, double tolerancia)
        {
            double xi = 0, xiAnterior = 0;
            double error = 100;
            int iter = 1;

            Console.WriteLine("\ni   |    a    |    b    |   f(a)  |  f(b)  |   xi   |   f(xi) |  f(a)*f(xi) |   ea%");
            Console.WriteLine("---------------------------------------------------------------------------------------");

            while (true)
            {
                double fa = Evaluar(f, a);
                double fb = Evaluar(f, b);

                xi = Math.Round((a * fb - b * fa) / (fb - fa), 4);
                double fxi = Evaluar(f, xi);
                double producto = Math.Round(fa * fxi, 4);

                if (iter > 1)
                    error = Math.Round(Math.Abs((xi - xiAnterior) / xi) * 100, 4);

                Console.WriteLine($"{iter,2} | {a,7:F4} | {b,7:F4} | {fa,7:F4} | {fb,7:F4} | {xi,7:F4} | {fxi,7:F4} | {producto,11:F4} | {error,7:F4}");

                if (usarTolerancia)
                {
                    if (error <= tolerancia) break;
                }
                else
                {
                    if (Math.Abs(producto) <= 0.000001) break;
                }

                if (producto < 0)
                    b = xi;
                else
                    a = xi;

                xiAnterior = xi;
                iter++;

                if (iter > 100) break;
            }

            Console.WriteLine("\n========================================");
            Console.WriteLine($"Raíz aproximada: {xi:F4}");
            Console.WriteLine("========================================");
        }

        static double LeerDouble(string mensaje)
        {
            double valor;
            string input;

            Console.Write(mensaje);

            while (true)
            {
                input = Console.ReadLine();

                // Permite tanto coma como punto
                input = input.Replace(',', '.');

                if (double.TryParse(input, NumberStyles.Any, CultureInfo.InvariantCulture, out valor))
                    break;

                Console.Write("Valor inválido. Intente de nuevo: ");
            }

            return Math.Round(valor, 4);
        }


        static void GenerarCSV(string f, double a, double b)
        {
            string ruta = "grafica.csv";

            using (StreamWriter sw = new StreamWriter(ruta))
            {
                sw.WriteLine("x;f(x)");

                for (double x = a - 2; x <= b + 2; x += 0.1)
                {
                    double y = Evaluar(f, x);
                    sw.WriteLine($"{x};{y}");
                }
            }

            Console.WriteLine($"\nArchivo generado: {ruta}");
        }

    }
}
