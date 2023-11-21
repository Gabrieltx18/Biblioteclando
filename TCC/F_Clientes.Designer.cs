
namespace TCC
{
    partial class F_Clientes
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
            this.dgv_Clientes = new System.Windows.Forms.DataGridView();
            this.tb_Busca = new System.Windows.Forms.TextBox();
            this.btn_Cadastrar = new System.Windows.Forms.Button();
            this.cb_Busca = new System.Windows.Forms.ComboBox();
            this.lbl_Busca = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Clientes)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_Clientes
            // 
            this.dgv_Clientes.AllowUserToAddRows = false;
            this.dgv_Clientes.AllowUserToDeleteRows = false;
            this.dgv_Clientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Clientes.Location = new System.Drawing.Point(15, 83);
            this.dgv_Clientes.Name = "dgv_Clientes";
            this.dgv_Clientes.ReadOnly = true;
            this.dgv_Clientes.RowHeadersWidth = 51;
            this.dgv_Clientes.RowTemplate.Height = 24;
            this.dgv_Clientes.Size = new System.Drawing.Size(963, 461);
            this.dgv_Clientes.TabIndex = 0;
            // 
            // tb_Busca
            // 
            this.tb_Busca.Location = new System.Drawing.Point(226, 33);
            this.tb_Busca.Name = "tb_Busca";
            this.tb_Busca.Size = new System.Drawing.Size(258, 22);
            this.tb_Busca.TabIndex = 1;
            this.tb_Busca.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btn_Cadastrar
            // 
            this.btn_Cadastrar.Location = new System.Drawing.Point(878, 12);
            this.btn_Cadastrar.Name = "btn_Cadastrar";
            this.btn_Cadastrar.Size = new System.Drawing.Size(100, 65);
            this.btn_Cadastrar.TabIndex = 5;
            this.btn_Cadastrar.Text = "Cadastrar";
            this.btn_Cadastrar.UseVisualStyleBackColor = true;
            this.btn_Cadastrar.Click += new System.EventHandler(this.btn_Cadastrar_Click);
            // 
            // cb_Busca
            // 
            this.cb_Busca.FormattingEnabled = true;
            this.cb_Busca.Items.AddRange(new object[] {
            "Nome",
            "CPF",
            "Telefone"});
            this.cb_Busca.Location = new System.Drawing.Point(99, 33);
            this.cb_Busca.Name = "cb_Busca";
            this.cb_Busca.Size = new System.Drawing.Size(121, 24);
            this.cb_Busca.TabIndex = 7;
            this.cb_Busca.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lbl_Busca
            // 
            this.lbl_Busca.AutoSize = true;
            this.lbl_Busca.Location = new System.Drawing.Point(12, 36);
            this.lbl_Busca.Name = "lbl_Busca";
            this.lbl_Busca.Size = new System.Drawing.Size(81, 17);
            this.lbl_Busca.TabIndex = 8;
            this.lbl_Busca.Text = "Buscar por:";
            // 
            // F_Clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(204)))), ((int)(((byte)(185)))));
            this.ClientSize = new System.Drawing.Size(990, 556);
            this.Controls.Add(this.lbl_Busca);
            this.Controls.Add(this.cb_Busca);
            this.Controls.Add(this.btn_Cadastrar);
            this.Controls.Add(this.tb_Busca);
            this.Controls.Add(this.dgv_Clientes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "F_Clientes";
            this.Text = "F_Clientes";
            this.Load += new System.EventHandler(this.F_Clientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Clientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_Clientes;
        private System.Windows.Forms.TextBox tb_Busca;
        private System.Windows.Forms.Button btn_Cadastrar;
        private System.Windows.Forms.ComboBox cb_Busca;
        private System.Windows.Forms.Label lbl_Busca;
    }
}