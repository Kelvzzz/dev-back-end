

namespace AtividadeZAbstracao.Entidades.Pessoa_Fisica
{
    internal class PessoaFisica : Contribuinte 
    {

        public double GastosSaude;
            double imposto
        {
            get;
            set;
        }
        public PessoaFisica(string nome, double rendaAnual, double gastosSaude) : base(nome, rendaAnual)
        {
            GastosSaude = gastosSaude;
        }

        public override double CalcularImposto()
        {
            double imposto;

            if (RendaAnual < 20000)
            {
                imposto = RendaAnual * 0.15;
            }
            else
            {
                imposto = RendaAnual * 0.25;
            }

            imposto -= GastosSaude * 0.50;
            return imposto;
            
                
            

        }
    }
}
