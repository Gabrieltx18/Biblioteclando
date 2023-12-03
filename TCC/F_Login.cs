using System;
using System.Data;
using System.Windows.Forms;

namespace TCC
{
    public partial class F_Login : Form
    {
        DataTable dt = new DataTable();

        public F_Login()
        {
            InitializeComponent();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            string username = tb_Usuario.Text;
            string senha = tb_Senha.Text;

            if (tb_Usuario.Text == "" || tb_Senha.Text == "")
            {
                MessageBox.Show("Preencha os campos corretamente");
                tb_Usuario.Focus();
                return;
            }

            string sql = "SELECT nome, senha, cargo FROM tbFuncionario " +
                         "WHERE nome='" + username + "' AND senha= '" + senha + "'";

            dt = Banco.consulta(sql);

            if (dt.Rows.Count == 1)
            {
                string nivelAcesso = dt.Rows[0]["cargo"].ToString();

                switch (nivelAcesso)
                {
                    case "Gerente":
                        F_MenuAdm f_ = new F_MenuAdm();
                        f_.Show();
                        break;
                    case "Bibliotecário":
                        F_MenuFuncionario f_MenuFuncionario = new F_MenuFuncionario();
                        f_MenuFuncionario.Show();
                        break;
                    default:
                        MessageBox.Show("Perfil não autorizado.");
                        break;
                }
            }
            else
            {
                MessageBox.Show("Usuário ou Senha não encontrados");
            }
        }

        private void ckb_Senha_CheckedChanged(object sender, EventArgs e)
        {
            if (ckb_Senha.Checked)
            {
                tb_Senha.PasswordChar = '\u0000';
            }
            else
            {
                tb_Senha.PasswordChar = '*';
            }
        }
    }
}
