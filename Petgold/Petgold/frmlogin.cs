using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Petgold
{
    public partial class frmlogin : Form
    {
        public frmlogin()
        {
            InitializeComponent();
            FormSplash splash = new FormSplash();
            splash.Show();
            Application.DoEvents();
            Thread.Sleep(3000);
            splash.Close();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            string login, senha;
            login = txtlogin.Text;
            senha = txtsenha.Text;
            if (login == "admin" && senha == "admin")
            {
                Formprincipal principal = new Formprincipal();
                principal.Show();
                this.Visible = false;
            }
            else
            {
                MessageBox.Show("SUAS CREDENCIAIS ESTÃO INVALIDAS, TENTE NOVAMENTE", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtlogin.Text = "";
                txtsenha.Text = "";
            }
            }
        }


    }


             

        
    
 

