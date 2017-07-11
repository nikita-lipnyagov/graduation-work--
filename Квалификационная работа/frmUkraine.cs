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
    public partial class frmUkraine : Form
    {
        public frmUkraine()
        {
            InitializeComponent();
        }
        private void frmUkraine_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        private void Menu_Click(object sender, EventArgs e)
        {
            frmMenu frmMenu = new frmMenu();
            frmMenu.Show();
            this.Hide();
        }

        private void Menu_MouseEnter(object sender, EventArgs e)
        {
            Menu.Height += 5;
            Menu.Width += 3;
        }

        private void Menu_MouseLeave(object sender, EventArgs e)
        {
            Menu.Height -= 5;
            Menu.Width -= 3;
        }

        private void Kladovishe_MouseEnter(object sender, EventArgs e)
        {
            Kladovishe.Width += 2;
            Kladovishe.Height += 2;
        }

        private void Kladovishe_MouseLeave(object sender, EventArgs e)
        {
            Kladovishe.Width -= 2;
            Kladovishe.Height -= 2;
        }

        private void Mariinskiy_park_MouseEnter(object sender, EventArgs e)
        {
            Mariinskiy_park.Width += 2;
            Mariinskiy_park.Height += 2;
        }

        private void Mariinskiy_park_MouseLeave(object sender, EventArgs e)
        {
            Mariinskiy_park.Width -= 2;
            Mariinskiy_park.Height -= 2;
        }

        private void Frometivkya_MouseEnter(object sender, EventArgs e)
        {
            Frometivkya.Width += 2;
            Frometivkya.Height += 2;
        }

        private void Frometivkya_MouseLeave(object sender, EventArgs e)
        {
            Frometivkya.Width -= 2;
            Frometivkya.Height -= 2;
        }
        private void Strilecka_MouseEnter(object sender, EventArgs e)
        {
            Strilecka.Width += 2;
            Strilecka.Height += 2;
        }

        private void Strilecka_MouseLeave(object sender, EventArgs e)
        {
            Strilecka.Width -= 2;
            Strilecka.Height -= 2;
        }

        private void Saksaganska_MouseEnter(object sender, EventArgs e)
        {
            Saksaganska.Width += 2;
            Saksaganska.Height += 2;
        }

        private void Saksaganska_MouseLeave(object sender, EventArgs e)
        {
            Saksaganska.Width -= 2;
            Saksaganska.Height -= 2;
        }

        private void pictureBox7_MouseEnter(object sender, EventArgs e)
        {
            Luck.Width += 2;
            Luck.Height += 2;
        }

        private void pictureBox7_MouseLeave(object sender, EventArgs e)
        {
            Luck.Width -= 2;
            Luck.Height -= 2;
        }
        private void Lviv_MouseEnter(object sender, EventArgs e)
        {
            Lviv.Width += 2;
            Lviv.Height += 2;
        }

        private void Lviv_MouseLeave(object sender, EventArgs e)
        {
            Lviv.Width -= 2;
            Lviv.Height -= 2;
        }
        private void Novgorod_MouseEnter(object sender, EventArgs e)
        {
            Novgorod.Width += 2;
            Novgorod.Height += 2;
        }

        private void Novgorod_MouseLeave(object sender, EventArgs e)
        {
            Novgorod.Width -= 2;
            Novgorod.Height -= 2;
        }
        private void Rava_MouseEnter(object sender, EventArgs e)
        {
            Rava.Width += 2;
            Rava.Height += 2;
        }

        private void Rava_MouseLeave(object sender, EventArgs e)
        {
            Rava.Width -= 2;
            Rava.Height -= 2;
        }
        private void pictureBox2_MouseEnter(object sender, EventArgs e)
        {
            Kovel.Width += 2;
            Kovel.Height += 2;
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            Kovel.Width -= 2;
            Kovel.Height -= 2;
        } 
        private void Saki_MouseEnter(object sender, EventArgs e)
        {
            Saki.Width += 2;
            Saki.Height += 2;
        }

        private void Saki_MouseLeave(object sender, EventArgs e)
        {
            Saki.Width -= 2;
            Saki.Height -= 2;
        }
        private void Yalta_MouseEnter(object sender, EventArgs e)
        {
            Yalta.Width += 2;
            Yalta.Height += 2;
        }

        private void Yalta_MouseLeave(object sender, EventArgs e)
        {
            Yalta.Width -= 2;
            Yalta.Height -= 2;
        }
        private void Gurzuf_MouseEnter(object sender, EventArgs e)
        {
            Gurzuf.Width += 2;
            Gurzuf.Height += 2;
        }
        private void Gurzuf_MouseLeave(object sender, EventArgs e)
        {
            Gurzuf.Width -= 2;
            Gurzuf.Height -= 2;
        }
        private void Gadyach_MouseEnter(object sender, EventArgs e)
        {
            Gadyach.Width += 2;
            Gadyach.Height += 2;
        }

        private void Gadyach_MouseLeave(object sender, EventArgs e)
        {
            Gadyach.Width -= 2;
            Gadyach.Height -= 2;
        }
        private void Polonne_MouseEnter(object sender, EventArgs e)
        {
            Polonne.Width += 2;
            Polonne.Height += 2;
        }

        private void Polonne_MouseLeave(object sender, EventArgs e)
        {
            Polonne.Width -= 2;
            Polonne.Height -= 2;
        }
        private void Kolodyazhne_MouseEnter(object sender, EventArgs e)
        {
            Kolodyazhne.Width += 2;
            Kolodyazhne.Height += 2;
        }

        private void Kolodyazhne_MouseLeave(object sender, EventArgs e)
        {
            Kolodyazhne.Width -= 2;
            Kolodyazhne.Height -= 2;
        }
        private void Kladovishe_Click(object sender, EventArgs e)
        {
            Form imgFrm = new Form();
            imgFrm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            imgFrm.MaximizeBox = false;
            imgFrm.MinimizeBox = false;
            imgFrm.Width = Kladovishe_.Image.Width;
            imgFrm.Height = Kladovishe_.Image.Height;
            imgFrm.BackgroundImage = Kladovishe_.Image;
            imgFrm.StartPosition = FormStartPosition.CenterScreen;
            imgFrm.Text = "Байкове кладовище";
            imgFrm.Show();
        }
        
        private void Mariinskiy_park_Click(object sender, EventArgs e)
        {
            Form imgFrm = new Form();
            imgFrm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            imgFrm.MaximizeBox = false;
            imgFrm.MinimizeBox = false;
            imgFrm.Width = Mariinskiy_park_.Image.Width;
            imgFrm.Height = Mariinskiy_park_.Image.Height;
            imgFrm.BackgroundImage = Mariinskiy_park_.Image;
            imgFrm.StartPosition = FormStartPosition.CenterScreen;
            imgFrm.Text = "Маріїнський парк";
            imgFrm.Show();
        }

        private void Frometivkya_Click(object sender, EventArgs e)
        {
            Form imgFrm = new Form();
            imgFrm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            imgFrm.MaximizeBox = false;
            imgFrm.MinimizeBox = false;
            imgFrm.Width = Frometivkya_.Image.Width;
            imgFrm.Height = Frometivkya_.Image.Height;
            imgFrm.BackgroundImage = Frometivkya_.Image;
            imgFrm.StartPosition = FormStartPosition.CenterScreen;
            imgFrm.Text = "Вулиця Фрометівська";
            imgFrm.Show();
        }

        private void Strilecka_Click(object sender, EventArgs e)
        {
            Form imgFrm = new Form();
            imgFrm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            imgFrm.MaximizeBox = false;
            imgFrm.MinimizeBox = false;
            imgFrm.Width = Strilecka_.Image.Width;
            imgFrm.Height = Strilecka_.Image.Height;
            imgFrm.BackgroundImage = Strilecka_.Image;
            imgFrm.StartPosition = FormStartPosition.CenterScreen;
            imgFrm.Text = "Вулиця Стрілецька";
            imgFrm.Show();
        }

        private void Saksaganska_Click(object sender, EventArgs e)
        {
            Form imgFrm = new Form();
            imgFrm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            imgFrm.MaximizeBox = false;
            imgFrm.MinimizeBox = false;
            imgFrm.Width = Saksaganska_.Image.Width;
            imgFrm.Height = Saksaganska_.Image.Height;
            imgFrm.BackgroundImage = Saksaganska_.Image;
            imgFrm.StartPosition = FormStartPosition.CenterScreen;
            imgFrm.Text = "Вулиця Саксаганська";
            imgFrm.Show();
        }

        private void Luck_Click(object sender, EventArgs e)
        {
            Form imgFrm = new Form();
            imgFrm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            imgFrm.MaximizeBox = false;
            imgFrm.MinimizeBox = false;
            imgFrm.Width = Luck_.Image.Width;
            imgFrm.Height = Luck_.Image.Height;
            imgFrm.BackgroundImage = Luck_.Image;
            imgFrm.StartPosition = FormStartPosition.CenterScreen;
            imgFrm.Text = "Луцьк";
            imgFrm.Show();
        }

        private void Lviv_Click(object sender, EventArgs e)
        {
            Form imgFrm = new Form();
            imgFrm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            imgFrm.MaximizeBox = false;
            imgFrm.MinimizeBox = false;
            imgFrm.Width = Lviv_.Image.Width;
            imgFrm.Height = Lviv_.Image.Height;
            imgFrm.BackgroundImage = Lviv_.Image;
            imgFrm.StartPosition = FormStartPosition.CenterScreen;
            imgFrm.Text = "Львів";
            imgFrm.Show();
        }

        private void Novgorod_Click(object sender, EventArgs e)
        {
            Form imgFrm = new Form();
            imgFrm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            imgFrm.MaximizeBox = false;
            imgFrm.MinimizeBox = false;
            imgFrm.Width = Novgorod_.Image.Width;
            imgFrm.Height = Novgorod_.Image.Height;
            imgFrm.BackgroundImage = Novgorod_.Image;
            imgFrm.StartPosition = FormStartPosition.CenterScreen;
            imgFrm.Text = "Новгород-Волинський";
            imgFrm.Show();
        }

        private void Rava_Click(object sender, EventArgs e)
        {
            Form imgFrm = new Form();
            imgFrm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            imgFrm.MaximizeBox = false;
            imgFrm.MinimizeBox = false;
            imgFrm.Width = Rava_.Image.Width;
            imgFrm.Height = Rava_.Image.Height;
            imgFrm.BackgroundImage = Rava_.Image;
            imgFrm.StartPosition = FormStartPosition.CenterScreen;
            imgFrm.Text = "Рава Руська";
            imgFrm.Show();
        }

        private void Kovel_Click(object sender, EventArgs e)
        {
            Form imgFrm = new Form();
            imgFrm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            imgFrm.MaximizeBox = false;
            imgFrm.MinimizeBox = false;
            imgFrm.Width = Kovel_.Image.Width;
            imgFrm.Height = Kovel_.Image.Height;
            imgFrm.BackgroundImage = Kovel_.Image;
            imgFrm.StartPosition = FormStartPosition.CenterScreen;
            imgFrm.Text = "Ковель";
            imgFrm.Show();
        }

        private void Saki_Click(object sender, EventArgs e)
        {
            Form imgFrm = new Form();
            imgFrm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            imgFrm.MaximizeBox = false;
            imgFrm.MinimizeBox = false;
            imgFrm.Width = Saki_.Image.Width;
            imgFrm.Height = Saki_.Image.Height;
            imgFrm.BackgroundImage = Saki_.Image;
            imgFrm.StartPosition = FormStartPosition.CenterScreen;
            imgFrm.Text = "Саки";
            imgFrm.Show();
        }

        private void Yalta_Click(object sender, EventArgs e)
        {
            Form imgFrm = new Form();
            imgFrm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            imgFrm.MaximizeBox = false;
            imgFrm.MinimizeBox = false;
            imgFrm.Width = Yalta_.Image.Width;
            imgFrm.Height = Yalta_.Image.Height;
            imgFrm.BackgroundImage = Yalta_.Image;
            imgFrm.StartPosition = FormStartPosition.CenterScreen;
            imgFrm.Text = "Ялта";
            imgFrm.Show();
        }

        private void Gurzuf_Click(object sender, EventArgs e)
        {
            Form imgFrm = new Form();
            imgFrm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            imgFrm.MaximizeBox = false;
            imgFrm.MinimizeBox = false;
            imgFrm.Width = Gurzuf_.Image.Width;
            imgFrm.Height = Gurzuf_.Image.Height;
            imgFrm.BackgroundImage = Gurzuf_.Image;
            imgFrm.StartPosition = FormStartPosition.CenterScreen;
            imgFrm.Text = "Гурзуф";
            imgFrm.Show();
        }

        private void Gadyach_Click(object sender, EventArgs e)
        {
            Form imgFrm = new Form();
            imgFrm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            imgFrm.MaximizeBox = false;
            imgFrm.MinimizeBox = false;
            imgFrm.Width = Gadyach_.Image.Width;
            imgFrm.Height = Gadyach_.Image.Height;
            imgFrm.BackgroundImage = Gadyach_.Image;
            imgFrm.StartPosition = FormStartPosition.CenterScreen;
            imgFrm.Text = "Гадяч";
            imgFrm.Show();
        }

        private void Polonne_Click(object sender, EventArgs e)
        {
            Form imgFrm = new Form();
            imgFrm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            imgFrm.MaximizeBox = false;
            imgFrm.MinimizeBox = false;
            imgFrm.Width = Polonne_.Image.Width;
            imgFrm.Height = Polonne_.Image.Height;
            imgFrm.BackgroundImage = Polonne_.Image;
            imgFrm.StartPosition = FormStartPosition.CenterScreen;
            imgFrm.Text = "Містечко Полонне";
            imgFrm.Show();
        }

        private void Kolodyazhne_Click(object sender, EventArgs e)
        {
            Form imgFrm = new Form();
            imgFrm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            imgFrm.MaximizeBox = false;
            imgFrm.MinimizeBox = false;
            imgFrm.Width = Kolodyazhne_.Image.Width;
            imgFrm.Height = Kolodyazhne_.Image.Height;
            imgFrm.BackgroundImage = Kolodyazhne_.Image;
            imgFrm.StartPosition = FormStartPosition.CenterScreen;
            imgFrm.Text = "Село Колодяжне";
            imgFrm.Show();
        }

       

       

       

        



      

       

       

        

       

        

        

       

    }
}
