

using Master.Interfaces;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Master.Classes.Entidades
{
    internal class Conta : IOperacoes
    {
        private string titular;
        private int numero;
        private double saldo;


        protected double SaldoDaConta
        {
            get { return saldo; }
            set { saldo = value; }
        }


        protected int NumeroDaConta
        {
            get { return numero; }
            set { numero = value; }
        }


        protected string TitularDaConta
        {
            get { return titular; }
            set { titular = value; }
        }



        void IOperacoes.Deposito(double qtd)
        {
            throw new NotImplementedException();
        }

        void IOperacoes.Saque(double qtd)
        {
            throw new NotImplementedException();
        }
        public Conta(string titularDaConta,int numeroDaConta)
        {
            NumeroDaConta = numeroDaConta;
            TitularDaConta = titularDaConta;
            SaldoDaConta = 0;
        }

        public Conta(string titularDaConta, int numeroDaConta, double saldoDaConta) : this(titularDaConta, numeroDaConta)
        {
            SaldoDaConta = saldoDaConta;
            
        }

        //Métodos
        public void Deposito(double qtd)
        {
            SaldoDaConta -= qtd;
        }

        public virtual void Saque(double qtd)
        {
            SaldoDaConta += qtd;
        }
            
        public virtual void ExibirDados()
        {
            Console.WriteLine($"Titular da conta: {TitularDaConta}\n" +
                $"Número da conta: {NumeroDaConta}\n" +
                $"Saldo da conta: {SaldoDaConta:c}");
        }
    }
}
