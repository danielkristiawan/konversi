﻿namespace Terbilangform
{
    partial class Form1
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
            this.inputNominal = new System.Windows.Forms.TextBox();
            this.hasilKonversi = new System.Windows.Forms.ListBox();
            this.btn_Konversi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nominal";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Terbilang";
            // 
            // inputNominal
            // 
            this.inputNominal.Location = new System.Drawing.Point(100, 39);
            this.inputNominal.Name = "inputNominal";
            this.inputNominal.Size = new System.Drawing.Size(100, 20);
            this.inputNominal.TabIndex = 3;
            // 
            // hasilKonversi
            // 
            this.hasilKonversi.FormattingEnabled = true;
            this.hasilKonversi.Location = new System.Drawing.Point(100, 84);
            this.hasilKonversi.Name = "hasilKonversi";
            this.hasilKonversi.Size = new System.Drawing.Size(335, 95);
            this.hasilKonversi.TabIndex = 4;
            // 
            // btn_Konversi
            // 
            this.btn_Konversi.Location = new System.Drawing.Point(259, 36);
            this.btn_Konversi.Name = "btn_Konversi";
            this.btn_Konversi.Size = new System.Drawing.Size(121, 23);
            this.btn_Konversi.TabIndex = 0;
            this.btn_Konversi.Text = "Cek Terbilang";
            this.btn_Konversi.UseVisualStyleBackColor = true;
            this.btn_Konversi.Click += new System.EventHandler(this.btn_Konversi_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 261);
            this.Controls.Add(this.btn_Konversi);
            this.Controls.Add(this.hasilKonversi);
            this.Controls.Add(this.inputNominal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox inputNominal;
        private System.Windows.Forms.ListBox hasilKonversi;
        private System.Windows.Forms.Button btn_Konversi;
    }
}

