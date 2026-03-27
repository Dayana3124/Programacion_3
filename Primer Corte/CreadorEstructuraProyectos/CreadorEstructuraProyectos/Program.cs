using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreadorEstructuraProyectos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -  ");
            Console.WriteLine("                     CREADOR ESTRUCTURA PROYECTOS              ");
            Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -  ");
            Console.Write("Ingrese el Nombre del proyecto: ");
            string nombreProyecto = Console.ReadLine();

            
            while (string.IsNullOrWhiteSpace(nombreProyecto))
            {
                Console.Write("Ingrese un nombre válido: ");
                nombreProyecto = Console.ReadLine();
            }

            
            Directory.CreateDirectory(nombreProyecto);

            string carpetaDocumentos = Path.Combine(nombreProyecto, "documentos");
            string carpetaImagenes = Path.Combine(nombreProyecto, "imagenes");
            string carpetaCodigo = Path.Combine(nombreProyecto, "codigo");

            Directory.CreateDirectory(carpetaDocumentos);
            Directory.CreateDirectory(carpetaImagenes);
            Directory.CreateDirectory(carpetaCodigo);

            
            Console.Write("Descripción del proyecto: ");
            string descripcion = Console.ReadLine();

            
            string rutaReadme = Path.Combine(carpetaDocumentos, "readme.txt");
            File.WriteAllText(rutaReadme, descripcion);

            
            string rutaAbsoluta = Path.GetFullPath(nombreProyecto);

            Console.WriteLine("\n>> Proyecto creado correctamente");
            Console.WriteLine("Ruta absoluta:");
            Console.WriteLine(rutaAbsoluta);
        }
    }
}


