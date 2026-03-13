using Sistema_Restaurante_Cocina.enums;
using Sistema_Restaurante_Cocina.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Restaurante_Cocina.Modelos
{
    public class Postre : Plato , IPreparable
    {
        public bool ContieneLactosa { get; set; }
        public int CaloriasPorPorcion { get; set; }


        public Postre(int id, string nombre, string descripcion, decimal precioBase, TipoComida comida, NivelDificultad dificultad, bool contieneLactosa, int caloriasPorPorcion)
           : base(id, nombre, descripcion, precioBase, comida, dificultad)
        {
            ContieneLactosa = contieneLactosa;
            CaloriasPorPorcion = caloriasPorPorcion;
        }

        public override void MostrarInformacionNutricional()
        {
            Console.WriteLine("- - - - - - - -- - - - - - - - - - - - - -");
            Console.WriteLine("          INFORMACION POSTRE       ");
            Console.WriteLine("- - - - - - - -- - - - - - - - - - - - - -");
            Console.WriteLine("                                            ");
            base.MostrarInformacionNutricional();
            Console.WriteLine($"Contiene Lactosa: {(ContieneLactosa ? "Sí" : "No")}");
            Console.WriteLine($"Calorías por Porción: {CaloriasPorPorcion} kcal");

        }

        public decimal CalcularCostoTotal()
        {
            decimal costoLactosa = ContieneLactosa ? 2.00m : 0.00m;
            return PrecioBase + costoLactosa;

        }

        public TimeSpan CalcularTiempoPreparacion()
        {
            int minutos = ContieneLactosa ? 15 : 10;
            return TimeSpan.FromMinutes(minutos);
        }
         public void GenerarOrdenCocina()
        {
            Console.WriteLine("- - - - - - - -- - - - - - - - - - - - - -");
            Console.WriteLine("         ORDEN DE COCINA POSTRE     ");
            Console.WriteLine("- - - - - - - -- - - - - - - - - - - - - -");
            Console.WriteLine("                                            ");
            Console.WriteLine($"Postre: {Nombre}"); 
            Console.WriteLine($"Contiene Lactosa: {(ContieneLactosa ? "Sí" : "No")}");
            Console.WriteLine($"Calorías por Porción: {CaloriasPorPorcion} kcal");
        }

        
       
    }
}
