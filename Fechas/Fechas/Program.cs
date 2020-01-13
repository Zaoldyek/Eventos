using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fechas
{
    class Program
    {
        static void Main(string[] args)
        {
           
          Fechas();
            
        }
        public static void Fechas()
        {
            string cText="";
            string line;
            System.IO.StreamReader file = new System.IO.StreamReader(@"C:\fecha1.txt");
            while ((line = file.ReadLine()) != null)
            {
                cText = line;
                string[] lstDatos = cText.Split(',');
                DateTime dtDate = Convert.ToDateTime(lstDatos[1]);
                DateTime dtHoy = DateTime.Now;

                if (dtDate <= dtHoy)
                {
                    string cConcepto = CalcularTiempo(dtDate, dtHoy, 1);
                    Console.WriteLine(lstDatos[0] + " ocurrio hace " + cConcepto);
                }
                else
                {
                    string cConcepto = CalcularTiempo(dtDate, dtHoy, 2);
                    Console.WriteLine(lstDatos[0] + " ocurrira dentro de " + cConcepto);
                }
               
            }
            Console.Read();
        }
        public static string CalcularTiempo(DateTime _dtInput, DateTime _dtHoy, int _iTipo)
        {
            string cTexto = "";
            TimeSpan tsDiferencia;
            int iDay = 0;
            if (_iTipo == 1)
            {
                tsDiferencia = _dtHoy - _dtInput;
            }
            else
            {
                tsDiferencia = _dtInput - _dtHoy;
            }
            iDay = tsDiferencia.Days;
            cTexto = iDay + " Dias";
            if (iDay >= 24) {
                cTexto = (tsDiferencia.Days / 24 )+" Meses";
            }
            if (iDay == 0) {
                cTexto = tsDiferencia.Hours + " Horas";
            }
            if (tsDiferencia.Hours == 0) {
                cTexto = tsDiferencia.Minutes + " Minutos";
            }

            return cTexto;
        }
    }
}
