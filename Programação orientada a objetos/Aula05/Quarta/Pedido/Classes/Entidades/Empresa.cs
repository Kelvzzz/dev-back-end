namespace Pedido.Classes.Entidades
{
    internal class Empresa
    {

        //1º Campos
        private string nome;
        private List<Funcionario> funcionarios;


        // 2º - Propriedades
        protected List<Funcionario> ListaFuncionarios
        {
            get { return funcionarios; }
            set { funcionarios = value; }
        }

        protected string NomeDaEmpresa
        {
            get { return nome; }
            set { nome = value; }
        }

        public Empresa(string nomeDaEmpresa)
        {
            NomeDaEmpresa = nomeDaEmpresa;
            ListaFuncionarios = new List<Funcionario>();
        }

        // 4º MÉTODOS
        public void AdicionarFuncionario(Funcionario funcionario)
        {
            ListaFuncionarios.Add(funcionario);
        }


    }
}