using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fechas
{
    class ConvertirPositivoService:ConvertirPositivo
    {
        public int ConvertiraPositivo(int _iEntero)
        {
            return (Math.Abs(_iEntero));
        }
    }
}
