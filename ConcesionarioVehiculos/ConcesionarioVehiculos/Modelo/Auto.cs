using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConcesionarioVehiculos.Interfaces;

namespace ConcesionarioVehiculos.Modelo
{
    public class Auto : Vehiculo , IVendible    
    {
        public int NumeroPuertas { get; set; }  
        public bool TieneAireAcondicionado { get; set; }

        public Auto(int id, string marca, string modelo, int año, decimal precioBase,
                     string combustible, string estado,
                     int numeroPuertas, bool tieneAireAcondicionado)
             : base(id, marca, modelo, año, precioBase, combustible, estado)
        {
            NumeroPuertas = numeroPuertas;
            TieneAireAcondicionado = tieneAireAcondicionado;
        }

        public override void MostrarInformacion()
        {
            base.MostrarInformacion();
            Console.WriteLine($"Número de puertas: {NumeroPuertas}");
            Console.WriteLine($"Aire acondicionado: {(TieneAireAcondicionado ? "Sí" : "No")}");
        }

        public decimal CalcularPrecioFinal()
        {
            decimal precioFinal = PrecioBase + (TieneAireAcondicionado ? 2000 : 0);
            return precioFinal;
        }

        public void GenerarFacturaVenta()
        {
            Console.WriteLine("- - - - - - - -- - - - - - - - - - - - - -");
            Console.WriteLine("            FACTURA AUTO            ");
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
