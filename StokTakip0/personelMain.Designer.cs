namespace StokTakip0
{
    partial class personelMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(personelMain));
            this.arkaPlan = new System.Windows.Forms.PictureBox();
            this.picGeri = new System.Windows.Forms.PictureBox();
            this.picMinimize = new System.Windows.Forms.PictureBox();
            this.picClose = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.urunBoyutu = new System.Windows.Forms.ComboBox();
            this.urunAdedi = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.onayButonu = new System.Windows.Forms.Button();
            this.stokDurumuTablo = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.urunID = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.talepTarihi = new System.Windows.Forms.DateTimePicker();
            this.urunCesidi = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.arkaPlan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGeri)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stokDurumuTablo)).BeginInit();
            this.SuspendLayout();
            // 
            // arkaPlan
            // 
            this.arkaPlan.Image = ((System.Drawing.Image)(resources.GetObject("arkaPlan.Image")));
            this.arkaPlan.Location = new System.Drawing.Point(330, 495);
            this.arkaPlan.Name = "arkaPlan";
            this.arkaPlan.Size = new System.Drawing.Size(271, 198);
            this.arkaPlan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.arkaPlan.TabIndex = 6;
            this.arkaPlan.TabStop = false;
            // 
            // picGeri
            // 
            this.picGeri.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picGeri.Image = ((System.Drawing.Image)(resources.GetObject("picGeri.Image")));
            this.picGeri.Location = new System.Drawing.Point(11, 0);
            this.picGeri.Margin = new System.Windows.Forms.Padding(2);
            this.picGeri.Name = "picGeri";
            this.picGeri.Size = new System.Drawing.Size(24, 26);
            this.picGeri.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picGeri.TabIndex = 31;
            this.picGeri.TabStop = false;
            this.picGeri.Click += new System.EventHandler(this.picGeri_Click);
            // 
            // picMinimize
            // 
            this.picMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picMinimize.Image = ((System.Drawing.Image)(resources.GetObject("picMinimize.Image")));
            this.picMinimize.Location = new System.Drawing.Point(841, 11);
            this.picMinimize.Margin = new System.Windows.Forms.Padding(2);
            this.picMinimize.Name = "picMinimize";
            this.picMinimize.Size = new System.Drawing.Size(24, 26);
            this.picMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picMinimize.TabIndex = 32;
            this.picMinimize.TabStop = false;
            this.picMinimize.Click += new System.EventHandler(this.picMinimize_Click);
            // 
            // picClose
            // 
            this.picClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picClose.Image = ((System.Drawing.Image)(resources.GetObject("picClose.Image")));
            this.picClose.Location = new System.Drawing.Point(870, 2);
            this.picClose.Margin = new System.Windows.Forms.Padding(2);
            this.picClose.Name = "picClose";
            this.picClose.Size = new System.Drawing.Size(19, 24);
            this.picClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picClose.TabIndex = 33;
            this.picClose.TabStop = false;
            this.picClose.Click += new System.EventHandler(this.picClose_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(26)))), ((int)(((byte)(61)))));
            this.label4.Location = new System.Drawing.Point(531, 385);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 20);
            this.label4.TabIndex = 52;
            this.label4.Text = "Ürün Adedi:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(26)))), ((int)(((byte)(61)))));
            this.label3.Location = new System.Drawing.Point(531, 321);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 20);
            this.label3.TabIndex = 50;
            this.label3.Text = "Ürün Boyutu:";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(26)))), ((int)(((byte)(61)))));
            this.label5.Location = new System.Drawing.Point(531, 258);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 20);
            this.label5.TabIndex = 48;
            this.label5.Text = "Ürün Çeşidi:";
            // 
            // urunBoyutu
            // 
            this.urunBoyutu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.urunBoyutu.FormattingEnabled = true;
            this.urunBoyutu.Items.AddRange(new object[] {
            "S ",
            "M ",
            "L",
            "36 (Ayakkabı)",
            "37 (Ayakkabı)",
            "38 (Ayakkabı)"});
            this.urunBoyutu.Location = new System.Drawing.Point(535, 344);
            this.urunBoyutu.Name = "urunBoyutu";
            this.urunBoyutu.Size = new System.Drawing.Size(191, 28);
            this.urunBoyutu.TabIndex = 54;
            // 
            // urunAdedi
            // 
            this.urunAdedi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.urunAdedi.FormattingEnabled = true;
            this.urunAdedi.Items.AddRange(new object[] {
            "10",
            "20",
            "30",
            "40",
            "50"});
            this.urunAdedi.Location = new System.Drawing.Point(535, 408);
            this.urunAdedi.Name = "urunAdedi";
            this.urunAdedi.Size = new System.Drawing.Size(191, 28);
            this.urunAdedi.TabIndex = 56;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(26)))), ((int)(((byte)(61)))));
            this.label1.Location = new System.Drawing.Point(275, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(359, 47);
            this.label1.TabIndex = 57;
            this.label1.Text = "Ürün Sipariş Formu";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // onayButonu
            // 
            this.onayButonu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(26)))), ((int)(((byte)(61)))));
            this.onayButonu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.onayButonu.FlatAppearance.BorderSize = 0;
            this.onayButonu.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.onayButonu.ForeColor = System.Drawing.Color.White;
            this.onayButonu.Location = new System.Drawing.Point(565, 454);
            this.onayButonu.Name = "onayButonu";
            this.onayButonu.Size = new System.Drawing.Size(127, 44);
            this.onayButonu.TabIndex = 59;
            this.onayButonu.Text = "Gönder";
            this.onayButonu.UseVisualStyleBackColor = false;
            this.onayButonu.Click += new System.EventHandler(this.onayButonu_Click);
            // 
            // stokDurumuTablo
            // 
            this.stokDurumuTablo.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.stokDurumuTablo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.stokDurumuTablo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.stokDurumuTablo.Location = new System.Drawing.Point(45, 186);
            this.stokDurumuTablo.Name = "stokDurumuTablo";
            this.stokDurumuTablo.Size = new System.Drawing.Size(402, 286);
            this.stokDurumuTablo.TabIndex = 61;
            this.stokDurumuTablo.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.stokDurumuTablo_CellFormatting_1);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(26)))), ((int)(((byte)(61)))));
            this.label2.Location = new System.Drawing.Point(174, 140);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 26);
            this.label2.TabIndex = 62;
            this.label2.Text = "Stok Durumu";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(26)))), ((int)(((byte)(61)))));
            this.label6.Location = new System.Drawing.Point(531, 202);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 20);
            this.label6.TabIndex = 63;
            this.label6.Text = "Ürün ID:";
            // 
            // urunID
            // 
            this.urunID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.urunID.Location = new System.Drawing.Point(535, 225);
            this.urunID.Name = "urunID";
            this.urunID.Size = new System.Drawing.Size(191, 26);
            this.urunID.TabIndex = 65;
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Location = new System.Drawing.Point(732, 225);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(31, 30);
            this.button1.TabIndex = 66;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // talepTarihi
            // 
            this.talepTarihi.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.talepTarihi.Enabled = false;
            this.talepTarihi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.talepTarihi.Location = new System.Drawing.Point(521, 154);
            this.talepTarihi.Name = "talepTarihi";
            this.talepTarihi.Size = new System.Drawing.Size(225, 26);
            this.talepTarihi.TabIndex = 67;
            // 
            // urunCesidi
            // 
            this.urunCesidi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.urunCesidi.Location = new System.Drawing.Point(535, 281);
            this.urunCesidi.Name = "urunCesidi";
            this.urunCesidi.ReadOnly = true;
            this.urunCesidi.Size = new System.Drawing.Size(191, 28);
            this.urunCesidi.TabIndex = 68;
            this.urunCesidi.Text = "";
            // 
            // personelMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(900, 666);
            this.Controls.Add(this.urunCesidi);
            this.Controls.Add(this.talepTarihi);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.urunID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.stokDurumuTablo);
            this.Controls.Add(this.onayButonu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.urunAdedi);
            this.Controls.Add(this.urunBoyutu);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.picClose);
            this.Controls.Add(this.picMinimize);
            this.Controls.Add(this.picGeri);
            this.Controls.Add(this.arkaPlan);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "personelMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.Load += new System.EventHandler(this.personelMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.arkaPlan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGeri)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stokDurumuTablo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox arkaPlan;
        private System.Windows.Forms.PictureBox picGeri;
        private System.Windows.Forms.PictureBox picMinimize;
        private System.Windows.Forms.PictureBox picClose;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox urunBoyutu;
        private System.Windows.Forms.ComboBox urunAdedi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button onayButonu;
        private System.Windows.Forms.DataGridView stokDurumuTablo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox urunID;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker talepTarihi;
        private System.Windows.Forms.RichTextBox urunCesidi;
    }
}