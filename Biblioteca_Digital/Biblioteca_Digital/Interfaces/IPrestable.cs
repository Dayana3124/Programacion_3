using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_Digital.Interfaces
{
    public interface IPrestable
    {
        DateTime CalcularFechaDevolucion();
        void GenerarComprobantePrestramo();
        decimal CalcularMultaPorRetraso(int diasRetraso);
    }
}
