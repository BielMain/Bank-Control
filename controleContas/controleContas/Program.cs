using System;

namespace controleContas
{

    class Program
    {
        static void Main(string[] args)
        {
            Banco banco = new Banco("Bradesco", 11204);
            Agencia agencia = new Agencia(banco, 505, "66000100", "91994599999");

            Clientes cliente1 = new Clientes("Alexandre", "12345678901", 2001);
            Clientes cliente2 = new Clientes("Fernando", "21345678901", 1988);

            Contas conta1 = new Contas(agencia, cliente1, 12345, 120m);
            Contas conta2 = new Contas(agencia, cliente2, 65414, 0m);

            Console.WriteLine("A conta de número {0} tem saldo {1:C2}", conta1.NumeroProp, conta1.SaldoProp);
            Console.WriteLine("A conta de número {0} tem saldo {1:C2}", conta2.NumeroProp, conta2.SaldoProp);

            Contas maiorSaldo;
            if (conta1.SaldoProp > conta2.SaldoProp)
            {
                maiorSaldo = conta1;
            }
            else
            {
                maiorSaldo = conta2;
            }

            Console.WriteLine("Conta {0} tem o maior saldo", maiorSaldo.NumeroProp);
            Console.Read();
        }
    }
}
