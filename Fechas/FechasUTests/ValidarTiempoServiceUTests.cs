using Microsoft.VisualStudio.TestTools.UnitTesting;
using Fechas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fechas.Tests
{
    [TestClass()]
    public class ValidarTiempoServiceUTests
    {
        [TestMethod()]
        public void ValidarTiempo_FechaPasada_CadenaConInformacionCorrectaEnDias()
        {
            //Arrange
            DateTime dtActual = new DateTime(2020, 01, 14);
            DateTime dtFechaReferencia = new DateTime(2020, 01, 12);
            TimeSpan tsDiferencia = dtActual - dtFechaReferencia;
            Propiedades propiedades = new Propiedades();
            ValidarTiempoService validarTiempoService = new ValidarTiempoService();
            ConvertirPositivoService convertirPositivoService = new ConvertirPositivoService();
            string ValorEsperado =  "2 Días";
            string cResultado = "";

            //Act
            validarTiempoService.PrepararMensajePosterior(tsDiferencia,propiedades, convertirPositivoService);
            cResultado = propiedades.iTiempo + propiedades.cTexto;

            //Assert
            Assert.AreEqual(ValorEsperado,cResultado);
        }

        [TestMethod()]
        public void ValidarTiempo_FechaFutura_CadenaConInformacionCorrectaEnDias()
        {
            //Arrange
            DateTime dtActual = new DateTime(2020, 01, 14);
            DateTime dtFechaReferencia = new DateTime(2020, 01, 15);
            TimeSpan tsDiferencia = dtActual - dtFechaReferencia;
            Propiedades propiedades = new Propiedades();
            ValidarTiempoService validarTiempoService = new ValidarTiempoService();
            ConvertirPositivoService convertirPositivoService = new ConvertirPositivoService();
            string ValorEsperado = "1 Días";
            string cResultado = "";

            //Act
            validarTiempoService.PrepararMensajePosterior(tsDiferencia, propiedades, convertirPositivoService);
            cResultado = propiedades.iTiempo + propiedades.cTexto;

            //Assert
            Assert.AreEqual(ValorEsperado, cResultado);
        }

        [TestMethod()]
        public void ValidarTiempo_FechaPasada_CadenaConInformacionCorrectaEnMes()
        {
            //Arrange
            DateTime dtActual = new DateTime(2020, 01, 14);
            DateTime dtFechaReferencia = new DateTime(2019, 12, 15);
            TimeSpan tsDiferencia = dtActual - dtFechaReferencia;
            Propiedades propiedades = new Propiedades();
            ValidarTiempoService validarTiempoService = new ValidarTiempoService();
            ConvertirPositivoService convertirPositivoService = new ConvertirPositivoService();
            string ValorEsperado = "1 Meses";
            string cResultado = "";

            //Act
            validarTiempoService.PrepararMensajePosterior(tsDiferencia, propiedades, convertirPositivoService);
            cResultado = propiedades.iTiempo + propiedades.cTexto;

            //Assert
            Assert.AreEqual(ValorEsperado, cResultado);
        }

        [TestMethod()]
        public void ValidarTiempo_FechaFutura_CadenaConInformacionCorrectaEnMeses()
        {
            //Arrange
            DateTime dtActual = new DateTime(2020, 01, 14);
            DateTime dtFechaReferencia = new DateTime(2020, 03, 15);
            TimeSpan tsDiferencia = dtActual - dtFechaReferencia;
            Propiedades propiedades = new Propiedades();
            ValidarTiempoService validarTiempoService = new ValidarTiempoService();
            ConvertirPositivoService convertirPositivoService = new ConvertirPositivoService();
            string ValorEsperado = "2 Meses";
            string cResultado = "";

            //Act
            validarTiempoService.PrepararMensajePosterior(tsDiferencia, propiedades, convertirPositivoService);
            cResultado = propiedades.iTiempo + propiedades.cTexto;

            //Assert
            Assert.AreEqual(ValorEsperado, cResultado);
        }
    }
}