using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Petgold
{
    public partial class FrmAgenda : Form
    {

        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\User\\Downloads\\petgold-main\\Petgold\\Petgold\\Database1.mdf;Integrated Security=True");
        public FrmAgenda()
        {
            InitializeComponent();
        }

        private void btnsair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void CarregatxtServico()
        {
            string servico = " SELECT id , servico ,preco* FROM Servico";
            SqlCommand cmd = new SqlCommand(servico, con);
            con.Open();
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(servico, con);
            DataSet ds = new DataSet();
            da.Fill(ds, "servico");
            cbxid.ValueMember = "id";
            cbxidanimal

        }
    }
}
