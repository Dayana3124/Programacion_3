using Sistema_Restaurante_Cocina.enums;
using Sistema_Restaurante_Cocina.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Restaurante_Cocina.Modelos
{
    public class Entrada : Plato  , IPreparable
    {
        public bool EsFria { get; set; }    
        public int Porciones { get; set; }


        public Entrada(int id, string nombre, string descripcion, decimal precioBase, TipoComida comida, NivelDificultad dificultad, bool esFria, int porciones)
          : base(id, nombre, descripcion, precioBase, comida, dificultad)
        {
            EsFria = esFria;
            Porciones = porciones;
        }

        public override void MostrarInformacionNutricional()
        {
            Console.WriteLine("- - - - - - - -- - - - - - - - - - - - - -");
            Console.WriteLine("          INFORMACION ENTRADA       ");
            Console.WriteLine("- - - - - - - -- - - - - - - - - - - - - -");
            Console.WriteLine("                                            ");
            base.MostrarInformacionNutricional();
            Console.WriteLine($"Es Fría: {(EsFria ? "Sí" : "No")}");
            Console.WriteLine($"Porciones: {Porciones}");
        }
            

        public TimeSpan CalcularTiempoPreparacion()
        {
            int minutos = EsFria ? 10 : 20;
            return TimeSpan.FromMinutes(minutos);
        }

        public void GenerarOrdenCocina()
        {
            Console.WriteLine("- - - - - - - -- - - - - - - - - - - - - -");
            Console.WriteLine("          ORDEN DE COCINA ENTRADA       ");
            Console.WriteLine("- - - - - - - -- - - - - - - - - - - - - -");
            Console.WriteLine("                                            ");
            Console.WriteLine($"Entrada: {Nombre}");
            Console.WriteLine($"Porciones: {Porciones}");
            Console.WriteLine($"Es Fría: {(EsFria ? "Sí" : "No")}");
            Console.WriteLine($"Tiempo estimado: {CalcularTiempoPreparacion().TotalMinutes} minutos");
        }

        

        public decimal CalcularCostoTotal()
        {
            
            return PrecioBase + Porciones;
        }
    }
}
