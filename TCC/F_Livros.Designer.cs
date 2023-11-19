
namespace TCC
{
    partial class F_Livros
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
            this.btn_Excluir = new System.Windows.Forms.Button();
            this.btn_Alterar = new System.Windows.Forms.Button();
            this.lbl_Busca = new System.Windows.Forms.Label();
            this.cb_Busca = new System.Windows.Forms.ComboBox();
            this.btn_Cadastrar = new System.Windows.Forms.Button();
            this.tb_Busca = new System.Windows.Forms.TextBox();
            this.dgv_Livros = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Livros)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Excluir
            // 
            this.btn_Excluir.Location = new System.Drawing.Point(761, 12);
            this.btn_Excluir.Name = "btn_Excluir";
            this.btn_Excluir.Size = new System.Drawing.Size(100, 65);
            this.btn_Excluir.TabIndex = 24;
            this.btn_Excluir.Text = "Excluir";
            this.btn_Excluir.UseVisualStyleBackColor = true;
            this.btn_Excluir.Click += new System.EventHandler(this.btn_Excluir_Click);
            // 
            // btn_Alterar
            // 
            this.btn_Alterar.Location = new System.Drawing.Point(878, 12);
            this.btn_Alterar.Name = "btn_Alterar";
            this.btn_Alterar.Size = new System.Drawing.Size(100, 65);
            this.btn_Alterar.TabIndex = 23;
            this.btn_Alterar.Text = "Alterar";
            this.btn_Alterar.UseVisualStyleBackColor = true;
            // 
            // lbl_Busca
            // 
            this.lbl_Busca.AutoSize = true;
            this.lbl_Busca.Location = new System.Drawing.Point(12, 36);
            this.lbl_Busca.Name = "lbl_Busca";
            this.lbl_Busca.Size = new System.Drawing.Size(81, 17);
            this.lbl_Busca.TabIndex = 22;
            this.lbl_Busca.Text = "Buscar por:";
            // 
            // cb_Busca
            // 
            this.cb_Busca.FormattingEnabled = true;
            this.cb_Busca.Items.AddRange(new object[] {
            "Título"});
            this.cb_Busca.Location = new System.Drawing.Point(99, 33);
            this.cb_Busca.Name = "cb_Busca";
            this.cb_Busca.Size = new System.Drawing.Size(121, 24);
            this.cb_Busca.TabIndex = 21;
            // 
            // btn_Cadastrar
            // 
            this.btn_Cadastrar.Location = new System.Drawing.Point(645, 12);
            this.btn_Cadastrar.Name = "btn_Cadastrar";
            this.btn_Cadastrar.Size = new System.Drawing.Size(100, 65);
            this.btn_Cadastrar.TabIndex = 20;
            this.btn_Cadastrar.Text = "Cadastrar";
            this.btn_Cadastrar.UseVisualStyleBackColor = true;
            this.btn_Cadastrar.Click += new System.EventHandler(this.btn_Cadastrar_Click);
            // 
            // tb_Busca
            // 
            this.tb_Busca.Location = new System.Drawing.Point(226, 33);
            this.tb_Busca.Name = "tb_Busca";
            this.tb_Busca.Size = new System.Drawing.Size(258, 22);
            this.tb_Busca.TabIndex = 19;
            this.tb_Busca.TextChanged += new System.EventHandler(this.tb_Busca_TextChanged);
            // 
            // dgv_Livros
            // 
            this.dgv_Livros.AllowUserToAddRows = false;
            this.dgv_Livros.AllowUserToDeleteRows = false;
            this.dgv_Livros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Livros.Location = new System.Drawing.Point(15, 83);
            this.dgv_Livros.Name = "dgv_Livros";
            this.dgv_Livros.ReadOnly = true;
            this.dgv_Livros.RowHeadersWidth = 51;
            this.dgv_Livros.RowTemplate.Height = 24;
            this.dgv_Livros.Size = new System.Drawing.Size(963, 461);
            this.dgv_Livros.TabIndex = 18;
            // 
            // F_Livros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(204)))), ((int)(((byte)(185)))));
            this.ClientSize = new System.Drawing.Size(990, 556);
            this.Controls.Add(this.btn_Excluir);
            this.Controls.Add(this.btn_Alterar);
            this.Controls.Add(this.lbl_Busca);
            this.Controls.Add(this.cb_Busca);
            this.Controls.Add(this.btn_Cadastrar);
            this.Controls.Add(this.tb_Busca);
            this.Controls.Add(this.dgv_Livros);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "F_Livros";
            this.Text = "F_Livros";
            this.Load += new System.EventHandler(this.F_Livros_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Livros)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Excluir;
        private System.Windows.Forms.Button btn_Alterar;
        private System.Windows.Forms.Label lbl_Busca;
        private System.Windows.Forms.ComboBox cb_Busca;
        private System.Windows.Forms.Button btn_Cadastrar;
        private System.Windows.Forms.TextBox tb_Busca;
        private System.Windows.Forms.DataGridView dgv_Livros;
    }
}