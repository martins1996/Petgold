using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Petgold
{
    class Petgold
    {
        public int id { get; set; }

        public string nome { get; set; }

        public string endereco { get; set; }

        public string cidade { get; set; }

        public string celular { get; set; }

        public string email { get; set; }

        public string data_de_nascimento { get; set; }

        SqlConnection con = new SqlConnection ("Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename=C:\\Users\\User\\Downloads\\petgold-main\\Petgold\\Petgold\\Database1.mdf;Integrated Security = True");


        public void InserirCli(string nome, string endereco, string cidade, string celular, string email, string data_de_nacimento)
        {
            string sql = "INSERT INTO CLIENTE (NOME ,ENDERECO,CIDADE,CELULAR,EMAIL,DATA_DE_NASCIMENTO) VALUES ('" + nome + "','" + endereco + "','" + cidade + "','" + celular + "','" + email + "','" + data_de_nacimento + "')";
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public List<Petgold> ListaPetgold()

        {
            List<Petgold> lista = new List<Petgold>();
            string sql = "SELECT * FROM  Clientes";
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Petgold f = new Petgold();
                f.id = Convert.ToInt32(dr["id"]);
                f.nome = dr["nome"].ToString();
                f.endereco = dr["endereco"].ToString();
                f.cidade = dr["cidade"].ToString();
                f.celular = dr["celular"].ToString();
                f.email = dr["email"].ToString();
                f.data_de_nascimento = dr["data_de_nascimento"].ToString();
                lista.Add(f);

            }
            return lista;

        }

        public void ExcluirCli(int id)
        {
            string sql = "DELETE FROM  CLIENTE WHERER id  = '" + id + "'";
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public void LocalizarCli(int id)
        {
            string sql = "SELECT FROM CLIENTE WHERER id = '" + id + "'";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader dr = cmd.ExecuteReader();
            string data = Convert.ToString(data_de_nascimento);
            while (dr.Read())
            {
                nome = dr["nome"].ToString();
                endereco = dr["endereco"].ToString();
                cidade = dr["cidade"].ToString();
                celular = dr["celualr"].ToString();
                email = dr["email"].ToString();
                data_de_nascimento = dr["data_de_nascimento"].ToString();

            }
            dr.Close();
            con.Close();

        }
        public void AtualizarCli(int id, string nome, string endereco, string cidade, string celular, string email, string data_de_nascimento)
        {
            string sql = "UPDATE CLIENTE  SET NOME='" + nome + "',endereco='" + endereco + "',cidade='" + cidade + "',celular='" + email + "',data_de_nascimento='" + data_de_nascimento + "'";
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public int NCli()
        {
            int total = 0;
            string sql = " SELECT COUNT (*) AS TOTAL CLIENTE";
            if (con.State == System.Data.ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();
            SqlCommand cmd = new SqlCommand(sql,con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                total = Convert.ToInt32(dr["total"]);

            }
            dr.Close();
            con.Close();
            return total;


        }



    }
}