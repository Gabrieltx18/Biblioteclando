
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
            this.tb_Descrição = new System.Windows.Forms.TextBox();
            this.tb_Titulo = new System.Windows.Forms.TextBox();
            this.tb_Paginas = new System.Windows.Forms.TextBox();
            this.comboGenero = new System.Windows.Forms.ComboBox();
            this.comboAutor = new System.Windows.Forms.ComboBox();
            this.comboEditora = new System.Windows.Forms.ComboBox();
            this.dt_DataPublicacao = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // lbl_ISBN
            // 
            this.lbl_ISBN.AutoSize = true;
            this.lbl_ISBN.Font = new System.Drawing.Font("Arial", 12F);
            this.lbl_ISBN.Location = new System.Drawing.Point(36, 75);
            this.lbl_ISBN.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_ISBN.Name = "lbl_ISBN";
            this.lbl_ISBN.Size = new System.Drawing.Size(55, 23);
            this.lbl_ISBN.TabIndex = 0;
            this.lbl_ISBN.Text = "ISBN";
            // 
            // lbl_Titulo
            // 
            this.lbl_Titulo.AutoSize = true;
            this.lbl_Titulo.Font = new System.Drawing.Font("Arial", 12F);
            this.lbl_Titulo.Location = new System.Drawing.Point(303, 75);
            this.lbl_Titulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Titulo.Name = "lbl_Titulo";
            this.lbl_Titulo.Size = new System.Drawing.Size(56, 23);
            this.lbl_Titulo.TabIndex = 1;
            this.lbl_Titulo.Text = "Titulo";
            // 
            // lbl_Data
            // 
            this.lbl_Data.AutoSize = true;
            this.lbl_Data.Font = new System.Drawing.Font("Arial", 12F);
            this.lbl_Data.Location = new System.Drawing.Point(36, 325);
            this.lbl_Data.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Data.Name = "lbl_Data";
            this.lbl_Data.Size = new System.Drawing.Size(179, 23);
            this.lbl_Data.TabIndex = 2;
            this.lbl_Data.Text = "Data de publicação";
            // 
            // lbl_paginas
            // 
            this.lbl_paginas.AutoSize = true;
            this.lbl_paginas.Font = new System.Drawing.Font("Arial", 12F);
            this.lbl_paginas.Location = new System.Drawing.Point(231, 324);
            this.lbl_paginas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_paginas.Name = "lbl_paginas";
            this.lbl_paginas.Size = new System.Drawing.Size(180, 23);
            this.lbl_paginas.TabIndex = 3;
            this.lbl_paginas.Text = "Numero de paginas";
            // 
            // lbl_Descrição
            // 
            this.lbl_Descrição.AutoSize = true;
            this.lbl_Descrição.Font = new System.Drawing.Font("Arial", 12F);
            this.lbl_Descrição.Location = new System.Drawing.Point(36, 143);
            this.lbl_Descrição.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Descrição.Name = "lbl_Descrição";
            this.lbl_Descrição.Size = new System.Drawing.Size(98, 23);
            this.lbl_Descrição.TabIndex = 4;
            this.lbl_Descrição.Text = "Descrição";
            // 
            // lbl_Editora
            // 
            this.lbl_Editora.AutoSize = true;
            this.lbl_Editora.Font = new System.Drawing.Font("Arial", 12F);
            this.lbl_Editora.Location = new System.Drawing.Point(427, 248);
            this.lbl_Editora.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Editora.Name = "lbl_Editora";
            this.lbl_Editora.Size = new System.Drawing.Size(73, 23);
            this.lbl_Editora.TabIndex = 5;
            this.lbl_Editora.Text = "Editora";
            // 
            // lbl_Genero
            // 
            this.lbl_Genero.AutoSize = true;
            this.lbl_Genero.Font = new System.Drawing.Font("Arial", 12F);
            this.lbl_Genero.Location = new System.Drawing.Point(36, 248);
            this.lbl_Genero.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Genero.Name = "lbl_Genero";
            this.lbl_Genero.Size = new System.Drawing.Size(76, 23);
            this.lbl_Genero.TabIndex = 6;
            this.lbl_Genero.Text = "Genero";
            // 
            // lbl_Autor
            // 
            this.lbl_Autor.AutoSize = true;
            this.lbl_Autor.Font = new System.Drawing.Font("Arial", 12F);
            this.lbl_Autor.Location = new System.Drawing.Point(234, 248);
            this.lbl_Autor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Autor.Name = "lbl_Autor";
            this.lbl_Autor.Size = new System.Drawing.Size(57, 23);
            this.lbl_Autor.TabIndex = 7;
            this.lbl_Autor.Text = "Autor";
            // 
            // btn_Cadastrar
            // 
            this.btn_Cadastrar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_Cadastrar.FlatAppearance.BorderSize = 0;
            this.btn_Cadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Cadastrar.Font = new System.Drawing.Font("Javanese Text", 10.2F);
            this.btn_Cadastrar.Location = new System.Drawing.Point(499, 406);
            this.btn_Cadastrar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Cadastrar.Name = "btn_Cadastrar";
            this.btn_Cadastrar.Size = new System.Drawing.Size(149, 44);
            this.btn_Cadastrar.TabIndex = 8;
            this.btn_Cadastrar.Text = "Cadastrar";
            this.btn_Cadastrar.UseVisualStyleBackColor = false;
            this.btn_Cadastrar.Click += new System.EventHandler(this.btn_Cadastrar_Click);
            // 
            // tb_ISBN
            // 
            this.tb_ISBN.Location = new System.Drawing.Point(38, 102);
            this.tb_ISBN.Margin = new System.Windows.Forms.Padding(4);
            this.tb_ISBN.Name = "tb_ISBN";
            this.tb_ISBN.Size = new System.Drawing.Size(261, 27);
            this.tb_ISBN.TabIndex = 9;
            // 
            // tb_Descrição
            // 
            this.tb_Descrição.Location = new System.Drawing.Point(40, 170);
            this.tb_Descrição.Margin = new System.Windows.Forms.Padding(4);
            this.tb_Descrição.Multiline = true;
            this.tb_Descrição.Name = "tb_Descrição";
            this.tb_Descrição.Size = new System.Drawing.Size(610, 74);
            this.tb_Descrição.TabIndex = 14;
            // 
            // tb_Titulo
            // 
            this.tb_Titulo.Location = new System.Drawing.Point(307, 102);
            this.tb_Titulo.Margin = new System.Windows.Forms.Padding(4);
            this.tb_Titulo.Name = "tb_Titulo";
            this.tb_Titulo.Size = new System.Drawing.Size(341, 27);
            this.tb_Titulo.TabIndex = 15;
            // 
            // tb_Paginas
            // 
            this.tb_Paginas.Location = new System.Drawing.Point(235, 351);
            this.tb_Paginas.Margin = new System.Windows.Forms.Padding(4);
            this.tb_Paginas.Name = "tb_Paginas";
            this.tb_Paginas.Size = new System.Drawing.Size(261, 27);
            this.tb_Paginas.TabIndex = 16;
            // 
            // comboGenero
            // 
            this.comboGenero.FormattingEnabled = true;
            this.comboGenero.Location = new System.Drawing.Point(40, 274);
            this.comboGenero.Name = "comboGenero";
            this.comboGenero.Size = new System.Drawing.Size(189, 27);
            this.comboGenero.TabIndex = 18;
            // 
            // comboAutor
            // 
            this.comboAutor.FormattingEnabled = true;
            this.comboAutor.Location = new System.Drawing.Point(235, 274);
            this.comboAutor.Name = "comboAutor";
            this.comboAutor.Size = new System.Drawing.Size(189, 27);
            this.comboAutor.TabIndex = 19;
            // 
            // comboEditora
            // 
            this.comboEditora.FormattingEnabled = true;
            this.comboEditora.Location = new System.Drawing.Point(430, 274);
            this.comboEditora.Name = "comboEditora";
            this.comboEditora.Size = new System.Drawing.Size(220, 27);
            this.comboEditora.TabIndex = 20;
            // 
            // dt_DataPublicacao
            // 
            this.dt_DataPublicacao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_DataPublicacao.Location = new System.Drawing.Point(38, 351);
            this.dt_DataPublicacao.Name = "dt_DataPublicacao";
            this.dt_DataPublicacao.Size = new System.Drawing.Size(177, 27);
            this.dt_DataPublicacao.TabIndex = 21;
            this.dt_DataPublicacao.Value = new System.DateTime(2023, 12, 2, 0, 0, 0, 0);
            // 
            // F_adcLivro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(204)))), ((int)(((byte)(185)))));
            this.ClientSize = new System.Drawing.Size(677, 495);
            this.Controls.Add(this.dt_DataPublicacao);
            this.Controls.Add(this.lbl_paginas);
            this.Controls.Add(this.comboEditora);
            this.Controls.Add(this.comboAutor);
            this.Controls.Add(this.comboGenero);
            this.Controls.Add(this.tb_Paginas);
            this.Controls.Add(this.tb_Titulo);
            this.Controls.Add(this.tb_Descrição);
            this.Controls.Add(this.tb_ISBN);
            this.Controls.Add(this.btn_Cadastrar);
            this.Controls.Add(this.lbl_Autor);
            this.Controls.Add(this.lbl_Genero);
            this.Controls.Add(this.lbl_Editora);
            this.Controls.Add(this.lbl_Descrição);
            this.Controls.Add(this.lbl_Data);
            this.Controls.Add(this.lbl_Titulo);
            this.Controls.Add(this.lbl_ISBN);
            this.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "F_adcLivro";
            this.Text = "Cadastrar";
            this.Load += new System.EventHandler(this.F_adcLivro_Load);
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
        private System.Windows.Forms.TextBox tb_Descrição;
        private System.Windows.Forms.TextBox tb_Titulo;
        private System.Windows.Forms.TextBox tb_Paginas;
        private System.Windows.Forms.ComboBox comboGenero;
        private System.Windows.Forms.ComboBox comboAutor;
        private System.Windows.Forms.ComboBox comboEditora;
        private System.Windows.Forms.DateTimePicker dt_DataPublicacao;
    }
}