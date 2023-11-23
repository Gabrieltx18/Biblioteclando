
namespace TCC
{
    partial class F_updEmpretimo
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dt_novaDataEmprestimo = new System.Windows.Forms.DateTimePicker();
            this.dt_novaDataDevolucao = new System.Windows.Forms.DateTimePicker();
            this.tb_IdEmprestimo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Javanese Text", 10.2F);
            this.button1.Location = new System.Drawing.Point(522, 322);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 36);
            this.button1.TabIndex = 0;
            this.button1.Text = "Alterar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Javanese Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 45);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID do emprestimo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Javanese Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 45);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nova Data";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Javanese Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 215);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 45);
            this.label3.TabIndex = 3;
            this.label3.Text = "Devolução";
            // 
            // dt_novaDataEmprestimo
            // 
            this.dt_novaDataEmprestimo.Location = new System.Drawing.Point(130, 176);
            this.dt_novaDataEmprestimo.Name = "dt_novaDataEmprestimo";
            this.dt_novaDataEmprestimo.Size = new System.Drawing.Size(200, 22);
            this.dt_novaDataEmprestimo.TabIndex = 4;
            // 
            // dt_novaDataDevolucao
            // 
            this.dt_novaDataDevolucao.Location = new System.Drawing.Point(129, 222);
            this.dt_novaDataDevolucao.Name = "dt_novaDataDevolucao";
            this.dt_novaDataDevolucao.Size = new System.Drawing.Size(200, 22);
            this.dt_novaDataDevolucao.TabIndex = 5;
            // 
            // tb_IdEmprestimo
            // 
            this.tb_IdEmprestimo.Location = new System.Drawing.Point(190, 119);
            this.tb_IdEmprestimo.Name = "tb_IdEmprestimo";
            this.tb_IdEmprestimo.Size = new System.Drawing.Size(186, 22);
            this.tb_IdEmprestimo.TabIndex = 6;
            // 
            // F_updEmpretimo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(204)))), ((int)(((byte)(185)))));
            this.ClientSize = new System.Drawing.Size(636, 370);
            this.Controls.Add(this.tb_IdEmprestimo);
            this.Controls.Add(this.dt_novaDataDevolucao);
            this.Controls.Add(this.dt_novaDataEmprestimo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "F_updEmpretimo";
            this.Text = "Alterar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dt_novaDataEmprestimo;
        private System.Windows.Forms.DateTimePicker dt_novaDataDevolucao;
        private System.Windows.Forms.TextBox tb_IdEmprestimo;
    }
}