using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fechas
{
    public class ValidarTiempoService : ValidarTiempo
    {
        public void PrepararMensajePosterior(TimeSpan _tsDiferencia, Propiedades propiedades,ConvertirPositivo convertirPositivo)
        {
            int iDay = convertirPositivo.ConvertiraPositivo(_tsDiferencia.Days);
            int iHora = convertirPositivo.ConvertiraPositivo(_tsDiferencia.Hours);
            int iMinutos = convertirPositivo.ConvertiraPositivo(_tsDiferencia.Minutes);

            AsignarValores(iDay, "Días",propiedades);

            if (iDay >= 30)
            {
                AsignarValores((iDay / 30), "Meses", propiedades);
            }
            else
            {
                if (iDay == 0)
                {
                    AsignarValores(iHora, "Horas", propiedades);
                }
                if (iHora == 0 && iDay == 0)
                {
                    AsignarValores(iMinutos, "Minutos", propiedades);
                }
            }
        }

        private void AsignarValores(int _iTiempo, string _cMensaje, Propiedades _lPropiedad)
        {
            _lPropiedad.iTiempo = _iTiempo;
            _lPropiedad.cTexto = $" {_cMensaje}";
        }
    }
}
