using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;//hatalar için import edilmiştir ve dahi proje kısmından.
namespace GP3
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void kapat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void GERİ_Click(object sender, EventArgs e)
        {
            Form1 f2 = new Form1();
            f2.Visible = true;
            this.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
           label1.Text =(listBox3.Items.Count.ToString());
           

            if (Convert.ToInt32(label1.Text) < 5)
            {
                gunaPictureBox1.BackColor = Color.Red;
            }
            else if (Convert.ToInt32(label1.Text) > 5 && Convert.ToInt32(label1.Text) < 10)
            {
                gunaPictureBox1.BackColor = Color.Orange;
            }
            else if (Convert.ToInt32(label1.Text) > 10) {
                gunaPictureBox1.BackColor = Color.DarkGreen;
            }
           
        
        }

        private void button1_Click(object sender, EventArgs e)
        {
             MessageBoxButtons evetHayir = MessageBoxButtons.YesNo;
            MessageBoxIcon uyarı = MessageBoxIcon.Information;


            if (Convert.ToInt32(label1.Text) < 5) {
                MessageBox.Show(label1.Text + " Kişi ile Katılım oranı çok azdır. Onaylıyor musunuz ?", "Katılımcı Onay", evetHayir, MessageBoxIcon.Warning);
            }
            else if (Convert.ToInt32(label1.Text)>= 5 && Convert.ToInt32(label1.Text) <= 10) {
                MessageBox.Show(label1.Text + " Kişi ile Katılım oranı orta düzeydedir. Onaylıyor musunuz ?", "Katılımcı Onay", evetHayir,uyarı);
            }
            else if (Convert.ToInt32(label1.Text) > 10) {
                MessageBox.Show(label1.Text + " Kişi ile Katılım oranı yeterlidir. Onaylıyor musunuz ?", "Katılımcı Onay",evetHayir,uyarı);
            }
        }

    }
}
