

using System;

namespace PrimieroTeste
{
    public  class ContaBancaria
    {
        private string m_nomeCorrentista;

        private double m_saldo;

        private bool m_bloqueio = false;

        public ContaBancaria()
        {
        }

        public ContaBancaria(string nomeCorrentista, double saldo)
        {
            this.m_nomeCorrentista = nomeCorrentista;
            this.m_saldo = saldo;
        }

        public string NomeCorrentista
        {
            get { return m_nomeCorrentista; }
        }

        public double Saldo
        {
            get { return m_saldo; }
        }

        public Boolean Bloqueado
        {
            get { return m_bloqueio; }
        }
       

        public void Debito(double montante)
        {
            if (m_bloqueio)
            {
                throw new Exception("Conta bloqueada");
            }

            if (montante > m_saldo)
            {
                throw new ArgumentOutOfRangeException("Valor a ser sacado é maior que o saido");
            }

            if (montante < 0)
            {
                throw new ArgumentOutOfRangeException("Montante nao pode ser negativo");
            }

            m_saldo -= montante; // inserido erro de codigo  
        }

        public void Credito(double montante)
        {
            if (m_bloqueio)
            {
                throw new Exception("Conta bloqueada");
            }

            if (montante < 0)
            {
                throw new ArgumentOutOfRangeException("montante");
            }

            m_saldo += montante;
        }

        public void BloquearConta()
        {
            m_bloqueio = true;
        }

        public void DesbloqueiaConta()
        {
            m_bloqueio = false;
        }
    }
}
