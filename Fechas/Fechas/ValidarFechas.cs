using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fechas
{
    public interface IValidarFechas
    {
        /// <summary>
        /// Prepara el mensaje previo..
        /// </summary>
        /// <param name="_dtHoy"></param>
        /// <param name="_dtInput"></param>
        /// <param name="_cTexto"></param>
        /// <returns></returns>
        string PrepararMensajePrevio(DateTime _dtHoy, DateTime _dtInput, string _cTexto);
    }
}
