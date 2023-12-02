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
    public partial class F_Livros : Form
    {
        public F_Livros()
        {
            InitializeComponent();
        }

        private void F_Livros_Load(object sender, EventArgs e)
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
                    cmd.CommandText = "SELECT * FROM vwLivrosDetalher";
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

        private void btn_Cadastrar_Click(object sender, EventArgs e)
        {
            F_adcLivro livro = new F_adcLivro();
            livro.Show();
        }

        private void btn_Excluir_Click(object sender, EventArgs e)
        {
            F_delLivro f_Del = new F_delLivro();
            f_Del.Show();
        }
    }
}
