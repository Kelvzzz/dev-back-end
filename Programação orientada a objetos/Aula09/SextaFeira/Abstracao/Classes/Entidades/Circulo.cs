using Abstracao.Enumeracoes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Abstracao.Classes.Entidades
{
    internal class Circulo : Forma
    {

        private double raio;


        public double Raio
        {
            get { return raio; }
            set { raio = value; }
        }
        public Circulo(Cor cor,double raio) : base(cor)
        {
            Raio = raio;
        }


        public override void Area()
        {
            Console.WriteLine(Math.PI * Math.Pow(Raio,2)) ;
        }
    }
}
