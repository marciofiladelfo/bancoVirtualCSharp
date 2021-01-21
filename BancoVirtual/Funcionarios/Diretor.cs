using System;
using System.Collections.Generic;
using System.Text;

namespace BancoVirtual.Funcionarios
{
    public class Diretor : Funcionario
    {
        public override double GetBonificacao()
        {
            return Salario;
        }
    }
}
