using System;
using System.Collections.Generic;
using System.Text;

namespace controleContas
{
    public class Contas
    {
        public Clientes titular;
        public Agencia agencia;
        public int numero;
        public decimal saldo;

        public Contas(Agencia agencia, Clientes titular, int numero, decimal saldo)
        {
            if (saldo < 10.0m)
            {
                Console.WriteLine("Saldo inválido! Valor abaixo do esperado.");
                this.saldo = saldo;
            }
            else
            {
                this.saldo = saldo;
            }

            if (titular == null)
            {
                throw new System.ArgumentException("Cliente inválido");
            }

            if (agencia == null)
            {
                throw new System.ArgumentException("Agência inválida!");
            }

            this.numero = numero;
            this.titular = titular;
            this.agencia = agencia;

        }

        public Clientes TitularProp
        {
            get => titular;
            set => titular = value;
        }

        public int NumeroProp
        {
            get => numero;
            set => numero = value;
        }

        public void transferir(Contas contato, decimal valor)
        {
            if (saldo - valor < 0.0m)
            {
                Console.WriteLine("Saldo inválido! Insira um valor positivo.");
                return;
            }
            else
            {
                contato.deposito(valor);
                this.SaldoProp -= valor;
            }
        }

        public void deposito(decimal valor)
        {
            if (valor > 0)
            {
                saldo += valor;
            }
        }

        public void saque(decimal valor)
        {
            if (saldo - valor > 0.0m)
            {
                saldo -= valor + 0.10m;
            }
            else
            {
                Console.WriteLine("Saldo inválido! Insira um valor positivo.");
            }
        }

        public decimal SaldoProp
        {
            get
            {
                return saldo;
            }
            set
            {
                if (value >= 0.0m)
                {
                    saldo = value;
                }
                else
                {
                    Console.WriteLine("Saldo inválido! Insira um valor positivo.");
                }
            }
        }
    }
}
