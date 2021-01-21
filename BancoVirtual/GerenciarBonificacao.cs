using BancoVirtual.Funcionarios;
using System;
using System.Collections.Generic;
using System.Text;

namespace BancoVirtual
{
    public class GerenciarBonificacao
    {
        private double _total;
        public void Registrar(Funcionario funcionario)
        {
            _total += funcionario.GetBonificacao();
           
        }

        public double GetTotalBonificacao()
        {
            return _total;
        }

    }
}
