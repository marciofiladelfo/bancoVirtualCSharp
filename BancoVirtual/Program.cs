using System;
using BancoVirtual.Funcionarios;

namespace BancoVirtual
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente c1 = new Cliente();
            c1.Nome = "Gabriela";
            c1.Cpf = "999.888.777-66";
            c1.Profissao = "Dev C#";

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
            c2.Nome = "Matheus";
            c2.Cpf = "111.222.333-44";
            c2.Profissao = "Dev Java";

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

            GerenciarBonificacao gerenciador = new GerenciarBonificacao();

            Console.WriteLine();
            Funcionario func1 = new Funcionario();
            func1.Nome = "Carlos";
            func1.Cpf = "333.444.555-66";
            func1.Salario = 2800.00;

            gerenciador.Registrar(func1);
            Console.WriteLine();

            Funcionario dir1 = new Diretor();
            dir1.Nome = "Roberta";
            dir1.Cpf = "222.666.777-99";
            dir1.Salario = 5000.00;

            gerenciador.Registrar(dir1);

            Console.WriteLine(func1.Nome);
            Console.WriteLine("Funcionario " + func1.GetBonificacao());

            Console.WriteLine(dir1.Nome);
            Console.WriteLine("Diretor " + dir1.GetBonificacao());

            Console.WriteLine();
            Console.WriteLine("A bonificação Total é:" + gerenciador.GetTotalBonificacao());

            Console.ReadLine();
        }
    }
}
