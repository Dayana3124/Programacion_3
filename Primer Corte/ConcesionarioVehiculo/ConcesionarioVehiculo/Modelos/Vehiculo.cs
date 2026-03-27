using ConcesionarioVehiculo.Enunm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConcesionarioVehiculo.Modelos
{
    public abstract class Vehiculo
    {
        public int Id { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int Año { get; set; }
        public decimal PrecioBase { get; set; }
        public TipoCombustible Combustible { get; set; }
        public EstadoVehiculo Estado { get; set; }

        protected Vehiculo(int id, string marca, string modelo, int año,
                           decimal precioBase, TipoCombustible combustible,
                           EstadoVehiculo estado)
        {
            Id = id;
            Marca = marca;
            Modelo = modelo;
            Año = año;
            PrecioBase = precioBase;
            Combustible = combustible;
            Estado = estado;
        }

        public virtual void MostrarInformacion()
        {
            Console.WriteLine($"ID: {Id}");
            Console.WriteLine($"Marca: {Marca}");
            Console.WriteLine($"Modelo: {Modelo}");
            Console.WriteLine($"Año: {Año}");
            Console.WriteLine($"Precio base: {PrecioBase}");
            Console.WriteLine($"Combustible: {Combustible}");
            Console.WriteLine($"Estado: {Estado}");
        }
    }
}
