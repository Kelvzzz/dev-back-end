using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace SistemaERP.Classes.Enumeracoes
{
    public enum StatusUsuario;
    public class Enumeracoes
    {
     public  enum StatusUsuario
        {
            [Description ("Aguardando aprovação...")]
            Aguardando = 0,
            [Description("Usuário Aprovado")]
            Aprovado = 1,
            [Description("Usuario Reprovado")]
            Reprovado = 2
        }
    }
}
