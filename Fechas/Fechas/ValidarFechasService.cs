using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fechas
{
    public class ValidarFechasService: IValidarFechas
    {
        public string PrepararMensajePrevio(DateTime _dtHoy, DateTime _dtInput, string _cTexto)
        {
            string cMensajeGenerado = string.Empty;
            if (_dtHoy == _dtInput)
            {
                cMensajeGenerado = ConcatenarValores(_cTexto, "está ocurriendo en este momento");
            }
            else
            {
                if (_dtInput <= _dtHoy)
                {
                    cMensajeGenerado = ConcatenarValores(_cTexto, "ocurrió hace");
                }
                else
                {
                    cMensajeGenerado = ConcatenarValores(_cTexto, "ocurrirá dentro de"); 
                }
            }

            return cMensajeGenerado;
        }

        private string ConcatenarValores(string Evento, string Mensaje)
        {
            return $"{Evento} {Mensaje} ";
        }
    }
}
