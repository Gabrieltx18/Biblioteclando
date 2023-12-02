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
   
        public void CarragaGenero()
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
                    comboGenero.DataSource = dt;
                    comboGenero.DisplayMember = "nome_genero";
                    comboGenero.ValueMember = "id_genero";
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
        public void CarragaAutor()
        {
            string msql = "SELECT * from (select -1 as id_Autor,'Selecione...' as Nome_Autor union select id_Autor,Nome_Autor from tbAutor) as tb order by id_Autor";

            MySqlConnection con = Banco.conexaobanco();

            using (MySqlCommand cmd = new MySqlCommand(msql, con))
            {

                try
                {
                    MySqlDataAdapter mda = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    mda.Fill(dt);
                    comboAutor.DataSource = dt;
                    comboAutor.DisplayMember = "Nome_Autor";
                    comboAutor.ValueMember = "id_Autor";
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
        public void CarragaEditora()
        {
            string msql = "SELECT * from (select -1 as id_Editora,'Selecione...' as nome union select id_Editora,nome from tbEditora) as tb order by id_Editora";

            MySqlConnection con = Banco.conexaobanco();

            using (MySqlCommand cmd = new MySqlCommand(msql, con))
            {

                try
                {
                    MySqlDataAdapter mda = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    mda.Fill(dt);
                    comboEditora.DataSource = dt;
                    comboEditora.DisplayMember = "nome";
                    comboEditora.ValueMember = "id_Editora";
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

                    cmd.CommandText = "INSERT INTO tbLivro(ISBN, título, descrição,id_Editora,id_Autor,id_Genero, data_publicacao, Número_de_páginas) VALUES(@ISBN, @TITULO, @DESCRICAO,@id_editora,@AUTOR,@GENERO, @DATA, @PAGINAS);";
                    cmd.Parameters.AddWithValue("@ISBN", tb_ISBN.Text);
                    cmd.Parameters.AddWithValue("@TITULO", tb_Titulo.Text);
                    cmd.Parameters.AddWithValue("@DESCRICAO", tb_Descrição.Text);
                    cmd.Parameters.AddWithValue("@DATA", dt_DataPublicacao.Value.ToString("yyyy-MM-dd"));
                    cmd.Parameters.AddWithValue("@PAGINAS", tb_Paginas.Text);
                    cmd.Parameters.AddWithValue("@AUTOR",comboAutor.SelectedValue);
                    cmd.Parameters.AddWithValue("@id_editora", comboEditora.SelectedValue);
                    cmd.Parameters.AddWithValue("@GENERO",comboGenero.SelectedValue);
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
            CarragaGenero();
            CarragaAutor();
            CarragaEditora();
        }
    }
}
