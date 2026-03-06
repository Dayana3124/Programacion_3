using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConcesionarioVehiculos.Modelo
{
    public class Camion : Vehiculo, Interfaces.IVendible    
    {
        public decimal CapacidadCarga { get; set; }
        public int NumeroEjes { get; set; } 

        public Camion(int id, string marca, string modelo, int año, decimal precioBase,
                      string combustible, string estado,
                      decimal capacidadCarga, int numeroEjes)
              : base(id, marca, modelo, año, precioBase, combustible, estado)
        {
            CapacidadCarga = capacidadCarga;
            NumeroEjes = numeroEjes;
        }   

        public override void MostrarInformacion()
        {
            Console.WriteLine("- - - - - - - -- - - - - - - - - - - - - -");
            Console.WriteLine("             INFORMACION CAMION           ");
            Console.WriteLine("- - - - - - - -- - - - - - - - - - - - - -");
            base.MostrarInformacion();
            Console.WriteLine($"Capacidad de carga: {CapacidadCarga} toneladas");
            Console.WriteLine($"Número de ejes: {NumeroEjes}");
        }   

        public decimal CalcularPrecioFinal()
        {
            decimal precioFinal = PrecioBase + (CapacidadCarga * 500);
            return precioFinal;
        }   

        public void GenerarFacturaVenta()
        {
            Console.WriteLine("- - - - - - - -- - - - - - - - - - - - - -");
            Console.WriteLine("             FACTURA CAMION           ");
            Console.WriteLine("- - - - - - - -- - - - - - - - - - - - - -");

            Console.WriteLine($"Vehículo: {Marca} - {Modelo}");
            Console.WriteLine($"Año: {Año}");
            Console.WriteLine($"Estado: {Estado}");
            Console.WriteLine($"Precio base: {PrecioBase}");    
            Console.WriteLine($"Precio final: {CalcularPrecioFinal()}");    
        }

        public decimal CalcularComisionVendedor()
        {
            return CalcularPrecioFinal() * 0.05m;
        }

    }
}
