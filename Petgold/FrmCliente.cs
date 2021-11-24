using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Net;
using System.IO;
using System.Data.SqlClient;


namespace Petgold
{
    public partial class FrmCliente : Form
    {
        public FrmCliente()
        {
            InitializeComponent();
        }

        private void btnsair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btninserir_Click(object sender, EventArgs e)
        {
            Petgold petgold = new Petgold();
            petgold.InserirCli( txtnome.Text, txtendereco.Text, txtcidade.Text, txtcelular.Text, txtemail.Text, txtdata.Text);
            MessageBox.Show("CLIENTE ADICIONADO COM SUCESSO !", "CADASTRO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            List<Petgold> cliente = petgold.ListaPetgold();
            dgvcliente.DataSource = cliente;
            txtnome.Text = "";
            txtendereco.Text = "";
            txtcidade.Text = "";
            txtcelular.Text = "";
            txtemail.Text = "";
            txtdata.Text = "";
        
        }

        private void FrmCliente_Load(object sender, EventArgs e)
        {
            Petgold petgold = new Petgold();
            List<Petgold> pet = petgold.ListaPetgold();
            dgvcliente.DataSource = petgold;


        }

        private void btnatualizar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtid.Text.Trim());
            Petgold petgold = new Petgold();
            petgold.ExcluirCli(id, txtnome.Text, txtendereco.Text, txtcidade.Text, txtcelular.Text, txtemail.Text, txtdata.Text);
            MessageBox.Show("CLIENTE ATUALIZADO COM SUCESSO", "ATUALIZAR", MessageBoxButtons.OK, MessageBoxIcon.Information);
            List<Petgold> Cliente = petgold.ListaPetgold();
            dgvcliente.DataSource = Cliente;
            txtnome.Text = "";
            txtendereco.Text = "";
            txtcidade.Text = "";
            txtcelular.Text = "";
            txtemail.Text = "";
            txtdata.Text = "";
        }

        private void btnapagar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtid.Text.Trim());
            Petgold petgold = new Petgold();
            petgold.ExcluirCli(id, txtnome.Text, txtendereco.Text, txtcidade.Text, txtcelular.Text, txtemail.Text, txtdata.Text);
            MessageBox.Show("CLIENTE ATUALIZADO COM SUCESSO", "ATUALIZAR", MessageBoxButtons.OK, MessageBoxIcon.Information);
            List<Petgold> Cliente = petgold.ListaPetgold();
            dgvcliente.DataSource = Cliente;
            txtnome.Text = "";
            txtendereco.Text = "";
            txtcidade.Text = "";
            txtcelular.Text = "";
            txtemail.Text = "";
            txtdata.Text = "";
        }

        private void dgvcliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var pegaid = dgvcliente.CurrentCell.RowIndex;
            var pegaid2 = dgvcliente.Rows[pegaid].Cells[0].Value.ToString();
            int id = Convert.ToInt32(pegaid2);
            Petgold petgold = new Petgold();
            petgold.LocalizarCli(id);
            txtid.Text = Convert.ToString(id);
            txtnome.Text = petgold.nome;
            txtendereco.Text = petgold.endereco;
            txtcidade.Text = petgold.cidade;
            txtcelular.Text = petgold.celular;
            txtemail.Text = petgold.email;
            txtdata.Text = petgold.data_de_nascimento;
        }
    }
}
