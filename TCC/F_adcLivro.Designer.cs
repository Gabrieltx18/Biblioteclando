
namespace TCC
{
    partial class F_adcLivro
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
            this.lbl_ISBN = new System.Windows.Forms.Label();
            this.lbl_Titulo = new System.Windows.Forms.Label();
            this.lbl_Data = new System.Windows.Forms.Label();
            this.lbl_paginas = new System.Windows.Forms.Label();
            this.lbl_Descrição = new System.Windows.Forms.Label();
            this.lbl_Editora = new System.Windows.Forms.Label();
            this.lbl_Genero = new System.Windows.Forms.Label();
            this.lbl_Autor = new System.Windows.Forms.Label();
            this.btn_Cadastrar = new System.Windows.Forms.Button();
            this.tb_ISBN = new System.Windows.Forms.TextBox();
            this.tb_Editora = new System.Windows.Forms.TextBox();
            this.tb_Autor = new System.Windows.Forms.TextBox();
            this.tb_Genero = new System.Windows.Forms.TextBox();
            this.tb_Descrição = new System.Windows.Forms.TextBox();
            this.tb_Titulo = new System.Windows.Forms.TextBox();
            this.tb_Paginas = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // lbl_ISBN
            // 
            this.lbl_ISBN.AutoSize = true;
            this.lbl_ISBN.Location = new System.Drawing.Point(42, 58);
            this.lbl_ISBN.Name = "lbl_ISBN";
            this.lbl_ISBN.Size = new System.Drawing.Size(39, 17);
            this.lbl_ISBN.TabIndex = 0;
            this.lbl_ISBN.Text = "ISBN";
            // 
            // lbl_Titulo
            // 
            this.lbl_Titulo.AutoSize = true;
            this.lbl_Titulo.Location = new System.Drawing.Point(42, 92);
            this.lbl_Titulo.Name = "lbl_Titulo";
            this.lbl_Titulo.Size = new System.Drawing.Size(43, 17);
            this.lbl_Titulo.TabIndex = 1;
            this.lbl_Titulo.Text = "Titulo";
            // 
            // lbl_Data
            // 
            this.lbl_Data.AutoSize = true;
            this.lbl_Data.Location = new System.Drawing.Point(44, 258);
            this.lbl_Data.Name = "lbl_Data";
            this.lbl_Data.Size = new System.Drawing.Size(130, 17);
            this.lbl_Data.TabIndex = 2;
            this.lbl_Data.Text = "Data de publicação";
            // 
            // lbl_paginas
            // 
            this.lbl_paginas.AutoSize = true;
            this.lbl_paginas.Location = new System.Drawing.Point(42, 292);
            this.lbl_paginas.Name = "lbl_paginas";
            this.lbl_paginas.Size = new System.Drawing.Size(132, 17);
            this.lbl_paginas.TabIndex = 3;
            this.lbl_paginas.Text = "Numero de paginas";
            // 
            // lbl_Descrição
            // 
            this.lbl_Descrição.AutoSize = true;
            this.lbl_Descrição.Location = new System.Drawing.Point(45, 130);
            this.lbl_Descrição.Name = "lbl_Descrição";
            this.lbl_Descrição.Size = new System.Drawing.Size(71, 17);
            this.lbl_Descrição.TabIndex = 4;
            this.lbl_Descrição.Text = "Descrição";
            // 
            // lbl_Editora
            // 
            this.lbl_Editora.AutoSize = true;
            this.lbl_Editora.Location = new System.Drawing.Point(46, 230);
            this.lbl_Editora.Name = "lbl_Editora";
            this.lbl_Editora.Size = new System.Drawing.Size(53, 17);
            this.lbl_Editora.TabIndex = 5;
            this.lbl_Editora.Text = "Editora";
            // 
            // lbl_Genero
            // 
            this.lbl_Genero.AutoSize = true;
            this.lbl_Genero.Location = new System.Drawing.Point(45, 166);
            this.lbl_Genero.Name = "lbl_Genero";
            this.lbl_Genero.Size = new System.Drawing.Size(56, 17);
            this.lbl_Genero.TabIndex = 6;
            this.lbl_Genero.Text = "Genero";
            // 
            // lbl_Autor
            // 
            this.lbl_Autor.AutoSize = true;
            this.lbl_Autor.Location = new System.Drawing.Point(46, 195);
            this.lbl_Autor.Name = "lbl_Autor";
            this.lbl_Autor.Size = new System.Drawing.Size(42, 17);
            this.lbl_Autor.TabIndex = 7;
            this.lbl_Autor.Text = "Autor";
            // 
            // btn_Cadastrar
            // 
            this.btn_Cadastrar.Location = new System.Drawing.Point(580, 361);
            this.btn_Cadastrar.Name = "btn_Cadastrar";
            this.btn_Cadastrar.Size = new System.Drawing.Size(126, 34);
            this.btn_Cadastrar.TabIndex = 8;
            this.btn_Cadastrar.Text = "Cadastrar";
            this.btn_Cadastrar.UseVisualStyleBackColor = true;
            this.btn_Cadastrar.Click += new System.EventHandler(this.btn_Cadastrar_Click);
            // 
            // tb_ISBN
            // 
            this.tb_ISBN.Location = new System.Drawing.Point(87, 58);
            this.tb_ISBN.Name = "tb_ISBN";
            this.tb_ISBN.Size = new System.Drawing.Size(233, 22);
            this.tb_ISBN.TabIndex = 9;
            // 
            // tb_Editora
            // 
            this.tb_Editora.Location = new System.Drawing.Point(105, 225);
            this.tb_Editora.Name = "tb_Editora";
            this.tb_Editora.Size = new System.Drawing.Size(233, 22);
            this.tb_Editora.TabIndex = 11;
            // 
            // tb_Autor
            // 
            this.tb_Autor.Location = new System.Drawing.Point(94, 192);
            this.tb_Autor.Name = "tb_Autor";
            this.tb_Autor.Size = new System.Drawing.Size(233, 22);
            this.tb_Autor.TabIndex = 12;
            // 
            // tb_Genero
            // 
            this.tb_Genero.Location = new System.Drawing.Point(107, 163);
            this.tb_Genero.Name = "tb_Genero";
            this.tb_Genero.Size = new System.Drawing.Size(233, 22);
            this.tb_Genero.TabIndex = 13;
            // 
            // tb_Descrição
            // 
            this.tb_Descrição.Location = new System.Drawing.Point(122, 127);
            this.tb_Descrição.Multiline = true;
            this.tb_Descrição.Name = "tb_Descrição";
            this.tb_Descrição.Size = new System.Drawing.Size(277, 22);
            this.tb_Descrição.TabIndex = 14;
            // 
            // tb_Titulo
            // 
            this.tb_Titulo.Location = new System.Drawing.Point(87, 92);
            this.tb_Titulo.Name = "tb_Titulo";
            this.tb_Titulo.Size = new System.Drawing.Size(268, 22);
            this.tb_Titulo.TabIndex = 15;
            // 
            // tb_Paginas
            // 
            this.tb_Paginas.Location = new System.Drawing.Point(180, 289);
            this.tb_Paginas.Name = "tb_Paginas";
            this.tb_Paginas.Size = new System.Drawing.Size(233, 22);
            this.tb_Paginas.TabIndex = 16;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(180, 258);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 17;
            // 
            // F_adcLivro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 407);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.tb_Paginas);
            this.Controls.Add(this.tb_Titulo);
            this.Controls.Add(this.tb_Descrição);
            this.Controls.Add(this.tb_Genero);
            this.Controls.Add(this.tb_Autor);
            this.Controls.Add(this.tb_Editora);
            this.Controls.Add(this.tb_ISBN);
            this.Controls.Add(this.btn_Cadastrar);
            this.Controls.Add(this.lbl_Autor);
            this.Controls.Add(this.lbl_Genero);
            this.Controls.Add(this.lbl_Editora);
            this.Controls.Add(this.lbl_Descrição);
            this.Controls.Add(this.lbl_paginas);
            this.Controls.Add(this.lbl_Data);
            this.Controls.Add(this.lbl_Titulo);
            this.Controls.Add(this.lbl_ISBN);
            this.Name = "F_adcLivro";
            this.Text = "F_adcLivro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_ISBN;
        private System.Windows.Forms.Label lbl_Titulo;
        private System.Windows.Forms.Label lbl_Data;
        private System.Windows.Forms.Label lbl_paginas;
        private System.Windows.Forms.Label lbl_Descrição;
        private System.Windows.Forms.Label lbl_Editora;
        private System.Windows.Forms.Label lbl_Genero;
        private System.Windows.Forms.Label lbl_Autor;
        private System.Windows.Forms.Button btn_Cadastrar;
        private System.Windows.Forms.TextBox tb_ISBN;
        private System.Windows.Forms.TextBox tb_Editora;
        private System.Windows.Forms.TextBox tb_Autor;
        private System.Windows.Forms.TextBox tb_Genero;
        private System.Windows.Forms.TextBox tb_Descrição;
        private System.Windows.Forms.TextBox tb_Titulo;
        private System.Windows.Forms.TextBox tb_Paginas;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}