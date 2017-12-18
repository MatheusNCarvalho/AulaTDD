using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PrimieroTeste;

namespace TesteUnitario
{
    /// <summary>
    /// Summary description for OperacoesTeste
    /// </summary>
    [TestClass]
    public class OperacoesTeste
    {


        [TestMethod]
        public void TestSomaInteiros()
        {
            Operacoes target = new Operacoes();

            Assert.AreEqual(5, target.Soma(4, 1));
            Assert.AreEqual(-9, target.Soma(-10, 1));
        }



        [TestMethod]

        public void TestSubInteiros()
        {

            Operacoes target = new Operacoes();

            Assert.AreEqual(-2, target.substrair(4, 6));

        }
    }
}
