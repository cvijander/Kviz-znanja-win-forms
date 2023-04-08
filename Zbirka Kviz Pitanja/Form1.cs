namespace Zbirka_Kviz_Pitanja
{
    public partial class Form1 : Form
    {
        private string ime;
        private string prezime;
        private int poeni = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            gboxPitanje1.Visible = false;
            gboxPitanje2.Visible = false;
            gbxPitanje3.Visible = false;
            gbxPitanje4.Visible = false;
            grbOdgovori.Visible = false;
        }

        private void btnPredjiNaPitanja_Click(object sender, EventArgs e)
        {
            ime = txtIme.Text;
            prezime = txtPrezime.Text;
            gboxPocetnoLogovanje.Visible = false;
            gboxPitanje1.Visible = true;
            gboxPitanje2.Visible = false;
            gbxPitanje3.Visible = false;
            gbxPitanje4.Visible = false;
            grbOdgovori.Visible = false;
        }

        private void btn1to2_Click(object sender, EventArgs e)
        {
            if (!chb1950.Checked == true && cbx1963.Checked == true && chb2012.Checked == true && !chb2017.Checked == true)
                poeni++;

            gboxPitanje2.Visible = true;
            gboxPitanje1.Visible = false;
            gbxPitanje3.Visible = false;
            gbxPitanje4.Visible = false;
            grbOdgovori.Visible = false;
        }

        private void btn2to3_Click(object sender, EventArgs e)
        {
            if (!rbtJukeBox.Checked == true && rbtGroupBox.Checked == true && !rbtTextBox.Checked == true && !rbtRichTextBox.Checked == true)
                poeni++;
            gboxPitanje2.Visible = false;
            gboxPitanje1.Visible = false;
            gbxPitanje3.Visible = true;
            gbxPitanje4.Visible = false;
            grbOdgovori.Visible = false;
        }

        private void btn3to4_Click(object sender, EventArgs e)
        {
            if (chbDesktopAplikacije.Checked == true && chbServerskeAplikacije.Checked == true && ckbMobilneAplikacije.Checked == true && ckbWebAplikacije.Checked == true)
                poeni++;
            gbxPitanje4.Visible = true;
            gboxPitanje1.Visible = false;
            gbxPitanje3.Visible = false;
            gboxPitanje2.Visible = false;
            grbOdgovori.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!rbtGroupBoxP4.Checked == true && !rbtJukeBoxP4.Checked == true && rbtRichTextBoxP4.Checked == true && !rbtTextBoxP4.Checked == true)
                poeni++;
            grbOdgovori.Visible = true;
            gbxPitanje4.Visible = false;
            label7.Text = "Broj tacnih odgovora: " + poeni;
        }

        private void btnIzadji_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void grbOdgovori_Enter(object sender, EventArgs e)
        {
            label7.Text = "Broj tacnih odgovora: " + poeni;
        }
    }
}