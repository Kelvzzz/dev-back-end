
namespace Banco.Entidades
{
	internal class ContaPessoaFisica
	{
		private int numero;
		private double saldo;


		//Campos
		protected int NumeroDaConta
		{
			get { return numero; }
			set { numero = value; }
		}

		private string titular;

		protected string TitularDaConta
		{
			get { return titular; }
			set { titular = value; }
		}
		protected double SaldoDaConta
		{
			get { return saldo; }
			set { saldo = value; }
		}
	
	//Construtor 
	public ContaPessoaFisica(string titularDaConta, int numeroDaConta)
		{
			TitularDaConta = titularDaConta;
			NumeroDaConta = numeroDaConta;
			SaldoDaConta = 0;
		}

        public ContaPessoaFisica(string titular, string titularDaConta, double saldoDaConta)
        {
            this.titular = titular;
            TitularDaConta = titularDaConta;
            SaldoDaConta = saldoDaConta;
        }

		//Metodos
		public void Saque(double quantia)
		{
			SaldoDaConta -= quantia;
		}
		public void Deposito(double quantia)
		{
			SaldoDaConta += quantia;
		}
    }


}
