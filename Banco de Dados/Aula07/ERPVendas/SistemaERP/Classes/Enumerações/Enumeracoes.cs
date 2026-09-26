using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace SistemaERP.Classes.Enumerações
{
    internal enum StatusUsuario
    {
        [Description("Aguardando aprovação...")]
        Aguardando,
        [Description("Usuario Aprovado")]
        Aprovado,
        [Description("Usuario Reprovado")]
        Reprovado
    }
}
