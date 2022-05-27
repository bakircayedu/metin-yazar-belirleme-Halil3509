
namespace odev2_3
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
            this.btnMetinYukle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDosyaYolu = new System.Windows.Forms.TextBox();
            this.btnStackOku = new System.Windows.Forms.Button();
            this.rtbDosyaOzellikleri = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAgacaAktar = new System.Windows.Forms.Button();
            this.btnEnSikKelime = new System.Windows.Forms.Button();
            this.txtKelimeAdet = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMetinYukle
            // 
            this.btnMetinYukle.Location = new System.Drawing.Point(36, 32);
            this.btnMetinYukle.Name = "btnMetinYukle";
            this.btnMetinYukle.Size = new System.Drawing.Size(128, 33);
            this.btnMetinYukle.TabIndex = 0;
            this.btnMetinYukle.Text = "Metin Yükle";
            this.btnMetinYukle.UseVisualStyleBackColor = true;
            this.btnMetinYukle.Click += new System.EventHandler(this.btnMetinYukle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(202, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Dosya Yolu";
            // 
            // txtDosyaYolu
            // 
            this.txtDosyaYolu.Location = new System.Drawing.Point(189, 39);
            this.txtDosyaYolu.Name = "txtDosyaYolu";
            this.txtDosyaYolu.Size = new System.Drawing.Size(210, 20);
            this.txtDosyaYolu.TabIndex = 2;
            // 
            // btnStackOku
            // 
            this.btnStackOku.Location = new System.Drawing.Point(36, 114);
            this.btnStackOku.Name = "btnStackOku";
            this.btnStackOku.Size = new System.Drawing.Size(128, 33);
            this.btnStackOku.TabIndex = 3;
            this.btnStackOku.Text = "Stack Oku";
            this.btnStackOku.UseVisualStyleBackColor = true;
            this.btnStackOku.Click += new System.EventHandler(this.btnStackOku_Click);
            // 
            // rtbDosyaOzellikleri
            // 
            this.rtbDosyaOzellikleri.Location = new System.Drawing.Point(36, 206);
            this.rtbDosyaOzellikleri.Name = "rtbDosyaOzellikleri";
            this.rtbDosyaOzellikleri.Size = new System.Drawing.Size(265, 277);
            this.rtbDosyaOzellikleri.TabIndex = 4;
            this.rtbDosyaOzellikleri.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Dosya Özellikleri";
            // 
            // btnAgacaAktar
            // 
            this.btnAgacaAktar.Location = new System.Drawing.Point(36, 543);
            this.btnAgacaAktar.Name = "btnAgacaAktar";
            this.btnAgacaAktar.Size = new System.Drawing.Size(128, 33);
            this.btnAgacaAktar.TabIndex = 6;
            this.btnAgacaAktar.Text = "Ağaca Aktar";
            this.btnAgacaAktar.UseVisualStyleBackColor = true;
            this.btnAgacaAktar.Click += new System.EventHandler(this.btnAgacaAktar_Click);
            // 
            // btnEnSikKelime
            // 
            this.btnEnSikKelime.Location = new System.Drawing.Point(580, 32);
            this.btnEnSikKelime.Name = "btnEnSikKelime";
            this.btnEnSikKelime.Size = new System.Drawing.Size(194, 33);
            this.btnEnSikKelime.TabIndex = 7;
            this.btnEnSikKelime.Text = "En Sık Kullanılan Kelimeleri Getir";
            this.btnEnSikKelime.UseVisualStyleBackColor = true;
            this.btnEnSikKelime.Click += new System.EventHandler(this.btnEnSikKelime_Click);
            // 
            // txtKelimeAdet
            // 
            this.txtKelimeAdet.Location = new System.Drawing.Point(792, 39);
            this.txtKelimeAdet.Name = "txtKelimeAdet";
            this.txtKelimeAdet.Size = new System.Drawing.Size(38, 20);
            this.txtKelimeAdet.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(945, 32);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(152, 43);
            this.button1.TabIndex = 9;
            this.button1.Text = "Hash Tablo Oluştur";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1372, 826);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtKelimeAdet);
            this.Controls.Add(this.btnEnSikKelime);
            this.Controls.Add(this.btnAgacaAktar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rtbDosyaOzellikleri);
            this.Controls.Add(this.btnStackOku);
            this.Controls.Add(this.txtDosyaYolu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnMetinYukle);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMetinYukle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDosyaYolu;
        private System.Windows.Forms.Button btnStackOku;
        private System.Windows.Forms.RichTextBox rtbDosyaOzellikleri;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAgacaAktar;
        private System.Windows.Forms.Button btnEnSikKelime;
        private System.Windows.Forms.TextBox txtKelimeAdet;
        private System.Windows.Forms.Button button1;
    }
}

