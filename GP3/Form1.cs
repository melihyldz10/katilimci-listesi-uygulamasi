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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Form2 form2 = new Form2();


        
        private void list_Click(object sender, EventArgs e)
        {
            if (listBox2.Items.Count>0 ) {
                for (int i = 0; i < listBox2.Items.Count; i++)
                {
                    form2.listBox3.Items.Add(listBox2.Items[i]);
                }
                
                this.Visible = false;
                form2.ShowDialog();
            }
            else {MessageBox.Show("Lütfen Eklemek İstediğiniz Katılımcıyı Seçiniz.", "Katılımcı Listesi",MessageBoxButtons.OKCancel,MessageBoxIcon.Error);  }
           
        }



        private void git_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex ==-1)
            {
                MessageBox.Show("Lütfen Eklemek İstediğiniz Katılımcıyı Seçiniz.", "Katılımcı Listesi", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            else {
                listBox2.Items.Add(listBox1.SelectedItem);
                int i = 0;
                i = listBox1.SelectedIndex;
                listBox1.Items.RemoveAt(i);
            }

        }

        private void gel_Click(object sender, EventArgs e)
        {

            if (listBox2.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen Çıkarmak istediğiniz Katılımcıyı Seçiniz.", "Katılımcı Listesi", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            else
            {
                listBox1.Items.Add(listBox2.SelectedItem);
                int i = 0;
                i = listBox2.SelectedIndex;
                listBox2.Items.RemoveAt(i);
            }
        }

        private void tamG_Click(object sender, EventArgs e)
        {

            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                listBox2.Items.Add(listBox1.Items[i]);
            }
            listBox1.Items.Clear();
        }

        private void tamGel_Click(object sender, EventArgs e)
        {


            for (int i = 0; i < listBox2.Items.Count; i++)
            {
                listBox1.Items.Add(listBox2.Items[i]);
            }
            listBox2.Items.Clear();

         
        }

        
    }
}
