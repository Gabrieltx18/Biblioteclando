﻿
namespace TCC
{
    partial class F_adcFuncionario
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_senha = new System.Windows.Forms.Button();
            this.btn_cadastrar = new System.Windows.Forms.Button();
            this.tb_Senha = new System.Windows.Forms.TextBox();
            this.tb_nome = new System.Windows.Forms.TextBox();
            this.cb_cargo = new System.Windows.Forms.ComboBox();
            this.dt_adimissão = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Senha";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 249);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Adimissão";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Cargo";
            // 
            // btn_senha
            // 
            this.btn_senha.Location = new System.Drawing.Point(285, 137);
            this.btn_senha.Name = "btn_senha";
            this.btn_senha.Size = new System.Drawing.Size(103, 23);
            this.btn_senha.TabIndex = 4;
            this.btn_senha.Text = "Gerar Senha";
            this.btn_senha.UseVisualStyleBackColor = true;
            this.btn_senha.Click += new System.EventHandler(this.btn_senha_Click);
            // 
            // btn_cadastrar
            // 
            this.btn_cadastrar.Location = new System.Drawing.Point(688, 415);
            this.btn_cadastrar.Name = "btn_cadastrar";
            this.btn_cadastrar.Size = new System.Drawing.Size(75, 23);
            this.btn_cadastrar.TabIndex = 5;
            this.btn_cadastrar.Text = "button2";
            this.btn_cadastrar.UseVisualStyleBackColor = true;
            this.btn_cadastrar.Click += new System.EventHandler(this.btn_cadastrar_Click);
            // 
            // tb_Senha
            // 
            this.tb_Senha.Location = new System.Drawing.Point(85, 137);
            this.tb_Senha.Name = "tb_Senha";
            this.tb_Senha.Size = new System.Drawing.Size(184, 22);
            this.tb_Senha.TabIndex = 6;
            // 
            // tb_nome
            // 
            this.tb_nome.Location = new System.Drawing.Point(85, 85);
            this.tb_nome.Name = "tb_nome";
            this.tb_nome.Size = new System.Drawing.Size(109, 22);
            this.tb_nome.TabIndex = 7;
            // 
            // cb_cargo
            // 
            this.cb_cargo.FormattingEnabled = true;
            this.cb_cargo.Items.AddRange(new object[] {
            "Gerente",
            "Auxiliar",
            "Bibliotecario"});
            this.cb_cargo.Location = new System.Drawing.Point(89, 192);
            this.cb_cargo.Name = "cb_cargo";
            this.cb_cargo.Size = new System.Drawing.Size(121, 24);
            this.cb_cargo.TabIndex = 8;
            // 
            // dt_adimissão
            // 
            this.dt_adimissão.Location = new System.Drawing.Point(125, 244);
            this.dt_adimissão.Name = "dt_adimissão";
            this.dt_adimissão.Size = new System.Drawing.Size(200, 22);
            this.dt_adimissão.TabIndex = 9;
            // 
            // F_adcFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dt_adimissão);
            this.Controls.Add(this.cb_cargo);
            this.Controls.Add(this.tb_nome);
            this.Controls.Add(this.tb_Senha);
            this.Controls.Add(this.btn_cadastrar);
            this.Controls.Add(this.btn_senha);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "F_adcFuncionario";
            this.Text = "F_adcFuncionario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_senha;
        private System.Windows.Forms.Button btn_cadastrar;
        private System.Windows.Forms.TextBox tb_Senha;
        private System.Windows.Forms.TextBox tb_nome;
        private System.Windows.Forms.ComboBox cb_cargo;
        private System.Windows.Forms.DateTimePicker dt_adimissão;
    }
}