
namespace TCC
{
    partial class F_Relatorio
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
            this.dgv_Relatorio = new System.Windows.Forms.DataGridView();
            this.dtPicker_Inicial = new System.Windows.Forms.DateTimePicker();
            this.dtPicker_Final = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_GerarRelatorio = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Relatorio)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_Relatorio
            // 
            this.dgv_Relatorio.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(204)))), ((int)(((byte)(185)))));
            this.dgv_Relatorio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Relatorio.Location = new System.Drawing.Point(263, 12);
            this.dgv_Relatorio.Name = "dgv_Relatorio";
            this.dgv_Relatorio.RowHeadersWidth = 51;
            this.dgv_Relatorio.RowTemplate.Height = 24;
            this.dgv_Relatorio.Size = new System.Drawing.Size(715, 532);
            this.dgv_Relatorio.TabIndex = 0;
            // 
            // dtPicker_Inicial
            // 
            this.dtPicker_Inicial.Location = new System.Drawing.Point(28, 188);
            this.dtPicker_Inicial.Name = "dtPicker_Inicial";
            this.dtPicker_Inicial.Size = new System.Drawing.Size(211, 22);
            this.dtPicker_Inicial.TabIndex = 1;
            // 
            // dtPicker_Final
            // 
            this.dtPicker_Final.Location = new System.Drawing.Point(28, 330);
            this.dtPicker_Final.Name = "dtPicker_Final";
            this.dtPicker_Final.Size = new System.Drawing.Size(211, 22);
            this.dtPicker_Final.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grip;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Javanese Text", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 38);
            this.label1.TabIndex = 3;
            this.label1.Text = "Data Inicial";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Javanese Text", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 289);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 38);
            this.label2.TabIndex = 4;
            this.label2.Text = "Data Final";
            // 
            // btn_GerarRelatorio
            // 
            this.btn_GerarRelatorio.Location = new System.Drawing.Point(28, 464);
            this.btn_GerarRelatorio.Name = "btn_GerarRelatorio";
            this.btn_GerarRelatorio.Size = new System.Drawing.Size(147, 50);
            this.btn_GerarRelatorio.TabIndex = 5;
            this.btn_GerarRelatorio.Text = "Gerar Relatorio";
            this.btn_GerarRelatorio.UseVisualStyleBackColor = true;
            this.btn_GerarRelatorio.Click += new System.EventHandler(this.btn_GerarRelatorio_Click);
            // 
            // F_Relatorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(204)))), ((int)(((byte)(185)))));
            this.ClientSize = new System.Drawing.Size(990, 556);
            this.Controls.Add(this.btn_GerarRelatorio);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtPicker_Final);
            this.Controls.Add(this.dtPicker_Inicial);
            this.Controls.Add(this.dgv_Relatorio);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "F_Relatorio";
            this.Text = "F_Relatorio";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Relatorio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_Relatorio;
        private System.Windows.Forms.DateTimePicker dtPicker_Inicial;
        private System.Windows.Forms.DateTimePicker dtPicker_Final;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_GerarRelatorio;
    }
}