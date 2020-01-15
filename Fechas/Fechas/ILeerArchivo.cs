using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fechas
{
    interface ILeerArchivo
    {
        List<string> LeerArchivo(string _cRuta);
    }
}
