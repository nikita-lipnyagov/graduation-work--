using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Квалификационная_работа
{
    public partial class frmTest2 : Form
    {
        public frmTest2()
        {
            InitializeComponent();
        }
        DataSet ds;
        DataView dv1, dv2;
        string nameXMLfile = "Baza2.xml";
        int currentRow = 0, columnsCount, columnsCount1;
        int[] arr;
        int c1 = 0;
        string email = "lesya_ukrainka2015@mail.ru";
        string password = "zxcvb060499";
        public string toEmail,Surname;
        public int Ocinka1;
        private void frmTest2_FormClosing(object sender, FormClosingEventArgs e)
        {      
            if (MessageBox.Show("Ви дійсно хочете вийти з тесту?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                frmTest frmTest = new frmTest();
                frmTest.Show();
            }
            else
                e.Cancel = true;
        }
       
        private void NextQuestion_MouseEnter(object sender, EventArgs e)
        {
            NextQuestion.Font = new Font("Comic Sans MS", 20);
            NextQuestion.ForeColor = Color.Blue;           
        }
        private void NextQuestion_MouseLeave(object sender, EventArgs e)
        {
            NextQuestion.Font = new Font("Comic Sans MS", 18);
            NextQuestion.ForeColor = Color.Black;
        }
        void LoadXmlFile()
        {
            ds = new DataSet();
            FileStream fsReadXml = new FileStream(nameXMLfile, FileMode.Open);
            ds.ReadXml(fsReadXml, XmlReadMode.InferTypedSchema);
            fsReadXml.Close();
            dv1 = new DataView(ds.Tables[0]);
            dataGridView1.DataSource = dv1;
            string s = dataGridView1.Rows[0].Cells[2].Value.ToString();
            dv2 = new DataView(ds.Tables[1]);
            dv2.RowFilter = "Код = '" + s + "'";
            dataGridView2.DataSource = dv2;
            currentRow = 0;

            arr = new int[dv1.Count];
            for (int i = 0; i < arr.Length; i++)
                arr[i] = i;
            Random rnd = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                int k1 = rnd.Next(0, arr.Length);
                int k2 = rnd.Next(0, arr.Length);
                int temp = arr[k1];
                arr[k1] = arr[k2];
                arr[k2] = temp;
            }
        }
        void Filllabel()
        {
            columnsCount = dv1.Table.Columns.Count;
            string[] slabel = new string[columnsCount];
            int i = arr[currentRow];
            for (int j = 0; j < columnsCount; j++)
                if (!dv1.Table.Rows[i].ItemArray[j].Equals(DBNull.Value))
                    slabel[j] = dv1.Table.Rows[i].ItemArray[j].ToString();
                else
                    slabel[j] = "";
            Vopros.Text = slabel[0];

            columnsCount1 = dv2.Table.Columns.Count;
            string[] slabel1 = new string[columnsCount1];
            for (int j = 0; j < columnsCount1; j++)
                if (!dv2.Table.Rows[i].ItemArray[j].Equals(DBNull.Value))
                    slabel1[j] = dv2.Table.Rows[i].ItemArray[j].ToString();
                else
                    slabel[j] = "";
            A.Text = slabel1[1];
            B.Text = slabel1[2];
            C.Text = slabel1[3];
            D.Text = slabel1[4];
            Nomervoprosa.Text = (currentRow + 1).ToString();
        }

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            string s;
            int i = e.RowIndex;
            if (i < dv1.Count)
            {
                s = dataGridView1.Rows[i].Cells[2].Value.ToString();
                dv2 = new DataView(ds.Tables[1]);
                dv2.RowFilter = "Код = '" + s + "'";
                dataGridView2.DataSource = dv2;
            }
        }

        private void frmTest2_Load(object sender, EventArgs e)
        {
            nameXMLfile = "Baza2.xml";
            LoadXmlFile();
            Filllabel();
           }

        public void NextQuestion_Click(object sender, EventArgs e)
        {
            int i = arr[currentRow];
            columnsCount = dv2.Table.Columns.Count;
            string[] slabel = new string[columnsCount];
            slabel[5] = dv2.Table.Rows[i].ItemArray[5].ToString();
            slabel[6] = dv2.Table.Rows[i].ItemArray[6].ToString();
            slabel[7] = dv2.Table.Rows[i].ItemArray[7].ToString();
            slabel[8] = dv2.Table.Rows[i].ItemArray[8].ToString();
            if (chA.Checked == true && chB.Checked == true)
            {
                c1 = c1 + Convert.ToInt32(slabel[5]) + Convert.ToInt32(slabel[6]);
               Ocinka.Text = c1.ToString();
            }
            if (chA.Checked == true && chC.Checked == true)
            {
                c1 = c1 + Convert.ToInt32(slabel[5]) + Convert.ToInt32(slabel[7]);
                Ocinka.Text = c1.ToString();
            }
            if (chA.Checked == true && chD.Checked == true)
            {
                c1 = c1 + Convert.ToInt32(slabel[5]) + Convert.ToInt32(slabel[8]);
                Ocinka.Text = c1.ToString();
            }
            if (chB.Checked == true && chC.Checked == true)
            {
                c1 = c1 + Convert.ToInt32(slabel[6]) + Convert.ToInt32(slabel[7]);
                Ocinka.Text = c1.ToString();
            }
            if (chB.Checked == true && chD.Checked == true)
            {
                c1 = c1 + Convert.ToInt32(slabel[6]) + Convert.ToInt32(slabel[8]);
                Ocinka.Text = c1.ToString();
            }
            if (chC.Checked == true && chD.Checked == true)
            {
                c1 = c1 + Convert.ToInt32(slabel[7]) + Convert.ToInt32(slabel[8]);
                Ocinka.Text = c1.ToString();
            }
            if (chA.Checked == true && chB.Checked == true && chC.Checked == false && chD.Checked == false || chA.Checked == true && chC.Checked == true && chB.Checked == false && chD.Checked == false || chA.Checked == true && chD.Checked == true && chB.Checked == false && chC.Checked == false || chB.Checked == true && chC.Checked == true && chA.Checked == false && chD.Checked == false || chB.Checked == true && chD.Checked == true && chA.Checked == false && chC.Checked == false || chC.Checked == true && chD.Checked == true && chA.Checked == false && chB.Checked == false)
            {
                currentRow++;
            }    
            else
            {
            MessageBox.Show("Оберіть дві відповіді!");
            }
            
            chA.Checked = false;
            chB.Checked = false;
            chC.Checked = false;
            chD.Checked = false;
            if (currentRow <= 5)
                Filllabel();
            else
            {
                Ocinka.Visible = true;
                lbl4.Visible = true;
                lbl5.Visible = true;
                sum.Visible = true;
                NextQuestion.Visible = false;
                Test.Enabled = false;      
                sum.Text = Math.Round(Convert.ToDecimal(c1 + Ocinka1) / 2, 0).ToString();
                int sum1 = Convert.ToInt32(sum.Text);
                string[] str = File.ReadAllLines(Application.StartupPath + "\\txt Файлы\\Учень.txt"); //читаем в массив
                if (str.Length!=0)
                {               
                toEmail = Convert.ToString(str[2]);
                StreamWriter SW = new StreamWriter(Application.StartupPath + "\\txt Файлы\\Учень.txt");
                SW.WriteLine(str[0]);
                SW.WriteLine(str[1]);
                SW.WriteLine(str[2]);
                SW.WriteLine("Ваша оцінка за пройдений тест: " + sum.Text);
                if (sum1<=3)
                {
                    SW.WriteLine("Оцінка є поганою, вам необхідно попрацювати над своїми помилками!");
                }
                if (sum1 > 3 && sum1<=6)
                {
                    SW.WriteLine("Звичайно краще ніж 2, але також незадовільно, зробіть роботу над помилками!");
                }
                if (sum1>=7&&sum1<=9)
                {
                    SW.WriteLine("Добре, але можна краще!");
                }
                if(sum1>=10)
                {
                    SW.WriteLine("Молодець, так тримати! Майбутній вчений!");
                }
                SW.Close();              
                    try
                    {
                        //Вказуємо SMTP сервер и авторизуємося.
                        SmtpClient Smtp_Client = new SmtpClient("smtp.mail.ru", 2525);
                        Smtp_Client.Credentials = new NetworkCredential(email, password);
                        //Виключаємо или включаємо SSL - (наприклад для гугла повинен бути включен).
                        Smtp_Client.EnableSsl = true;
                        //Формування самого листа
                        MailMessage Message = new MailMessage();
                        Message.From = new MailAddress(email);// от кого
                        Message.To.Add(new MailAddress(toEmail));// кому
                        Message.Subject = "Тест з української літератури.";
                        Message.Body = "Вам на пошту відправлено лист з вашими персональними даними: прізвище, ім'я, оцінка.";
                        //Прикріплення файлу для повідомлення.
                        string file = Application.StartupPath + "\\txt Файлы\\Учень.txt";
                        Attachment attach = new Attachment(file, MediaTypeNames.Application.Octet);
                        // Добавляємо інформацію для файлу
                        ContentDisposition disposition = attach.ContentDisposition;
                        disposition.CreationDate = System.IO.File.GetCreationTime(file);
                        disposition.ModificationDate = System.IO.File.GetLastWriteTime(file);
                        disposition.ReadDate = System.IO.File.GetLastAccessTime(file);

                        Message.Attachments.Add(attach);

                        Smtp_Client.Send(Message);// сама відправка...
                        MessageBox.Show("Вам на пошту відпралено лист!");
                    }
                    catch (Exception s)
                    {
                        MessageBox.Show(s.Message);
                    }
                }
                     
            }
        }

      

       

       

       

        

       
    }
}
