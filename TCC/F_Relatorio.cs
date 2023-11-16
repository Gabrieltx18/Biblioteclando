using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data;

namespace TCC
{
    public partial class F_Relatorio : Form
    {
        public string inicio;
        public string final;
        public F_Relatorio()
        {
            InitializeComponent();
        }

        public static DataTable Leitores(F_Relatorio f)
        {
            
            try
            {
                using (var cmd = Banco.conexaobanco().CreateCommand())
                {
                    cmd.CommandText = "SELECT e.id_livro, l.título, COUNT(*) AS total_emprestimos " +
                                    "FROM tbEmprestimo e " +
                                    "JOIN tbLivro l ON e.id_livro = l.id_livro " +
                                    "WHERE e.data_de_emprestimo BETWEEN @DataInicial AND @DataFinal " +
                                    "GROUP BY e.id_livro, l.título " +
                                    "ORDER BY e.id_livro DESC";

                    cmd.Parameters.AddWithValue("@DataInicial", f.inicio);
                    cmd.Parameters.AddWithValue("@DataFinal", f.final);

                    using (MySqlDataAdapter data = new MySqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        data.Fill(dt);
                        return dt;
                    }

                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void btn_GerarRelatorio_Click(object sender, EventArgs e)
        {
            F_Relatorio f = new F_Relatorio();
            f.inicio = dtPicker_Inicial.Value.ToString("yyyy-MM-dd");
            f.final = dtPicker_Final.Value.ToString("yyyy-MM-dd");
            dgv_Relatorio.DataSource = Leitores(f);
        }
    }
}
