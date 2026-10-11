namespace Graficke_rozhrani
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int PocetCokies = 0;
        int SilaKliknuti = 1;
        int PasivniPrijem = 0;
        int PasivniKrabice = 0;
        private void mainClicker_Click(object sender, EventArgs e)
        {
            PocetCokies += SilaKliknuti;
            PocetCookies.Text = Convert.ToString(PocetCokies);
        }

        private void ZlepseniSily_Click(object sender, EventArgs e)
        {
            if (PocetCokies >= 150)
            {
                PocetCokies -= 150;
                SilaKliknuti += 1;

                PocetCookies.Text = PocetCokies.ToString();
            }
        }

        private void PasivniKlikani_Click(object sender, EventArgs e)
        {
            if (PocetCokies >= 200)
            {
                PocetCokies -= 200;
                PasivniPrijem += 1;
                timer1.Enabled = true;
                PocetCookies.Text = PocetCokies.ToString();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            PocetCokies += PasivniPrijem;
            PocetCookies.Text = PocetCokies.ToString();
        }

        private void BalikCookies_Click(object sender, EventArgs e)
        {
            if (PocetCokies >= 250)
            {
                PocetCokies -= 250;
                PasivniKrabice += 50;
                timer2.Enabled = true;
                PocetCookies.Text = PocetCokies.ToString();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            PocetCokies += PasivniKrabice;
            PocetCookies.Text = PocetCokies.ToString();
        }
    }
}
