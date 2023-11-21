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
    public partial class F_adcEmpretimo : Form
    {
        public string cliente;
        public string livro;
        public string emprestimo;
        public string devolução;
        public F_adcEmpretimo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cadastar();
        }
        private void cadastar()
        {
            try
            {
                var cmd = (Banco.conexaobanco().CreateCommand());
                {
                    cmd.CommandText = "Insert into tbEmprestimo(data_de_Emprestimo,previsao_de_devolução,id_leitor,id_livro)" +
                        "VALUES(@EMPRESTIMO,@DEVOLUCAO,@CLIENTE,@LIVRO)";
                    cmd.Parameters.AddWithValue("@EMPRESTIMO",dt_emprestimo.Value.ToString("yyyy-MM-dd"));
                    cmd.Parameters.AddWithValue("@DEVOLUCAO", dt_devolucao.Value.ToString("yyyy-MM-dd"));
                    cmd.Parameters.AddWithValue("@CLIENTE", tb_cliente.Text);
                    cmd.Parameters.AddWithValue("@LIVRO", tb_livro.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Emprestimo Efetuado");
                }
            }
            catch
            {
                MessageBox.Show("Cliente ou Livro não encotrados", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
    }
}
