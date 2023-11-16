using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TCC
{
    public partial class F_adcLeitores : Form
    {
        public string nome;
        public string cpf;
        public string endereço;
        public string email;
        public string telefone;
        public F_adcLeitores()
        {
            InitializeComponent();
        }

        private void btn_Cadastrar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tb_nome.Text) || string.IsNullOrEmpty(tb_cpf.Text) ||
                    string.IsNullOrEmpty(tb_telefone.Text) || string.IsNullOrEmpty(tb_endereço.Text) ||
                    string.IsNullOrEmpty(tb_email.Text))
          {
                MessageBox.Show("Por favor, preencha todos os campos.");
                tb_nome.Focus();
                return;
          }
                F_adcLeitores adc = new F_adcLeitores();
                adc.nome = tb_nome.Text;
                adc.cpf = tb_cpf.Text;
                adc.telefone = tb_telefone.Text;
                adc.endereço = tb_endereço.Text;
                adc.email = tb_email.Text;
                cadastrar(adc);
                ActiveForm.Close();
            }
            private static void cadastrar(F_adcLeitores u)
            {
                try
                {
                    var cmd = Banco.conexaobanco().CreateCommand();
                    {
                        cmd.CommandText = "Insert Into tbLeitor(nome,Endereço,telefone,email,CPF)" +
                            "VALUES(@nome,@endereco,@telefone,@email,@cpf)";
                        cmd.Parameters.AddWithValue("@nome", u.nome);
                        cmd.Parameters.AddWithValue("@cpf", u.cpf);
                        cmd.Parameters.AddWithValue("@telefone", u.telefone);
                        cmd.Parameters.AddWithValue("@email", u.email);
                        cmd.Parameters.AddWithValue("@endereco", u.endereço);
                        cmd.ExecuteNonQuery();
                        Banco.conexaobanco().Close();
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
