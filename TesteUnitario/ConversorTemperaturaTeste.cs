using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PrimieroTeste;

namespace TesteUnitario
{
    /// <summary>
    /// Summary description for ConversorTemperaturaTeste
    /// </summary>
    [TestClass]
    public class ConversorTemperaturaTeste
    {
        

        [TestMethod]
        public void TestConverteCelsiusFahrenheit()
        {
            Assert.AreEqual(122, ConversorTemperatura.converteCelsiusParaFahrenheit(50));

        }

        [TestMethod]
        public void TestConverteFahrenheitCelis()
        {
            Assert.AreEqual(-14, ConversorTemperatura.converteFahrenheitParaCelsius(6));

        }
    }
}
