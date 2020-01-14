using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Fechas.Tests
{
    [TestClass()]
    public class ValidarFechasServiceUTests
    {
        [TestMethod()]
        public void ValidarFechas_FechaFutura_CadenaConInformacionCorrecta()
        {
            //Arrange
            DateTime dtActual = new DateTime(2020, 01, 14);
            DateTime dtFechaReferencia = new DateTime(2020, 01, 15);
            string resultado = "";
            string ValorEsperado = "Mañana ocurrirá dentro de ";
            string cNombreEvento = "Mañana";
            ValidarFechasService validarFechasService = new ValidarFechasService();

            //Act
            resultado = validarFechasService.PrepararMensajePrevio(dtActual, dtFechaReferencia, cNombreEvento);

            //Assert
            Assert.AreEqual(ValorEsperado,resultado);
        }

        [TestMethod()]
        public void ValidarFechas_FechaPasado_CadenaConInformacionCorrecta()
        {
            //Arrange
            DateTime dtActual = new DateTime(2020, 01, 14);
            DateTime dtFechaReferencia = new DateTime(2020, 01, 10);
            string ValorEsperado = "En el pasado ocurrió hace ";
            string resultado = "";
            string cNombreEvento = "En el pasado";
            ValidarFechasService validarFechasService = new ValidarFechasService();

            //Act
            resultado = validarFechasService.PrepararMensajePrevio(dtActual, dtFechaReferencia, cNombreEvento);

            //Assert
            Assert.AreEqual(ValorEsperado, resultado);
        }

        [TestMethod()]
        public void ValidarFechas_FechaActual_CadenaConInformacionCorrecta()
        {
            //Arrange
            DateTime dtActual = new DateTime(2020, 01, 14);
            DateTime dtFechaReferencia = new DateTime(2020, 01, 14);
            string ValorEsperado = "El Ahora está ocurriendo en este momento ";
            string resultado = "";
            string cNombreEvento = "El Ahora";
            ValidarFechasService SUT = new ValidarFechasService();

            //Act
            resultado = SUT.PrepararMensajePrevio(dtActual, dtFechaReferencia, cNombreEvento);

            //Assert
            Assert.AreEqual(ValorEsperado, resultado);
        }

    }
}