namespace KeyEventLogger
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnBaslat = new Button();
            btnDurdur = new Button();
            btnTemizle = new Button();
            btnKaydet = new Button();
            lstKayitlar = new ListBox();
            lblDurum = new Label();
            SuspendLayout();
            // 
            // btnBaslat
            // 
            btnBaslat.Location = new Point(362, 53);
            btnBaslat.Name = "btnBaslat";
            btnBaslat.Size = new Size(75, 23);
            btnBaslat.TabIndex = 0;
            btnBaslat.Text = "Başlat";
            btnBaslat.UseVisualStyleBackColor = true;
            // 
            // btnDurdur
            // 
            btnDurdur.Location = new Point(324, 93);
            btnDurdur.Name = "btnDurdur";
            btnDurdur.Size = new Size(75, 23);
            btnDurdur.TabIndex = 1;
            btnDurdur.Text = "Durdur";
            btnDurdur.UseVisualStyleBackColor = true;
            // 
            // btnTemizle
            // 
            btnTemizle.Location = new Point(437, 152);
            btnTemizle.Name = "btnTemizle";
            btnTemizle.Size = new Size(75, 23);
            btnTemizle.TabIndex = 2;
            btnTemizle.Text = "Temizle";
            btnTemizle.UseVisualStyleBackColor = true;
            // 
            // btnKaydet
            // 
            btnKaydet.Location = new Point(385, 227);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(75, 23);
            btnKaydet.TabIndex = 3;
            btnKaydet.Text = "Kaydet";
            btnKaydet.UseVisualStyleBackColor = true;
            // 
            // lstKayitlar
            // 
            lstKayitlar.FormattingEnabled = true;
            lstKayitlar.Location = new Point(584, 277);
            lstKayitlar.Name = "lstKayitlar";
            lstKayitlar.Size = new Size(120, 94);
            lstKayitlar.TabIndex = 4;
            // 
            // lblDurum
            // 
            lblDurum.AutoSize = true;
            lblDurum.Location = new Point(280, 249);
            lblDurum.Name = "lblDurum";
            lblDurum.Size = new Size(71, 15);
            lblDurum.TabIndex = 5;
            lblDurum.Text = "Kayıt: Kapalı";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblDurum);
            Controls.Add(lstKayitlar);
            Controls.Add(btnKaydet);
            Controls.Add(btnTemizle);
            Controls.Add(btnDurdur);
            Controls.Add(btnBaslat);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBaslat;
        private Button btnDurdur;
        private Button btnTemizle;
        private Button btnKaydet;
        private ListBox lstKayitlar;
        private Label lblDurum;
    }
}
