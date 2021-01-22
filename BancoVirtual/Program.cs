using System;
using BancoVirtual.Funcionarios;
using BancoVirtual.Sistemas;

namespace BancoVirtual
{
    class Program
    {
        static void Main(string[] args)
        {
            CadastrarCliente();
            Console.WriteLine();
            CadastrarContas();
            Console.WriteLine();
            CalcularBonificacao();
            Console.WriteLine();
            UsarSistemaInterno();

            Console.ReadLine();
        }

        public static void CadastrarCliente()
        {
            Cliente c1 = new Cliente();
            c1.Nome = "Gabriela";
            c1.Cpf = "999.888.777-66";
            c1.Profissao = "Dev C#";

            Cliente c2 = new Cliente();
            c2.Nome = "Matheus";
            c2.Cpf = "111.222.333-44";
            c2.Profissao = "Dev Java";
        }

        public static void CadastrarContas()
        {
            Cliente c1 = new Cliente();
            ContaCorrente conta1 = new ContaCorrente(0001, 36887);
            conta1.Titular = c1;
            conta1.Saldo = 100.00;

            Console.WriteLine("Titular: " + conta1.Titular);
            Console.WriteLine("Agencia: " + conta1.Agencia);
            Console.WriteLine("Conta Corrente: " + conta1.Conta);
            Console.WriteLine("Saldo Inicial Conta1: " + conta1.Saldo);

            conta1.Sacar(20);
            Console.WriteLine("Saldo: " + conta1.Saldo);

            conta1.Depositar(350.50);
            Console.WriteLine("Saldo: " + conta1.Saldo);
            Console.WriteLine();

            Cliente c2 = new Cliente();
            ContaCorrente conta2 = new ContaCorrente(0001, 34544);
            conta2.Titular = c2;
            conta2.Saldo = 200.00;

            Console.WriteLine("Titular: " + conta2.Titular);
            Console.WriteLine("Agencia: " + conta2.Agencia);
            Console.WriteLine("Conta Corrente: " + conta2.Conta);
            Console.WriteLine("Saldo Inicial Conta2: " + conta2.Saldo);
            Console.WriteLine();

            conta1.Tranferir(150.50, conta2);
            Console.WriteLine("Saldo Conta1: " + conta1.Saldo);
            Console.WriteLine("Saldo Conta2: " + conta2.Saldo);

            Console.WriteLine();
            Console.WriteLine("Total de contas criadas: " + ContaCorrente.Total);
        }

        public static void UsarSistemaInterno()
        {
            SistemaInterno sistemaInterno = new SistemaInterno();

            Diretor roberta = new Diretor("159.753.398-04");
            roberta.Nome = "Roberta";
            roberta.Senha = "1234";

            GerenteDeConta camila = new GerenteDeConta("326.985.628-89");
            camila.Nome = "Camila";
            camila.Senha = "4321";

            ParceiroComercial parceiro = new ParceiroComercial();
            parceiro.Senha = "0987";

            sistemaInterno.Logar(roberta, "1234");
            sistemaInterno.Logar(camila, "1234");
            sistemaInterno.Logar(parceiro, "0987");
        }

        public static void CalcularBonificacao()
        {
            GerenciarBonificacao gerenciadorBonificacao = new GerenciarBonificacao();

            Funcionario pedro = new Designer("833.222.048-39");
            pedro.Nome = "Pedro";

            Funcionario roberta = new Diretor("159.753.398-04");
            roberta.Nome = "Roberta";

            Funcionario igor = new Auxiliar("981.198.778-53");
            igor.Nome = "Igor";

            Funcionario camila = new GerenteDeConta("326.985.628-89");
            camila.Nome = "Camila";

            Funcionario marcio = new Desenvolvedor("326.985.628-89");
            marcio.Nome = "Marcio";

            gerenciadorBonificacao.Registrar(marcio);
            gerenciadorBonificacao.Registrar(pedro);
            gerenciadorBonificacao.Registrar(roberta);
            gerenciadorBonificacao.Registrar(igor);
            gerenciadorBonificacao.Registrar(camila);

            Console.WriteLine("Total de bonificações do mês " +
                gerenciadorBonificacao.GetTotalBonificacao());
        }
    }
}

