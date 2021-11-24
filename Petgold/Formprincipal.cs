using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Petgold
{
    public partial class Formprincipal : Form
    {
        public Formprincipal()
        {
            InitializeComponent();
        }

        private void btncliente_Click(object sender, EventArgs e)
        {
            FrmCliente cliente = new FrmCliente();
            cliente.TopLevel = false; // pra n abrir form no topo 
            cliente.Dock = DockStyle.Fill; //prende form no panel
            panecentral.Controls.Clear(); // limpa panel
            panecentral.Controls.Add(cliente);// add form no panel
            cliente.Show();
        }

        private void btninicio_Click(object sender, EventArgs e)
        {
            panecentral.Controls.Clear();
        }

        private void btnsair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnfuncionarios_Click(object sender, EventArgs e)
        {
            FrmFuncionario funcionario = new FrmFuncionario();
            funcionario.TopLevel = false; // pra n abrir form no topo 
            funcionario.Dock = DockStyle.Fill; //prende form no panel
            panecentral.Controls.Clear(); // limpa panel
            panecentral.Controls.Add(funcionario);// add form no panel
            funcionario.Show();
        }

        private void btnanimais_Click(object sender, EventArgs e)
        {
            FrmAnimais animais = new FrmAnimais();
            animais.TopLevel = false; // pra n abrir form no topo 
            animais.Dock = DockStyle.Fill; //prende form no panel
            panecentral.Controls.Clear(); // limpa panel
            panecentral.Controls.Add(animais);// add form no panel
            animais.Show();
        }

        private void btnagenda_Click(object sender, EventArgs e)
        {
            FrmAgenda agenda = new FrmAgenda();
            agenda.TopLevel = false; // pra n abrir form no topo 
            agenda.Dock = DockStyle.Fill; //prende form no panel
            panecentral.Controls.Clear(); // limpa panel
            panecentral.Controls.Add(agenda);// add form no panel
            agenda.Show();
        }

        private void btnservico_Click(object sender, EventArgs e)
        {
            FrmServiço servico = new FrmServiço();
            servico.TopLevel = false; // pra n abrir form no topo 
            servico.Dock = DockStyle.Fill; //prende form no panel
            panecentral.Controls.Clear(); // limpa panel
            panecentral.Controls.Add(servico);// add form no panel
            servico.Show();
        }

        private void btnraca_Click(object sender, EventArgs e)
        {
            FrmRaça raca = new FrmRaça();
            raca.TopLevel = false; // pra n abrir form no topo 
            raca.Dock = DockStyle.Fill; //prende form no panel
            panecentral.Controls.Clear(); // limpa panel
            panecentral.Controls.Add(raca);// add form no panel
            raca.Show();
        }

        private void panecentral_Paint(object sender, PaintEventArgs e)
        {

        }
    }
    }


