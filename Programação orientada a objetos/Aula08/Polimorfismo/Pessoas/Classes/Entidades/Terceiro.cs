

namespace Pessoas.Classes.Entidades
{
    internal class Terceiro : Funcionario
    {     //Campos
		private double despesa;

        //Propriedade
        protected double DespesaAdicional
		{
			get { return despesa; }
		    set {despesa = value; }
		}
        
        //Construtor
        public Terceiro(string nomeFuncionario, double valorHora, int jornadaFuncionario) : base(nomeFuncionario, valorHora, jornadaFuncionario)
        {
            DespesaAdicional =  (ValorHora * JornadaFuncionario) * 0.2; 
        }

        //Métodos
        public override double Pagamento()
        {
            return base.Pagamento() + DespesaAdicional;
        }

	}
}
