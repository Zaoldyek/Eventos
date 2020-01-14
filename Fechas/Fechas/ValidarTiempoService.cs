using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fechas
{
    class ValidarTiempoService : ValidarTiempo
    {
        public void ValidarTiempo(TimeSpan _tsDiferencia, Propiedades propiedades)
        {
            int iDay = _tsDiferencia.Days;
            int iHora = _tsDiferencia.Hours;
            int iMinutos = _tsDiferencia.Minutes;

            propiedades.cTexto = iDay + " Dias";

            if (iDay >= 30)
            {
                propiedades.iTiempo = iDay / 30;
                propiedades.cTexto = " Meses";
            }
            if (iDay == 0)
            {
                propiedades.iTiempo = iHora;
                propiedades.cTexto = " Horas";
            }
            if (iHora == 0 && iDay == 0)
            {
                propiedades.iTiempo = iMinutos;
                propiedades.cTexto = " Minutos";
            }
        }
    }
}
