using BancoVirtual.Sistemas;
using System;
using System.Collections.Generic;
using System.Text;

namespace BancoVirtual
{
    public class ParceiroComercial : IAutenticavel
    {
        public string Senha { get; set; }
        public bool Autenticar(string senha)
        {
            return Senha == senha;
        }
    }
}
