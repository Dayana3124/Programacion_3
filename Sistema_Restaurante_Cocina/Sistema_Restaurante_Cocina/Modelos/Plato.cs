using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sistema_Restaurante_Cocina.enums;


namespace Sistema_Restaurante_Cocina.Modelos
{
    public abstract class Plato
    {
        public int Id { get; set; } 
        public string Nombre { get; set; }  
        public string Descripcion { get; set; }    
        public decimal PrecioBase { get; set; }
        public TipoComida Comida { get; set; }
        public NivelDificultad Dificultad { get; set; }

        protected Plato(int id, string nombre, string descripcion, decimal precioBase, TipoComida comida, NivelDificultad dificultad)
        {
            Id = id;
            Nombre = nombre;
            Descripcion = descripcion;
            PrecioBase = precioBase;
            Comida = comida;
            Dificultad = dificultad;
        }

        public virtual void MostrarInformacionNutricional()
        {
            Console.WriteLine($"Nombre {Nombre}");
            Console.WriteLine($"ID: {Id}");
            Console.WriteLine($"Descripción: {Descripcion}");   
            Console.WriteLine($"Precio Base: {PrecioBase:C}");  
            Console.WriteLine($"Tipo de Comida: {Comida}"); 
            Console.WriteLine($"Nivel de Dificultad: {Dificultad}");    
        }
    }
}
