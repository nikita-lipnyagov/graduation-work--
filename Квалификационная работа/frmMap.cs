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
    public partial class frmMap : Form
    {
        public frmMap()
        {
            InitializeComponent();
        }
        
        private void frmMap_FormClosed(object sender, FormClosedEventArgs e)
        {

            Application.Exit();
        }

        private void pictureBox2_MouseEnter(object sender, EventArgs e)
        {
            pictureBox2.Height = 80;
            pictureBox2.Width += 5;
        }
        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            pictureBox2.Height = 65;
            pictureBox2.Width -= 5;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            frmMenu frmMenu = new frmMenu();
            frmMenu.Show();
            this.Hide();
        }
        private void pictureBox8_MouseEnter_1(object sender, EventArgs e)
        {
            USA.Height += 3;
            USA.Width += 2;
            Info.Text = "Пам’ятник Лесі Українці у Клівленді (США)";
        }
        private void pictureBox8_MouseLeave(object sender, EventArgs e)
        {
            USA.Height -= 3;
            USA.Width  -= 2;
            Info.Text = "";
        }

        private void pictureBox5_MouseEnter(object sender, EventArgs e)
        {
            Canada.Height += 3;
            Canada.Width += 2;
            Info.Text = "Пам'ятник Лесі Українці у Торонто";
        }
        private void pictureBox5_MouseLeave(object sender, EventArgs e)
        {
            Canada.Height -= 3;
            Canada.Width -= 2;
            Info.Text = "";
        }
        private void pictureBox13_MouseEnter(object sender, EventArgs e)
        {
            Germany.Height += 3;
            Germany.Width += 2;
            Info.Text = "Меморіальна дошка Лесі Українці в Берліні";
        }
        private void pictureBox13_MouseLeave(object sender, EventArgs e)
        {
            Germany.Height -= 3;
            Germany.Width -= 2;
            Info.Text = "";
        }
        private void pictureBox11_MouseEnter(object sender, EventArgs e)
        {
            Italy.Height += 3;
            Italy.Width += 2;
            Info.Text = "Меморіальна дошка на будинку, де проживала Леся Українка Інтерес у Сан-Ремо";
        }
        private void pictureBox11_MouseLeave(object sender, EventArgs e)
        {
            Italy.Height -= 3;
            Italy.Width -= 2;
            Info.Text = "";
        }

       
        
        private void pictureBox7_MouseEnter(object sender, EventArgs e)
        {
            Georgia.Height += 3;
            Georgia.Width += 2;
            Info.Text = "Пам'ятник Лесі Українці в Телаві (Грузія)";
        }
        private void pictureBox7_MouseLeave(object sender, EventArgs e)
        {
            Georgia.Height -= 3;
            Georgia.Width -= 2;
            Info.Text = "";
        }
        private void pictureBox3_MouseEnter(object sender, EventArgs e)
        {
            Avstria.Height += 3;
            Avstria.Width += 2;
            Info.Text = "Меморіальна дошка Лесі Українці у Відні (Австрія)";
        }
        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            Avstria.Height -= 3;
            Avstria.Width -= 2;
            Info.Text = "";
        }
       
        private void pictureBox13_Click(object sender, EventArgs e)
        {
            Form imgFrm = new Form();
            imgFrm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            imgFrm.MaximizeBox = false;
            imgFrm.MinimizeBox = false;
            imgFrm.Width = Berlin.Image.Width;
            imgFrm.Height = Berlin.Image.Height;
            imgFrm.BackgroundImage = Berlin.Image;
            imgFrm.StartPosition = FormStartPosition.CenterScreen;
            imgFrm.Text = "Берлін";
            imgFrm.Show();
        }

        

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Form imgFrm = new Form();
            imgFrm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            imgFrm.MaximizeBox = false;
            imgFrm.MinimizeBox = false;
            imgFrm.Width = Toronto.Image.Width;
            imgFrm.Height = Toronto.Image.Height;
            imgFrm.BackgroundImage = Toronto.Image;
            imgFrm.StartPosition = FormStartPosition.CenterScreen;
            imgFrm.Text = "Торонто";
            imgFrm.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Form imgFrm = new Form();
            imgFrm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            imgFrm.MaximizeBox = false;
            imgFrm.MinimizeBox = false;
            imgFrm.Width = Viden.Image.Width;
            imgFrm.Height = Viden.Image.Height;
            imgFrm.BackgroundImage = Viden.Image;
            imgFrm.StartPosition = FormStartPosition.CenterScreen;
            imgFrm.Text = "Відень";
            imgFrm.Show();
        }

        private void Georgia_Click(object sender, EventArgs e)
        {
            Form imgFrm = new Form();
            imgFrm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            imgFrm.MaximizeBox = false;
            imgFrm.MinimizeBox = false;
            imgFrm.Width = Telava.Image.Width;
            imgFrm.Height = Telava.Image.Height;
            imgFrm.BackgroundImage = Telava.Image;
            imgFrm.StartPosition = FormStartPosition.CenterScreen;
            imgFrm.Text = "Телава";
            imgFrm.Show();
        }

        private void USA_Click(object sender, EventArgs e)
        {
            Form imgFrm = new Form();
            imgFrm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            imgFrm.MaximizeBox = false;
            imgFrm.MinimizeBox = false;
            imgFrm.Width = Klivlend.Image.Width;
            imgFrm.Height = Klivlend.Image.Height;
            imgFrm.BackgroundImage = Klivlend.Image;
            imgFrm.StartPosition = FormStartPosition.CenterScreen;
            imgFrm.Text = "Клівленд";
            imgFrm.Show();
        }

        private void Italy_Click(object sender, EventArgs e)
        {
            Form imgFrm = new Form();
            imgFrm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            imgFrm.MaximizeBox = false;
            imgFrm.MinimizeBox = false;
            imgFrm.Width = SanRemo.Image.Width;
            imgFrm.Height = SanRemo.Image.Height;
            imgFrm.BackgroundImage = SanRemo.Image;
            imgFrm.StartPosition = FormStartPosition.CenterScreen;
            imgFrm.Text = "Сан Ремо";
            imgFrm.Show();
        }

      

        private void Ukraine_Click(object sender, EventArgs e)
        {
            frmUkraine frmUkraine = new frmUkraine();
            frmUkraine.Show();
            this.Hide();
        }

       




    }
}
