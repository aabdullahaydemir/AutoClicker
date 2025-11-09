namespace WinFormsApp1
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
        protected void Dispose(bool disposing)
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            txb_kordinat = new TextBox();
            btn_kaydet = new Button();
            btn_tekrarla = new Button();
            btn_tekrarlamayi_durdur = new Button();
            txb_tekrar_sayisi = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txb_tekrarlama_hareket_sure_araligi = new TextBox();
            label3 = new Label();
            txb_tekrarlarin_arasindaki_sure_araligi = new TextBox();
            btn_durdur = new Button();
            btn_baslat = new Button();
            panel1 = new Panel();
            label4 = new Label();
            panel2 = new Panel();
            label5 = new Label();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txb_kordinat
            // 
            txb_kordinat.Location = new Point(1569, 154);
            txb_kordinat.Name = "txb_kordinat";
            txb_kordinat.Size = new Size(125, 27);
            txb_kordinat.TabIndex = 0;
            txb_kordinat.Visible = false;
            // 
            // btn_kaydet
            // 
            btn_kaydet.Location = new Point(1711, 153);
            btn_kaydet.Name = "btn_kaydet";
            btn_kaydet.Size = new Size(163, 29);
            btn_kaydet.TabIndex = 1;
            btn_kaydet.Text = "Kordinatları Kaydet";
            btn_kaydet.UseVisualStyleBackColor = true;
            btn_kaydet.Visible = false;
            btn_kaydet.Click += btn_kaydet_Click_1;
            // 
            // btn_tekrarla
            // 
            btn_tekrarla.BackColor = Color.FromArgb(192, 255, 192);
            btn_tekrarla.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btn_tekrarla.Location = new Point(275, 206);
            btn_tekrarla.Name = "btn_tekrarla";
            btn_tekrarla.Size = new Size(103, 60);
            btn_tekrarla.TabIndex = 4;
            btn_tekrarla.Text = "Tekrarla";
            btn_tekrarla.UseVisualStyleBackColor = false;
            btn_tekrarla.Click += btn_tekrarla_Click;
            // 
            // btn_tekrarlamayi_durdur
            // 
            btn_tekrarlamayi_durdur.BackColor = Color.FromArgb(192, 0, 0);
            btn_tekrarlamayi_durdur.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btn_tekrarlamayi_durdur.Location = new Point(441, 206);
            btn_tekrarlamayi_durdur.Name = "btn_tekrarlamayi_durdur";
            btn_tekrarlamayi_durdur.Size = new Size(103, 60);
            btn_tekrarlamayi_durdur.TabIndex = 5;
            btn_tekrarlamayi_durdur.Text = "BİTİR";
            btn_tekrarlamayi_durdur.UseVisualStyleBackColor = false;
            btn_tekrarlamayi_durdur.Click += btn_tekrarlamayi_durdur_Click;
            // 
            // txb_tekrar_sayisi
            // 
            txb_tekrar_sayisi.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txb_tekrar_sayisi.Location = new Point(576, 148);
            txb_tekrar_sayisi.Name = "txb_tekrar_sayisi";
            txb_tekrar_sayisi.Size = new Size(125, 34);
            txb_tekrar_sayisi.TabIndex = 7;
            txb_tekrar_sayisi.Text = "1";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(385, 154);
            label1.Name = "label1";
            label1.Size = new Size(142, 28);
            label1.TabIndex = 8;
            label1.Text = "Tekrar Sayısı :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(275, 60);
            label2.Name = "label2";
            label2.Size = new Size(252, 28);
            label2.TabIndex = 11;
            label2.Text = "Hareket Hız Süre Aralığı :";
            // 
            // txb_tekrarlama_hareket_sure_araligi
            // 
            txb_tekrarlama_hareket_sure_araligi.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txb_tekrarlama_hareket_sure_araligi.Location = new Point(576, 57);
            txb_tekrarlama_hareket_sure_araligi.Name = "txb_tekrarlama_hareket_sure_araligi";
            txb_tekrarlama_hareket_sure_araligi.Size = new Size(125, 34);
            txb_tekrarlama_hareket_sure_araligi.TabIndex = 10;
            txb_tekrarlama_hareket_sure_araligi.Text = "50";
            txb_tekrarlama_hareket_sure_araligi.TextChanged += txb_tekrarlama_hareket_sure_araligi_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(59, 106);
            label3.Name = "label3";
            label3.Size = new Size(468, 28);
            label3.TabIndex = 13;
            label3.Text = "Tekrarlamanın Arasındaki Bekleme Süre Aralığı :";
            // 
            // txb_tekrarlarin_arasindaki_sure_araligi
            // 
            txb_tekrarlarin_arasindaki_sure_araligi.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txb_tekrarlarin_arasindaki_sure_araligi.Location = new Point(576, 100);
            txb_tekrarlarin_arasindaki_sure_araligi.Name = "txb_tekrarlarin_arasindaki_sure_araligi";
            txb_tekrarlarin_arasindaki_sure_araligi.Size = new Size(125, 34);
            txb_tekrarlarin_arasindaki_sure_araligi.TabIndex = 12;
            txb_tekrarlarin_arasindaki_sure_araligi.Text = "200";
            // 
            // btn_durdur
            // 
            btn_durdur.BackColor = Color.Red;
            btn_durdur.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btn_durdur.Location = new Point(203, 58);
            btn_durdur.Name = "btn_durdur";
            btn_durdur.Size = new Size(103, 60);
            btn_durdur.TabIndex = 15;
            btn_durdur.Text = "Durdur";
            btn_durdur.UseVisualStyleBackColor = false;
            btn_durdur.Click += btn_durdur_Click;
            // 
            // btn_baslat
            // 
            btn_baslat.BackColor = Color.Lime;
            btn_baslat.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btn_baslat.ForeColor = SystemColors.ControlText;
            btn_baslat.Location = new Point(74, 58);
            btn_baslat.Name = "btn_baslat";
            btn_baslat.RightToLeft = RightToLeft.Yes;
            btn_baslat.Size = new Size(97, 60);
            btn_baslat.TabIndex = 14;
            btn_baslat.Text = "Başlat";
            btn_baslat.UseVisualStyleBackColor = false;
            btn_baslat.Click += btn_baslat_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.InactiveCaption;
            panel1.Controls.Add(label4);
            panel1.Controls.Add(btn_durdur);
            panel1.Controls.Add(btn_baslat);
            panel1.Location = new Point(542, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(350, 161);
            panel1.TabIndex = 16;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(16, 12);
            label4.Name = "label4";
            label4.Size = new Size(184, 31);
            label4.TabIndex = 0;
            label4.Text = "HAREKET KAYIT";
            // 
            // panel2
            // 
            panel2.BackColor = Color.LightSteelBlue;
            panel2.Controls.Add(label5);
            panel2.Controls.Add(btn_tekrarlamayi_durdur);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(btn_tekrarla);
            panel2.Controls.Add(txb_tekrar_sayisi);
            panel2.Controls.Add(txb_tekrarlarin_arasindaki_sure_araligi);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(txb_tekrarlama_hareket_sure_araligi);
            panel2.Location = new Point(542, 210);
            panel2.Name = "panel2";
            panel2.Size = new Size(746, 315);
            panel2.TabIndex = 17;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.Highlight;
            label5.Location = new Point(15, 11);
            label5.Name = "label5";
            label5.Size = new Size(227, 31);
            label5.TabIndex = 0;
            label5.Text = "HAREKET KONTROL";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.ErrorImage = (Image)resources.GetObject("pictureBox1.ErrorImage");
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(513, 513);
            pictureBox1.TabIndex = 18;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(1297, 529);
            Controls.Add(pictureBox1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(btn_kaydet);
            Controls.Add(txb_kordinat);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txb_kordinat;
        private Button btn_kaydet;
        private Button btn_tekrarla;
        private Button btn_tekrarlamayi_durdur;
        private TextBox txb_tekrar_sayisi;
        private Label label1;
        private Label label2;
        private TextBox txb_tekrarlama_hareket_sure_araligi;
        private Label label3;
        private TextBox txb_tekrarlarin_arasindaki_sure_araligi;
        private Button btn_durdur;
        private Button btn_baslat;
        private Panel panel1;
        private Label label4;
        private Panel panel2;
        private Label label5;
        private PictureBox pictureBox1;
    }
}
