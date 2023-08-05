using System;

namespace Otopark_Takip
{
    partial class frm2AraçOtoparkKaydı
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
            this.txtTc = new System.Windows.Forms.TextBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.TxtSoyad = new System.Windows.Forms.TextBox();
            this.TxtTelefon = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPlaka = new System.Windows.Forms.TextBox();
            this.txtRenk = new System.Windows.Forms.TextBox();
            this.comboMarka = new System.Windows.Forms.ComboBox();
            this.comboSeri = new System.Windows.Forms.ComboBox();
            this.comboParkYeri = new System.Windows.Forms.ComboBox();
            this.grupKişi = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grupAraç = new System.Windows.Forms.GroupBox();
            this.btnSeri = new System.Windows.Forms.Button();
            this.btnMarka = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.grupKişi.SuspendLayout();
            this.grupAraç.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtTc
            // 
            this.txtTc.Location = new System.Drawing.Point(104, 29);
            this.txtTc.Name = "txtTc";
            this.txtTc.Size = new System.Drawing.Size(100, 20);
            this.txtTc.TabIndex = 0;
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(104, 59);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(100, 20);
            this.txtAd.TabIndex = 1;
            // 
            // TxtSoyad
            // 
            this.TxtSoyad.Location = new System.Drawing.Point(104, 89);
            this.TxtSoyad.Name = "TxtSoyad";
            this.TxtSoyad.Size = new System.Drawing.Size(100, 20);
            this.TxtSoyad.TabIndex = 2;
            // 
            // TxtTelefon
            // 
            this.TxtTelefon.Location = new System.Drawing.Point(104, 119);
            this.TxtTelefon.Name = "TxtTelefon";
            this.TxtTelefon.Size = new System.Drawing.Size(100, 20);
            this.TxtTelefon.TabIndex = 3;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(104, 149);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(100, 20);
            this.txtEmail.TabIndex = 4;
            // 
            // txtPlaka
            // 
            this.txtPlaka.Location = new System.Drawing.Point(147, 29);
            this.txtPlaka.Name = "txtPlaka";
            this.txtPlaka.Size = new System.Drawing.Size(121, 20);
            this.txtPlaka.TabIndex = 5;
            // 
            // txtRenk
            // 
            this.txtRenk.Location = new System.Drawing.Point(147, 133);
            this.txtRenk.Name = "txtRenk";
            this.txtRenk.Size = new System.Drawing.Size(121, 20);
            this.txtRenk.TabIndex = 6;
            // 
            // comboMarka
            // 
            this.comboMarka.FormattingEnabled = true;
            this.comboMarka.Location = new System.Drawing.Point(147, 63);
            this.comboMarka.Name = "comboMarka";
            this.comboMarka.Size = new System.Drawing.Size(121, 21);
            this.comboMarka.TabIndex = 7;
            this.comboMarka.SelectedIndexChanged += new System.EventHandler(this.comboMarka_SelectedIndexChanged);
            // 
            // comboSeri
            // 
            this.comboSeri.FormattingEnabled = true;
            this.comboSeri.Location = new System.Drawing.Point(147, 98);
            this.comboSeri.Name = "comboSeri";
            this.comboSeri.Size = new System.Drawing.Size(121, 21);
            this.comboSeri.TabIndex = 8;
            // 
            // comboParkYeri
            // 
            this.comboParkYeri.FormattingEnabled = true;
            this.comboParkYeri.Location = new System.Drawing.Point(147, 167);
            this.comboParkYeri.Name = "comboParkYeri";
            this.comboParkYeri.Size = new System.Drawing.Size(121, 21);
            this.comboParkYeri.TabIndex = 9;
            
            // 
            // grupKişi
            // 
            this.grupKişi.Controls.Add(this.label5);
            this.grupKişi.Controls.Add(this.txtTc);
            this.grupKişi.Controls.Add(this.label4);
            this.grupKişi.Controls.Add(this.txtAd);
            this.grupKişi.Controls.Add(this.label3);
            this.grupKişi.Controls.Add(this.TxtSoyad);
            this.grupKişi.Controls.Add(this.label2);
            this.grupKişi.Controls.Add(this.TxtTelefon);
            this.grupKişi.Controls.Add(this.label1);
            this.grupKişi.Controls.Add(this.txtEmail);
            this.grupKişi.Location = new System.Drawing.Point(46, 35);
            this.grupKişi.Name = "grupKişi";
            this.grupKişi.Size = new System.Drawing.Size(220, 201);
            this.grupKişi.TabIndex = 10;
            this.grupKişi.TabStop = false;
            this.grupKişi.Text = "Kişi Bilgileri";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(53, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "E-mail";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Telefon";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Soyad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Ad";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "TC";
            // 
            // grupAraç
            // 
            this.grupAraç.Controls.Add(this.btnSeri);
            this.grupAraç.Controls.Add(this.btnMarka);
            this.grupAraç.Controls.Add(this.label10);
            this.grupAraç.Controls.Add(this.label9);
            this.grupAraç.Controls.Add(this.label8);
            this.grupAraç.Controls.Add(this.label7);
            this.grupAraç.Controls.Add(this.label6);
            this.grupAraç.Controls.Add(this.txtRenk);
            this.grupAraç.Controls.Add(this.txtPlaka);
            this.grupAraç.Controls.Add(this.comboParkYeri);
            this.grupAraç.Controls.Add(this.comboMarka);
            this.grupAraç.Controls.Add(this.comboSeri);
            this.grupAraç.Location = new System.Drawing.Point(312, 35);
            this.grupAraç.Name = "grupAraç";
            this.grupAraç.Size = new System.Drawing.Size(324, 201);
            this.grupAraç.TabIndex = 11;
            this.grupAraç.TabStop = false;
            this.grupAraç.Text = "Araç Gilgileri";
            this.grupAraç.Enter += new System.EventHandler(this.grupAraç_Enter);
            // 
            // btnSeri
            // 
            this.btnSeri.Location = new System.Drawing.Point(272, 98);
            this.btnSeri.Name = "btnSeri";
            this.btnSeri.Size = new System.Drawing.Size(32, 23);
            this.btnSeri.TabIndex = 16;
            this.btnSeri.Text = "+";
            this.btnSeri.UseVisualStyleBackColor = true;
            this.btnSeri.Click += new System.EventHandler(this.btnSeri_Click);
            // 
            // btnMarka
            // 
            this.btnMarka.Location = new System.Drawing.Point(272, 61);
            this.btnMarka.Name = "btnMarka";
            this.btnMarka.Size = new System.Drawing.Size(30, 23);
            this.btnMarka.TabIndex = 15;
            this.btnMarka.Text = "+";
            this.btnMarka.UseVisualStyleBackColor = true;
            this.btnMarka.Click += new System.EventHandler(this.btnMarka_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(73, 170);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(50, 13);
            this.label10.TabIndex = 14;
            this.label10.Text = "Park Yeri";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(90, 133);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(33, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = "Renk";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(98, 106);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(25, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Seri";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(86, 66);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Marka";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(89, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Plaka";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(223, 271);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Kayıt";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(326, 271);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 13;
            this.button2.Text = "İptal";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // frm2AraçOtoparkKaydı
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(639, 356);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.grupAraç);
            this.Controls.Add(this.grupKişi);
            this.Name = "frm2AraçOtoparkKaydı";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Araç Otopark Kaydı";
            this.Load += new System.EventHandler(this.frm2AraçOtoparkKaydı_Load);
            this.grupKişi.ResumeLayout(false);
            this.grupKişi.PerformLayout();
            this.grupAraç.ResumeLayout(false);
            this.grupAraç.PerformLayout();
            this.ResumeLayout(false);

        }

   
        #endregion

        private System.Windows.Forms.TextBox txtTc;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.TextBox TxtSoyad;
        private System.Windows.Forms.TextBox TxtTelefon;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPlaka;
        private System.Windows.Forms.TextBox txtRenk;
        private System.Windows.Forms.ComboBox comboMarka;
        private System.Windows.Forms.ComboBox comboSeri;
        private System.Windows.Forms.ComboBox comboParkYeri;
        private System.Windows.Forms.GroupBox grupKişi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grupAraç;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnSeri;
        private System.Windows.Forms.Button btnMarka;
    }
}