using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trabajo.Modelos;
using Trabajo.Interfaces;

namespace Trabajo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("- - - - - - - - - - - - - - - --  - - - - - - - - -");
            Console.WriteLine(" Bienvenido al reproductor de música y podcasts! ");
            Console.WriteLine("- - - - - - - - - - - - - - - --  - - - - - - - - -");

            List<IReproductor> Playlist = new List<IReproductor>();

            bool continuar = true;

            while (continuar)
            {

                Console.WriteLine("- - - - - - - - - - - - - - - --  - - - - - - - - -");
                Console.WriteLine("                 MENU PRINCIPAL                    ");
                Console.WriteLine("- - - - - - - - - - - - - - - --  - - - - - - - - -");

                Console.WriteLine("1. Agregar Cancion ");
                Console.WriteLine("2. Agregar podcast");
                Console.WriteLine("3. Reproducir Playlist");
                Console.WriteLine("4. Detener Playlist");
                Console.WriteLine("5. Salir");

                Console.Write(" Ingrese una opcion ");
                string opcion = Console.ReadLine();
                switch (opcion)
                {
                    case "1":

                        Console.WriteLine("- - - - - - - - - - - - - - - --  - - - - - - - - -");
                        Console.WriteLine("                 AGREGAR CANCION                    ");
                        Console.WriteLine("- - - - - - - - - - - - - - - --  - - - - - - - - -");

                        Console.WriteLine("                          ");
                        Console.Write(" Ingrese el nombre de la canción: ");
                        string tituloCancion = Console.ReadLine();

                        Console.Write(" Ingrese el artista de la canción: ");
                        string artistaCancion = Console.ReadLine();

                        Console.Write(" Ingrese el almbun de la canción: ");
                        string albumCancion = Console.ReadLine();

                        Playlist.Add(new Cancion { Titulo = tituloCancion, Artista = artistaCancion, Album = albumCancion });
                        break;
                    case "2":

                        Console.WriteLine("- - - - - - - - - - - - - - - --  - - - - - - - - -");
                        Console.WriteLine("                 AGREGAR PODCAST                    ");
                        Console.WriteLine("- - - - - - - - - - - - - - - --  - - - - - - - - -");
                        Console.WriteLine("                          ");

                        Console.Write("Ingrese el título del podcast: ");
                        string tituloPodcast = Console.ReadLine();

                        Console.Write("Ingrese el nombre del creador: ");
                        string creadorPodcast = Console.ReadLine();

                        Console.Write("Ingrese el numero del episodio: ");
                        string episodioPodcast = Console.ReadLine();

                        Playlist.Add(new Podcast { Titulo = tituloPodcast, Creador = creadorPodcast, Episodio = episodioPodcast });

                        break;
                    case "3":
                        Console.WriteLine("- - - - - - - - - - - - - - - --  - - - - - - - - -");
                        Console.WriteLine("                 REPRODUCIENDO PODCAST                    ");
                        Console.WriteLine("- - - - - - - - - - - - - - - --  - - - - - - - - -");
                        Console.WriteLine("                          ");
                        foreach (var item in Playlist)
                        {
                            item.Play();
                        }
                        break;
                    case "4":
                        Console.WriteLine("- - - - - - - - - - - - - - - --  - - - - - - - - -");
                        Console.WriteLine("                 DETENER PLAYLIST                    ");
                        Console.WriteLine("- - - - - - - - - - - - - - - --  - - - - - - - - -");
                        Console.WriteLine("                          ");
                        foreach (var item in Playlist)
                        {
                            item.Stop();
                        }
                        break;
                    case "5":
                        continuar = false;
                        break;
                    default:
                        Console.WriteLine("Opción no válida, intente nuevamente.");
                        break;


                }

            }
        }
    }
}
