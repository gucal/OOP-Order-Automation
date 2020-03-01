namespace Order_Ottomation
{
    partial class UrunSil
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
            this.txtSilinecekUrun = new System.Windows.Forms.TextBox();
            this.btnUrunSil = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(108, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Silinecek Ürünün Adı:";
            // 
            // txtSilinecekUrun
            // 
            this.txtSilinecekUrun.Location = new System.Drawing.Point(239, 134);
            this.txtSilinecekUrun.Name = "txtSilinecekUrun";
            this.txtSilinecekUrun.Size = new System.Drawing.Size(179, 20);
            this.txtSilinecekUrun.TabIndex = 1;
            // 
            // btnUrunSil
            // 
            this.btnUrunSil.Location = new System.Drawing.Point(267, 186);
            this.btnUrunSil.Name = "btnUrunSil";
            this.btnUrunSil.Size = new System.Drawing.Size(126, 68);
            this.btnUrunSil.TabIndex = 2;
            this.btnUrunSil.Text = "Ürün Sil";
            this.btnUrunSil.UseVisualStyleBackColor = true;
            this.btnUrunSil.Click += new System.EventHandler(this.btnUrunSil_Click_1);
            // 
            // UrunSil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnUrunSil);
            this.Controls.Add(this.txtSilinecekUrun);
            this.Controls.Add(this.label1);
            this.Name = "UrunSil";
            this.Text = "UrunSil";
            this.Load += new System.EventHandler(this.UrunSil_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSilinecekUrun;
        private System.Windows.Forms.Button btnUrunSil;
    }
}