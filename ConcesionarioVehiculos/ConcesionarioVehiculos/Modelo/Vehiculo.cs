using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConcesionarioVehiculos.Modelo
{
    public abstract class Vehiculo
    {
        public int Id { get; set; }
        public string Marca { get; set; }   
        public string Modelo    { get; set; }
        public int Año  { get; set; } 
        public decimal PrecioBase  { get; set; }
        public string Combustible { get; set; } 
        public string Estado { get; set; }  

        protected Vehiculo(int Id, string Marca, string modelo, int Año, decimal PrecioBase, string Combustible, string Estado)
        { 
            this.Id = Id;
            this.Marca = Marca;
            this.Modelo = modelo;
            this.Año = Año;
            this.PrecioBase = PrecioBase;
            this.Combustible = Combustible;
            this.Estado = Estado;   
        }


        public virtual void MostrarInformacion()
        {
            Console.WriteLine($"ID: {Id}");
            Console.WriteLine($"Marca: {Marca}");
            Console.WriteLine($"AModelo: {Modelo}");
            Console.WriteLine($"Año: {Año}");
            Console.WriteLine($"PrecioBase: {PrecioBase}");
            Console.WriteLine($"Combustible: {Combustible}");
            Console.WriteLine($"Estado: {Estado}");
        }
    }
}
