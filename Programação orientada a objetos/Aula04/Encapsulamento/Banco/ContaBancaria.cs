
namespace Banco
{
    public class ContaBancaria
    {
        //Primeira coisa - Campos
        private string titular;
        private int numero;
        private double saldo;

        //Ordem de criação de classes = Primeiro campos, Segundo Propriedades, Terceiro construtor, quarto métodos

        // Segundo membro - Propriedades       ( Mecanismo flexivel para ler e gravar objetos)
        protected string TitularDaConta
        {
            get { return titular; }
            set
            {
                if (value.IsWhiteSpace())
                {
                    titular = value;
                }
                else
                {
                    Console.WriteLine("Valor de campo invalido");
                }
            }
        }

        protected int NumeroDaConta
        {
            get { return numero; }
            private set { numero = value; }
        }

        protected double SaldoDaConta
        {
            get { return saldo; }
            set { saldo = value; }
        }


        // 3 membro da classe - construtor
        public ContaBancaria(string titularDaConta, int numeroDaConta, double saldoDaConta)
        {
            TitularDaConta = titularDaConta;
            NumeroDaConta = numeroDaConta;
            SaldoDaConta = saldoDaConta;
        }

        public ContaBancaria(string titularDaConta, int numeroDaConta)
        {
            TitularDaConta = titularDaConta;
            NumeroDaConta = numeroDaConta;
            SaldoDaConta = 0;
        }

        //Quarto membro - métodos

        public void Deposito(double quantia)
        {
            SaldoDaConta += quantia;
        }

        public void Saque(double quantia)
        {
            if (quantia <= 0)
            {
                Console.WriteLine("Valor invalido, insira valor positivos ou diferente de zero");
            }
            else
            {
                SaldoDaConta -= quantia + 5.00;
            }

            SaldoDaConta -= quantia + 5.00;

        }

    

    public string ExibirDados()
        {
            return $"Dados da conta:\n" +
                $"\tTitular da conta: {TitularDaConta}\n" +
                $"\tNúmero da conta: {NumeroDaConta}\n" +
                $"\tSaldo da conta: {SaldoDaConta:c}";
        }
    }
}
