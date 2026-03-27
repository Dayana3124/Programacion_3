using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConcesionarioVehiculo.Interface
{
    public interface IVendible
    {
        decimal CalcularPrecioFinal();
        void GenerarFacturaVenta();
        decimal CalcularComisionVendedor();
    }
}

