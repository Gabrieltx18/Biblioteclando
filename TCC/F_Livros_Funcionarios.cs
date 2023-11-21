using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace TCC
{
    public partial class F_Livros_Funcionarios : Form
    {
        public F_Livros_Funcionarios()
        {
            InitializeComponent();
        }

        private void F_Livros_Funcionarios_Load(object sender, EventArgs e)
        {
            dgv_Livros.DataSource = Livros();
        }

        private void tb_Busca_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();

            dt = (DataTable)dgv_Livros.DataSource;

            System.Console.WriteLine("Teste dt>" + dt.Columns.Count);
            System.Console.WriteLine("Teste grid>" + dgv_Livros.Columns.Count);

            string colunaSelecionada = cb_Busca.SelectedItem.ToString();
            string valorBusca = tb_Busca.Text;

            dt.DefaultView.RowFilter = $"{colunaSelecionada} like '%{valorBusca}%'";
        }
        public static DataTable Livros()
        {
            MySqlDataAdapter data = null;
            DataTable dt = new DataTable();
            try
            {
                using (var cmd = Banco.conexaobanco().CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM vwLivrosDetalhes";
                    data = new MySqlDataAdapter(cmd.CommandText, Banco.conexaobanco());
                    data.Fill(dt);
                    return dt;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
