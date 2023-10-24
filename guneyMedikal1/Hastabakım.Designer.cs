namespace guneyMedikal1
{
    partial class Hastabakım
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
            this.lblUrunAra = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblSatisFiyati = new System.Windows.Forms.Label();
            this.lblGelisFiyati = new System.Windows.Forms.Label();
            this.lblStokAdedi = new System.Windows.Forms.Label();
            this.lblUrunAdi = new System.Windows.Forms.Label();
            this.lblUrunKodu = new System.Windows.Forms.Label();
            this.txtSatisFiyati = new System.Windows.Forms.TextBox();
            this.txtGelisFiyati = new System.Windows.Forms.TextBox();
            this.txtStokAdedi = new System.Windows.Forms.TextBox();
            this.txtUrunAdi = new System.Windows.Forms.TextBox();
            this.txtUrunKodu = new System.Windows.Forms.TextBox();
            this.btnUrunSil = new System.Windows.Forms.Button();
            this.btnUrunSat = new System.Windows.Forms.Button();
            this.btnUrunGuncelle = new System.Windows.Forms.Button();
            this.btnUrunEkle = new System.Windows.Forms.Button();
            this.btnYoneticiPaneli = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUrunAra
            // 
            this.lblUrunAra.AutoSize = true;
            this.lblUrunAra.Location = new System.Drawing.Point(313, 49);
            this.lblUrunAra.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblUrunAra.Name = "lblUrunAra";
            this.lblUrunAra.Size = new System.Drawing.Size(56, 15);
            this.lblUrunAra.TabIndex = 67;
            this.lblUrunAra.Text = "Ürün Ara";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(376, 45);
            this.textBox6.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(205, 23);
            this.textBox6.TabIndex = 66;
            this.textBox6.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(315, 74);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(671, 509);
            this.dataGridView1.TabIndex = 65;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView1_CellFormatting);
            // 
            // lblSatisFiyati
            // 
            this.lblSatisFiyati.AutoSize = true;
            this.lblSatisFiyati.Location = new System.Drawing.Point(61, 276);
            this.lblSatisFiyati.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblSatisFiyati.Name = "lblSatisFiyati";
            this.lblSatisFiyati.Size = new System.Drawing.Size(64, 15);
            this.lblSatisFiyati.TabIndex = 64;
            this.lblSatisFiyati.Text = "Satış Fiyatı";
            // 
            // lblGelisFiyati
            // 
            this.lblGelisFiyati.AutoSize = true;
            this.lblGelisFiyati.Location = new System.Drawing.Point(60, 228);
            this.lblGelisFiyati.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblGelisFiyati.Name = "lblGelisFiyati";
            this.lblGelisFiyati.Size = new System.Drawing.Size(65, 15);
            this.lblGelisFiyati.TabIndex = 63;
            this.lblGelisFiyati.Text = "Geliş Fiyatı";
            // 
            // lblStokAdedi
            // 
            this.lblStokAdedi.AutoSize = true;
            this.lblStokAdedi.Location = new System.Drawing.Point(58, 178);
            this.lblStokAdedi.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblStokAdedi.Name = "lblStokAdedi";
            this.lblStokAdedi.Size = new System.Drawing.Size(66, 15);
            this.lblStokAdedi.TabIndex = 62;
            this.lblStokAdedi.Text = "Stok Adedi";
            // 
            // lblUrunAdi
            // 
            this.lblUrunAdi.AutoSize = true;
            this.lblUrunAdi.Location = new System.Drawing.Point(66, 128);
            this.lblUrunAdi.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblUrunAdi.Name = "lblUrunAdi";
            this.lblUrunAdi.Size = new System.Drawing.Size(55, 15);
            this.lblUrunAdi.TabIndex = 61;
            this.lblUrunAdi.Text = "Ürün Adı";
            // 
            // lblUrunKodu
            // 
            this.lblUrunKodu.AutoSize = true;
            this.lblUrunKodu.Location = new System.Drawing.Point(58, 78);
            this.lblUrunKodu.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblUrunKodu.Name = "lblUrunKodu";
            this.lblUrunKodu.Size = new System.Drawing.Size(65, 15);
            this.lblUrunKodu.TabIndex = 60;
            this.lblUrunKodu.Text = "Ürün Kodu";
            // 
            // txtSatisFiyati
            // 
            this.txtSatisFiyati.Location = new System.Drawing.Point(134, 272);
            this.txtSatisFiyati.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.txtSatisFiyati.Name = "txtSatisFiyati";
            this.txtSatisFiyati.Size = new System.Drawing.Size(164, 23);
            this.txtSatisFiyati.TabIndex = 59;
            // 
            // txtGelisFiyati
            // 
            this.txtGelisFiyati.Location = new System.Drawing.Point(134, 224);
            this.txtGelisFiyati.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.txtGelisFiyati.Name = "txtGelisFiyati";
            this.txtGelisFiyati.Size = new System.Drawing.Size(164, 23);
            this.txtGelisFiyati.TabIndex = 58;
            // 
            // txtStokAdedi
            // 
            this.txtStokAdedi.Location = new System.Drawing.Point(134, 174);
            this.txtStokAdedi.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.txtStokAdedi.Name = "txtStokAdedi";
            this.txtStokAdedi.Size = new System.Drawing.Size(164, 23);
            this.txtStokAdedi.TabIndex = 57;
            // 
            // txtUrunAdi
            // 
            this.txtUrunAdi.Location = new System.Drawing.Point(134, 124);
            this.txtUrunAdi.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.txtUrunAdi.Name = "txtUrunAdi";
            this.txtUrunAdi.Size = new System.Drawing.Size(164, 23);
            this.txtUrunAdi.TabIndex = 56;
            // 
            // txtUrunKodu
            // 
            this.txtUrunKodu.Location = new System.Drawing.Point(134, 74);
            this.txtUrunKodu.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.txtUrunKodu.Name = "txtUrunKodu";
            this.txtUrunKodu.Size = new System.Drawing.Size(164, 23);
            this.txtUrunKodu.TabIndex = 55;
            this.txtUrunKodu.TextChanged += new System.EventHandler(this.txtUrunKodu_TextChanged);
            // 
            // btnUrunSil
            // 
            this.btnUrunSil.Location = new System.Drawing.Point(164, 398);
            this.btnUrunSil.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.btnUrunSil.Name = "btnUrunSil";
            this.btnUrunSil.Size = new System.Drawing.Size(134, 43);
            this.btnUrunSil.TabIndex = 54;
            this.btnUrunSil.Text = "Ürün Sil";
            this.btnUrunSil.UseVisualStyleBackColor = true;
            this.btnUrunSil.Click += new System.EventHandler(this.btnUrunSil_Click);
            // 
            // btnUrunSat
            // 
            this.btnUrunSat.Location = new System.Drawing.Point(10, 398);
            this.btnUrunSat.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.btnUrunSat.Name = "btnUrunSat";
            this.btnUrunSat.Size = new System.Drawing.Size(134, 43);
            this.btnUrunSat.TabIndex = 53;
            this.btnUrunSat.Text = "Ürün Sat";
            this.btnUrunSat.UseVisualStyleBackColor = true;
            this.btnUrunSat.Click += new System.EventHandler(this.btnUrunSat_Click);
            // 
            // btnUrunGuncelle
            // 
            this.btnUrunGuncelle.Location = new System.Drawing.Point(164, 332);
            this.btnUrunGuncelle.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.btnUrunGuncelle.Name = "btnUrunGuncelle";
            this.btnUrunGuncelle.Size = new System.Drawing.Size(134, 43);
            this.btnUrunGuncelle.TabIndex = 52;
            this.btnUrunGuncelle.Text = "Ürün Güncelle";
            this.btnUrunGuncelle.UseVisualStyleBackColor = true;
            this.btnUrunGuncelle.Click += new System.EventHandler(this.btnUrunGuncelle_Click);
            // 
            // btnUrunEkle
            // 
            this.btnUrunEkle.Location = new System.Drawing.Point(10, 332);
            this.btnUrunEkle.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.btnUrunEkle.Name = "btnUrunEkle";
            this.btnUrunEkle.Size = new System.Drawing.Size(134, 43);
            this.btnUrunEkle.TabIndex = 51;
            this.btnUrunEkle.Text = "Ürün Ekle";
            this.btnUrunEkle.UseVisualStyleBackColor = true;
            this.btnUrunEkle.Click += new System.EventHandler(this.btnUrunEkle_Click);
            // 
            // btnYoneticiPaneli
            // 
            this.btnYoneticiPaneli.Location = new System.Drawing.Point(850, 30);
            this.btnYoneticiPaneli.Name = "btnYoneticiPaneli";
            this.btnYoneticiPaneli.Size = new System.Drawing.Size(101, 36);
            this.btnYoneticiPaneli.TabIndex = 71;
            this.btnYoneticiPaneli.Text = "Yönetici Paneli";
            this.btnYoneticiPaneli.UseVisualStyleBackColor = true;
            this.btnYoneticiPaneli.Click += new System.EventHandler(this.btnYoneticiPaneli_Click);
            // 
            // Hastabakım
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(992, 585);
            this.Controls.Add(this.btnYoneticiPaneli);
            this.Controls.Add(this.lblUrunAra);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblSatisFiyati);
            this.Controls.Add(this.lblGelisFiyati);
            this.Controls.Add(this.lblStokAdedi);
            this.Controls.Add(this.lblUrunAdi);
            this.Controls.Add(this.lblUrunKodu);
            this.Controls.Add(this.txtSatisFiyati);
            this.Controls.Add(this.txtGelisFiyati);
            this.Controls.Add(this.txtStokAdedi);
            this.Controls.Add(this.txtUrunAdi);
            this.Controls.Add(this.txtUrunKodu);
            this.Controls.Add(this.btnUrunSil);
            this.Controls.Add(this.btnUrunSat);
            this.Controls.Add(this.btnUrunGuncelle);
            this.Controls.Add(this.btnUrunEkle);
            this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Hastabakım";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hasta Bakım";
            this.Load += new System.EventHandler(this.Plastik_Load);
            this.Resize += new System.EventHandler(this.Hastabakım_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUrunAra;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblSatisFiyati;
        private System.Windows.Forms.Label lblGelisFiyati;
        private System.Windows.Forms.Label lblStokAdedi;
        private System.Windows.Forms.Label lblUrunAdi;
        private System.Windows.Forms.Label lblUrunKodu;
        private System.Windows.Forms.TextBox txtSatisFiyati;
        private System.Windows.Forms.TextBox txtGelisFiyati;
        private System.Windows.Forms.TextBox txtStokAdedi;
        private System.Windows.Forms.TextBox txtUrunAdi;
        private System.Windows.Forms.TextBox txtUrunKodu;
        private System.Windows.Forms.Button btnUrunSil;
        private System.Windows.Forms.Button btnUrunSat;
        private System.Windows.Forms.Button btnUrunGuncelle;
        private System.Windows.Forms.Button btnUrunEkle;
        private System.Windows.Forms.Button btnYoneticiPaneli;
    }
}