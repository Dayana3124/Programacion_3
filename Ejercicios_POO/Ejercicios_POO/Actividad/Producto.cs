using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_POO.Actividad
{
    class Producto
    {
        public string nombre { get; set; }
        public string codigo { get; set; }
        public decimal precio { get; set; }
        public int CantidadStock { get; private set; }



        public Producto(string nombre, string codigo, decimal precio, int cantidadStock)
        {
            this.nombre = nombre;
            this.codigo = codigo;
            this.precio = precio;
            this.CantidadStock = cantidadStock;
        }

        public void AgregarStock(int cantidad)
        {


            if (cantidad > 0)
            {
                CantidadStock += cantidad;
                Console.WriteLine("              ");
                Console.WriteLine(" - - - - - - -  - - - - - - - -  - - - - - - -  - - - - - - -  ");
                Console.WriteLine($"Se agregaron {cantidad} unidades al producto {nombre}.");
                Console.WriteLine("                                             ");
                Console.WriteLine($"Stock actual: {CantidadStock} unidades.");
                Console.WriteLine(" - - - - - - -  - - - - - - - -  - - - - - - -  - - - - - - -  ");
            }
            else
            {
                Console.WriteLine("La cantidad debe ser mayor que cero.");
            }
        }


        public decimal VenderProducto(int cantidad)
        {
            if (cantidad > 0 && cantidad <= CantidadStock)
            {
                CantidadStock -= cantidad;
                decimal totalVenta = cantidad * precio;

                Console.WriteLine(" - - - - - - -  - - - - - - - -  - - - - - - -  - - - - - - -  ");
               
                Console.WriteLine($"Se vendieron {cantidad} unidades del producto {nombre}.");
                Console.WriteLine("              ");

                Console.WriteLine($"Total de la venta: {totalVenta:C}");
                Console.WriteLine("              ");
                Console.WriteLine($"Stock restante: {CantidadStock} unidades.");
               
                Console.WriteLine(" - - - - - - -  - - - - - - - -  - - - - - - -  - - - - - - -  ");

                return totalVenta;
            }
            else
            {
                Console.WriteLine("Cantidad inválida o stock insuficiente.");
                return 0;
            }
        }
        public void MostrarInfo()
        {
            Console.WriteLine("              ");
            Console.WriteLine(" - - - - - - -  - - - - - - - -  - - - - - - -  - - - - - - -  ");
            Console.WriteLine("                       INFORMACIÓN DEL PRODUCTO                    ");
            Console.WriteLine(" - - - - - - -  - - - - - - - -  - - - - - - -  - - - - - - -  ");
            Console.WriteLine("              ");

            Console.WriteLine($"Nombre: {nombre}");
            Console.WriteLine($"Código: {codigo}");
            Console.WriteLine($"Precio: {precio:C}");
            Console.WriteLine($"Stock disponible: {CantidadStock}");
        }




        public static void Ejecutar()
        {
            Console.Clear();

            string opcion = "";
            Console.WriteLine("              ");
            Console.WriteLine(" - - - - - - -  - - - - - - - -  - - - - - - -  - - - - - - -  ");
            Console.WriteLine("                  CONTROL DE INVENTARIO                   ");
            Console.WriteLine(" - - - - - - -  - - - - - - - -  - - - - - - -  - - - - - - -  ");
            Console.WriteLine("              ");

            Console.Write("Ingrese el nombre del producto: ");
            string nombre = Console.ReadLine();

            Console.Write("Ingrese el código del producto: ");
            string codigo = Console.ReadLine();

            Console.Write("Ingrese el precio del producto: ");
            decimal precio = decimal.Parse(Console.ReadLine());

            Console.Write("Ingrese la cantidad inicial en stock: ");
            int stock = int.Parse(Console.ReadLine());

            Producto producto = new Producto(nombre, codigo, precio, stock);

            Console.Clear();

            Console.WriteLine("              ");
            Console.WriteLine(" - - - - - - -  - - - - - - - -  - - - - - - -  - - - - - - -  ");
            Console.WriteLine($"                       Producto: {producto.nombre}                  ");
            Console.WriteLine(" - - - - - - -  - - - - - - - -  - - - - - - -  - - - - - - -  ");
            Console.WriteLine("              ");

            Console.WriteLine("1 Agregar Stock ");
            Console.WriteLine("2 Vender producto ");
            Console.WriteLine("3 Mostrar info ");
            Console.WriteLine("4 Salir  ");
            Console.WriteLine("              ");

            Console.Write("Ingrese una opción: ");
            opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                    Console.WriteLine("              ");
                    Console.WriteLine(" - - - - - - -  - - - - - - - -  - - - - - - -  - - - - - - -  ");
                    Console.WriteLine("                       AGREGAR STOCK                    ");
                    Console.WriteLine(" - - - - - - -  - - - - - - - -  - - - - - - -  - - - - - - -  ");
                    Console.WriteLine("              ");

                    Console.Write("Ingrese la cantidad a agregar: ");
                    int cantidad = int.Parse(Console.ReadLine());
                    producto.AgregarStock(cantidad);
                    System.Threading.Thread.Sleep(3000);
                    break;
                case "2":

                    Console.WriteLine("              ");
                    Console.WriteLine(" - - - - - - -  - - - - - - - -  - - - - - - -  - - - - - - -  ");
                    Console.WriteLine("                       VENDER PRODUCTO                    ");
                    Console.WriteLine(" - - - - - - -  - - - - - - - -  - - - - - - -  - - - - - - -  ");
                    Console.WriteLine("              ");

                    Console.Write("Ingrese la cantidad a vender: ");
                    int Cantidad = int.Parse(Console.ReadLine());
                    producto.VenderProducto(Cantidad);
                     System.Threading.Thread.Sleep(3000);
                    break;
                case "3":
                    producto.MostrarInfo();
                    break;
                case "4":
                    Console.WriteLine("              ");
                    Console.WriteLine(" - - - - - - -  - - - - - - - -  - - - - - - -  - - - - - - -  ");
                    Console.WriteLine("               SALIENDO DEL CONTROL DE INVENTARIO ...              ");
                    Console.WriteLine(" - - - - - - -  - - - - - - - -  - - - - - - -  - - - - - - -  ");
                    Console.WriteLine("              "); ;
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
