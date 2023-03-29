namespace StokTakip0
{
    partial class DepoSorumlusuKontrol
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DepoSorumlusuKontrol));
            this.depoSorumlusuTablo = new System.Windows.Forms.DataGridView();
            this.picGeri = new System.Windows.Forms.PictureBox();
            this.picClose = new System.Windows.Forms.PictureBox();
            this.picMinimize = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.depoSorumlusuTablo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGeri)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMinimize)).BeginInit();
            this.SuspendLayout();
            // 
            // depoSorumlusuTablo
            // 
            this.depoSorumlusuTablo.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.depoSorumlusuTablo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.depoSorumlusuTablo.Location = new System.Drawing.Point(125, 93);
            this.depoSorumlusuTablo.Name = "depoSorumlusuTablo";
            this.depoSorumlusuTablo.Size = new System.Drawing.Size(628, 240);
            this.depoSorumlusuTablo.TabIndex = 0;
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
            this.picClose.Location = new System.Drawing.Point(870, 1);
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
            this.picMinimize.Location = new System.Drawing.Point(842, 10);
            this.picMinimize.Margin = new System.Windows.Forms.Padding(2);
            this.picMinimize.Name = "picMinimize";
            this.picMinimize.Size = new System.Drawing.Size(24, 26);
            this.picMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picMinimize.TabIndex = 34;
            this.picMinimize.TabStop = false;
            this.picMinimize.Click += new System.EventHandler(this.picMinimize_Click);
            // 
            // DepoSorumlusuKontrol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.ClientSize = new System.Drawing.Size(900, 666);
            this.Controls.Add(this.picClose);
            this.Controls.Add(this.picMinimize);
            this.Controls.Add(this.picGeri);
            this.Controls.Add(this.depoSorumlusuTablo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DepoSorumlusuKontrol";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DepoSorumlusuKontrol";
            this.Load += new System.EventHandler(this.DepoSorumlusuKontrol_Load);
            ((System.ComponentModel.ISupportInitialize)(this.depoSorumlusuTablo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGeri)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMinimize)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView depoSorumlusuTablo;
        private System.Windows.Forms.PictureBox picGeri;
        private System.Windows.Forms.PictureBox picClose;
        private System.Windows.Forms.PictureBox picMinimize;
    }
}