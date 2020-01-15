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
    public class ConvertirPositivoServiceUTests
    {
        [TestMethod()]
        public void ConvertiraPositivo_ValorNegativo_RecineValorPositivo()
        {
            //Arrange
            int iValorPositivo = 0;
            ConvertirPositivoService convertirPositivoService = new ConvertirPositivoService();
            
            //Act
            iValorPositivo = convertirPositivoService.ConvertiraPositivo(-5);

            //Assert
            Assert.AreEqual(5, iValorPositivo);
        }

        [TestMethod()]
        public void ConvertiraPositivo_ValorPositivo_RecineValorPositivo()
        {
            //Arrange
            int iValorPositivo = 0;
            ConvertirPositivoService convertirPositivoService = new ConvertirPositivoService();

            //Act
            iValorPositivo = convertirPositivoService.ConvertiraPositivo(5);

            //Assert
            Assert.AreEqual(5, iValorPositivo);
        }
    }
}