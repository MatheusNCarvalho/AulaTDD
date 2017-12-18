using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PrimieroTeste;

namespace TesteUnitario
{
    /// <summary>
    /// Summary description for ContaBancariaTeste
    /// </summary>
    [TestClass]
    public class ContaBancariaTeste
    {



        private String NomeCorrentista = "Matheus";
        private Double Saldo = 540.00;


        ContaBancaria contaBancaria;


        [TestMethod]
        public void TestContaBancariaNomeCorrentista()
        {
            ContaBancaria contaBancaria = new ContaBancaria(NomeCorrentista, Saldo);
           
           Assert.AreEqual("Matheus", contaBancaria.NomeCorrentista);
       
        }


        [TestMethod]
        public void TestContaBancariaSaldo()
        {
            Assert.AreEqual(540.00, Saldo);
        }

        [TestMethod]
        public void TestContaBancariaDebito()
        {
            ContaBancaria contaBancaria = new ContaBancaria(NomeCorrentista, 200);
            contaBancaria.Debito(150);
            Assert.AreEqual(50, contaBancaria.Saldo);
        }

        [TestMethod]
        public void TestContaBancariaCredito()
        {
            ContaBancaria contaBancaria1 = new ContaBancaria(NomeCorrentista, 200);
            contaBancaria1.Credito(150);
            Assert.AreEqual(350, contaBancaria1.Saldo);
        }

        [TestMethod]
        public void TestContaBancariaBloquearConta()
        {
            ContaBancaria contaBancaria3 = new ContaBancaria(NomeCorrentista, 200);
           contaBancaria3.BloquearConta();
            Assert.IsTrue(contaBancaria3.Bloqueado);

        }


        [TestMethod]
        public void TestContaBancariaDesbloquearConta()
        {
            ContaBancaria cb4 = new ContaBancaria(NomeCorrentista, 200);
            cb4.DesbloqueiaConta();
            Assert.IsFalse(cb4.Bloqueado);

        }

    }
}
