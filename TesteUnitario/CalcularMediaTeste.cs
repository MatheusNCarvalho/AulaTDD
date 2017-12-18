using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PrimieroTeste;

namespace TesteUnitario
{
    /// <summary>
    /// Summary description for CalcularMediaTeste
    /// </summary>
    [TestClass]
    public class CalcularMediaTeste
    {
        private CalculaMedia calculaMedia = new CalculaMedia()
        {
            NomeAluno = "Matheus Neves",
            ContadorPontos = 0,
            ContadorProvas = 0,
            SomaPontos = 0,
            SomaProvas = 0

        };


        [TestMethod]
        public void TestCalculaMediaInserirNota()
        {
            int[] notas = {6,7,5,8};
            int[] pontos = { 2,1,3,2};
            
            calculaMedia.InserirNotaProva(notas);
            calculaMedia.InserirPonto(pontos);
            Assert.AreEqual(8.5m, calculaMedia.CalcularMedia());


        }
    }
}
