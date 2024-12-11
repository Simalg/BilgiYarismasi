namespace BilgiYarismasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int soruNo = 0, dogru = 0, yanlis = 0;
        
        private void btnSonraki_Click(object sender, EventArgs e)
        {
            btnA.Enabled = true;
            btnB.Enabled = true;
            btnC.Enabled = true;
            btnD.Enabled = true;
            btnSonraki.Enabled = false;

            pictureBox1.Visible = false;
            pictureBox2.Visible = false;


            soruNo++;
            lblSoruNo.Text = soruNo.ToString();

            if (soruNo == 1)
            {
                richTextBox1.Text = "Cumhuriyet kaç yýlýnda ilan edilmiþtir?";
                btnA.Text = "1920";
                btnB.Text = "1921";
                btnC.Text = "1922";
                btnD.Text = "1923";
                label4.Text = "1923";

            }
            if (soruNo == 2)
            {
                richTextBox1.Text = "Dairenin alaný nedir?";
                btnA.Text = "?r^2";
                btnB.Text = "2 ?.r2+ 2?rh";
                btnC.Text = "a^2";
                btnD.Text = "(a+b)/2 x h";
                label4.Text = "?r^2";
            }
            if (soruNo == 3)
            {
                richTextBox1.Text = "Son kuþlar hangi yazarýmýza aittir?";
                btnA.Text = "Sait Faik";
                btnB.Text = "Cemal Süreyya";
                btnC.Text = "Atilla Ýlhan";
                btnD.Text = "Reþat Nuri";
                label4.Text = "Sait Faik";
                btnSonraki.Text = "Sonuçlar";
            }
            if (soruNo == 4)
            {
                btnA.Enabled= false;
                btnB.Enabled= false;    
                btnC.Enabled= false;
                btnD.Enabled= false;
                btnSonraki.Enabled= false;
                MessageBox.Show("Doðru: " + dogru + "\n" + "Yanlýþ: " + yanlis);
            }
        }
        private void ButtonClickHandler(Button clickedButton)
        {
            
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            btnSonraki.Enabled = true;

           
            label5.Text = clickedButton.Text;

          
            if (label4.Text == label5.Text)
            {
                dogru++;
                lblDogru.Text = dogru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlis++;
                lblYanlis.Text = yanlis.ToString();
                pictureBox2.Visible = true;
            }
        }

        private void btnA_Click(object sender, EventArgs e)
        {
            ButtonClickHandler(btnA);
        }

        private void btnB_Click(object sender, EventArgs e)
        {
            ButtonClickHandler(btnB);
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            ButtonClickHandler(btnC);
        }

        private void btnD_Click(object sender, EventArgs e)
        {
            ButtonClickHandler(btnD);
        }
    }
}
