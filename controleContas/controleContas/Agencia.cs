using System;
using System.Collections.Generic;
using System.Text;

namespace controleContas
{
    public class Agencia
    {
        private int numero;
        private string cep;
        private string telefone;
        private Banco banco;

        public Agencia(Banco banco, int numero, string cep, string telefone)
        {
            this.banco = banco;
            this.numero = numero;
            this.cep = cep;
            this.telefone = telefone;
        }

        public Banco BancoProp
        {
            get => banco;
        }

        public int NumeroProp
        {
            get => numero;
        }

        public string CepProp
        {
            get => cep;
        }

        public string TelefoneProp
        {
            get => telefone;
        }
    }
}