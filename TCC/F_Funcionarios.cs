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
    public partial class F_Funcionarios : Form
    {
        public F_Funcionarios()
        {
            InitializeComponent();
        }

        private void F_Funcionarios_Load(object sender, EventArgs e)
        {
            dgv_Funcionarios.DataSource = Funcionarios();
            if ((bool)(cb_Busca.SelectedItem = true))
            {
                tb_Busca.Visible = true;
            }
        }

        private void tb_Busca_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();

            dt = (DataTable)dgv_Funcionarios.DataSource;

            System.Console.WriteLine("Teste dt>" + dt.Columns.Count);
            System.Console.WriteLine("Teste grid>" + dgv_Funcionarios.Columns.Count);

            string colunaSelecionada = cb_Busca.SelectedItem.ToString();
            string valorBusca = tb_Busca.Text;

            dt.DefaultView.RowFilter = $"{colunaSelecionada} like '%{valorBusca}%'";
        }
        public static DataTable Funcionarios()
        {
            MySqlDataAdapter data = null;
            DataTable dt = new DataTable();
            try
            {
                using (var cmd = Banco.conexaobanco().CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM tbFuncionario";
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
            F_adcFuncionario f_AdcFuncionario = new F_adcFuncionario();
            f_AdcFuncionario.Show();
        }

        private void btn_Excluir_Click(object sender, EventArgs e)
        {
            F_delFuncionarios f_DelFuncionarios = new F_delFuncionarios();
            f_DelFuncionarios.Show();
        }
    }
}
