using BancoVirtual.Funcionarios;
using System;
using System.Collections.Generic;
using System.Text;

namespace BancoVirtual.Sistemas
{
    public interface IAutenticavel
    {
        bool Autenticar(string senha);
    }
}
