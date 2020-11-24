using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using controleContas;

namespace controleContasGui
{
    public partial class FrmClientes : Form
    {
        private List<Clientes> clientes;
        public List<Clientes> GetClientes
        {
            get => clientes;
        }
        public FrmClientes()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cpfTxt.Text == "" || nomeTxt.Text == "" || anoTxt.Text == "")
            {
                MessageBox.Show("Os campos não podem estar vazios", "Campos vazios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cpfTxt.Text.Length < 11)
            {
                MessageBox.Show("O CPF não pode ter menos de 11 caracteres", "CPF inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Clientes cliente = new Clientes(nomeTxt.Text, cpfTxt.Text, Convert.ToInt32(anoTxt.Text));
            clientes.Add(cliente);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
