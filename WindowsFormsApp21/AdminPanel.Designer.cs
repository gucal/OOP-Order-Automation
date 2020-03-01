namespace Order_Ottomation
{
    partial class AdminPanel
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
            this.btnUrunSil = new System.Windows.Forms.Button();
            this.btnUrunEkle = new System.Windows.Forms.Button();
            this.btnUrunGuncelle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnUrunSil
            // 
            this.btnUrunSil.Location = new System.Drawing.Point(245, 307);
            this.btnUrunSil.Name = "btnUrunSil";
            this.btnUrunSil.Size = new System.Drawing.Size(366, 113);
            this.btnUrunSil.TabIndex = 3;
            this.btnUrunSil.Text = "Ürün Sil";
            this.btnUrunSil.UseVisualStyleBackColor = true;
            this.btnUrunSil.Click += new System.EventHandler(this.btnUrunSil_Click_1);
            // 
            // btnUrunEkle
            // 
            this.btnUrunEkle.Location = new System.Drawing.Point(32, 86);
            this.btnUrunEkle.Name = "btnUrunEkle";
            this.btnUrunEkle.Size = new System.Drawing.Size(339, 121);
            this.btnUrunEkle.TabIndex = 4;
            this.btnUrunEkle.Text = "Ürün Ekle";
            this.btnUrunEkle.UseVisualStyleBackColor = true;
            this.btnUrunEkle.Click += new System.EventHandler(this.btnUrunEkle_Click_1);
            // 
            // btnUrunGuncelle
            // 
            this.btnUrunGuncelle.Location = new System.Drawing.Point(482, 86);
            this.btnUrunGuncelle.Name = "btnUrunGuncelle";
            this.btnUrunGuncelle.Size = new System.Drawing.Size(327, 121);
            this.btnUrunGuncelle.TabIndex = 5;
            this.btnUrunGuncelle.Text = "Ürün Güncelle";
            this.btnUrunGuncelle.UseVisualStyleBackColor = true;
            this.btnUrunGuncelle.Click += new System.EventHandler(this.btnUrunGuncelle_Click_1);
            // 
            // AdminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 514);
            this.Controls.Add(this.btnUrunGuncelle);
            this.Controls.Add(this.btnUrunEkle);
            this.Controls.Add(this.btnUrunSil);
            this.Name = "AdminPanel";
            this.Text = "AdminPanel";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnUrunSil;
        private System.Windows.Forms.Button btnUrunEkle;
        private System.Windows.Forms.Button btnUrunGuncelle;
    }
}