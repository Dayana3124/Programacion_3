using Biblioteca_Digital.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca_Digital.Interfaces;  

namespace Biblioteca_Digital.Modelo
{
    public class Revista : MaterialBiblioteca, IPrestable   
    {
        public int NumeroEdicion { get; set; }
        public string Periodicidad { get; set; }

        public Revista(int id, string titulo, string autor, int añoPublicacion, TipoCategoria categoria,
                       int numeroEdicion, string periodicidad)
            : base(id, titulo, autor, añoPublicacion, categoria)
        {
            NumeroEdicion = numeroEdicion;
            Periodicidad = periodicidad;
        }

        public override void MostrarInformacion()
        {
            Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - - - - - - -");
            Console.WriteLine("             INFORMACION DE LA REVISTA       ");
            Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - - - - - - -");
            Console.WriteLine("                                         ");
            base.MostrarInformacion();
            Console.WriteLine($"Número de edición: {NumeroEdicion}");
            Console.WriteLine($"Periodicidad: {Periodicidad}");
        }

        public DateTime CalcularFechaDevolucion()
        {
            return DateTime.Now.AddDays(7);
        }


        public void GenerarComprobantePrestramo()
        {
            Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - - - - - - -");
            Console.WriteLine("            COMPROBANTE PRESTAMO REVISTA       ");
            Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - - - - - - -");
            Console.WriteLine("                                         ");
            Console.WriteLine($"Revista: {Titulo}");
            Console.WriteLine($"Autor: {Autor}");
            Console.WriteLine($"Número de edición: {NumeroEdicion}");
            Console.WriteLine($"Periodicidad: {Periodicidad}");
            Console.WriteLine($"Fecha devolución: {CalcularFechaDevolucion()}");
        }

        public decimal CalcularMultaPorRetraso(int diasRetraso)
        {
            return diasRetraso * 500;
        }
    }
}
