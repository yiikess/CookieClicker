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
            timer1 = new System.Windows.Forms.Timer(components);
            timer2 = new System.Windows.Forms.Timer(components);
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
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
            PasivniKlikani.Text = "200 Cookies";
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
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // timer2
            // 
            timer2.Interval = 15000;
            timer2.Tick += timer2_Tick;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(291, 101);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(213, 99);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(label_VelkyBalik);
            Controls.Add(label_PasivniKlikani);
            Controls.Add(label_ZlepseniSiliClicknuti);
            Controls.Add(BalikCookies);
            Controls.Add(PasivniKlikani);
            Controls.Add(ZlepseniSily);
            Controls.Add(PocetCookies);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private PictureBox pictureBox1;
    }
}
