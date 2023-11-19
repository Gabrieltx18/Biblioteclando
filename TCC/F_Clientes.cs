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
    public partial class F_Clientes : Form
    {
        public F_Clientes()
        {
            InitializeComponent();
        }

        private void F_Clientes_Load(object sender, EventArgs e)
        {
            dgv_Clientes.DataSource = Leitores();
            if((bool)(cb_Busca.SelectedItem = false))
            {
                tb_Busca.Visible = true;
            }
        }

        private void btn_Cadastrar_Click(object sender, EventArgs e)
        {
            F_adcLeitores Cadastar = new F_adcLeitores();
            Cadastar.Show();
        }
        
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();

            dt = (DataTable)dgv_Clientes.DataSource;

            System.Console.WriteLine("Teste dt>" + dt.Columns.Count);
            System.Console.WriteLine("Teste grid>" + dgv_Clientes.Columns.Count);

            string colunaSelecionada = cb_Busca.SelectedItem.ToString();
            string valorBusca = tb_Busca.Text;

            dt.DefaultView.RowFilter = $"{colunaSelecionada} like '%{valorBusca}%'";
        }
        public static DataTable Leitores()
        {
            MySqlDataAdapter data = null;
            DataTable dt = new DataTable();
            try
            {
                using (var cmd = Banco.conexaobanco().CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM tbLeitor";
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            tb_Busca.Clear();
        }
    }
}