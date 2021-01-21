using System;
using System.Collections.Generic;
using System.Text;

namespace BancoVirtual
{
    public class ContaCorrente
    {
        public Cliente Titular { get; set; }
        public int Agencia { get; set; }
        public int Conta { get; set; }
        private double saldo;
        public static int Total { get; private set; }


        // Criando métodos getters and setters -> atalho: digitar prop e teclar 2x o tab
        public double Saldo
        {
            get
            {
                return this.saldo;
            }
            set
            {
                if(value < 0)
                {
                    return;
                }
                this.saldo = value;
            }
        }

        //Criando o construtor
        public ContaCorrente (int agencia, int conta)
        {
            Agencia = agencia;
            Conta = conta;
            Total++;
        }


        public void Sacar(double valor)
        {
            if(this.saldo >= valor)
            {
                this.saldo -= valor;
            }
            else
            {
                Console.WriteLine("Saldo insuficiente");
            }
        }

        public void Depositar(double valor)
        {
            this.saldo += valor;
        }

        public void Tranferir(double valor, ContaCorrente contaDestino)
        {
            if(this.saldo >= valor)
            {
                Sacar(valor);
                contaDestino.Depositar(valor);
            }
            else
            {
                Console.WriteLine("Saldo insuficiente");
            }
        }
    }
}
