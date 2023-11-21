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
        public string isbn;
        public string titulo;
        public string descricao;
        public string autor;
        public string genero;
        public string editora;
        public string data;
        public string paginas;
        public F_adcLivro()
        {
            InitializeComponent();
        }

        private void btn_Cadastrar_Click(object sender, EventArgs e)
        {
           
            F_adcLivro adc = new F_adcLivro();
            adc.isbn = tb_ISBN.Text;
            adc.titulo = tb_Titulo.Text;
            adc.descricao = tb_Descrição.Text;
            adc.autor = tb_Autor.Text;
            adc.editora = tb_Editora.Text;
            adc.genero = tb_Genero.Text;
            adc.paginas = tb_Paginas.Text;
            adc.data = dateTimePicker1.Value.ToString("yyyy-MM-dd");
            cadastrar(adc);
            ActiveForm.Close();
        }
        private static void cadastrar(F_adcLivro u)
        {
            try
            {
                var cmd = Banco.conexaobanco().CreateCommand();
                {
                    cmd.CommandText = "INSERT INTO tbLivro(ISBN, título, descrição, data_publicacao, Número_de_páginas) VALUES(@ISBN, @TITULO, @DESCRICAO, @DATA, @PAGINAS); " +
                                          "INSERT INTO tbAutor (Nome_Autor) VALUES (@AUTOR);" +
                                          "INSERT INTO tbEditora (nome) VALUES (@EDITORA);" +
                                          "INSERT INTO tbGenero (nome_genero) VALUES (@GENERO);";

                    cmd.Parameters.AddWithValue("@ISBN", u.isbn);
                    cmd.Parameters.AddWithValue("@TITULO", u.titulo);
                    cmd.Parameters.AddWithValue("@DESCRICAO", u.descricao);
                    cmd.Parameters.AddWithValue("@DATA", u.data);
                    cmd.Parameters.AddWithValue("@PAGINAS", u.paginas);
                    cmd.Parameters.AddWithValue("@AUTOR", u.autor);
                    cmd.Parameters.AddWithValue("@EDITORA", u.editora);
                    cmd.Parameters.AddWithValue("@GENERO", u.genero);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
