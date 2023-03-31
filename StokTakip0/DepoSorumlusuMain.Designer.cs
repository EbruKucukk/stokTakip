namespace StokTakip0
{
    partial class DepoSorumlusuMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DepoSorumlusuMain));
            this.picGeri = new System.Windows.Forms.PictureBox();
            this.picClose = new System.Windows.Forms.PictureBox();
            this.picMinimize = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.firmaButon = new System.Windows.Forms.Button();
            this.urunCesidi = new System.Windows.Forms.RichTextBox();
            this.urunAdediTxt = new System.Windows.Forms.Label();
            this.urunBoyutuTxt = new System.Windows.Forms.Label();
            this.urunCesidiTxt = new System.Windows.Forms.Label();
            this.urunAdedi = new System.Windows.Forms.RichTextBox();
            this.urunBoyutu = new System.Windows.Forms.RichTextBox();
            this.urunID = new System.Windows.Forms.TextBox();
            this.urunLabel = new System.Windows.Forms.Label();
            this.tarih = new System.Windows.Forms.TextBox();
            this.gunTarihi = new System.Windows.Forms.Label();
            this.talepTablo = new System.Windows.Forms.DataGridView();
            this.iptalBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.onayTablo = new System.Windows.Forms.DataGridView();
            this.güncelleBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblmesaj = new System.Windows.Forms.Label();
            this.logoPicture = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picGeri)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.talepTablo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.onayTablo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // picGeri
            // 
            this.picGeri.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picGeri.Image = ((System.Drawing.Image)(resources.GetObject("picGeri.Image")));
            this.picGeri.Location = new System.Drawing.Point(11, 11);
            this.picGeri.Margin = new System.Windows.Forms.Padding(2);
            this.picGeri.Name = "picGeri";
            this.picGeri.Size = new System.Drawing.Size(24, 26);
            this.picGeri.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picGeri.TabIndex = 32;
            this.picGeri.TabStop = false;
            this.picGeri.Click += new System.EventHandler(this.picGeri_Click);
            // 
            // picClose
            // 
            this.picClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picClose.Image = ((System.Drawing.Image)(resources.GetObject("picClose.Image")));
            this.picClose.Location = new System.Drawing.Point(1039, 11);
            this.picClose.Margin = new System.Windows.Forms.Padding(2);
            this.picClose.Name = "picClose";
            this.picClose.Size = new System.Drawing.Size(19, 24);
            this.picClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picClose.TabIndex = 35;
            this.picClose.TabStop = false;
            this.picClose.Click += new System.EventHandler(this.picClose_Click);
            // 
            // picMinimize
            // 
            this.picMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picMinimize.Image = ((System.Drawing.Image)(resources.GetObject("picMinimize.Image")));
            this.picMinimize.Location = new System.Drawing.Point(1011, 20);
            this.picMinimize.Margin = new System.Windows.Forms.Padding(2);
            this.picMinimize.Name = "picMinimize";
            this.picMinimize.Size = new System.Drawing.Size(24, 26);
            this.picMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picMinimize.TabIndex = 34;
            this.picMinimize.TabStop = false;
            this.picMinimize.Click += new System.EventHandler(this.picMinimize_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(26)))), ((int)(((byte)(61)))));
            this.label1.Location = new System.Drawing.Point(375, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(321, 47);
            this.label1.TabIndex = 37;
            this.label1.Text = "Ürün Talep Takibi";
            // 
            // firmaButon
            // 
            this.firmaButon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(26)))), ((int)(((byte)(61)))));
            this.firmaButon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.firmaButon.FlatAppearance.BorderSize = 0;
            this.firmaButon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.firmaButon.ForeColor = System.Drawing.Color.White;
            this.firmaButon.Location = new System.Drawing.Point(817, 539);
            this.firmaButon.Name = "firmaButon";
            this.firmaButon.Size = new System.Drawing.Size(170, 35);
            this.firmaButon.TabIndex = 38;
            this.firmaButon.Text = "Onayla";
            this.firmaButon.UseVisualStyleBackColor = false;
            this.firmaButon.Visible = false;
            this.firmaButon.Click += new System.EventHandler(this.firmaButon_Click);
            // 
            // urunCesidi
            // 
            this.urunCesidi.BackColor = System.Drawing.Color.White;
            this.urunCesidi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.urunCesidi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.urunCesidi.Location = new System.Drawing.Point(818, 360);
            this.urunCesidi.Name = "urunCesidi";
            this.urunCesidi.ReadOnly = true;
            this.urunCesidi.Size = new System.Drawing.Size(173, 30);
            this.urunCesidi.TabIndex = 66;
            this.urunCesidi.Text = "";
            this.urunCesidi.Visible = false;
            // 
            // urunAdediTxt
            // 
            this.urunAdediTxt.AutoSize = true;
            this.urunAdediTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.urunAdediTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(26)))), ((int)(((byte)(61)))));
            this.urunAdediTxt.Location = new System.Drawing.Point(816, 455);
            this.urunAdediTxt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.urunAdediTxt.Name = "urunAdediTxt";
            this.urunAdediTxt.Size = new System.Drawing.Size(111, 24);
            this.urunAdediTxt.TabIndex = 69;
            this.urunAdediTxt.Text = "Ürün Adedi:";
            this.urunAdediTxt.Visible = false;
            // 
            // urunBoyutuTxt
            // 
            this.urunBoyutuTxt.AutoSize = true;
            this.urunBoyutuTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.urunBoyutuTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(26)))), ((int)(((byte)(61)))));
            this.urunBoyutuTxt.Location = new System.Drawing.Point(814, 399);
            this.urunBoyutuTxt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.urunBoyutuTxt.Name = "urunBoyutuTxt";
            this.urunBoyutuTxt.Size = new System.Drawing.Size(119, 24);
            this.urunBoyutuTxt.TabIndex = 68;
            this.urunBoyutuTxt.Text = "Ürün Boyutu:";
            this.urunBoyutuTxt.Visible = false;
            // 
            // urunCesidiTxt
            // 
            this.urunCesidiTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.urunCesidiTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(26)))), ((int)(((byte)(61)))));
            this.urunCesidiTxt.Location = new System.Drawing.Point(813, 330);
            this.urunCesidiTxt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.urunCesidiTxt.Name = "urunCesidiTxt";
            this.urunCesidiTxt.Size = new System.Drawing.Size(123, 27);
            this.urunCesidiTxt.TabIndex = 67;
            this.urunCesidiTxt.Text = "Ürün Çeşidi:";
            this.urunCesidiTxt.Visible = false;
            // 
            // urunAdedi
            // 
            this.urunAdedi.BackColor = System.Drawing.Color.White;
            this.urunAdedi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.urunAdedi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.urunAdedi.Location = new System.Drawing.Point(818, 480);
            this.urunAdedi.Name = "urunAdedi";
            this.urunAdedi.ReadOnly = true;
            this.urunAdedi.Size = new System.Drawing.Size(173, 30);
            this.urunAdedi.TabIndex = 72;
            this.urunAdedi.Text = "";
            this.urunAdedi.Visible = false;
            // 
            // urunBoyutu
            // 
            this.urunBoyutu.BackColor = System.Drawing.Color.White;
            this.urunBoyutu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.urunBoyutu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.urunBoyutu.Location = new System.Drawing.Point(818, 422);
            this.urunBoyutu.Name = "urunBoyutu";
            this.urunBoyutu.ReadOnly = true;
            this.urunBoyutu.Size = new System.Drawing.Size(173, 30);
            this.urunBoyutu.TabIndex = 73;
            this.urunBoyutu.Text = "";
            this.urunBoyutu.Visible = false;
            // 
            // urunID
            // 
            this.urunID.Location = new System.Drawing.Point(7, 591);
            this.urunID.Name = "urunID";
            this.urunID.Size = new System.Drawing.Size(100, 20);
            this.urunID.TabIndex = 75;
            this.urunID.Visible = false;
            // 
            // urunLabel
            // 
            this.urunLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.urunLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(26)))), ((int)(((byte)(61)))));
            this.urunLabel.Location = new System.Drawing.Point(12, 568);
            this.urunLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.urunLabel.Name = "urunLabel";
            this.urunLabel.Size = new System.Drawing.Size(95, 20);
            this.urunLabel.TabIndex = 76;
            this.urunLabel.Text = "Ürün ID:";
            this.urunLabel.Visible = false;
            // 
            // tarih
            // 
            this.tarih.Location = new System.Drawing.Point(7, 643);
            this.tarih.Name = "tarih";
            this.tarih.Size = new System.Drawing.Size(100, 20);
            this.tarih.TabIndex = 77;
            this.tarih.Visible = false;
            this.tarih.TextChanged += new System.EventHandler(this.tarih_TextChanged);
            // 
            // gunTarihi
            // 
            this.gunTarihi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gunTarihi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(26)))), ((int)(((byte)(61)))));
            this.gunTarihi.Location = new System.Drawing.Point(12, 620);
            this.gunTarihi.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.gunTarihi.Name = "gunTarihi";
            this.gunTarihi.Size = new System.Drawing.Size(95, 20);
            this.gunTarihi.TabIndex = 78;
            this.gunTarihi.Text = "Talep Tarihi:";
            this.gunTarihi.Visible = false;
            // 
            // talepTablo
            // 
            this.talepTablo.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.talepTablo.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.talepTablo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.talepTablo.Location = new System.Drawing.Point(139, 92);
            this.talepTablo.Name = "talepTablo";
            this.talepTablo.Size = new System.Drawing.Size(749, 201);
            this.talepTablo.TabIndex = 79;
            this.talepTablo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.talepTablo_CellClick_1);
            this.talepTablo.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.talepTablo_CellValueChanged_1);
            // 
            // iptalBtn
            // 
            this.iptalBtn.BackColor = System.Drawing.Color.Maroon;
            this.iptalBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iptalBtn.FlatAppearance.BorderSize = 0;
            this.iptalBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.iptalBtn.ForeColor = System.Drawing.Color.White;
            this.iptalBtn.Location = new System.Drawing.Point(817, 580);
            this.iptalBtn.Name = "iptalBtn";
            this.iptalBtn.Size = new System.Drawing.Size(170, 35);
            this.iptalBtn.TabIndex = 80;
            this.iptalBtn.Text = "İptal Et";
            this.iptalBtn.UseVisualStyleBackColor = false;
            this.iptalBtn.Visible = false;
            this.iptalBtn.Click += new System.EventHandler(this.iptalBtn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(95)))), ((int)(((byte)(122)))));
            this.panel1.Location = new System.Drawing.Point(818, 389);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(173, 2);
            this.panel1.TabIndex = 81;
            this.panel1.Visible = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(95)))), ((int)(((byte)(122)))));
            this.panel2.Location = new System.Drawing.Point(818, 508);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(173, 2);
            this.panel2.TabIndex = 82;
            this.panel2.Visible = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(95)))), ((int)(((byte)(122)))));
            this.panel3.Location = new System.Drawing.Point(820, 450);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(173, 2);
            this.panel3.TabIndex = 83;
            this.panel3.Visible = false;
            // 
            // onayTablo
            // 
            this.onayTablo.AllowUserToAddRows = false;
            this.onayTablo.AllowUserToDeleteRows = false;
            this.onayTablo.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.onayTablo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.onayTablo.Location = new System.Drawing.Point(16, 360);
            this.onayTablo.Name = "onayTablo";
            this.onayTablo.ReadOnly = true;
            this.onayTablo.Size = new System.Drawing.Size(749, 201);
            this.onayTablo.TabIndex = 84;
            this.onayTablo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.onayTablo_CellClick);
            this.onayTablo.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.onayTablo_CellValueChanged);
            // 
            // güncelleBtn
            // 
            this.güncelleBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(26)))), ((int)(((byte)(61)))));
            this.güncelleBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.güncelleBtn.FlatAppearance.BorderSize = 0;
            this.güncelleBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.güncelleBtn.ForeColor = System.Drawing.Color.White;
            this.güncelleBtn.Location = new System.Drawing.Point(342, 576);
            this.güncelleBtn.Name = "güncelleBtn";
            this.güncelleBtn.Size = new System.Drawing.Size(170, 35);
            this.güncelleBtn.TabIndex = 85;
            this.güncelleBtn.Text = "Güncelle";
            this.güncelleBtn.UseVisualStyleBackColor = false;
            this.güncelleBtn.Click += new System.EventHandler(this.güncelleBtn_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(26)))), ((int)(((byte)(61)))));
            this.label2.Location = new System.Drawing.Point(219, 317);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(355, 40);
            this.label2.TabIndex = 86;
            this.label2.Text = "Gün İçinde Onaylananlar";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblmesaj
            // 
            this.lblmesaj.Location = new System.Drawing.Point(813, 637);
            this.lblmesaj.Name = "lblmesaj";
            this.lblmesaj.Size = new System.Drawing.Size(174, 23);
            this.lblmesaj.TabIndex = 87;
            this.lblmesaj.Visible = false;
            // 
            // logoPicture
            // 
            this.logoPicture.Image = ((System.Drawing.Image)(resources.GetObject("logoPicture.Image")));
            this.logoPicture.Location = new System.Drawing.Point(746, 303);
            this.logoPicture.Name = "logoPicture";
            this.logoPicture.Size = new System.Drawing.Size(312, 331);
            this.logoPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logoPicture.TabIndex = 74;
            this.logoPicture.TabStop = false;
            // 
            // DepoSorumlusuMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.ClientSize = new System.Drawing.Size(1070, 684);
            this.Controls.Add(this.lblmesaj);
            this.Controls.Add(this.güncelleBtn);
            this.Controls.Add(this.onayTablo);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.iptalBtn);
            this.Controls.Add(this.talepTablo);
            this.Controls.Add(this.gunTarihi);
            this.Controls.Add(this.tarih);
            this.Controls.Add(this.urunLabel);
            this.Controls.Add(this.urunID);
            this.Controls.Add(this.urunBoyutu);
            this.Controls.Add(this.urunAdedi);
            this.Controls.Add(this.urunAdediTxt);
            this.Controls.Add(this.urunBoyutuTxt);
            this.Controls.Add(this.urunCesidiTxt);
            this.Controls.Add(this.urunCesidi);
            this.Controls.Add(this.firmaButon);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picClose);
            this.Controls.Add(this.picMinimize);
            this.Controls.Add(this.picGeri);
            this.Controls.Add(this.logoPicture);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DepoSorumlusuMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DepoSorumlusuMain";
            this.Load += new System.EventHandler(this.DepoSorumlusuMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picGeri)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.talepTablo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.onayTablo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picGeri;
        private System.Windows.Forms.PictureBox picClose;
        private System.Windows.Forms.PictureBox picMinimize;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button firmaButon;
        private System.Windows.Forms.RichTextBox urunCesidi;
        private System.Windows.Forms.Label urunAdediTxt;
        private System.Windows.Forms.Label urunBoyutuTxt;
        private System.Windows.Forms.Label urunCesidiTxt;
        private System.Windows.Forms.RichTextBox urunAdedi;
        private System.Windows.Forms.RichTextBox urunBoyutu;
        private System.Windows.Forms.TextBox urunID;
        private System.Windows.Forms.Label urunLabel;
        private System.Windows.Forms.TextBox tarih;
        private System.Windows.Forms.Label gunTarihi;
        private System.Windows.Forms.DataGridView talepTablo;
        private System.Windows.Forms.Button iptalBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView onayTablo;
        private System.Windows.Forms.Button güncelleBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblmesaj;
        private System.Windows.Forms.PictureBox logoPicture;
    }
}