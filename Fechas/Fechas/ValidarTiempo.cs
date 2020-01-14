using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fechas
{
    public interface ValidarTiempo
    {
        void ValidarTiempo(TimeSpan _tsDiferencia,Propiedades propiedades);
    }
}
