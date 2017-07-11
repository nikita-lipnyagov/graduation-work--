using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Квалификационная_работа
{
    public partial class frmTest : Form
    {
        public frmTest()
        {
            InitializeComponent();
        }
        private void frmTest_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            lblMenu.Height = 80;
            lblMenu.Width += 5;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            lblMenu.Height = 65;
            lblMenu.Width -= 5;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            frmMenu frmMenu = new frmMenu();
            frmMenu.Show();
            this.Hide();
        }

        private void Normal_MouseEnter(object sender, EventArgs e)
        {
            Normal.Font = new Font("Comic Sans MS", 24);
            Normal.ForeColor = Color.Blue;
            Info.Text = "Одразу проходите тест й отримуєте оцінку.";
        }

        private void Normal_MouseLeave(object sender, EventArgs e)
        {
            Normal.Font = new Font("Comic Sans MS", 22);
            Normal.ForeColor = Color.Black;
            Info.Text = "";
        }

        private void WithRegistration_MouseEnter(object sender, EventArgs e)
        {
            WithRegistration.Font = new Font("Comic Sans MS", 24);
            WithRegistration.ForeColor = Color.Blue;
            Info.Text = "Спочатку реєструєтесь(Прізвище, Ім'я, пошта), потім проходите тест й після його закінчення ваші результати відсилаються вам на пошту.";
        }

        private void WithRegistration_MouseLeave(object sender, EventArgs e)
        {
            WithRegistration.Font = new Font("Comic Sans MS", 22);
            WithRegistration.ForeColor = Color.Black;
            Info.Text = "";
        }

        public void Normal_Click(object sender, EventArgs e)
        {
            File.Create(Application.StartupPath + "\\txt Файлы\\Учень.txt");
            frmTest1 frmTest1 = new frmTest1();
            frmTest1.ShowDialog();
            this.Hide();          
        }

        public void WithRegistration_Click(object sender, EventArgs e)
        {
            frmRegistration frmRegistration = new frmRegistration();
            frmRegistration.ShowDialog();
            this.Hide();
            
        }

        
       
    }
}
