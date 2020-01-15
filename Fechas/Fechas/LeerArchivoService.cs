using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Fechas
{
    public class LeerArchivoService : ILeerArchivo
    {
        public Func<string, string[]> lectorArchivo { get; set; }

        public LeerArchivoService()
        {
            lectorArchivo = e => File.ReadAllLines(e);
        }
        public List<string> LeerArchivo(string _cRuta)
        {
            
            List<string> lstRegistros = new List<string>();
            lstRegistros = lectorArchivo(_cRuta).ToList();

            return lstRegistros;
        }
    }
}
