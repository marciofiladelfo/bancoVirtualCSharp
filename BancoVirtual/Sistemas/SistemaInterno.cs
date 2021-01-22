using BancoVirtual.Funcionarios;
using System;
using System.Collections.Generic;
using System.Text;

namespace BancoVirtual.Sistemas
{
    public class SistemaInterno
    {
        public void Logar(IAutenticavel funcionario, string senha)
        {
            bool usuarioAutenticado = funcionario.Autenticar(senha);

            if (usuarioAutenticado)
            {
                Console.WriteLine("Acesso liberado");
            }
            else
            {
                Console.WriteLine("Acesso negado");
            }
                
        }
     
    }
}
