using Contrato.Classes.Contratos;


namespace Contrato.Classes.Contratos.Entidades
{
    internal class Funcionarios
    {    //Campos
        private string nome;
        protected List<HoraContrato> contratos;

        //Propriedades
        protected string Nome
        {
            get { return nome; }
            set { nome = value; }
        }


        protected List<HoraContrato> Contratos
     
        { 
            get { return contratos; }
            set { contratos = value; }
        }

        //Construtor
        public Funcionarios ( string nome)
        {
            Nome = nome;
        }

        //Métodos
        public void AdicionarContrato(double valor , int horas)
        {
            HoraContrato contrato = new HoraContrato(horas, valor);
            Contratos.Add(contrato);
        }
    }




}
