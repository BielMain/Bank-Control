using System;
using System.Collections.Generic;
using System.Text;

namespace controleContas
{
    public class Clientes
    {
        public string nome;
        private string cpf;
        public int anoNasc;

        public Clientes(string nome, string cpf, int anoNasc)
        {
            this.nome = nome;
            this.cpf = cpf;
            this.anoNasc = anoNasc; 
        }

        public string NomeProp
        {
            get => nome;
            set => nome = value;
        }

        public string CpfProp
        {
            get
            {
                return cpf;
            }
            set
            {
                if (value.Length != 11)
                {
                    Console.WriteLine("CPF informado possui menos que 11 caracteres");
                } else
                {
                    cpf = value;
                }
            }
        }

        public int AnoNascProp
        {
            get
            {
                return anoNasc;
            }
            set
            {
               anoNasc = value;
             
            }
        }
    }
}