

namespace Contrato.Classes.Contratos
{
    internal class HoraContrato
    {
        private int horas;
        private double valor;

        //Propriedades
        protected int HorasTrabalhadas
        {
            get { return horas; }
            set { horas = value; }
        }

        public double ValorPorhora
        {
            get { return valor; }
            set { valor = value; }

        }

        //Construtor
        public HoraContrato(int horasTrabalhas, double valorPorHora)
        {
            HorasTrabalhadas = HorasTrabalhadas;
            ValorPorhora = valorPorHora;
        }

        //Metodo 
        public double Pagamento()
        {
            return ValorPorhora * HorasTrabalhadas;
        }
    }
}
