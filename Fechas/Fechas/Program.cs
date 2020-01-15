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
            LeerArchivoService leerArchivoService = new LeerArchivoService();
            List<string> lstRegistros = new List<string>();
            string cRuta = @"C:\fecha1.txt";
            lstRegistros = leerArchivoService.LeerArchivo(cRuta);

            for (int i = 0; i <= lstRegistros.Count-1; i++)
            {
                string[] lstDatos = lstRegistros[i].Split(',');
                DateTime dtDate = Convert.ToDateTime(lstDatos[1]);
                DateTime dtHoy = DateTime.Now;
                string cNombre = lstDatos[0];

                Diferencia diferencia = new Diferencia(dtHoy, dtDate, cNombre, validarFechasService, convertirPositivoService, validarTiempo);

                Imprimir main = new Imprimir();
                main.imprimir(diferencia);
            }
            
            Console.Read();
        }
    }
}
