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
    public partial class F_adcFuncionario : Form
    {
        public string nome;
        public string senha;
        public string cargo;
        public string data;
        public F_adcFuncionario()
        {
            InitializeComponent();
        }

        private void btn_senha_Click(object sender, EventArgs e)
        {
            string senha = GerarSenha(5);
            tb_Senha.Text = $"{senha}";
        }
        private string GerarSenha(int comprimento)
        {
            const string caracteresPermitidos = "0123456789";
            Random random = new Random();
            char[] senhaArray = new char[comprimento];

            for (int i = 0; i < comprimento; i++)
            {
                senhaArray[i] = caracteresPermitidos[random.Next(caracteresPermitidos.Length)];
            }

            return new string(senhaArray);
        }

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            F_adcFuncionario adc = new F_adcFuncionario();
            adc.nome = tb_nome.Text;
            adc.senha = tb_Senha.Text;
            adc.cargo = cb_cargo.Text;
            adc.data = dt_adimissão.Value.ToString("yyyy-MM-dd");
            cadastrar(adc);
            ActiveForm.Close();
        }
        private static void cadastrar(F_adcFuncionario u)
        {
            try
            {
                var cmd = Banco.conexaobanco().CreateCommand();
                {
                    cmd.CommandText = "Insert Into tbFuncionario(nome,senha,data_contratação,cargo)" +
                        "VALUES(@nome,@senha,@data,@cargo)";
                    cmd.Parameters.AddWithValue("@nome", u.nome);
                    cmd.Parameters.AddWithValue("@senha", u.senha);
                    cmd.Parameters.AddWithValue("@data", u.data);
                    cmd.Parameters.AddWithValue("@cargo", u.cargo);
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
