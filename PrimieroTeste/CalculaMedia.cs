

using System;

namespace PrimieroTeste
{
    public class CalculaMedia
    {
        public string NomeAluno { get; set; }
        public int ContadorProvas { get; set; }
        public int ContadorPontos { get; set; }
        public int SomaPontos { get; set; }
        public decimal SomaProvas { get; set; }

        public void InserirNotaProva(Array nota)
        {

            System.Console.Write("nota {0} ", nota.Length);
            this.ContadorProvas = nota.Length;

            if (this.ContadorProvas >= 4)
            {

            }
            else
            {
                throw new Exception("Excedeu o limite de provas no ano");
            }
            
            
            foreach (int i in nota)
            {
                this.SomaProvas += i;

                //System.Console.Write("sss {0} ", nota.Length);
            }
            //System.Console.Write("sss {0} ",this.SomaProvas);
            //this.SomaProvas += nota;
        }

        public void InserirPonto(Array ponto)
        {
            this.ContadorPontos = ponto.Length;
            if (this.ContadorPontos >= 4)
            {
               
            }else
            {
                throw new Exception("Excedeu o limite de pontos no ano");
            }

               
            
            foreach (int o in ponto)
            {
                this.SomaPontos += o;
            }
            //this.SomaPontos++;
        }

        public decimal CalcularMedia()
        {
            decimal retorno = (SomaProvas + SomaPontos) / 4;
            return retorno;
        }
    }
}
