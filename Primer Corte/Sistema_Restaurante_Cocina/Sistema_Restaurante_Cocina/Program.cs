using Sistema_Restaurante_Cocina.enums;
using Sistema_Restaurante_Cocina.Interface;
using Sistema_Restaurante_Cocina.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Sistema_Restaurante_Cocina
{
    public class Program
    {
        private static List<IPreparable> platos = new List<IPreparable>();
        private static int siguienteId = 1;
        static void Main(string[] args)
        {
            Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - - - - - - - - -");
            Console.WriteLine("   BIENVENIDO A NUESTRO SISTEMA DE RESTAURANTE ");
            Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - - - - - - - - -");
            Console.WriteLine("                                                         ");


          InicializarPlatosEjemplo();

            int opcion;
            do
            {
                MostrarMenu();
                Console.Write("Ingrese una opción: ");

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
            Console.WriteLine("        MENU PRINCIPAL SISTEMA RESTAURANTE Y COCINA       ");
            Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - - - - - - - - -");
            Console.WriteLine("1. Agregar Entrada");
            Console.WriteLine("2. Agregar Plato Principal");
            Console.WriteLine("3. Agregar Postre");
            Console.WriteLine("4. Mostrar Platos");
            Console.WriteLine("5. Realizar Pedido");
            Console.WriteLine("6. Salir");
        }

        private static void ProcesarOpcion(int opcion)
        {
            switch (opcion)
            {
                case 1: AgregarEntrada();
                    break;
                case 2: AgregarPlatoPrincipal();
                    break;
                case 3: AgregarPostre();
                    break;
                case 4: MostrarPlatos();
                    break;
                case 5: RealizarPedido();
                    break;

                case 6:
                    Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - - - - - - - - -");
                    Console.WriteLine("  ¡Gracias por usar el Sistema Restaurante y Cocina!" );
                    Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - - - - - - - - -"); 
                    break;
                default: Console.WriteLine("Opción inválida."); 
                    break;
            }
        }

        private static void AgregarEntrada()
        {
            Console.WriteLine("- - - - - - - -- - - - - - - - - - - - - -");
            Console.WriteLine("             AGREGAR ENTRADA      ");
            Console.WriteLine("- - - - - - - -- - - - - - - - - - - - - -");
            Console.WriteLine("                                            ");
            Console.Write("Nombre: ");
            string nombre = Console.ReadLine();
            Console.Write("ID: ");
            int id = int.Parse(Console.ReadLine());
            Console.Write("Descripción: ");
            string descripcion = Console.ReadLine();
            Console.Write("Precio: ");
            decimal precio = decimal.Parse(Console.ReadLine());
            Console.Write("Tipo de Cocina Vegetariana, Vegana, Carnivora, Mariscos, Mixta: ");
            TipoComida tipoCocina = (TipoComida)Enum.Parse(typeof(TipoComida), Console.ReadLine(), true);
            Console.Write("Dificultad Facil, Intermedio, Avanzado: ");
            NivelDificultad dificultad = (NivelDificultad)Enum.Parse(typeof(NivelDificultad), Console.ReadLine(), true);
            Console.Write("¿Requiere Refrigeración? (si/no): ");
            bool requiereRefrigeracion = Console.ReadLine().ToLower() == "si";
            Console.Write("Tiempo de Preparación (minutos): ");
            int tiempoPreparacion = int.Parse(Console.ReadLine());
            var nuevaEntrada = new Entrada(siguienteId++, nombre, descripcion, precio, tipoCocina, dificultad, requiereRefrigeracion, tiempoPreparacion);
            platos.Add(nuevaEntrada);
            Console.WriteLine("Entrada agregada exitosamente.");
        }

        private static void AgregarPlatoPrincipal()
        {
            Console.WriteLine("- - - - - - - -- - - - - - - - - - - - - -");
            Console.WriteLine("          AGREGAR PLATO PRINCIPAL       ");
            Console.WriteLine("- - - - - - - -- - - - - - - - - - - - - -");
            Console.WriteLine("                                            ");
            Console.Write("Nombre: ");  
            string nombre = Console.ReadLine(); 
            Console.Write("ID: ");
            int id = int.Parse(Console.ReadLine()); 
            Console.Write("Descripción: ");
            string descripcion = Console.ReadLine();
            Console.Write("Precio: ");
            decimal precio = decimal.Parse(Console.ReadLine());
            Console.Write("Tipo de Cocina Vegetariana, Vegana, Carnivora, Mariscos, Mixta: ");
            TipoComida tipoCocina = (TipoComida)Enum.Parse(typeof(TipoComida), Console.ReadLine(), true);
            Console.Write("Dificultad Facil, Intermedio, Avanzado: ");
            NivelDificultad dificultad = (NivelDificultad)Enum.Parse(typeof(NivelDificultad), Console.ReadLine(), true);
            Console.Write("Proteína Principal: ");
            string proteinaPrincipal = Console.ReadLine();
            Console.Write("¿Incluye Guarnición? (si/no): ");
            bool incluyeGuarnicion = Console.ReadLine().ToLower() == "si";
            var nuevoPlatoPrincipal = new PlatoPrincipal(siguienteId++, nombre, descripcion, precio, tipoCocina, dificultad, proteinaPrincipal, incluyeGuarnicion);
            platos.Add(nuevoPlatoPrincipal);
            Console.WriteLine("Plato Principal agregado exitosamente.");
        }

        private static void AgregarPostre()
        {
            Console.WriteLine("- - - - - - - -- - - - - - - - - - - - - -");
            Console.WriteLine("            AGREGAR POSTRE                ");
            Console.WriteLine("- - - - - - - -- - - - - - - - - - - - - -");
            Console.WriteLine("                                            ");
            Console.WriteLine("Nombre: ");
            string nombre = Console.ReadLine();
            Console.Write("ID: ");
            int id = int.Parse(Console.ReadLine()); 
            Console.Write("Descripción: ");
            string descripcion = Console.ReadLine();
            Console.Write("Precio: ");
            decimal precio = decimal.Parse(Console.ReadLine());
            Console.Write("Tipo de Cocina Vegetariana, Vegana, Carnivora, Mariscos, Mixta: ");
            TipoComida tipoCocina = (TipoComida)Enum.Parse(typeof(TipoComida), Console.ReadLine(), true);
            Console.Write("Dificultad Facil, Intermedio, Avanzado: ");
            NivelDificultad dificultad = (NivelDificultad)Enum.Parse(typeof(NivelDificultad), Console.ReadLine(), true);
            Console.Write("¿Contiene Lactosa? (si/no): ");
            bool contieneLactosa = Console.ReadLine().ToLower() == "si";
            Console.Write("Calorías por Porción: ");
            int caloriasPorPorcion = int.Parse(Console.ReadLine());
            var nuevoPostre = new Postre(siguienteId++, nombre, descripcion, precio, tipoCocina, dificultad, contieneLactosa, caloriasPorPorcion);
            platos.Add(nuevoPostre);
            Console.WriteLine("Postre agregado exitosamente.");
        }

        private static void MostrarPlatos()
        {
            Console.WriteLine("- - - - - - - -- - - - - - - - - - - - - -");
            Console.WriteLine("             MOSTRAR PLATOS             ");
            Console.WriteLine("- - - - - - - -- - - - - - - - - - - - - -");
            Console.WriteLine("                                            ");
            if (platos.Count == 0)
            {
                Console.WriteLine("No hay platos disponibles.");
                return;
            }

            for (int i = 0; i < platos.Count; i++)
            {
                Console.WriteLine($"\n- - - - Plato {i + 1} - - - -");
                ((Plato)platos[i]).MostrarInformacionNutricional();
            }

        }

        private static void RealizarPedido()
        {
            Console.WriteLine("- - - - - - - -- - - - - - - - - - - - - -");
            Console.WriteLine("             REALIZAR PEDIDOS             ");
            Console.WriteLine("- - - - - - - -- - - - - - - - - - - - - -");
            Console.WriteLine("                                            ");
            if (platos.Count == 0)
            {
                Console.WriteLine("No hay platos disponibles para pedir.");
                return;
            }

          
            MostrarPlatos();

            Console.Write("\nSeleccione el número del plato que desea pedir: ");
            int seleccion = int.Parse(Console.ReadLine());

            var pedido = platos[seleccion - 1];

            Console.WriteLine("\nORDEN DE COCINA GENERADA");
            pedido.GenerarOrdenCocina();

            Console.WriteLine($"\nCosto del plato: {pedido.CalcularCostoTotal()}");
        }

        


        private static void InicializarPlatosEjemplo()
        {
            var entrada1 = new Entrada(siguienteId++, "Ensalada César",
                "Ensalada fresca con aderezo", 12.00m, TipoComida.Vegetariana, NivelDificultad.Facil, true, 2);


            var entrada2 = new Entrada(siguienteId++, "Sopa de Tomate",
                "Sopa caliente de tomate", 10.00m, TipoComida.Vegana, NivelDificultad.Facil, false, 1);


            var platoPrincipal1 = new PlatoPrincipal(siguienteId++, "Pollo a la Parrilla",
                "Pechuga de pollo con especias", 25.00m, TipoComida.Carnivora, NivelDificultad.Intermedio, "Pollo", true);

            var platoPrincipal2 = new PlatoPrincipal(siguienteId++, "Salmón al Horno",
                "Salmón con limón y especias", 30.00m, TipoComida.Mariscos, NivelDificultad.Avanzado, "Salmón", false);


            var postre1 = new Postre(siguienteId++, "Cheesecake",
                "Pastel de queso con fresa", 15.00m, TipoComida.Vegetariana, NivelDificultad.Intermedio, true, 320);

            var postre2 = new Postre(siguienteId++, "Gelatina de Frutas",
                "Gelatina natural con frutas", 8.00m, TipoComida.Vegana, NivelDificultad.Facil, false, 120);


            platos.Add(entrada1);
            platos.Add(entrada2);
            platos.Add(platoPrincipal1);
            platos.Add(platoPrincipal2);
            platos.Add(postre1);
            platos.Add(postre2);
        }

    }
    
}
