
namespace AtividadeZAbstracao.Entidades.Pessoa_Juridica
{
    internal class PessoaJuridica : Contribuinte
    {

        public int NumeroFuncionarios 
        {  
            get; set; 
        }
        public PessoaJuridica(string nome, double rendaAnual, int funcionarios) : base(nome, rendaAnual)
        {
            NumeroFuncionarios = funcionarios;
        }

        public override double CalcularImposto()
        {
            double taxa;

            if (NumeroFuncionarios > 10)
            {
                taxa = 0.14;
            }
            else
            {
                taxa = 0.16;
            }

            return RendaAnual * taxa;
        }

    }
}
