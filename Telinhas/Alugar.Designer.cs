﻿namespace LocadoraCarros.Telinhas
{
    partial class Alugar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Alugar));
            this.lb_alugar = new System.Windows.Forms.Label();
            this.lb_marca = new System.Windows.Forms.Label();
            this.lb_retirada = new System.Windows.Forms.Label();
            this.lb_modelo = new System.Windows.Forms.Label();
            this.lb_cor = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lb_devolucao = new System.Windows.Forms.Label();
            this.cB_marca = new System.Windows.Forms.ComboBox();
            this.cB_modelo = new System.Windows.Forms.ComboBox();
            this.cB_ano = new System.Windows.Forms.ComboBox();
            this.cB_cor = new System.Windows.Forms.ComboBox();
            this.bt_concluir = new System.Windows.Forms.Button();
            this.bt_cancelar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lb_sairHis = new System.Windows.Forms.Label();
            this.lb_usuarioAlu = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lb_menu = new System.Windows.Forms.Label();
            this.dt_nascimento = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_alugar
            // 
            this.lb_alugar.AutoSize = true;
            this.lb_alugar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_alugar.Location = new System.Drawing.Point(12, 12);
            this.lb_alugar.Name = "lb_alugar";
            this.lb_alugar.Size = new System.Drawing.Size(101, 32);
            this.lb_alugar.TabIndex = 0;
            this.lb_alugar.Text = "Alugar";
            // 
            // lb_marca
            // 
            this.lb_marca.AutoSize = true;
            this.lb_marca.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_marca.Location = new System.Drawing.Point(38, 195);
            this.lb_marca.Name = "lb_marca";
            this.lb_marca.Size = new System.Drawing.Size(63, 18);
            this.lb_marca.TabIndex = 1;
            this.lb_marca.Text = "Marca:";
            // 
            // lb_retirada
            // 
            this.lb_retirada.AutoSize = true;
            this.lb_retirada.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_retirada.Location = new System.Drawing.Point(322, 195);
            this.lb_retirada.Name = "lb_retirada";
            this.lb_retirada.Size = new System.Drawing.Size(82, 18);
            this.lb_retirada.TabIndex = 2;
            this.lb_retirada.Text = "Retirada:";
            // 
            // lb_modelo
            // 
            this.lb_modelo.AutoSize = true;
            this.lb_modelo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_modelo.Location = new System.Drawing.Point(31, 259);
            this.lb_modelo.Name = "lb_modelo";
            this.lb_modelo.Size = new System.Drawing.Size(70, 18);
            this.lb_modelo.TabIndex = 4;
            this.lb_modelo.Text = "Modelo:";
            // 
            // lb_cor
            // 
            this.lb_cor.AutoSize = true;
            this.lb_cor.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_cor.Location = new System.Drawing.Point(56, 396);
            this.lb_cor.Name = "lb_cor";
            this.lb_cor.Size = new System.Drawing.Size(42, 18);
            this.lb_cor.TabIndex = 5;
            this.lb_cor.Text = "Cor:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(56, 327);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = "Ano:";
            // 
            // lb_devolucao
            // 
            this.lb_devolucao.AutoSize = true;
            this.lb_devolucao.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_devolucao.Location = new System.Drawing.Point(306, 262);
            this.lb_devolucao.Name = "lb_devolucao";
            this.lb_devolucao.Size = new System.Drawing.Size(98, 18);
            this.lb_devolucao.TabIndex = 7;
            this.lb_devolucao.Text = "Devolução:";
            this.lb_devolucao.Click += new System.EventHandler(this.lb_devolucao_Click);
            // 
            // cB_marca
            // 
            this.cB_marca.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cB_marca.FormattingEnabled = true;
            this.cB_marca.Items.AddRange(new object[] {
            "Chevrolet",
            "Fiat",
            "Ford",
            "Peugeot",
            "Reno",
            "Volkswagen"});
            this.cB_marca.Location = new System.Drawing.Point(107, 192);
            this.cB_marca.Name = "cB_marca";
            this.cB_marca.Size = new System.Drawing.Size(193, 26);
            this.cB_marca.TabIndex = 8;
            this.cB_marca.SelectedIndexChanged += new System.EventHandler(this.cB_marca_SelectedIndexChanged);
            this.cB_marca.SelectedValueChanged += new System.EventHandler(this.cB_marca_SelectedValueChanged);
            // 
            // cB_modelo
            // 
            this.cB_modelo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cB_modelo.FormattingEnabled = true;
            this.cB_modelo.Location = new System.Drawing.Point(107, 259);
            this.cB_modelo.Name = "cB_modelo";
            this.cB_modelo.Size = new System.Drawing.Size(193, 26);
            this.cB_modelo.TabIndex = 9;
            // 
            // cB_ano
            // 
            this.cB_ano.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cB_ano.FormattingEnabled = true;
            this.cB_ano.Items.AddRange(new object[] {
            "2017",
            "2018",
            "2019",
            "2020",
            "2023",
            "2024"});
            this.cB_ano.Location = new System.Drawing.Point(107, 324);
            this.cB_ano.Name = "cB_ano";
            this.cB_ano.Size = new System.Drawing.Size(193, 26);
            this.cB_ano.TabIndex = 10;
            // 
            // cB_cor
            // 
            this.cB_cor.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cB_cor.FormattingEnabled = true;
            this.cB_cor.Items.AddRange(new object[] {
            "Branco",
            "Preto",
            "Prata",
            "Azul",
            "Vermelho"});
            this.cB_cor.Location = new System.Drawing.Point(107, 393);
            this.cB_cor.Name = "cB_cor";
            this.cB_cor.Size = new System.Drawing.Size(193, 26);
            this.cB_cor.TabIndex = 11;
            // 
            // bt_concluir
            // 
            this.bt_concluir.BackColor = System.Drawing.Color.White;
            this.bt_concluir.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_concluir.ForeColor = System.Drawing.Color.Black;
            this.bt_concluir.Location = new System.Drawing.Point(439, 355);
            this.bt_concluir.Name = "bt_concluir";
            this.bt_concluir.Size = new System.Drawing.Size(110, 34);
            this.bt_concluir.TabIndex = 12;
            this.bt_concluir.Text = "Concluir";
            this.bt_concluir.UseVisualStyleBackColor = false;
            this.bt_concluir.Click += new System.EventHandler(this.bt_concluir_Click);
            // 
            // bt_cancelar
            // 
            this.bt_cancelar.BackColor = System.Drawing.Color.White;
            this.bt_cancelar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_cancelar.ForeColor = System.Drawing.Color.Black;
            this.bt_cancelar.Location = new System.Drawing.Point(630, 355);
            this.bt_cancelar.Name = "bt_cancelar";
            this.bt_cancelar.Size = new System.Drawing.Size(110, 34);
            this.bt_cancelar.TabIndex = 13;
            this.bt_cancelar.Text = "Cancelar";
            this.bt_cancelar.UseVisualStyleBackColor = false;
            this.bt_cancelar.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.lb_sairHis);
            this.panel1.Controls.Add(this.lb_usuarioAlu);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Location = new System.Drawing.Point(-1, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(803, 82);
            this.panel1.TabIndex = 18;
            // 
            // lb_sairHis
            // 
            this.lb_sairHis.AutoSize = true;
            this.lb_sairHis.BackColor = System.Drawing.Color.Transparent;
            this.lb_sairHis.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_sairHis.ForeColor = System.Drawing.Color.White;
            this.lb_sairHis.Location = new System.Drawing.Point(735, 30);
            this.lb_sairHis.Name = "lb_sairHis";
            this.lb_sairHis.Size = new System.Drawing.Size(40, 18);
            this.lb_sairHis.TabIndex = 3;
            this.lb_sairHis.Text = "Sair";
            this.lb_sairHis.Click += new System.EventHandler(this.lb_sairHis_Click);
            // 
            // lb_usuarioAlu
            // 
            this.lb_usuarioAlu.AutoSize = true;
            this.lb_usuarioAlu.BackColor = System.Drawing.Color.Transparent;
            this.lb_usuarioAlu.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_usuarioAlu.ForeColor = System.Drawing.Color.White;
            this.lb_usuarioAlu.Location = new System.Drawing.Point(85, 12);
            this.lb_usuarioAlu.Name = "lb_usuarioAlu";
            this.lb_usuarioAlu.Size = new System.Drawing.Size(70, 18);
            this.lb_usuarioAlu.TabIndex = 2;
            this.lb_usuarioAlu.Text = "Usuario";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(67, 55);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lb_menu
            // 
            this.lb_menu.AutoSize = true;
            this.lb_menu.BackColor = System.Drawing.Color.Transparent;
            this.lb_menu.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.lb_menu.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_menu.ForeColor = System.Drawing.Color.Black;
            this.lb_menu.Location = new System.Drawing.Point(5, 143);
            this.lb_menu.Name = "lb_menu";
            this.lb_menu.Size = new System.Drawing.Size(84, 32);
            this.lb_menu.TabIndex = 17;
            this.lb_menu.Text = "Menu";
            // 
            // dt_nascimento
            // 
            this.dt_nascimento.CalendarFont = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dt_nascimento.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dt_nascimento.Location = new System.Drawing.Point(410, 259);
            this.dt_nascimento.MaxDate = new System.DateTime(2024, 1, 1, 0, 0, 0, 0);
            this.dt_nascimento.MinDate = new System.DateTime(2023, 8, 21, 0, 0, 0, 0);
            this.dt_nascimento.Name = "dt_nascimento";
            this.dt_nascimento.Size = new System.Drawing.Size(356, 26);
            this.dt_nascimento.TabIndex = 33;
            // 
            // dateTimePicker3
            // 
            this.dateTimePicker3.CalendarFont = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker3.Location = new System.Drawing.Point(410, 192);
            this.dateTimePicker3.MaxDate = new System.DateTime(2023, 11, 30, 0, 0, 0, 0);
            this.dateTimePicker3.MinDate = new System.DateTime(2023, 8, 21, 0, 0, 0, 0);
            this.dateTimePicker3.Name = "dateTimePicker3";
            this.dateTimePicker3.Size = new System.Drawing.Size(356, 26);
            this.dateTimePicker3.TabIndex = 34;
            this.dateTimePicker3.Value = new System.DateTime(2023, 8, 21, 0, 0, 0, 0);
            // 
            // Alugar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dateTimePicker3);
            this.Controls.Add(this.dt_nascimento);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lb_menu);
            this.Controls.Add(this.bt_cancelar);
            this.Controls.Add(this.bt_concluir);
            this.Controls.Add(this.cB_cor);
            this.Controls.Add(this.cB_ano);
            this.Controls.Add(this.cB_modelo);
            this.Controls.Add(this.cB_marca);
            this.Controls.Add(this.lb_devolucao);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lb_cor);
            this.Controls.Add(this.lb_modelo);
            this.Controls.Add(this.lb_retirada);
            this.Controls.Add(this.lb_marca);
            this.Controls.Add(this.lb_alugar);
            this.Name = "Alugar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alugar";
            this.Load += new System.EventHandler(this.Alugar_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_alugar;
        private System.Windows.Forms.Label lb_marca;
        private System.Windows.Forms.Label lb_retirada;
        private System.Windows.Forms.Label lb_modelo;
        private System.Windows.Forms.Label lb_cor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb_devolucao;
        private System.Windows.Forms.ComboBox cB_marca;
        private System.Windows.Forms.ComboBox cB_modelo;
        private System.Windows.Forms.ComboBox cB_ano;
        private System.Windows.Forms.ComboBox cB_cor;
        private System.Windows.Forms.Button bt_concluir;
        private System.Windows.Forms.Button bt_cancelar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lb_sairHis;
        private System.Windows.Forms.Label lb_usuarioAlu;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lb_menu;
        private System.Windows.Forms.DateTimePicker dt_nascimento;
        private System.Windows.Forms.DateTimePicker dateTimePicker3;
    }
}