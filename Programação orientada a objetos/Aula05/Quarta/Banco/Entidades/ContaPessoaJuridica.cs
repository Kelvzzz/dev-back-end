

namespace Banco.Entidades
{
    internal class ContaPessoaJuridica : ContaPessoaFisica
    {
		//Campos
		private double limite;

        
        //Construtor
        public ContaPessoaJuridica(string titularDaConta, int numeroDaConta, double limite) : base(titularDaConta, numeroDaConta)
        {
            LimiteDaConta = limite;
        }

        public ContaPessoaJuridica(string titular, string titularDaConta, double saldoDaConta,double limite) : base(titular, titularDaConta, saldoDaConta)
        {
            LimiteDaConta = limite;

        }
        //Propriedades
        protected double LimiteDaConta
		{
			get { return limite; }
			set { limite = value; }
		}
        public void Limite(double quantia)
        {
            SaldoDaConta += quantia;
        }
	}
}
