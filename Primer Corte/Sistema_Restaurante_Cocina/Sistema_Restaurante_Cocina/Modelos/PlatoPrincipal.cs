using Sistema_Restaurante_Cocina.enums;
using Sistema_Restaurante_Cocina.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Restaurante_Cocina.Modelos
{
    public class PlatoPrincipal : Plato , IPreparable
    {
        string ProteinaPrincipal { get; set; }
        bool IncluyeGuarnicion { get; set; }


        public PlatoPrincipal(int id, string nombre, string descripcion, decimal precioBase, TipoComida comida, NivelDificultad dificultad, string proteinaPrincipal, bool incluyeGuarnicion)
           : base(id, nombre, descripcion, precioBase, comida, dificultad)
        {
            ProteinaPrincipal = proteinaPrincipal;
            IncluyeGuarnicion = incluyeGuarnicion;
        }

        public override void MostrarInformacionNutricional()
        {
            Console.WriteLine("- - - - - - - -- - - - - - - - - - - - - -");
            Console.WriteLine("       INFORMACION PLATO PRINCIPAL       ");
            Console.WriteLine("- - - - - - - -- - - - - - - - - - - - - -");
            Console.WriteLine("                                            ");
            base.MostrarInformacionNutricional();
            Console.WriteLine($"Proteína Principal: {ProteinaPrincipal}");  
            Console.WriteLine($"Incluye Guarnición: {(IncluyeGuarnicion ? "Sí" : "No")}");
              
        }    

        public TimeSpan CalcularTiempoPreparacion()
        {
            int minutos = IncluyeGuarnicion ? 30 : 20;
            return TimeSpan.FromMinutes(minutos);
        }

        public void GenerarOrdenCocina()
        {
            Console.WriteLine("- - - - - - - -- - - - - - - - - - - - - -");
            Console.WriteLine("     ORDEN DE COCINA PLATO PRINCIPAL     ");
            Console.WriteLine("- - - - - - - -- - - - - - - - - - - - - -");
            Console.WriteLine("                                            ");
            Console.WriteLine($"Plato Principal: {Nombre}");
            Console.WriteLine($"Proteína Principal: {ProteinaPrincipal}");
            Console.WriteLine($" Incluye Guarnición: {(IncluyeGuarnicion ? "Sí" : "No")}");
            Console.WriteLine($"Tiempo estimado: {CalcularTiempoPreparacion().TotalMinutes} minutos");

        }
        public decimal CalcularCostoTotal()
        {
            decimal costoGuarnicion = IncluyeGuarnicion ? 5.00m : 0.00m;  
            return PrecioBase + costoGuarnicion;
        }

    }
}
