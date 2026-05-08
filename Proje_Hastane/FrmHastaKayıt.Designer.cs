namespace Proje_Hastane
{
    partial class FrmHastaKayıt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHastaKayıt));
            this.mskTC = new System.Windows.Forms.MaskedTextBox();
            this.TxtSifre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.AD = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAD = new System.Windows.Forms.TextBox();
            this.txtSOYAD = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.mskTELEFON = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbCİNSİYET = new System.Windows.Forms.ComboBox();
            this.btnKAYITYAP = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mskTC
            // 
            this.mskTC.Location = new System.Drawing.Point(243, 236);
            this.mskTC.Mask = "00000000000";
            this.mskTC.Name = "mskTC";
            this.mskTC.Size = new System.Drawing.Size(219, 31);
            this.mskTC.TabIndex = 4;
            this.mskTC.ValidatingType = typeof(int);
            // 
            // TxtSifre
            // 
            this.TxtSifre.Location = new System.Drawing.Point(243, 295);
            this.TxtSifre.Name = "TxtSifre";
            this.TxtSifre.Size = new System.Drawing.Size(219, 31);
            this.TxtSifre.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(153, 303);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 23);
            this.label3.TabIndex = 6;
            this.label3.Text = "Şifre : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(82, 244);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 23);
            this.label2.TabIndex = 5;
            this.label2.Text = "TC Kimlik NO : ";
            // 
            // AD
            // 
            this.AD.AutoSize = true;
            this.AD.Location = new System.Drawing.Point(166, 77);
            this.AD.Name = "AD";
            this.AD.Size = new System.Drawing.Size(45, 23);
            this.AD.TabIndex = 9;
            this.AD.Text = "Ad : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(140, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 23);
            this.label4.TabIndex = 10;
            this.label4.Text = "Soyad : ";
            // 
            // txtAD
            // 
            this.txtAD.Location = new System.Drawing.Point(243, 74);
            this.txtAD.Name = "txtAD";
            this.txtAD.Size = new System.Drawing.Size(219, 31);
            this.txtAD.TabIndex = 1;
            // 
            // txtSOYAD
            // 
            this.txtSOYAD.Location = new System.Drawing.Point(243, 128);
            this.txtSOYAD.Name = "txtSOYAD";
            this.txtSOYAD.Size = new System.Drawing.Size(219, 31);
            this.txtSOYAD.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 189);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 23);
            this.label1.TabIndex = 13;
            this.label1.Text = "Telefon Numarası : ";
            // 
            // mskTELEFON
            // 
            this.mskTELEFON.Location = new System.Drawing.Point(243, 181);
            this.mskTELEFON.Mask = "(999) 000-0000";
            this.mskTELEFON.Name = "mskTELEFON";
            this.mskTELEFON.Size = new System.Drawing.Size(219, 31);
            this.mskTELEFON.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(153, 355);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 23);
            this.label5.TabIndex = 16;
            this.label5.Text = "Cinsiyet : ";
            // 
            // cmbCİNSİYET
            // 
            this.cmbCİNSİYET.FormattingEnabled = true;
            this.cmbCİNSİYET.Items.AddRange(new object[] {
            "ERKEK\t",
            "KADIN"});
            this.cmbCİNSİYET.Location = new System.Drawing.Point(244, 355);
            this.cmbCİNSİYET.Name = "cmbCİNSİYET";
            this.cmbCİNSİYET.Size = new System.Drawing.Size(218, 31);
            this.cmbCİNSİYET.TabIndex = 6;
            // 
            // btnKAYITYAP
            // 
            this.btnKAYITYAP.BackColor = System.Drawing.Color.DarkCyan;
            this.btnKAYITYAP.Location = new System.Drawing.Point(244, 424);
            this.btnKAYITYAP.Name = "btnKAYITYAP";
            this.btnKAYITYAP.Size = new System.Drawing.Size(218, 97);
            this.btnKAYITYAP.TabIndex = 7;
            this.btnKAYITYAP.Text = "Kayıt Yap";
            this.btnKAYITYAP.UseVisualStyleBackColor = false;
            this.btnKAYITYAP.Click += new System.EventHandler(this.btnKAYITYAP_Click);
            // 
            // FrmHastaKayıt
            // 
            this.AcceptButton = this.btnKAYITYAP;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(1333, 796);
            this.Controls.Add(this.btnKAYITYAP);
            this.Controls.Add(this.cmbCİNSİYET);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.mskTELEFON);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSOYAD);
            this.Controls.Add(this.txtAD);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.AD);
            this.Controls.Add(this.mskTC);
            this.Controls.Add(this.TxtSifre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "FrmHastaKayıt";
            this.Text = "Hasta Kayıt";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox mskTC;
        private System.Windows.Forms.TextBox TxtSifre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label AD;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAD;
        private System.Windows.Forms.TextBox txtSOYAD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox mskTELEFON;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbCİNSİYET;
        private System.Windows.Forms.Button btnKAYITYAP;
    }
}