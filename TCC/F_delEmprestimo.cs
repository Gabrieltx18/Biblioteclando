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
    public partial class F_delEmprestimo : Form
    {
        public F_delEmprestimo()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            ConsultarEmprestimo();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Excluir();
        }
        private void Excluir()
        {
            try
            {
                int idToDelete = Convert.ToInt32(tbIdEmprestimo.Text);

                DialogResult result = MessageBox.Show("Tem certeza de que deseja excluir a linha?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {

                    string tabela = "tbEmprestimo";

                    MySqlConnection connection = Banco.conexaobanco();

                    try
                    {

                        string deleteQuery = $"DELETE FROM {tabela} WHERE id_Emprestimo = @Id";

                        using (MySqlCommand command = new MySqlCommand(deleteQuery, connection))
                        {
                            command.Parameters.AddWithValue("@Id", idToDelete);

                            int rowsAffected = command.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show($"Linha com ID {idToDelete} excluída com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show($"Nenhuma linha encontrada com o ID {idToDelete}.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Erro: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connection.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Exclusão cancelada. A linha não foi removida.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, insira um ID válido.", "Erro de Entrada", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ConsultarEmprestimo()
        {
            try
            {
                int idEmprestimo = Convert.ToInt32(tbIdEmprestimo.Text);

                using (MySqlCommand cmd = Banco.conexaobanco().CreateCommand())
                {
                    cmd.CommandText = "SELECT data_de_Emprestimo, previsao_de_devolução FROM tbEmprestimo WHERE id_emprestimo = @ID_EMPRESTIMO";
                    cmd.Parameters.AddWithValue("@ID_EMPRESTIMO", idEmprestimo);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            DateTime dataEmprestimo = Convert.ToDateTime(reader["data_de_Emprestimo"]);
                            DateTime dataDevolucaoPrevista = Convert.ToDateTime(reader["previsao_de_devolução"]);

                            lblDataEmprestimo.Text = "Data de Empréstimo: " + dataEmprestimo.ToString("dd/MM/yyyy");
                            lblDataDevolucao.Text = "Data de Devolução: " + dataDevolucaoPrevista.ToString("dd/MM/yyyy");

                            TimeSpan diasAtraso = DateTime.Now - dataDevolucaoPrevista;
                            int diasAtrasoInt = (int)diasAtraso.TotalDays;

                            if (diasAtrasoInt > 0)
                            {
                                double multa = diasAtrasoInt * 5.0;
                                lblMulta.Text = $"Multa por atraso: R$ {multa:F2}";
                            }
                            else
                            {
                                lblMulta.Text = "Sem multa, dentro do prazo.";
                            }

                        }
                        else
                        {
                            MessageBox.Show("Empréstimo não encontrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        Banco.conexaobanco().Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

