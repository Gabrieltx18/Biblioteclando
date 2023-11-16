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

            string sql = "SELECT usuario,senha FROM tbUsuario " +
                   "WHERE usuario='" + username + "' AND senha= '" + senha + "'";

            dt = Banco.consulta(sql);

            if (dt.Rows.Count == 1)
            {
                F_MenuAdm f_MenuAdm = new F_MenuAdm();
                f_MenuAdm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Usuario ou Senha não encotrados");
                return;
            }
        }
    }
}
