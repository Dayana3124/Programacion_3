using Biblioteca_Digital.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_Digital.Modelo
{
    public abstract class MaterialBiblioteca
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public int AñoPublicacion { get; set; }
        public TipoCategoria Categoria { get; set; }


        
        protected MaterialBiblioteca(int id, string titulo, string autor, int añoPublicacion, TipoCategoria categoria)
        {
            Id = id; 
            Titulo = titulo;
            Autor = autor; 
            AñoPublicacion = añoPublicacion; 
            Categoria = categoria;
        }


        public virtual void MostrarInformacion()
        {
            
            Console.WriteLine($"ID: {Id}");
            Console.WriteLine($"Título: {Titulo}");
            Console.WriteLine($"Autor: {Autor}");
            Console.WriteLine($"Año: {AñoPublicacion}");
            Console.WriteLine($"Categoría: {Categoria}");
        }

    }

}

