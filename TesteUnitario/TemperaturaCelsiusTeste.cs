using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PrimieroTeste;

namespace TesteUnitario
{
    /// <summary>
    /// Summary description for TemperaturaCelsius
    /// </summary>
    [TestClass]
    public class TemperaturaCelsiusTeste
    {
        
        

        [TestMethod]
        public void TestTemperaturaCelsius()
        {

            TemperaturaCelsius t = new TemperaturaCelsius(50);
           


            Assert.AreEqual(122, t.converteCelsiusParaFahrenheit());



        }
    }
}
