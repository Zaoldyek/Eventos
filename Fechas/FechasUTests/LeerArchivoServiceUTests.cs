using Microsoft.VisualStudio.TestTools.UnitTesting;
using Fechas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Fechas.Tests
{
    [TestClass()]
    public class LeerArchivoServiceUTests
    {
        [TestMethod()]
        public void LeerArchivo_RutaCorrecta_ListaConRegistros()
        {
            //Arrange
            LeerArchivoService leerArchivoService = new LeerArchivoService();
            List<string> lstRegistros = new List<string>();
            string cRuta = @"C:\fecha1.txt";

            //Act
            lstRegistros = leerArchivoService.LeerArchivo(cRuta);

            //Assert
            Assert.IsTrue(lstRegistros.Any());
        }

        [TestMethod()]
        [ExpectedException(typeof(FileNotFoundException))]
        public void LeerArchivo_RutaIncorrecta_ListaVacia()
        {
            //Arrange
            LeerArchivoService leerArchivoService = new LeerArchivoService();
            List<string> lstRegistros = new List<string>();
            string cRuta = @"";

            //Act
            leerArchivoService.lectorArchivo = e => throw new FileNotFoundException() ;

            //Assert
            leerArchivoService.LeerArchivo(cRuta);
        }
    }
}