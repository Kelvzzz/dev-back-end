
using Abstracao.Enumeracoes;
using Abstracao.Interfaces;
using System.Security.Cryptography.X509Certificates;

namespace Abstracao.Classes.Entidades
{
   abstract internal class Forma : IGeometria
    {
        //Campo
        Cor cor;

       //Construtor
        public Forma(Cor cor)
        {
            this.cor = cor;
        }

        /// <summary>
      
        /// </summary>

        //Método
        public abstract void Area();

        public string Cor()
        {
            return(cor.ToString()); 
        }
    }
}
