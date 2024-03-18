namespace Bankamatik_Simülasyonu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Sifre = new System.Windows.Forms.TextBox();
            this.msk_Hesap_No = new System.Windows.Forms.MaskedTextBox();
            this.btn_Giriş_Yap = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(51, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hesap No:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(109, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Şifre:";
            // 
            // txt_Sifre
            // 
            this.txt_Sifre.Location = new System.Drawing.Point(184, 111);
            this.txt_Sifre.Name = "txt_Sifre";
            this.txt_Sifre.Size = new System.Drawing.Size(205, 34);
            this.txt_Sifre.TabIndex = 2;
            this.txt_Sifre.Text = "0";
            this.txt_Sifre.UseSystemPasswordChar = true;
            // 
            // msk_Hesap_No
            // 
            this.msk_Hesap_No.Location = new System.Drawing.Point(184, 52);
            this.msk_Hesap_No.Mask = "000000";
            this.msk_Hesap_No.Name = "msk_Hesap_No";
            this.msk_Hesap_No.Size = new System.Drawing.Size(205, 34);
            this.msk_Hesap_No.TabIndex = 1;
            this.msk_Hesap_No.Text = "123456";
            this.msk_Hesap_No.ValidatingType = typeof(int);
            // 
            // btn_Giriş_Yap
            // 
            this.btn_Giriş_Yap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_Giriş_Yap.Location = new System.Drawing.Point(208, 161);
            this.btn_Giriş_Yap.Name = "btn_Giriş_Yap";
            this.btn_Giriş_Yap.Size = new System.Drawing.Size(142, 41);
            this.btn_Giriş_Yap.TabIndex = 3;
            this.btn_Giriş_Yap.Text = "Giriş Yap";
            this.btn_Giriş_Yap.UseVisualStyleBackColor = false;
            this.btn_Giriş_Yap.Click += new System.EventHandler(this.btn_Giriş_Yap_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel1.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.linkLabel1.Location = new System.Drawing.Point(410, 150);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(96, 29);
            this.linkLabel1.TabIndex = 4;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Kayıt Ol";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(530, 290);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.btn_Giriş_Yap);
            this.Controls.Add(this.msk_Hesap_No);
            this.Controls.Add(this.txt_Sifre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Sifre;
        private System.Windows.Forms.MaskedTextBox msk_Hesap_No;
        private System.Windows.Forms.Button btn_Giriş_Yap;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}

