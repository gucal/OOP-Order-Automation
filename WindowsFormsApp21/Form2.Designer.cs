namespace Order_Ottomation
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAdminGiris = new System.Windows.Forms.TextBox();
            this.txtAdminSifre = new System.Windows.Forms.TextBox();
            this.btnAdminGiris = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Lemon/Milk", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 178);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "ADMİN ADI :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Lemon/Milk", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 229);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 30);
            this.label2.TabIndex = 1;
            this.label2.Text = "ADMİN ŞİFRE :";
            // 
            // txtAdminGiris
            // 
            this.txtAdminGiris.Location = new System.Drawing.Point(192, 178);
            this.txtAdminGiris.Multiline = true;
            this.txtAdminGiris.Name = "txtAdminGiris";
            this.txtAdminGiris.Size = new System.Drawing.Size(190, 30);
            this.txtAdminGiris.TabIndex = 2;
            // 
            // txtAdminSifre
            // 
            this.txtAdminSifre.Location = new System.Drawing.Point(192, 229);
            this.txtAdminSifre.Multiline = true;
            this.txtAdminSifre.Name = "txtAdminSifre";
            this.txtAdminSifre.Size = new System.Drawing.Size(190, 30);
            this.txtAdminSifre.TabIndex = 3;
            // 
            // btnAdminGiris
            // 
            this.btnAdminGiris.BackColor = System.Drawing.Color.ForestGreen;
            this.btnAdminGiris.Font = new System.Drawing.Font("Lemon/Milk", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdminGiris.Location = new System.Drawing.Point(279, 283);
            this.btnAdminGiris.Name = "btnAdminGiris";
            this.btnAdminGiris.Size = new System.Drawing.Size(186, 43);
            this.btnAdminGiris.TabIndex = 4;
            this.btnAdminGiris.Text = "GİRİS";
            this.btnAdminGiris.UseVisualStyleBackColor = false;
            this.btnAdminGiris.Click += new System.EventHandler(this.btnAdminGiris_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Lemon/Milk", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Maroon;
            this.label3.Location = new System.Drawing.Point(183, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(297, 52);
            this.label3.TabIndex = 5;
            this.label3.Text = "ADMİN PANEL";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(512, 378);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnAdminGiris);
            this.Controls.Add(this.txtAdminSifre);
            this.Controls.Add(this.txtAdminGiris);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAdminGiris;
        private System.Windows.Forms.TextBox txtAdminSifre;
        private System.Windows.Forms.Button btnAdminGiris;
        private System.Windows.Forms.Label label3;
    }
}