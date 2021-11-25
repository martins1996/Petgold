using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Petgold
{
    class Funcionario
    {
        public int id { get; set; }
        public string nome { get; set; }
        public string addmissao { get; set; }
        public string login { get; set; }
        public string senha { get; set; }

        SqlConnection con = new SqlConnection("Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename=C:\\Users\\User\\Downloads\\petgold-main\\Petgold\\Petgold\\Database1.mdf;Integrated Security = True");

        public void InserirFunc(string nome, string addmisssao, string login, string senha)
        {
            string sql = "INSERT INTO  FUNCIONARIO (NOME,ADDMISSAO,LOGIN,SENHA)VALUES ('" + nome + "','" + addmisssao + "','" + login + "','" + senha + "')";
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public List<Funcionario> ListaFuncionario()
        {
            List<Funcionario> lista = new List<Funcionario>();
            string sql = "SELECT * FROM  Funcionario";
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Funcionario f = new Funcionario();
                f.id = Convert.ToInt32(dr["id"]);
                f.nome = dr["nome"].ToString();
                f.addmissao = dr["addmissao"].ToString();
                f.login = dr["login"].ToString();
                f.senha = dr["senha"].ToString();
                lista.Add(f);
            }
            return lista;
        }
        public void ExcluirFunc(int id)
        {
            string sql = "DELETE FROM  Funcionario  WHERER id  = '" + id + "'";
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public void LocalizarFunc(int id)
        {
            string sql = "SELECT FROM Funcionario WHERER id = '" + id + "'";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader dr = cmd.ExecuteReader();
            string data = Convert.ToString(addmissao);
            while (dr.Read())
            {
                nome = dr["nome"].ToString();
                addmissao = dr["addmissao"].ToString();
                login = dr["login"].ToString();
                senha = dr["senha"].ToString();

            }
            dr.Close();
            con.Close();
        }
        public void AtualizarFunc( int id, string nome , string addmissao ,string login , string senha)
        {
            string sql = "UPDATE FUNCIONARIO SET NOME='" + nome + "','" + addmissao + "','" + login + "','" + senha + "'";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}
