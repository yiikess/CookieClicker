namespace Graficke_rozhrani
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            PocetCookies = new Label();
            ZlepseniSily = new Button();
            PasivniKlikani = new Button();
            BalikCookies = new Button();
            label_ZlepseniSiliClicknuti = new Label();
            label_PasivniKlikani = new Label();
            label_VelkyBalik = new Label();
            casovac_na_pasiv_cookies = new System.Windows.Forms.Timer(components);
            casovac_na_balik = new System.Windows.Forms.Timer(components);
            main_clicker = new PictureBox();
            label_pasivni_cookies_cena = new Label();
            admin_button = new Button();
            casovac_cena_upgradu = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)main_clicker).BeginInit();
            SuspendLayout();
            // 
            // PocetCookies
            // 
            PocetCookies.AutoSize = true;
            PocetCookies.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
            PocetCookies.Location = new Point(360, 54);
            PocetCookies.Name = "PocetCookies";
            PocetCookies.Size = new Size(144, 30);
            PocetCookies.TabIndex = 1;
            PocetCookies.Text = "PocetCookies";
            // 
            // ZlepseniSily
            // 
            ZlepseniSily.Location = new Point(27, 114);
            ZlepseniSily.Name = "ZlepseniSily";
            ZlepseniSily.Size = new Size(128, 23);
            ZlepseniSily.TabIndex = 2;
            ZlepseniSily.Text = "150 Cookies";
            ZlepseniSily.UseVisualStyleBackColor = true;
            ZlepseniSily.Click += ZlepseniSily_Click;
            // 
            // PasivniKlikani
            // 
            PasivniKlikani.Location = new Point(27, 177);
            PasivniKlikani.Name = "PasivniKlikani";
            PasivniKlikani.Size = new Size(128, 23);
            PasivniKlikani.TabIndex = 3;
            PasivniKlikani.UseVisualStyleBackColor = true;
            PasivniKlikani.Click += PasivniKlikani_Click;
            // 
            // BalikCookies
            // 
            BalikCookies.Location = new Point(27, 249);
            BalikCookies.Name = "BalikCookies";
            BalikCookies.Size = new Size(128, 23);
            BalikCookies.TabIndex = 4;
            BalikCookies.Text = "250 Cookies";
            BalikCookies.UseVisualStyleBackColor = true;
            BalikCookies.Click += BalikCookies_Click;
            // 
            // label_ZlepseniSiliClicknuti
            // 
            label_ZlepseniSiliClicknuti.AutoSize = true;
            label_ZlepseniSiliClicknuti.Location = new Point(27, 89);
            label_ZlepseniSiliClicknuti.Name = "label_ZlepseniSiliClicknuti";
            label_ZlepseniSiliClicknuti.Size = new Size(119, 15);
            label_ZlepseniSiliClicknuti.TabIndex = 5;
            label_ZlepseniSiliClicknuti.Text = "Zlepšení síly clicknutí";
            // 
            // label_PasivniKlikani
            // 
            label_PasivniKlikani.AutoSize = true;
            label_PasivniKlikani.Location = new Point(48, 159);
            label_PasivniKlikani.Name = "label_PasivniKlikani";
            label_PasivniKlikani.Size = new Size(82, 15);
            label_PasivniKlikani.TabIndex = 6;
            label_PasivniKlikani.Text = "Pasivní Klikání";
            // 
            // label_VelkyBalik
            // 
            label_VelkyBalik.AutoSize = true;
            label_VelkyBalik.Location = new Point(41, 221);
            label_VelkyBalik.Name = "label_VelkyBalik";
            label_VelkyBalik.Size = new Size(105, 15);
            label_VelkyBalik.TabIndex = 7;
            label_VelkyBalik.Text = "Velký bálík cookies";
            // 
            // casovac_na_pasiv_cookies
            // 
            casovac_na_pasiv_cookies.Interval = 1000;
            casovac_na_pasiv_cookies.Tick += casovac_na_pasiv_cookies_Tick;
            // 
            // casovac_na_balik
            // 
            casovac_na_balik.Interval = 15000;
            casovac_na_balik.Tick += casovac_na_balik_Tick;
            // 
            // main_clicker
            // 
            main_clicker.BackColor = Color.Transparent;
            main_clicker.Image = (Image)resources.GetObject("main_clicker.Image");
            main_clicker.Location = new Point(291, 101);
            main_clicker.Name = "main_clicker";
            main_clicker.Size = new Size(213, 99);
            main_clicker.SizeMode = PictureBoxSizeMode.Zoom;
            main_clicker.TabIndex = 8;
            main_clicker.TabStop = false;
            main_clicker.Click += main_clicker_Click;
            // 
            // label_pasivni_cookies_cena
            // 
            label_pasivni_cookies_cena.AutoSize = true;
            label_pasivni_cookies_cena.Location = new Point(48, 181);
            label_pasivni_cookies_cena.Name = "label_pasivni_cookies_cena";
            label_pasivni_cookies_cena.Size = new Size(25, 15);
            label_pasivni_cookies_cena.TabIndex = 9;
            label_pasivni_cookies_cena.Text = "200";
            label_pasivni_cookies_cena.Click += label_pasivni_cookies_cena_Click;
            // 
            // admin_button
            // 
            admin_button.Location = new Point(303, 397);
            admin_button.Name = "admin_button";
            admin_button.Size = new Size(151, 23);
            admin_button.TabIndex = 10;
            admin_button.Text = "admin_button";
            admin_button.UseVisualStyleBackColor = true;
            admin_button.Click += admin_button_Click;
            // 
            // casovac_cena_upgradu
            // 
            casovac_cena_upgradu.Interval = 200;
            casovac_cena_upgradu.Tick += casovac_cena_upgradu_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(admin_button);
            Controls.Add(label_pasivni_cookies_cena);
            Controls.Add(main_clicker);
            Controls.Add(label_VelkyBalik);
            Controls.Add(label_PasivniKlikani);
            Controls.Add(label_ZlepseniSiliClicknuti);
            Controls.Add(BalikCookies);
            Controls.Add(PasivniKlikani);
            Controls.Add(ZlepseniSily);
            Controls.Add(PocetCookies);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)main_clicker).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label PocetCookies;
        private Button ZlepseniSily;
        private Button PasivniKlikani;
        private Button BalikCookies;
        private Label label_ZlepseniSiliClicknuti;
        private Label label_PasivniKlikani;
        private Label label_VelkyBalik;
        private System.Windows.Forms.Timer casovac_na_pasiv_cookies;
        private System.Windows.Forms.Timer casovac_na_balik;
        private PictureBox main_clicker;
        private Label label_pasivni_cookies_cena;
        private Button admin_button;
        private System.Windows.Forms.Timer casovac_cena_upgradu;
    }
}
