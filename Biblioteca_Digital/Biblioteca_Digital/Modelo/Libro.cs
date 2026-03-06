using Biblioteca_Digital.Enum;

using Biblioteca_Digital.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_Digital.Modelo
{
    public class Libro : MaterialBiblioteca , IPrestable    
    {
        public int NumeroPaginas { get; set; }
        public string ISBN { get; set; }

        

        public Libro(int id, string titulo, string autor, int añoPublicacion, TipoCategoria categoria,
                    int numeroPaginas, string isbn)
           : base(id, titulo, autor, añoPublicacion, categoria)
        {
            NumeroPaginas = numeroPaginas;
            ISBN = isbn;

        }

        public override void MostrarInformacion()
        {
            Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - - - - - - -");
            Console.WriteLine("             INFORMACION DEL LIBRO       ");
            Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - - - - - - -");
            Console.WriteLine("                                         ");
            base.MostrarInformacion();
            Console.WriteLine($"Número de páginas: {NumeroPaginas}");
            Console.WriteLine($"ISBN: {ISBN}");
        }

        public DateTime CalcularFechaDevolucion()
        {
            return DateTime.Now.AddDays(10);
        }

        public void GenerarComprobantePrestramo()
        {
            Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - - - - - - -");
            Console.WriteLine("            COMPROBANTE PRESTAMO LIBRO       ");
            Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - - - - - - -");
            Console.WriteLine("                                         ");
            Console.WriteLine($"libro: {Titulo}");
            Console.WriteLine($"Autor: {Autor}");
            Console.WriteLine($"ISBN: {ISBN}");
            Console.WriteLine($"Fecha préstamo: {DateTime.Now: dd/mm/yyyy}");
            Console.WriteLine($"Fecha devolución: {CalcularFechaDevolucion()}: dd/mm/yyyy");
        }

        public decimal CalcularMultaPorRetraso(int diasRetraso)
        {
            return diasRetraso * 1000;
        }
    }
}
