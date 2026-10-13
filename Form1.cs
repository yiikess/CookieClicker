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
        int cena_za_pasivni_klikani = 200;

        private void main_clicker_Click(object sender, EventArgs e)
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

            if (PocetCokies >= cena_za_pasivni_klikani)
            {
                PocetCokies -= cena_za_pasivni_klikani;
                cena_za_pasivni_klikani += 100;
                PasivniPrijem += 1;
                casovac_na_pasiv_cookies.Enabled = true;
                PocetCookies.Text = PocetCokies.ToString();
                label_pasivni_cookies_cena.Text = Convert.ToString(cena_za_pasivni_klikani) + "  Cookies";
            }

        }

        private void casovac_na_pasiv_cookies_Tick(object sender, EventArgs e)
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
                casovac_na_balik.Enabled = true;
                PocetCookies.Text = PocetCokies.ToString();
            }
        }

        private void casovac_na_balik_Tick(object sender, EventArgs e)
        {
            PocetCokies += PasivniKrabice;
            PocetCookies.Text = PocetCokies.ToString();
        }

        private void admin_button_Click(object sender, EventArgs e)
        {
            PocetCokies += 100;
            PocetCookies.Text = Convert.ToString(PocetCokies);
        }

        private void casovac_cena_upgradu_Tick(object sender, EventArgs e)
        {
            

        }

        private void label_pasivni_cookies_cena_Click(object sender, EventArgs e)
        {
            PasivniKlikani.PerformClick();
        }
    }
}
