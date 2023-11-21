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
    public partial class F_updEmpretimo : Form
    {
        public F_updEmpretimo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AtualizarEmprestimo();
        }
        private void AtualizarEmprestimo()
        {
            try
            {
                int idEmprestimo = Convert.ToInt32(tb_IdEmprestimo.Text);

                using (MySqlCommand cmd = Banco.conexaobanco().CreateCommand())
                {
                    cmd.CommandText = "UPDATE tbEmprestimo " +
                                      "SET data_de_Emprestimo = @EMPRESTIMO, previsao_de_devolução = @DEVOLUCAO " +
                                      "WHERE id_emprestimo = @ID_EMPRESTIMO";

                    cmd.Parameters.AddWithValue("@EMPRESTIMO", dt_novaDataEmprestimo.Value.ToString("yyyy-MM-dd"));
                    cmd.Parameters.AddWithValue("@DEVOLUCAO", dt_novaDataDevolucao.Value.ToString("yyyy-MM-dd"));
                    cmd.Parameters.AddWithValue("@ID_EMPRESTIMO", idEmprestimo);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Empréstimo atualizado com sucesso!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
