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
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }
        private void frmMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            label1.Font = new Font("Comic Sans MS", 20);
            label1.ForeColor = Color.Blue;
        }
        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            label1.Font = new Font("Comic Sans MS", 18);
            label1.ForeColor = Color.Black;
        }
        private void pictureBox2_MouseEnter(object sender, EventArgs e)
        {
            label3.Font = new Font("Comic Sans MS", 20);
            label3.ForeColor = Color.Blue;
        }
        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            label3.Font = new Font("Comic Sans MS", 18);
            label3.ForeColor = Color.Black;
        }
        private void pictureBox3_MouseEnter(object sender, EventArgs e)
        {
            label4.Font = new Font("Comic Sans MS", 20);
            label4.ForeColor = Color.Blue;
        }
     
        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            label4.Font = new Font("Comic Sans MS", 18);
            label4.ForeColor = Color.Black;
        }

        private void pictureBox4_MouseEnter(object sender, EventArgs e)
        {
            label5.Font = new Font("Comic Sans MS", 20);
            label5.ForeColor = Color.Blue;
        }

        private void pictureBox4_MouseLeave(object sender, EventArgs e)
        {
            label5.Font = new Font("Comic Sans MS", 18);
            label5.ForeColor = Color.Black;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            frmBiography frmBiography = new frmBiography();
            frmBiography.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            frmLisovaPisnya frmLisovaPisnya = new frmLisovaPisnya();
            frmLisovaPisnya.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            frmMap frmMap = new frmMap();
            frmMap.Show();
            this.Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            frmTest frmTest = new frmTest();
            frmTest.Show();
            this.Hide();
        }

       

       

       

       
        
    }
}
