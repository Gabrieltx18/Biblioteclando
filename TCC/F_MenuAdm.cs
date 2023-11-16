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

    public partial class F_MenuAdm : Form
    {
        private Form frmativo;
        
        public F_MenuAdm()
        {
            InitializeComponent();
        }
        private void fecharform()
        {
            if (frmativo != null)
                frmativo.Close();
        }
        private void FormShow(Form frm)
        {
            fecharform();
            frmativo = frm;
            frmativo.TopLevel = false;
            pn_form.Controls.Add(frm);
            frm.BringToFront();
            frm.Show();
        }

        private void btn_Clientes_Click(object sender, EventArgs e)
        {
            fecharform();
            FormShow(new F_Clientes());
        }
        private void button1_Click(object sender, EventArgs e)
        {
            fecharform();
            FormShow(new F_Livros());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            fecharform();
            FormShow(new F_Empretimos());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            fecharform();
            FormShow(new F_Funcionarios());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            fecharform();
            FormShow(new F_Relatorio());
        }
    }
}
