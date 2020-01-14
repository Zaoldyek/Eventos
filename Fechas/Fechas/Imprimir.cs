using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fechas
{
    class Imprimir
    {
        public void imprimir( string _cTexto, Diferencia _diferencias)
        {
            _diferencias.CalcularTiempoRestante();
        }
    }
}
