namespace MathGame
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.button_bolme = new System.Windows.Forms.Button();
            this.button_toplama = new System.Windows.Forms.Button();
            this.button_cikarma = new System.Windows.Forms.Button();
            this.button_carpma = new System.Windows.Forms.Button();
            this.lbl_sayi1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_sayi2 = new System.Windows.Forms.Label();
            this.lbl_sonuc = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label_dogrular = new System.Windows.Forms.Label();
            this.label_hatalar = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "divide.ico");
            this.ımageList1.Images.SetKeyName(1, "add.ico");
            this.ımageList1.Images.SetKeyName(2, "multiply.ico");
            this.ımageList1.Images.SetKeyName(3, "substract.ico");
            // 
            // button_bolme
            // 
            this.button_bolme.ImageIndex = 0;
            this.button_bolme.ImageList = this.ımageList1;
            this.button_bolme.Location = new System.Drawing.Point(376, 365);
            this.button_bolme.Name = "button_bolme";
            this.button_bolme.Size = new System.Drawing.Size(94, 78);
            this.button_bolme.TabIndex = 0;
            this.button_bolme.Tag = "/";
            this.button_bolme.UseVisualStyleBackColor = true;
            this.button_bolme.Click += new System.EventHandler(this.button_bolme_Click);
            // 
            // button_toplama
            // 
            this.button_toplama.ImageIndex = 1;
            this.button_toplama.ImageList = this.ımageList1;
            this.button_toplama.Location = new System.Drawing.Point(376, 43);
            this.button_toplama.Name = "button_toplama";
            this.button_toplama.Size = new System.Drawing.Size(94, 78);
            this.button_toplama.TabIndex = 0;
            this.button_toplama.Tag = "+";
            this.button_toplama.UseVisualStyleBackColor = true;
            this.button_toplama.Click += new System.EventHandler(this.button_toplama_Click);
            // 
            // button_cikarma
            // 
            this.button_cikarma.ImageIndex = 3;
            this.button_cikarma.ImageList = this.ımageList1;
            this.button_cikarma.Location = new System.Drawing.Point(376, 144);
            this.button_cikarma.Name = "button_cikarma";
            this.button_cikarma.Size = new System.Drawing.Size(94, 78);
            this.button_cikarma.TabIndex = 1;
            this.button_cikarma.Tag = "-";
            this.button_cikarma.UseVisualStyleBackColor = true;
            this.button_cikarma.Click += new System.EventHandler(this.button_cikarma_Click);
            // 
            // button_carpma
            // 
            this.button_carpma.ImageIndex = 2;
            this.button_carpma.ImageList = this.ımageList1;
            this.button_carpma.Location = new System.Drawing.Point(376, 259);
            this.button_carpma.Name = "button_carpma";
            this.button_carpma.Size = new System.Drawing.Size(94, 78);
            this.button_carpma.TabIndex = 2;
            this.button_carpma.Tag = "x";
            this.button_carpma.UseVisualStyleBackColor = true;
            this.button_carpma.Click += new System.EventHandler(this.button_carpma_Click);
            // 
            // lbl_sayi1
            // 
            this.lbl_sayi1.AutoSize = true;
            this.lbl_sayi1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_sayi1.Location = new System.Drawing.Point(116, 168);
            this.lbl_sayi1.Name = "lbl_sayi1";
            this.lbl_sayi1.Size = new System.Drawing.Size(90, 36);
            this.lbl_sayi1.TabIndex = 3;
            this.lbl_sayi1.Text = "sayı1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(47, 282);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 36);
            this.label2.TabIndex = 3;
            this.label2.Text = "?";
            // 
            // lbl_sayi2
            // 
            this.lbl_sayi2.AutoSize = true;
            this.lbl_sayi2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_sayi2.Location = new System.Drawing.Point(116, 247);
            this.lbl_sayi2.Name = "lbl_sayi2";
            this.lbl_sayi2.Size = new System.Drawing.Size(90, 36);
            this.lbl_sayi2.TabIndex = 3;
            this.lbl_sayi2.Text = "sayı2";
            // 
            // lbl_sonuc
            // 
            this.lbl_sonuc.AutoSize = true;
            this.lbl_sonuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_sonuc.Location = new System.Drawing.Point(100, 354);
            this.lbl_sonuc.Name = "lbl_sonuc";
            this.lbl_sonuc.Size = new System.Drawing.Size(106, 36);
            this.lbl_sonuc.TabIndex = 3;
            this.lbl_sonuc.Text = "Sonuç";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(47, 318);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(246, 36);
            this.label4.TabIndex = 4;
            this.label4.Text = "---------------------";
            // 
            // label_dogrular
            // 
            this.label_dogrular.AutoSize = true;
            this.label_dogrular.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_dogrular.Location = new System.Drawing.Point(12, 13);
            this.label_dogrular.Name = "label_dogrular";
            this.label_dogrular.Size = new System.Drawing.Size(85, 29);
            this.label_dogrular.TabIndex = 5;
            this.label_dogrular.Text = "Doğru:";
            // 
            // label_hatalar
            // 
            this.label_hatalar.AutoSize = true;
            this.label_hatalar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_hatalar.Location = new System.Drawing.Point(12, 64);
            this.label_hatalar.Name = "label_hatalar";
            this.label_hatalar.Size = new System.Drawing.Size(68, 29);
            this.label_hatalar.TabIndex = 5;
            this.label_hatalar.Text = "Hata:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(487, 490);
            this.Controls.Add(this.label_hatalar);
            this.Controls.Add(this.label_dogrular);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbl_sonuc);
            this.Controls.Add(this.lbl_sayi2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_sayi1);
            this.Controls.Add(this.button_cikarma);
            this.Controls.Add(this.button_carpma);
            this.Controls.Add(this.button_toplama);
            this.Controls.Add(this.button_bolme);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Math Game";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.KapansinMi);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Button button_bolme;
        private System.Windows.Forms.Button button_toplama;
        private System.Windows.Forms.Button button_cikarma;
        private System.Windows.Forms.Button button_carpma;
        private System.Windows.Forms.Label lbl_sayi1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_sayi2;
        private System.Windows.Forms.Label lbl_sonuc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label_dogrular;
        private System.Windows.Forms.Label label_hatalar;
    }
}

