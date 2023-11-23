
namespace TCC
{
    partial class F_Empretimos
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
            this.lbl = new System.Windows.Forms.Label();
            this.cb_Busca = new System.Windows.Forms.ComboBox();
            this.btn_Cadastrar = new System.Windows.Forms.Button();
            this.tb_Busca = new System.Windows.Forms.TextBox();
            this.dgv_Emprestimos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Emprestimos)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Excluir
            // 
            this.btn_Excluir.FlatAppearance.BorderSize = 0;
            this.btn_Excluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Excluir.Font = new System.Drawing.Font("Javanese Text", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.btn_Alterar.FlatAppearance.BorderSize = 0;
            this.btn_Alterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Alterar.Font = new System.Drawing.Font("Javanese Text", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Alterar.Location = new System.Drawing.Point(878, 12);
            this.btn_Alterar.Name = "btn_Alterar";
            this.btn_Alterar.Size = new System.Drawing.Size(100, 65);
            this.btn_Alterar.TabIndex = 23;
            this.btn_Alterar.Text = "Alterar";
            this.btn_Alterar.UseVisualStyleBackColor = true;
            this.btn_Alterar.Click += new System.EventHandler(this.btn_Alterar_Click);
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("Javanese Text", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.Location = new System.Drawing.Point(9, 30);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(89, 34);
            this.lbl.TabIndex = 22;
            this.lbl.Text = "Buscar por:";
            // 
            // cb_Busca
            // 
            this.cb_Busca.FormattingEnabled = true;
            this.cb_Busca.Items.AddRange(new object[] {
            "Data de Emprestimo",
            "Previsão de Devolução"});
            this.cb_Busca.Location = new System.Drawing.Point(99, 33);
            this.cb_Busca.Name = "cb_Busca";
            this.cb_Busca.Size = new System.Drawing.Size(121, 24);
            this.cb_Busca.TabIndex = 21;
            // 
            // btn_Cadastrar
            // 
            this.btn_Cadastrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(204)))), ((int)(((byte)(185)))));
            this.btn_Cadastrar.FlatAppearance.BorderSize = 0;
            this.btn_Cadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Cadastrar.Font = new System.Drawing.Font("Javanese Text", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cadastrar.Location = new System.Drawing.Point(645, 12);
            this.btn_Cadastrar.Name = "btn_Cadastrar";
            this.btn_Cadastrar.Size = new System.Drawing.Size(110, 65);
            this.btn_Cadastrar.TabIndex = 20;
            this.btn_Cadastrar.Text = "Cadastrar";
            this.btn_Cadastrar.UseVisualStyleBackColor = false;
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
            // dgv_Emprestimos
            // 
            this.dgv_Emprestimos.AllowUserToAddRows = false;
            this.dgv_Emprestimos.AllowUserToDeleteRows = false;
            this.dgv_Emprestimos.AllowUserToResizeColumns = false;
            this.dgv_Emprestimos.AllowUserToResizeRows = false;
            this.dgv_Emprestimos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(204)))), ((int)(((byte)(185)))));
            this.dgv_Emprestimos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgv_Emprestimos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Emprestimos.Location = new System.Drawing.Point(15, 83);
            this.dgv_Emprestimos.Name = "dgv_Emprestimos";
            this.dgv_Emprestimos.ReadOnly = true;
            this.dgv_Emprestimos.RowHeadersWidth = 51;
            this.dgv_Emprestimos.RowTemplate.Height = 24;
            this.dgv_Emprestimos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgv_Emprestimos.Size = new System.Drawing.Size(963, 461);
            this.dgv_Emprestimos.TabIndex = 18;
            this.dgv_Emprestimos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Emprestimos_CellContentClick);
            // 
            // F_Empretimos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(204)))), ((int)(((byte)(185)))));
            this.ClientSize = new System.Drawing.Size(990, 556);
            this.Controls.Add(this.btn_Excluir);
            this.Controls.Add(this.btn_Alterar);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.cb_Busca);
            this.Controls.Add(this.btn_Cadastrar);
            this.Controls.Add(this.tb_Busca);
            this.Controls.Add(this.dgv_Emprestimos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "F_Empretimos";
            this.Text = "F_Empretimos";
            this.Load += new System.EventHandler(this.F_Empretimos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Emprestimos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Excluir;
        private System.Windows.Forms.Button btn_Alterar;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.ComboBox cb_Busca;
        private System.Windows.Forms.Button btn_Cadastrar;
        private System.Windows.Forms.TextBox tb_Busca;
        private System.Windows.Forms.DataGridView dgv_Emprestimos;
    }
}