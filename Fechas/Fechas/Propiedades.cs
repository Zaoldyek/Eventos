using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fechas
{
    public class Propiedades : CalcularTiempo
    {
        public DateTime dtHoy { get; private set; }
        public DateTime dtInput { get; private set; }
        public string cNombre { get; private set; }
        public int iTiempo { get; set; }
        public string cTexto { get; set; }
        public IValidarFechas validarFechas { get; set; }
        public ConvertirPositivo convertirPositivo { get; set; }
        public ValidarTiempo ValidarTiempo { get; set; }

        public Propiedades(DateTime _dtHoy, DateTime _dtInput, string _cNombre, IValidarFechas _validarFechas,ConvertirPositivo _convertirPositivo,ValidarTiempo _validarTiempo)
        {
            this.dtHoy = _dtHoy;
            this.dtInput = _dtInput;
            this.cNombre = _cNombre;
            validarFechas = _validarFechas;
            convertirPositivo = _convertirPositivo;
            ValidarTiempo = _validarTiempo;
        }

        public void CalcularTiempoRestante()
        {
            string cTextoAux = "";
            TimeSpan tsDiferencia;

            cTextoAux = validarFechas.PrepararMensajePrevio(dtHoy, dtInput, cNombre);
            tsDiferencia = dtHoy - dtInput;

            ValidarTiempo.ValidarTiempo(tsDiferencia,this);
            
            this.iTiempo = convertirPositivo.ConvertiraPositivo(this.iTiempo);
            cTexto = cTextoAux + this.iTiempo + this.cTexto; 
            Console.WriteLine(cTexto);
        }

    }
}
