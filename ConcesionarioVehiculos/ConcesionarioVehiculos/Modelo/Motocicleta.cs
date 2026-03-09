
using ConcesionarioVehiculos.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConcesionarioVehiculos.Modelo
{
    public class Motocicleta : Vehiculo, Interfaces.IVendible
    {
        public int Cilindraje { get; set; }
        public bool EsDeportiva { get; set; }


        public Motocicleta(int id, string marca, string modelo, int año, decimal precioBase,
                            TipoCombustible combustible, EstadoVehiculo estado,
                            int cilindraje, bool esDeportiva)
             : base(id, marca, modelo, año, precioBase, combustible, estado)
        {
            Cilindraje = cilindraje;
            EsDeportiva = esDeportiva;
        }

        public override void MostrarInformacion()
        {
            Console.WriteLine("- - - - - - - -- - - - - - - - - - - - - -");
            Console.WriteLine("         INFORMACION MOTOCICLETA            ");
            Console.WriteLine("- - - - - - - -- - - - - - - - - - - - - -");
            base.MostrarInformacion();
            Console.WriteLine($"Cilindraje: {Cilindraje} cc");
            Console.WriteLine($"Es deportiva: {(EsDeportiva ? "Sí" : "No")}");
        }

        public decimal CalcularPrecioFinal()
        {
            decimal precioFinal = PrecioBase + (EsDeportiva ? 1500 : 0);
            return precioFinal;
        }

        public void GenerarFacturaVenta()
        {
            Console.WriteLine("- - - - - - - -- - - - - - - - - - - - - -");
            Console.WriteLine("         FACTURA  MOTOCICLETA            ");
            Console.WriteLine("- - - - - - - -- - - - - - - - - - - - - -");

            Console.WriteLine($"Vehículo: {Marca} - {Modelo}");
            Console.WriteLine($"Precio base: {PrecioBase}");
            Console.WriteLine($"Precio final: {CalcularPrecioFinal()}");

        }

        public decimal CalcularComisionVendedor()
        {
            return CalcularPrecioFinal() * 0.05m;
        }   
    }
}