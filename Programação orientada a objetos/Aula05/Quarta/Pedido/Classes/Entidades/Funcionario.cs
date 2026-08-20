
namespace Pedido.Classes.Entidades
{
    //Objeto que pode existir de forma independente

    internal class Funcionario
    {
        // Campos
        private string nome;

        public Funcionario(string nome)
        {
            this.Nome = nome;
        }

        //Segundo membro - Propriedades

        protected string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        // Terceiro membro = Construtor 

        public Funcionario()

    }
}