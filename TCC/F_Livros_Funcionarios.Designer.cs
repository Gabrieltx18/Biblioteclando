
namespace TCC
{
    partial class F_Livros_Funcionarios
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_Busca = new System.Windows.Forms.Label();
            this.cb_Busca = new System.Windows.Forms.ComboBox();
            this.tb_Busca = new System.Windows.Forms.TextBox();
            this.dgv_Livros = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Livros)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Busca
            // 
            this.lbl_Busca.AutoSize = true;
            this.lbl_Busca.Location = new System.Drawing.Point(9, 33);
            this.lbl_Busca.Name = "lbl_Busca";
            this.lbl_Busca.Size = new System.Drawing.Size(81, 17);
            this.lbl_Busca.TabIndex = 26;
            this.lbl_Busca.Text = "Buscar por:";
            // 
            // cb_Busca
            // 
            this.cb_Busca.FormattingEnabled = true;
            this.cb_Busca.Items.AddRange(new object[] {
            "Título",
            "Autor",
            "Genero",
            "Editora",
            "Paginas",
            "Data de Publicação"});
            this.cb_Busca.Location = new System.Drawing.Point(96, 30);
            this.cb_Busca.Name = "cb_Busca";
            this.cb_Busca.Size = new System.Drawing.Size(121, 24);
            this.cb_Busca.TabIndex = 25;
            // 
            // tb_Busca
            // 
            this.tb_Busca.Location = new System.Drawing.Point(223, 30);
            this.tb_Busca.Name = "tb_Busca";
            this.tb_Busca.Size = new System.Drawing.Size(258, 22);
            this.tb_Busca.TabIndex = 24;
            this.tb_Busca.TextChanged += new System.EventHandler(this.tb_Busca_TextChanged);
            // 
            // dgv_Livros
            // 
            this.dgv_Livros.AllowUserToAddRows = false;
            this.dgv_Livros.AllowUserToDeleteRows = false;
            this.dgv_Livros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Livros.Location = new System.Drawing.Point(12, 79);
            this.dgv_Livros.Name = "dgv_Livros";
            this.dgv_Livros.ReadOnly = true;
            this.dgv_Livros.RowHeadersWidth = 51;
            this.dgv_Livros.RowTemplate.Height = 24;
            this.dgv_Livros.Size = new System.Drawing.Size(963, 461);
            this.dgv_Livros.TabIndex = 23;
            // 
            // F_Livros_Funcionarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(204)))), ((int)(((byte)(185)))));
            this.ClientSize = new System.Drawing.Size(990, 556);
            this.Controls.Add(this.lbl_Busca);
            this.Controls.Add(this.cb_Busca);
            this.Controls.Add(this.tb_Busca);
            this.Controls.Add(this.dgv_Livros);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "F_Livros_Funcionarios";
            this.Text = "F_Livros_Funcionarios";
            this.Load += new System.EventHandler(this.F_Livros_Funcionarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Livros)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Busca;
        private System.Windows.Forms.ComboBox cb_Busca;
        private System.Windows.Forms.TextBox tb_Busca;
        private System.Windows.Forms.DataGridView dgv_Livros;
    }
}