

namespace IMPICC_INTERF
{
    public partial class Form1 : Form
    {
        static bool again = true;
        static int tentativi = 10, punti = 0;
        static string parolaDaIndovinare = "", lUs = "LETTERE USATE--->", indovinate = "", errate = "",lc="";
        static bool parolaCompleta = false, letteraIndovinata = false, parolaComp = false;
        static string l = "";
        static char[] pINd = { };
        public Form1()
        {
            InitializeComponent();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void fac_Click(object sender, EventArgs e)
        {
            tentativi = 10;
            punti = 0;
            lUs = "LETTERE USATE--->";
            tent.Text = "TENTATIVI--->" + tentativi.ToString();
            punteggio.Text = "PUNTEGGIO--->" + punti.ToString();
            string filePath = "IMPICCATO_PAROLE2.txt";
            string[] lines2 = File.ReadAllLines(filePath);
            Random random = new Random();
            int pS2 = random.Next(lines2.Length);
            parolaDaIndovinare = lines2[pS2];
            pINd = new string('_', parolaDaIndovinare.Length).ToCharArray();
            trat.Text = new string(pINd);

        }

        private void med_Click(object sender, EventArgs e)
        {
            tentativi = 10;
            punti = 0;
            lUs = "LETTERE USATE--->";
            tent.Text = "TENTATIVI--->" + tentativi.ToString();
            punteggio.Text = "PUNTEGGIO--->" + punti.ToString();
            string filePath = "IMPICCATO_PAROLE1.txt";
            string[] lines1 = File.ReadAllLines(filePath);
            Random random = new Random();
            int pS1 = random.Next(lines1.Length);
            parolaDaIndovinare = lines1[pS1];
            pINd = new string('_', parolaDaIndovinare.Length).ToCharArray();
            trat.Text = new string(pINd);
        }

        private void dif_Click(object sender, EventArgs e)
        {
            tentativi = 10;
            punti = 0;
            lUs = "LETTERE USATE--->";
            tent.Text = "TENTATIVI--->" + tentativi.ToString();
            punteggio.Text = "PUNTEGGIO--->" + punti.ToString();
            string filePath = "IMPICCATO_PAROLE3.txt";
            string[] lines3 = File.ReadAllLines(filePath);
            Random random = new Random();
            int pS3 = random.Next(lines3.Length);
            parolaDaIndovinare = lines3[pS3];
            pINd = new string('_', parolaDaIndovinare.Length).ToCharArray();
            trat.Text = new string(pINd);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lettera_Click(object sender, EventArgs e)
        {

            string l = scritLettera.Text;
            bool letteraIndovinata = false;
            char lettera = l[0];
            for (int i = 0; i < parolaDaIndovinare.Length; i++)
            {
                if (parolaDaIndovinare[i] == lettera && pINd[i] == '_')
                {
                    pINd[i] = lettera;
                    letteraIndovinata = true;
                }
            }
            trat.Text = new string(pINd);
            if (letteraIndovinata == false)
            {
                tentativi--;
            }
            if (tentativi == 0)
            {
                Application.Exit();
            }

            scritLettera.Text = "";
            tent.Text = "TENTATIVI--->" + tentativi.ToString();
            if (letteraIndovinata == true)
            {
                lettera = l[0];
                punti++;
                indovinate = indovinate + lettera;

                if (parolaDaIndovinare.Length == 4)
                {
                    punti = punti * 4;
                }
                else if (parolaDaIndovinare.Length == 5)
                {
                    punti = punti * 5;
                }
                else
                {
                    punti = punti * 6;
                }
            }

            punteggio.Text = "PUNTEGGIO--->" + punti.ToString();
            lUs += l + ",";
            lSbagliate.Text = lUs.ToString();
        }

        private void parola_Click(object sender, EventArgs e)
        {

            if (parolaDaIndovinare == scritParola.Text)
            {
                parolaComp = true;
                punti = punti * 10;
                trat.Text=parolaDaIndovinare.ToString();
            }
            scritParola.Text = "";
        }

        private void tentativi_Click(object sender, EventArgs e)
        {

        }

        private void lSbagliate_Click(object sender, EventArgs e) ///////////////USATE
        {

        }

        private void jolly_Click(object sender, EventArgs e)
        {
            if (pINd.Length == 6)
            {
                Random rand = new Random();
                int nCas = rand.Next(parolaDaIndovinare.Length);

                // Aiuto con un jolly per la modalità difficile
                char j = parolaDaIndovinare[nCas];
                jolly.Text = j.ToString();
            }
            

        }

        private void punteggio_Click(object sender, EventArgs e)
        {

        }

        private void scritLettera_TextChanged(object sender, EventArgs e)
        {
            string l = scritLettera.Text;

        }

        private void trat_Click(object sender, EventArgs e)
        {

        }

        private void scritParola_TextChanged(object sender, EventArgs e)
        {
            string lc=scritParola.Text;
        }
    }
}