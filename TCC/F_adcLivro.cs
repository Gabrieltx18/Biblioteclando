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
    public partial class F_adcLivro : Form
    {
   
        public void CarragaEditora()
        {
            string msql = "SELECT * from (select -1 as id_Genero,'Selecione...' as nome_genero union select id_Genero,nome_genero from tbGenero) as tb order by id_Genero";

            MySqlConnection con = Banco.conexaobanco();
            
            using (MySqlCommand cmd = new MySqlCommand(msql,con))
            {

                try
                {
                    MySqlDataAdapter mda = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    mda.Fill(dt);
                    comboEditora.DataSource = dt;
                    comboEditora.DisplayMember = "nome_genero";
                    comboEditora.ValueMember = "id_genero";
                }
                catch (Exception err)
                {

                    MessageBox.Show(err.Message);
                }
                finally
                {
                    con.Close();
                    con.Dispose();
                }

                
            }
        }

        public F_adcLivro()
        {
            InitializeComponent();
        }

        private void btn_Cadastrar_Click(object sender, EventArgs e)
        {
            cadastrar();
        }
        private void cadastrar()
        {
            try
            {
                var cmd = Banco.conexaobanco().CreateCommand();
                {



                    //cmd.CommandText = "INSERT INTO tbEditora(nome) VALUES(@EDITORA)";
                    //cmd.Parameters.Clear();
                    //cmd.Parameters.AddWithValue("@EDITORA", tb_Editora.Text);
                    //cmd.ExecuteNonQuery();

                    //cmd.CommandText = "INSERT INTO tbGenero(nome_genero) VALUES(@GENERO)";
                    //cmd.Parameters.Clear();
                    //cmd.Parameters.AddWithValue("@GENERO", tb_Genero.Text);
                    //cmd.ExecuteNonQuery();

                    cmd.CommandText = "INSERT INTO tbLivro(ISBN, título, descrição, data_publicacao, Número_de_páginas,id_Editora) VALUES(@ISBN, @TITULO, @DESCRICAO, @DATA, @PAGINAS,@id_editora);";
                    cmd.Parameters.AddWithValue("@ISBN", tb_ISBN.Text);
                    cmd.Parameters.AddWithValue("@TITULO", tb_Titulo.Text);
                    cmd.Parameters.AddWithValue("@DESCRICAO", tb_Descrição.Text);
                    cmd.Parameters.AddWithValue("@DATA", maskedDataPublicacao.Text);
                    cmd.Parameters.AddWithValue("@PAGINAS", tb_Paginas.Text);
                    cmd.Parameters.AddWithValue("@id_editora", comboEditora.SelectedValue);
                    cmd.ExecuteNonQuery();



                    MessageBox.Show("Cadastrado com sucesso");

                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void F_adcLivro_Load(object sender, EventArgs e)
        {
            CarragaEditora();
        }
    }
}
