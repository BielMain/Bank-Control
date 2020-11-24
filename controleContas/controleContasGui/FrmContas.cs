using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using controleContas;

namespace controleContasGui
{
    public partial class FrmContas : Form
    {
        List<Contas> contas = new List<Contas>();
        List<Clientes> clientes = new List<Clientes>();
        public FrmContas()
        {
            InitializeComponent();
            clientes.Add(new Clientes("Bruno", "12345678901", 1998));
            clientes.Add(new Clientes("Gabriela", "10987654321", 1996));
 
            lstContas.Items.Clear();
            lstContas.Items.Add("Nome\tCPF\tTitular");
 
            cmbTitular.Items.Clear();
            clientes.ForEach(delegate (Clientes cli) {
                cmbTitular.Items.Add(cli.NomeProp);
        }
            );
        }

    private void button4_Click(object sender, EventArgs e)
    {
        lstContas.Items.Add(txtNumero.Text + "\t" + txtSaldo.Text + "\t" +
          cmbTitular.SelectedItem.ToString());
    }

    private void button3_Click(object sender, EventArgs e)
    {
        DialogResult sair = MessageBox.Show("Você deseja sair?", "Sair", MessageBoxButtons.YesNo,
            MessageBoxIcon.Information);
        if (sair.Equals(DialogResult.Yes))
        {
            Application.Exit();
        }
    }

    private void button1_Click(object sender, EventArgs e)
    {
        //Clientes novoClienteForm = new Clientes(clientes);
        FrmClientes novosl = new FrmClientes();
            novosl.ShowDialog();
            this.clientes = novosl.GetClientes;

        cmbTitular.Items.Clear();
        clientes.ForEach(delegate (Clientes cli)
        {
          cmbTitular.Items.Add(cli.NomeProp);
        });
    }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limparCampos();
        }
        private void limparCampos()
        {
            txtSaldo.Text = "";
            txtNumero.Text = "";
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            if (cmbTitular.SelectedItem == null || txtNumero.Text == "" || txtSaldo.Text == "")
            {
                MessageBox.Show("Digite o texto correspondente ao campo", "Campo vazio", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Clientes titular = clientes.Find(delegate (Clientes cli) {
                return cli.NomeProp == cmbTitular.SelectedItem.ToString();
            });
            limparCampos();
        }
    }
}