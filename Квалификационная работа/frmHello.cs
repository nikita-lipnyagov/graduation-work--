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
    public partial class frmHello : Form
    {
        public frmHello()
        {
            InitializeComponent();
        }
        private void frmHello_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            frmMenu frmMenu = new frmMenu();
            frmMenu.Show();
            this.Hide();
        }
        private void pictureBox2_MouseEnter(object sender, EventArgs e)
        {
            pictureBox2.Height = 160;
        }
        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            pictureBox2.Height = 145;
        }
        private void pictureBox3_MouseEnter(object sender, EventArgs e)
        {
            pictureBox3.Height = 125;
            pictureBox3.Width = 65;
        }
        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            pictureBox3.Height = 110;
            pictureBox3.Width = 60;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            frmDovidka frmDovidka = new frmDovidka();
            frmDovidka.ShowDialog();
        }
 
        

       

       
    }
}
