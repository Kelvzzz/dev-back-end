using System;
using System.Collections.Generic;
using System.Text;

namespace CasasBahia2.Classes.Entidades
{
    internal class Logins
    {
        //Propriedades
        public int Id { get; set; }
        public string Usuario { get; set; }
        public string Senha { get; protected set; }
        public string Regra { get; protected set; }

        //Construtor
        public Logins(string usuario, string senha, string regra)
        {
            Usuario = usuario;
            Senha = senha;
            Regra = regra;
        }

    }
}
