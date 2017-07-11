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
    public partial class frmBiography : Form
    {
        public frmBiography()
        {
            InitializeComponent();
        }

        private void frmBiography_FormClosed(object sender, FormClosedEventArgs e)
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

        private void label1_MouseEnter(object sender, EventArgs e)
        {
            Batki.Font = new Font("Comic Sans MS", 20);
            Batki.ForeColor = Color.Blue;
        }
        private void label1_MouseLeave(object sender, EventArgs e)
        {
            Batki.Font = new Font("Comic Sans MS", 18);
            Batki.ForeColor = Color.Black;
        }

        private void label2_MouseEnter(object sender, EventArgs e)
        {
            Rid.Font = new Font("Comic Sans MS", 20);
            Rid.ForeColor = Color.Blue;
        }

        private void label2_MouseLeave(object sender, EventArgs e)
        {
            Rid.Font = new Font("Comic Sans MS", 18);
            Rid.ForeColor = Color.Black;
        }

        private void label3_MouseEnter(object sender, EventArgs e)
        {
            Ditinstvo.Font = new Font("Comic Sans MS", 20);
            Ditinstvo.ForeColor = Color.Blue;
        }

        private void label3_MouseLeave(object sender, EventArgs e)
        {
            Ditinstvo.Font = new Font("Comic Sans MS", 18);
            Ditinstvo.ForeColor = Color.Black;
        }

        private void label4_MouseEnter(object sender, EventArgs e)
        {
            Yunist.Font = new Font("Comic Sans MS", 20);
            Yunist.ForeColor = Color.Blue;
        }

        private void label4_MouseLeave(object sender, EventArgs e)
        {
            Yunist.Font = new Font("Comic Sans MS", 18);
            Yunist.ForeColor = Color.Black;
        }

        private void label5_MouseEnter(object sender, EventArgs e)
        {
            Zrilist.Font = new Font("Comic Sans MS", 20);
            Zrilist.ForeColor = Color.Blue;
        }

        private void label5_MouseLeave(object sender, EventArgs e)
        {
            Zrilist.Font = new Font("Comic Sans MS", 18);
            Zrilist.ForeColor = Color.Black;
        }

        private void label6_MouseEnter(object sender, EventArgs e)
        {
            Tvorchist.Font = new Font("Comic Sans MS", 20);
            Tvorchist.ForeColor = Color.Blue;
        }

        private void label6_MouseLeave(object sender, EventArgs e)
        {
            Tvorchist.Font = new Font("Comic Sans MS", 18);
            Tvorchist.ForeColor = Color.Black;
        }

        private void label7_MouseEnter(object sender, EventArgs e)
        {
            Fakti.Font = new Font("Comic Sans MS", 20);
            Fakti.ForeColor = Color.Blue;
        }

        private void label7_MouseLeave(object sender, EventArgs e)
        {
            Fakti.Font = new Font("Comic Sans MS", 18);
            Fakti.ForeColor = Color.Black;
        }

        private void label8_MouseEnter(object sender, EventArgs e)
        {
            Video.Font = new Font("Comic Sans MS", 20);
            Video.ForeColor = Color.Blue;
        }

        private void label8_MouseLeave(object sender, EventArgs e)
        {
            Video.Font = new Font("Comic Sans MS", 18);
            Video.ForeColor = Color.Black;
        }
        private void frmBiography_Load(object sender, EventArgs e)
        {
            webBrowser1.Navigate(Application.StartupPath + "\\Biography and tvorch\\1.htm");
        }
        private void label1_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(Application.StartupPath + "\\Biography and tvorch\\0.htm");
        }

        private void label2_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(Application.StartupPath + "\\Biography and tvorch\\1.htm");
        }

        private void label3_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(Application.StartupPath + "\\Biography and tvorch\\2.htm");
        }

        private void label4_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(Application.StartupPath + "\\Biography and tvorch\\3.htm");
        }

        private void label5_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(Application.StartupPath + "\\Biography and tvorch\\4.htm");
        }

        private void label6_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(Application.StartupPath + "\\Biography and tvorch\\5.htm");
        }

        private void label7_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(Application.StartupPath + "\\Biography and tvorch\\6.htm");
        }

        private void label8_Click(object sender, EventArgs e)
        {
            frmvideo1 frmvideo1 = new frmvideo1();
            frmvideo1.ShowDialog();
        }

       




    }
}
