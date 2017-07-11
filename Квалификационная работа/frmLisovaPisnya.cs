using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Квалификационная_работа
{
    public partial class frmLisovaPisnya : Form
    {
        public frmLisovaPisnya()
        {
            InitializeComponent();
        }
        private void frmLisovaPisnya_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            frmMenu frmMenu = new frmMenu();
            frmMenu.Show();
            this.Hide();
        }
        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            pictureBox1.Height = 80;
            pictureBox1.Width += 5;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.Height = 65;
            pictureBox1.Width -= 5;
        }

        private void label2_MouseEnter(object sender, EventArgs e)
        {
            Istoria.Font = new Font("Comic Sans MS", 20);
            Istoria.ForeColor = Color.Blue;
        }
        private void label2_MouseLeave(object sender, EventArgs e)
        {
            Istoria.Font = new Font("Comic Sans MS", 18);
            Istoria.ForeColor = Color.Black;
        }
        private void label1_MouseEnter(object sender, EventArgs e)
        {
            Suzhet.Font = new Font("Comic Sans MS", 20);
            Suzhet.ForeColor = Color.Blue;
        }
        private void label1_MouseLeave(object sender, EventArgs e)
        {
            Suzhet.Font = new Font("Comic Sans MS", 18);
            Suzhet.ForeColor = Color.Black;
        }

        private void label3_MouseEnter(object sender, EventArgs e)
        {
            Analiz.Font = new Font("Comic Sans MS", 20);
            Analiz.ForeColor = Color.Blue;
        }

        private void label3_MouseLeave(object sender, EventArgs e)
        {
            Analiz.Font = new Font("Comic Sans MS", 18);
            Analiz.ForeColor = Color.Black;
        }

        private void label4_MouseEnter(object sender, EventArgs e)
        {
            Texttvoru.Font = new Font("Comic Sans MS", 20);
            Texttvoru.ForeColor = Color.Blue;
        }

        private void label4_MouseLeave(object sender, EventArgs e)
        {
            Texttvoru.Font = new Font("Comic Sans MS", 18);
            Texttvoru.ForeColor = Color.Black;
        }
        private void Igra_MouseEnter(object sender, EventArgs e)
        {
            Igra.Font = new Font("Comic Sans MS", 20);
            Igra.ForeColor = Color.Blue;
        }

        private void Igra_MouseLeave(object sender, EventArgs e)
        {
            Igra.Font = new Font("Comic Sans MS", 18);
            Igra.ForeColor = Color.Black;
        }
        private void frmLisovaPisnya_Load(object sender, EventArgs e)
        {
            webBrowser1.Navigate(Application.StartupPath + "\\Lisova Pisnya\\0.htm");
        }
        private void label2_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(Application.StartupPath + "\\Lisova Pisnya\\0.htm");
        }

        private void label1_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(Application.StartupPath + "\\Lisova Pisnya\\1.htm");
        }

        private void label3_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(Application.StartupPath + "\\Lisova Pisnya\\2.htm");
        }

        private void label4_Click(object sender, EventArgs e)
        {
            frmAdobe frmAdobe = new frmAdobe();
            frmAdobe.ShowDialog();
        }

        private void Igra_Click(object sender, EventArgs e)
        {
            frmPyatnashki frmPyatnashki = new frmPyatnashki();
            frmPyatnashki.ShowDialog();
        }

       

      



        

        
    }
}
