namespace Order_Ottomation
{
    partial class UrunGuncelle
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
            this.label3 = new System.Windows.Forms.Label();
            this.txtGuncellenecekUrun = new System.Windows.Forms.TextBox();
            this.txtGuncellenecekUrunYeniAdi = new System.Windows.Forms.TextBox();
            this.txtUrunGuncelAdedi = new System.Windows.Forms.TextBox();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(143, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Güncellenecek Ürün Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(179, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ürünün Yeni İsmi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(157, 219);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ürünün Güncel Adedi";
            // 
            // txtGuncellenecekUrun
            // 
            this.txtGuncellenecekUrun.Location = new System.Drawing.Point(298, 142);
            this.txtGuncellenecekUrun.Name = "txtGuncellenecekUrun";
            this.txtGuncellenecekUrun.Size = new System.Drawing.Size(151, 20);
            this.txtGuncellenecekUrun.TabIndex = 3;
            // 
            // txtGuncellenecekUrunYeniAdi
            // 
            this.txtGuncellenecekUrunYeniAdi.Location = new System.Drawing.Point(298, 181);
            this.txtGuncellenecekUrunYeniAdi.Name = "txtGuncellenecekUrunYeniAdi";
            this.txtGuncellenecekUrunYeniAdi.Size = new System.Drawing.Size(151, 20);
            this.txtGuncellenecekUrunYeniAdi.TabIndex = 4;
            // 
            // txtUrunGuncelAdedi
            // 
            this.txtUrunGuncelAdedi.Location = new System.Drawing.Point(298, 216);
            this.txtUrunGuncelAdedi.Name = "txtUrunGuncelAdedi";
            this.txtUrunGuncelAdedi.Size = new System.Drawing.Size(151, 20);
            this.txtUrunGuncelAdedi.TabIndex = 5;
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(307, 260);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(133, 53);
            this.btnGuncelle.TabIndex = 6;
            this.btnGuncelle.Text = "Ürün Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click_1);
            // 
            // UrunGuncelle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.txtUrunGuncelAdedi);
            this.Controls.Add(this.txtGuncellenecekUrunYeniAdi);
            this.Controls.Add(this.txtGuncellenecekUrun);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UrunGuncelle";
            this.Text = "UrunGuncelle";
            this.Load += new System.EventHandler(this.UrunGuncelle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtGuncellenecekUrun;
        private System.Windows.Forms.TextBox txtGuncellenecekUrunYeniAdi;
        private System.Windows.Forms.TextBox txtUrunGuncelAdedi;
        private System.Windows.Forms.Button btnGuncelle;
    }
}