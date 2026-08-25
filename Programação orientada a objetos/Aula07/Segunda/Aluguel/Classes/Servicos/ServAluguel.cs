
using Aluguel.Classes.Entidades;
using Aluguel.Interfaces;

namespace Aluguel.Classes.Servicos
{
    internal class ServAluguel
    {
		//Campos
		private double precoHora;
		private double precoDia;
		private ITaxaServ taxaServ;
        double pagamento, fatura, taxa;

		//Propriedade
		public double PrecoPorHora
		{
			get { return precoHora; }
			private set { precoHora = value; }
		}

		private double PrecoDia;

        public double PrecoPorDia
		{
			get { return precoDia; }
			private set { precoDia = value; }
		}

        public ITaxaServ TaxaDeServico
        {
            get { return taxaServ; }
           private set { taxaServ = value; }
        }


        //Construtor 
        public ServAluguel(double precoPorHora, double precoPorDia, ITaxaServ taxaDeServico)
        {
            PrecoPorHora = precoPorHora;
            PrecoPorDia = precoPorDia;
            TaxaDeServico = taxaDeServico;
        }


        //Métodos
        public void CalcularFatura(AluguelCarro aluguelDeCarro)
        {
            TimeSpan duracao;
            double pagamento;

            duracao = aluguelDeCarro.FimLocacao.Subtract(aluguelDeCarro.InicioLocacao);

            if (duracao.TotalHours <= 12.0)
            {
                 pagamento = PrecoPorHora * duracao.TotalHours;
            }

            else
            {
                pagamento = PrecoPorDia * duracao.TotalDays;
            }

            double taxa = taxaServ.taxa(pagamento);

            double fatura = pagamento + taxa;

        }

        public override string ToString()
        {
            return $"Pagamento sex taxa : {pagamento:c}" + 
                $"\n Taxa: {taxa:c}" +
                $"\n Pagamento Total; {fatura:c}";
        }
    }
}
