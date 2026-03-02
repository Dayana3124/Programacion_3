using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trabajo.Interfaces;

namespace Trabajo.Modelos
{
    public class Podcast : IReproductor
    {
        public string Titulo { get; set; }
        public string Creador { get; set; }
        public string Episodio { get; set; }



        public void Play()
        {
            Console.WriteLine($"Reproduciendo el podcast: {Titulo} de {Creador}");
        }

        public void Stop()
        {
            Console.WriteLine($"Deteniendo el podcast: {Titulo} de {Creador}");
        }
    }

}
       

