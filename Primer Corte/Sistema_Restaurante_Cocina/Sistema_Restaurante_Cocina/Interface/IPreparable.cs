using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Restaurante_Cocina.Interface
{
    public interface IPreparable
    {
        TimeSpan CalcularTiempoPreparacion();
        void GenerarOrdenCocina();
        decimal CalcularCostoTotal();
    }
}
