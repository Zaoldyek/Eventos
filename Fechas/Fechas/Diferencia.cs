﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fechas
{
    class Diferencia : Propiedades
    {
        public Diferencia(DateTime _dtHoy, DateTime _dtInput, string _cNombre, IValidarFechas _validarFechas, ConvertirPositivo _convertirPositivo, ValidarTiempo _validarTiempo) : base(_dtHoy, _dtInput, _cNombre, _validarFechas, _convertirPositivo, _validarTiempo)
        {
        }
    }
}
