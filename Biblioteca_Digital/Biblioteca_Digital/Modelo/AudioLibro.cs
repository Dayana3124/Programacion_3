using Biblioteca_Digital.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca_Digital.Interfaces;    

namespace Biblioteca_Digital.Modelo
{
    internal class AudioLibro : MaterialBiblioteca , IPrestable
    {
        public TimeSpan Duracion { get; set; }
        public string Narrador { get; set; }

        public AudioLibro(int id, string titulo, string autor, int añoPublicacion, TipoCategoria categoria,
                          TimeSpan duracion, string narrador)
            : base(id, titulo, autor, añoPublicacion, categoria)
        {
            Duracion = duracion;
            Narrador = narrador;
        }

        public override void MostrarInformacion()
        {
            Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - - - - - - -");
            Console.WriteLine("             INFORMACION DEL AUDIOLIBRO      ");
            Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - - - - - - -");
            Console.WriteLine("                                         ");
            base.MostrarInformacion();
            Console.WriteLine($"Duración: {Duracion}");
            Console.WriteLine($"Narrador: {Narrador}");
        }   

        public DateTime CalcularFechaDevolucion()
        {
            return DateTime.Now.AddDays(10);
        }

        public void GenerarComprobantePrestramo()
        {
            Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - - - - - - -");
            Console.WriteLine("           COMPROBANTE PRESTAMO AUDIOLIBRO      ");
            Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - - - - - - -");
            Console.WriteLine("                                         ");
            Console.WriteLine($"Audiolibro: {Titulo}");
            Console.WriteLine($"Autor: {Autor}");
            Console.WriteLine($"Duración: {Duracion}");
            Console.WriteLine($"Narrador: {Narrador}");
            Console.WriteLine($"Fecha préstamo: {DateTime.Now: dd/mm/yyyy}");
            Console.WriteLine($"Fecha devolución: {CalcularFechaDevolucion(): dd/mm/yyyy}");
        }
        public decimal CalcularMultaPorRetraso(int diasRetraso)
        {
            return diasRetraso * 800;
        }
    }
}
