namespace BolenToplamları
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
            this.txtBolunen = new System.Windows.Forms.TextBox();
            this.txtBolen = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblToplam = new System.Windows.Forms.Label();
            this.lblBolenSayisi = new System.Windows.Forms.Label();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kaça Kadar Gitsin:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(245, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tam Bölenine Bakıl Sayı:";
            // 
            // txtBolunen
            // 
            this.txtBolunen.Location = new System.Drawing.Point(292, 28);
            this.txtBolunen.Name = "txtBolunen";
            this.txtBolunen.Size = new System.Drawing.Size(100, 31);
            this.txtBolunen.TabIndex = 2;
            // 
            // txtBolen
            // 
            this.txtBolen.Location = new System.Drawing.Point(292, 86);
            this.txtBolen.Name = "txtBolen";
            this.txtBolen.Size = new System.Drawing.Size(100, 31);
            this.txtBolen.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(268, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 22);
            this.label3.TabIndex = 4;
            this.label3.Text = "Toplam:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(62, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 22);
            this.label4.TabIndex = 5;
            this.label4.Text = "Bölen Sayısı:";
            // 
            // lblToplam
            // 
            this.lblToplam.AutoSize = true;
            this.lblToplam.Location = new System.Drawing.Point(362, 152);
            this.lblToplam.Name = "lblToplam";
            this.lblToplam.Size = new System.Drawing.Size(20, 22);
            this.lblToplam.TabIndex = 6;
            this.lblToplam.Text = "0";
            // 
            // lblBolenSayisi
            // 
            this.lblBolenSayisi.AutoSize = true;
            this.lblBolenSayisi.Location = new System.Drawing.Point(199, 152);
            this.lblBolenSayisi.Name = "lblBolenSayisi";
            this.lblBolenSayisi.Size = new System.Drawing.Size(20, 22);
            this.lblBolenSayisi.TabIndex = 7;
            this.lblBolenSayisi.Text = "0";
            // 
            // btnHesapla
            // 
            this.btnHesapla.Location = new System.Drawing.Point(186, 210);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(100, 39);
            this.btnHesapla.TabIndex = 8;
            this.btnHesapla.Text = "Hesapla";
            this.btnHesapla.UseVisualStyleBackColor = true;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 287);
            this.Controls.Add(this.btnHesapla);
            this.Controls.Add(this.lblBolenSayisi);
            this.Controls.Add(this.lblToplam);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBolen);
            this.Controls.Add(this.txtBolunen);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Calisto MT", 15F, System.Drawing.FontStyle.Bold);
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBolunen;
        private System.Windows.Forms.TextBox txtBolen;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblToplam;
        private System.Windows.Forms.Label lblBolenSayisi;
        private System.Windows.Forms.Button btnHesapla;

    }
}

