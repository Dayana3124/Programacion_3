using Biblioteca_Digital.Enum;
using Biblioteca_Digital.Interfaces;
using Biblioteca_Digital.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_Digital
{
    internal class Program
    {
        private static List<IPrestable> materialesPrestables = new List<IPrestable>();
        private static int siguienteId = 1;
        static void Main(string[] args)
        {
            Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - - - - - - - - -");
            Console.WriteLine("   BIENVENIDO A NUESTRO SISTEMA DE BIBLIOTECA DIGITAL ");
            Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - - - - - - - - -");


           
            InicializarMaterialesEjemplo();

            int opcion;
            do
            {
                MostrarMenu();
                Console.Write("Ingreses una opción: ");

                if (int.TryParse(Console.ReadLine(), out opcion))
                {
                    ProcesarOpcion(opcion);
                }
                else
                {
                    Console.WriteLine("Opción inválida. Intente nuevamente.");
                }

                Console.WriteLine("\nPresione cualquier tecla para continuar...");
                Console.ReadKey();
                Console.Clear();

            } while (opcion != 6);
        }

        private static void MostrarMenu()
        {
            Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - - - - - - - - -");
            Console.WriteLine("                     MENU PRINCIPAL            ");
            Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - - - - - - - - -");
            Console.WriteLine("1. Agregar Libro");
            Console.WriteLine("2. Agregar Revista");
            Console.WriteLine("3. Agregar AudioLibro");
            Console.WriteLine("4. Mostrar Materiales");
            Console.WriteLine("5. Procesar Préstamos");
            Console.WriteLine("6. Salir");
        }

        private static void ProcesarOpcion(int opcion)
        {
            switch (opcion)
            {
                case 1:
                    AgregarLibro();
                    break;
                case 2:
                    AgregarRevista();
                    break;
                case 3:
                    AgregarAudioLibro();
                    break;
                case 4:
                    MostrarTodosMateriales();
                    break;
                case 5:
                    ProcesarPrestamo();
                    break;
                case 6:
                    Console.WriteLine("¡Gracias por usar el Sistema de Biblioteca Digital!");
                    break;
                default:
                    Console.WriteLine("Opción inválida.");
                    break;
            }
        }

        private static void AgregarLibro()
        {
            Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - - - - - -");
            Console.WriteLine("                 AGREGAR LIBRO                   ");
            Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - - - - - -");
            Console.Write("Ingreses el título: ");
            string titulo = Console.ReadLine();

            Console.Write("Ingrese el autor: ");
            string autor = Console.ReadLine();

            Console.Write("Ingrese el año de Publicación: ");
            int año = int.Parse(Console.ReadLine());

            Console.Write("Ingrese el número de Páginas: ");
            int paginas = int.Parse(Console.ReadLine());

            Console.Write("Ingrese el ISBN: ");
            string isbn = Console.ReadLine();

            TipoCategoria categoria = SeleccionarCategoria();

            var libro = new Libro(siguienteId++, titulo, autor, año, categoria, paginas, isbn);
            materialesPrestables.Add(libro);

            Console.WriteLine("Libro agregado exitosamente!");
        }

        private static void AgregarRevista()
        {
            Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - - - - - -");
            Console.WriteLine("                 AGREGAR REVISTA                  ");
            Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - - - - - -");
            Console.WriteLine("                                                  ");
            Console.Write("Título: ");
            string titulo = Console.ReadLine();

            Console.Write("Ingrese autor: ");
            string autor = Console.ReadLine();

            Console.Write("Ingrese año de Publicación: ");
            int año = int.Parse(Console.ReadLine());

            Console.Write("Ingrese número de Edición: ");
            int edicion = int.Parse(Console.ReadLine());

            Console.Write("P¿ingrese periodicidad: ");
            string periodicidad = Console.ReadLine();

            TipoCategoria categoria = SeleccionarCategoria();

            var revista = new Revista(siguienteId++, titulo, autor, año, categoria, edicion, periodicidad);
            materialesPrestables.Add(revista);

            Console.WriteLine("Revista agregada exitosamente!");
        }

        private static void AgregarAudioLibro()
        {
            Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - - - - - -");
            Console.WriteLine("                 AGREGAR AUDIOLIBRO                 ");
            Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - - - - - -");
            Console.WriteLine("                                                  ");
            Console.Write("Título: ");
            string titulo = Console.ReadLine();

            Console.Write("Ingrese autor: ");
            string autor = Console.ReadLine();

            Console.Write("Ingrese año de Publicación: ");
            int año = int.Parse(Console.ReadLine());

            Console.Write("Ingrese duración en horas: ");
            int horas = int.Parse(Console.ReadLine());

            Console.Write("Ingrese duración en minutos: ");
            int minutos = int.Parse(Console.ReadLine());

            Console.Write("Ingrese el narrador: ");
            string narrador = Console.ReadLine();

            TipoCategoria categoria = SeleccionarCategoria();

            var audioLibro = new AudioLibro(siguienteId++, titulo, autor, año, categoria,
                                          new TimeSpan(horas, minutos, 0), narrador);
            materialesPrestables.Add(audioLibro);

            Console.WriteLine("AudioLibro agregado exitosamente!");
        }

        private static TipoCategoria SeleccionarCategoria()
        {
            Console.WriteLine("\nSeleccione una categoría:");
            var categorias = System.Enum.GetValues(typeof(TipoCategoria));

            for (int i = 0; i < categorias.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {categorias.GetValue(i)}");
            }

            Console.Write("Opción: ");
            int opcion = int.Parse(Console.ReadLine()) - 1;

            return (TipoCategoria)categorias.GetValue(opcion);
        }

        private static void MostrarTodosMateriales()
        {
            Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - - - - - -");
            Console.WriteLine("                 MOSTRAR MATERIALES                  ");
            Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - - - - - -");
            Console.WriteLine("                                                  ");

            if (materialesPrestables.Count == 0)
            {
                Console.WriteLine("No hay materiales disponibles.");
                return;
            }

            for (int i = 0; i < materialesPrestables.Count; i++)
            {
                Console.WriteLine($"\n - - - -Material {i + 1} - - - - ");
                if (materialesPrestables[i] is MaterialBiblioteca material)
                {
                    material.MostrarInformacion();
                }
            }
        }

        private static void ProcesarPrestamo()
        {
            Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - - - - - -");
            Console.WriteLine("                 PROCESAR PRESTAMOS                 ");
            Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - - - - - -");
            Console.WriteLine("                                                  ");

            if (materialesPrestables.Count == 0)
            {
                Console.WriteLine("No hay materiales disponibles para préstamo.");
                return;
            }

            MostrarTodosMateriales();

            Console.Write("\nIngrese el número del material a prestar: ");
            if (int.TryParse(Console.ReadLine(), out int seleccion) &&
                seleccion >= 1 && seleccion <= materialesPrestables.Count)
            {
                var materialSeleccionado = materialesPrestables[seleccion - 1];

                Console.WriteLine("\n");
                materialSeleccionado.GenerarComprobantePrestramo();

                
                Console.Write("\n¿Desea simular días de retraso? (0 para no): ");
                if (int.TryParse(Console.ReadLine(), out int diasRetraso) && diasRetraso > 0)
                {
                    decimal multa = materialSeleccionado.CalcularMultaPorRetraso(diasRetraso);
                    Console.WriteLine($"Multa por {diasRetraso} días de retraso: ${multa:F2}");
                }
            }
            else
            {
                Console.WriteLine("Selección inválida.");
            }
        }

        private static void InicializarMaterialesEjemplo()
        {
            
            var libro1 = new Libro(siguienteId++, "Cien Años de Soledad", "Gabriel Garcia marquez", 1,
                                  TipoCategoria.Ficcion, 863, "978-62-876-415-7");

            var revista1 = new Revista(siguienteId++, "Revista Ciencia y Cultura", "VEquipo Editorial", 2024,
                                      TipoCategoria.Ciencia, 120, "Mensual");

            var audio1 = new AudioLibro(siguienteId++, "El Principito (Audiolibro)", "Antoine de Saint-Exupéry", 2023,
                                       TipoCategoria.Ficcion, new TimeSpan(3, 20, 0), "María González");

            materialesPrestables.Add(libro1);
            materialesPrestables.Add(revista1);
            materialesPrestables.Add(audio1);
        }
    }
   
}

