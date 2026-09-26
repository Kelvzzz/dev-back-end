using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace SistemaERP.Classes.Enumeracoes
{
    internal class Enumeracoes
    {
        internal enum StatusUsuario
        {
            [Description ("Aguardando aprovação...")]
            Aguardando,
            [Description("Usuário Aprovado")]
            Aprovado,
            [Description("Usuario Reprovado")]
            Reprovado
        }
    }
}
