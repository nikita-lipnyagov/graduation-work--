using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Квалификационная_работа
{
    public partial class frmRegistration : Form
    {
        bool isSaved = false;
        public frmRegistration()
        {
            InitializeComponent();
        }
        private void frmRegistration_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!isSaved)
            {
                if (MessageBox.Show("Усі ваші дані не зберігуться", "Ви дійсно хочете вийти з тесту?", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {
                    frmTest frmTest = new frmTest();
                    frmTest.Show();                  
                }
                else
                    e.Cancel = true;
            }
        }
  
        private void lSave_MouseEnter(object sender, EventArgs e)
        {
            lSave.Font = new Font("Comic Sans MS", 18);
            lSave.ForeColor = Color.Blue;
        }

        private void lSave_MouseLeave(object sender, EventArgs e)
        {
            lSave.Font = new Font("Comic Sans MS", 16);
            lSave.ForeColor = Color.Black;
        }

        private void lNext_MouseEnter(object sender, EventArgs e)
        {
            lNext.Font = new Font("Comic Sans MS", 18);
            lNext.ForeColor = Color.Blue;
        }

        private void lNext_MouseLeave(object sender, EventArgs e)
        {
            lNext.Font = new Font("Comic Sans MS", 16);
            lNext.ForeColor = Color.Black;
        }
        public static bool IsValidEmail(string strIn)
        {
            // Повертає true коли strIn написана у допустимому e-mail форматі.
            return Regex.IsMatch(strIn,
                   @"^(?("")("".+?""@)|(([0-9a-zA-Z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-zA-Z])@))" +
                   @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-zA-Z][-\w]*[0-9a-zA-Z]\.)+[a-zA-Z]{2,6}))$");
        }
        
        public void lSave_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "" || txtSurname.Text == "" || txtPochta.Text == "")
            {
                MessageBox.Show("Не усі поля заповнені!");
            }
            else
            {
                string s1 = Convert.ToString(txtName.Text);
                string s2 = Convert.ToString(txtSurname.Text);
                string s3 = Convert.ToString(txtPochta.Text);
                if (IsValidEmail(s3) == true)
                {
                    StreamWriter SW = new StreamWriter(Application.StartupPath + "\\txt Файлы\\Учень.txt");
                    SW.WriteLine(s2);
                    SW.WriteLine(s1);
                    SW.WriteLine(s3);
                    SW.Close();
                    lSave.Visible = false;
                }
                else
                {
                    MessageBox.Show("Перевіріть будь-ласка правильність вашої реєстрації");
                }
            }
        }
       
        public void lNext_Click(object sender, EventArgs e)
        {
            isSaved = true;
            frmTest1 frmTest1 = new frmTest1();
            frmTest1.Show();
            this.Hide();
            
        }    

        
   

       

      

  
    }
}
