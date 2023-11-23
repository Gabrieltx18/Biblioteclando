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
                    cmd.CommandText = "INSERT INTO tbAutor(Nome_Autor) VALUES(@AUTOR)";
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@AUTOR", tb_Autor.Text);
                    cmd.ExecuteNonQuery();

                    cmd.CommandText = "INSERT INTO tbEditora(nome) VALUES(@EDITORA)";
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@EDITORA", tb_Editora.Text);
                    cmd.ExecuteNonQuery();

                    cmd.CommandText = "INSERT INTO tbGenero(nome_genero) VALUES(@GENERO)";
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@GENERO", tb_Genero.Text);
                    cmd.ExecuteNonQuery();

                    cmd.CommandText = "INSERT INTO tbLivro(ISBN, título, descrição, data_publicacao, Número_de_páginas) VALUES(@ISBN, @TITULO, @DESCRICAO, @DATA, @PAGINAS);";  
                    cmd.Parameters.AddWithValue("@ISBN", tb_ISBN.Text);
                    cmd.Parameters.AddWithValue("@TITULO", tb_Titulo.Text);
                    cmd.Parameters.AddWithValue("@DESCRICAO", tb_Descrição.Text);
                    cmd.Parameters.AddWithValue("@DATA", dateTimePicker1.Value.ToString("yyyy-MM-dd"));
                    cmd.Parameters.AddWithValue("@PAGINAS", tb_Paginas.Text);
                    cmd.ExecuteNonQuery();



                    MessageBox.Show("Cadastrado com sucesso");

                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
