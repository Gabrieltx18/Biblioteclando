
namespace TCC
{
    partial class F_adcEmpretimo
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
            this.dt_devolucao = new System.Windows.Forms.DateTimePicker();
            this.dt_emprestimo = new System.Windows.Forms.DateTimePicker();
            this.tb_livro = new System.Windows.Forms.TextBox();
            this.tb_cliente = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dt_devolucao
            // 
            this.dt_devolucao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_devolucao.Location = new System.Drawing.Point(154, 262);
            this.dt_devolucao.Name = "dt_devolucao";
            this.dt_devolucao.Size = new System.Drawing.Size(150, 22);
            this.dt_devolucao.TabIndex = 0;
            // 
            // dt_emprestimo
            // 
            this.dt_emprestimo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_emprestimo.Location = new System.Drawing.Point(215, 211);
            this.dt_emprestimo.Name = "dt_emprestimo";
            this.dt_emprestimo.Size = new System.Drawing.Size(139, 22);
            this.dt_emprestimo.TabIndex = 1;
            // 
            // tb_livro
            // 
            this.tb_livro.Location = new System.Drawing.Point(31, 178);
            this.tb_livro.Name = "tb_livro";
            this.tb_livro.Size = new System.Drawing.Size(273, 22);
            this.tb_livro.TabIndex = 2;
            // 
            // tb_cliente
            // 
            this.tb_cliente.Location = new System.Drawing.Point(31, 117);
            this.tb_cliente.Name = "tb_cliente";
            this.tb_cliente.Size = new System.Drawing.Size(285, 22);
            this.tb_cliente.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 210);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "Data de Empretimo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 255);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 23);
            this.label2.TabIndex = 5;
            this.label2.Text = "Devolução";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 23);
            this.label3.TabIndex = 6;
            this.label3.Text = "Livro emprestado";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(27, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 23);
            this.label4.TabIndex = 7;
            this.label4.Text = "Cliente";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Javanese Text", 10.2F);
            this.button1.Location = new System.Drawing.Point(386, 287);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 37);
            this.button1.TabIndex = 8;
            this.button1.Text = "Cadastrar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // F_adcEmpretimo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(204)))), ((int)(((byte)(185)))));
            this.ClientSize = new System.Drawing.Size(563, 387);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_cliente);
            this.Controls.Add(this.tb_livro);
            this.Controls.Add(this.dt_emprestimo);
            this.Controls.Add(this.dt_devolucao);
            this.Name = "F_adcEmpretimo";
            this.Text = "Cadastrar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dt_devolucao;
        private System.Windows.Forms.DateTimePicker dt_emprestimo;
        private System.Windows.Forms.TextBox tb_livro;
        private System.Windows.Forms.TextBox tb_cliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
    }
}