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
            ValidarFechasService validarFechasService = new ValidarFechasService();
            ConvertirPositivoService convertirPositivoService = new ConvertirPositivoService();
            ValidarTiempoService validarTiempo = new ValidarTiempoService();
            string line;
            System.IO.StreamReader file = new System.IO.StreamReader(@"C:\fecha1.txt");
            while ((line = file.ReadLine()) != null)
            {
                string[] lstDatos = line.Split(',');
                DateTime dtDate = Convert.ToDateTime(lstDatos[1]);
                DateTime dtHoy = DateTime.Now;
                string cNombre = lstDatos[0];

                Diferencia diferencia = new Diferencia(dtHoy, dtDate, cNombre, validarFechasService, convertirPositivoService, validarTiempo);

                Imprimir main = new Imprimir();
                main.imprimir(cNombre,diferencia);
                
            }
            Console.Read();
        }
    }
}
