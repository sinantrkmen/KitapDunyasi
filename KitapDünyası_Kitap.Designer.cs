
namespace kitapDunyasi
{
    partial class KitapDünyası_Kitap
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnListele = new System.Windows.Forms.Button();
            this.btnAra = new System.Windows.Forms.Button();
            this.kitapId = new System.Windows.Forms.Label();
            this.dilId = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtKitapId = new System.Windows.Forms.TextBox();
            this.txtdilId = new System.Windows.Forms.TextBox();
            this.txtAdi = new System.Windows.Forms.TextBox();
            this.txtISBN = new System.Windows.Forms.TextBox();
            this.txtSayfaSayisi = new System.Windows.Forms.TextBox();
            this.txtBasimTarihi = new System.Windows.Forms.TextBox();
            this.txtKiralamaFiyati = new System.Windows.Forms.TextBox();
            this.textKiralamaSuresi = new System.Windows.Forms.TextBox();
            this.txtSonGuncellemeTarihi = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(21, 211);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1207, 376);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnEkle
            // 
            this.btnEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEkle.Location = new System.Drawing.Point(1109, 53);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(97, 31);
            this.btnEkle.TabIndex = 1;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSil
            // 
            this.btnSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil.Location = new System.Drawing.Point(1109, 129);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(97, 30);
            this.btnSil.TabIndex = 2;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGuncelle.Location = new System.Drawing.Point(1109, 90);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(97, 33);
            this.btnGuncelle.TabIndex = 3;
            this.btnGuncelle.Text = "Guncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnListele
            // 
            this.btnListele.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnListele.Location = new System.Drawing.Point(1109, 14);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(97, 33);
            this.btnListele.TabIndex = 4;
            this.btnListele.Text = "Listele";
            this.btnListele.UseVisualStyleBackColor = true;
            this.btnListele.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnAra
            // 
            this.btnAra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAra.Location = new System.Drawing.Point(1109, 165);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(97, 30);
            this.btnAra.TabIndex = 5;
            this.btnAra.Text = "Ara";
            this.btnAra.UseVisualStyleBackColor = true;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // kitapId
            // 
            this.kitapId.AutoSize = true;
            this.kitapId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kitapId.Location = new System.Drawing.Point(62, 14);
            this.kitapId.Name = "kitapId";
            this.kitapId.Size = new System.Drawing.Size(57, 20);
            this.kitapId.TabIndex = 6;
            this.kitapId.Text = "kitapId";
            // 
            // dilId
            // 
            this.dilId.AutoSize = true;
            this.dilId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dilId.Location = new System.Drawing.Point(81, 47);
            this.dilId.Name = "dilId";
            this.dilId.Size = new System.Drawing.Size(38, 20);
            this.dilId.TabIndex = 7;
            this.dilId.Text = "dilId";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(35, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Kitabın Adı";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(72, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "ISBN";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(24, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Sayfa Sayısı";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(537, 126);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(169, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "Son Güncelleme Tarihi";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(589, 89);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(119, 20);
            this.label7.TabIndex = 13;
            this.label7.Text = "Kiralama Süresi";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(595, 53);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(111, 20);
            this.label8.TabIndex = 12;
            this.label8.Text = "Kiralama Fiyatı";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(611, 14);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(95, 20);
            this.label9.TabIndex = 11;
            this.label9.Text = "Basım Tarihi";
            // 
            // txtKitapId
            // 
            this.txtKitapId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKitapId.Location = new System.Drawing.Point(135, 8);
            this.txtKitapId.Name = "txtKitapId";
            this.txtKitapId.Size = new System.Drawing.Size(317, 26);
            this.txtKitapId.TabIndex = 15;
            this.txtKitapId.TextChanged += new System.EventHandler(this.txtKitapId_TextChanged);
            // 
            // txtdilId
            // 
            this.txtdilId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtdilId.Location = new System.Drawing.Point(135, 47);
            this.txtdilId.Name = "txtdilId";
            this.txtdilId.Size = new System.Drawing.Size(317, 26);
            this.txtdilId.TabIndex = 16;
            // 
            // txtAdi
            // 
            this.txtAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAdi.Location = new System.Drawing.Point(135, 86);
            this.txtAdi.Name = "txtAdi";
            this.txtAdi.Size = new System.Drawing.Size(317, 26);
            this.txtAdi.TabIndex = 17;
            // 
            // txtISBN
            // 
            this.txtISBN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtISBN.Location = new System.Drawing.Point(135, 120);
            this.txtISBN.Name = "txtISBN";
            this.txtISBN.Size = new System.Drawing.Size(317, 26);
            this.txtISBN.TabIndex = 18;
            // 
            // txtSayfaSayisi
            // 
            this.txtSayfaSayisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSayfaSayisi.Location = new System.Drawing.Point(135, 159);
            this.txtSayfaSayisi.Name = "txtSayfaSayisi";
            this.txtSayfaSayisi.Size = new System.Drawing.Size(317, 26);
            this.txtSayfaSayisi.TabIndex = 19;
            // 
            // txtBasimTarihi
            // 
            this.txtBasimTarihi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBasimTarihi.Location = new System.Drawing.Point(725, 11);
            this.txtBasimTarihi.Name = "txtBasimTarihi";
            this.txtBasimTarihi.Size = new System.Drawing.Size(317, 26);
            this.txtBasimTarihi.TabIndex = 20;
            // 
            // txtKiralamaFiyati
            // 
            this.txtKiralamaFiyati.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKiralamaFiyati.Location = new System.Drawing.Point(725, 50);
            this.txtKiralamaFiyati.Name = "txtKiralamaFiyati";
            this.txtKiralamaFiyati.Size = new System.Drawing.Size(317, 26);
            this.txtKiralamaFiyati.TabIndex = 21;
            // 
            // textKiralamaSuresi
            // 
            this.textKiralamaSuresi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textKiralamaSuresi.Location = new System.Drawing.Point(725, 89);
            this.textKiralamaSuresi.Name = "textKiralamaSuresi";
            this.textKiralamaSuresi.Size = new System.Drawing.Size(317, 26);
            this.textKiralamaSuresi.TabIndex = 22;
            // 
            // txtSonGuncellemeTarihi
            // 
            this.txtSonGuncellemeTarihi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSonGuncellemeTarihi.Location = new System.Drawing.Point(725, 126);
            this.txtSonGuncellemeTarihi.Name = "txtSonGuncellemeTarihi";
            this.txtSonGuncellemeTarihi.Size = new System.Drawing.Size(317, 26);
            this.txtSonGuncellemeTarihi.TabIndex = 23;
            // 
            // KitapDünyası_Kitap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1240, 599);
            this.Controls.Add(this.txtSonGuncellemeTarihi);
            this.Controls.Add(this.textKiralamaSuresi);
            this.Controls.Add(this.txtKiralamaFiyati);
            this.Controls.Add(this.txtBasimTarihi);
            this.Controls.Add(this.txtSayfaSayisi);
            this.Controls.Add(this.txtISBN);
            this.Controls.Add(this.txtAdi);
            this.Controls.Add(this.txtdilId);
            this.Controls.Add(this.txtKitapId);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dilId);
            this.Controls.Add(this.kitapId);
            this.Controls.Add(this.btnAra);
            this.Controls.Add(this.btnListele);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.dataGridView1);
            this.Name = "KitapDünyası_Kitap";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnListele;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.Label kitapId;
        private System.Windows.Forms.Label dilId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtKitapId;
        private System.Windows.Forms.TextBox txtdilId;
        private System.Windows.Forms.TextBox txtAdi;
        private System.Windows.Forms.TextBox txtISBN;
        private System.Windows.Forms.TextBox txtSayfaSayisi;
        private System.Windows.Forms.TextBox txtBasimTarihi;
        private System.Windows.Forms.TextBox txtKiralamaFiyati;
        private System.Windows.Forms.TextBox textKiralamaSuresi;
        private System.Windows.Forms.TextBox txtSonGuncellemeTarihi;
    }
}

