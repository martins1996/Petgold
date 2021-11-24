using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Petgold
{
    class Animal
    {
        public int id { get; set; }
        public int id_proprietario { get; set; }
        public string nome { get; set; }
        public string raca { get; set; }
        public string data_de_nascimento { get; set; }
        public string especie { get; set; }
        public string pelagem { get; set; }
        public int peso { get; set; }
        public string porte { get; set; }
        public string sexo { get; set; }

        SqlConnection con = new SqlConnection("Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename=C:\\Users\\User\\Downloads\\petgold-main\\Petgold\\Petgold\\Database1.mdf;Integrated Security = True");
        
        public void InserirAnimal(string nome ,string raca ,string data_de_nascimento, string especie,string pelagem ,string porte, string sexo)
        {
            string sql = "INSERT INTO Animal( nome,raca,data_de_nascimento,especie,pelagem,porte,sexo)VALUES ('"+nome+"','"+raca+"','"+data_de_nascimento+"','"+especie+"',"
        }

    }   

}
