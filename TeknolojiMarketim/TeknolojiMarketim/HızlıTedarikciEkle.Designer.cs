﻿namespace TeknolojiMarketim
{
    partial class HızlıTedarikciEkle
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
            this.IsActive = new System.Windows.Forms.CheckBox();
            this.btn_ekle = new System.Windows.Forms.Button();
            this.tb_ekle = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // IsActive
            // 
            this.IsActive.AutoSize = true;
            this.IsActive.Location = new System.Drawing.Point(273, 107);
            this.IsActive.Name = "IsActive";
            this.IsActive.Size = new System.Drawing.Size(54, 20);
            this.IsActive.TabIndex = 15;
            this.IsActive.Text = "Aktif";
            this.IsActive.UseVisualStyleBackColor = true;
            // 
            // btn_ekle
            // 
            this.btn_ekle.Location = new System.Drawing.Point(333, 104);
            this.btn_ekle.Name = "btn_ekle";
            this.btn_ekle.Size = new System.Drawing.Size(75, 23);
            this.btn_ekle.TabIndex = 14;
            this.btn_ekle.Text = "Ekle";
            this.btn_ekle.UseVisualStyleBackColor = true;
            this.btn_ekle.Click += new System.EventHandler(this.btn_ekle_Click);
            // 
            // tb_ekle
            // 
            this.tb_ekle.Location = new System.Drawing.Point(157, 76);
            this.tb_ekle.Name = "tb_ekle";
            this.tb_ekle.Size = new System.Drawing.Size(251, 22);
            this.tb_ekle.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "Tedarikçi Ekle";
            // 
            // HızlıTedarikciEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 203);
            this.Controls.Add(this.IsActive);
            this.Controls.Add(this.btn_ekle);
            this.Controls.Add(this.tb_ekle);
            this.Controls.Add(this.label1);
            this.Name = "HızlıTedarikciEkle";
            this.Text = "HızlıTedarikciEkle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox IsActive;
        private System.Windows.Forms.Button btn_ekle;
        private System.Windows.Forms.TextBox tb_ekle;
        private System.Windows.Forms.Label label1;
    }
}