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
    public partial class F_Empretimos : Form
    {
        public F_Empretimos()
        {
            InitializeComponent();
            
        }

        private void F_Empretimos_Load(object sender, EventArgs e)
        {
            dgv_Emprestimos.DataSource = Emprestimos();
        }

        private void tb_Busca_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();

            dt = (DataTable)dgv_Emprestimos.DataSource;

            System.Console.WriteLine("Teste dt>" + dt.Columns.Count);
            System.Console.WriteLine("Teste grid>" + dgv_Emprestimos.Columns.Count);

            string colunaSelecionada = cb_Busca.SelectedItem.ToString();
            string valorBusca = tb_Busca.Text;

            dt.DefaultView.RowFilter = $"{colunaSelecionada} like '%{valorBusca}%'";
        }
        public static DataTable Emprestimos()
        {
            MySqlDataAdapter data = null;
            DataTable dt = new DataTable();
            try
            {
                using (var cmd = Banco.conexaobanco().CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM tbEmprestimo";
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
            F_adcEmpretimo f_Adc = new F_adcEmpretimo();
            f_Adc.Show();
        }

        private void btn_Excluir_Click(object sender, EventArgs e)
        {
            F_delEmprestimo f_Del = new F_delEmprestimo();
            f_Del.Show();
        }

        private void btn_Alterar_Click(object sender, EventArgs e)
        {
            F_updEmpretimo f_Upd = new F_updEmpretimo();
            f_Upd.Show();
        }

        private void dgv_Emprestimos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
