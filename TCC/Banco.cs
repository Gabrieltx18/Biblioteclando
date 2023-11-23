using System.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace TCC
{
    class Banco
    {
        public static MySqlConnection conexao;

        public static MySqlConnection conexaobanco()
        {
            conexao = new MySqlConnection("Data Source=Localhost;Database=biblioteclando1;Uid=root;Password=");
            conexao.Open();
            return conexao;
        }
        public static DataTable consulta(string sql)
        {
            MySqlDataAdapter da = null;
            DataTable dt = new DataTable();

            var cmd = Banco.conexaobanco().CreateCommand();
            {
                cmd.CommandText = sql;
                da = new MySqlDataAdapter(cmd.CommandText, Banco.conexaobanco());
                da.Fill(dt);
                Banco.conexaobanco().Close();
                return dt;
            }
        }
    }
}