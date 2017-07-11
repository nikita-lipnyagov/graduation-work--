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
    public partial class frmTest1 : Form
    {
        public frmTest1()
        {
            InitializeComponent();
        }
        DataSet ds;
        DataView dv1, dv2;
        public int c = 0;
        string nameXMLfile = "Baza1.xml";
        int currentRow = 0, columnsCount, columnsCount1;
        double koef;
        bool a = false;
        int[] arr;
        private void frmTest1_FormClosing(object sender, FormClosingEventArgs e)
        {
        if (a == false)
        {
            if (MessageBox.Show("Ви дійсно хочете вийти з тесту?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                frmTest frmTest = new frmTest();
                frmTest.Show();
            }
            else
                e.Cancel = true;
        }
        }            
           private void NextForm_MouseEnter(object sender, EventArgs e)
        {
            NextForm.Font = new Font("Comic Sans MS", 20);
            NextForm.ForeColor = Color.Blue;
        }

        private void NextForm_MouseLeave(object sender, EventArgs e)
        {
            NextForm.Font = new Font("Comic Sans MS", 18);
            NextForm.ForeColor = Color.Black;
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
            Vopros.Text = slabel[1];

            columnsCount1 = dv2.Table.Columns.Count;
            string[] slabel1 = new string[columnsCount1];
            for (int j = 0; j < columnsCount1; j++)
                if (!dv2.Table.Rows[i].ItemArray[j].Equals(DBNull.Value))
                    slabel1[j] = dv2.Table.Rows[i].ItemArray[j].ToString();
                else
                    slabel[j] = "";     
            A.Text = slabel1[1];
            B.Text = slabel1[2];
            C_.Text = slabel1[3];
            Nomervoprosa.Text = (currentRow+1).ToString();
        }
        void NextQuestion()
        {
            rbA.Checked = false;
            rbB.Checked = false;
            rbC.Checked = false;
            currentRow++;
            if (currentRow <= 19)
                Filllabel();
            else
            {
                int k = Convert.ToInt32(Bal.Text);
                koef = 1.667;              
                Ocinka.Text = Math.Round(Convert.ToDecimal(k / koef), 0).ToString();               
                Test.Enabled = false;
                NextForm.Visible = true;                                       
            }
        }
        private void frmTest1_Load(object sender, EventArgs e)
        {
            nameXMLfile = "Baza1.xml";
            LoadXmlFile();
            Filllabel();
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

        public void rbA_Click(object sender, EventArgs e)
        {
            int i = arr[currentRow];  
            columnsCount = dv2.Table.Columns.Count;
            string[] slabel = new string[columnsCount];
            slabel[4] = dv2.Table.Rows[i].ItemArray[4].ToString();
            c += Convert.ToInt32(slabel[4]);
            Bal.Text = c.ToString();
            NextQuestion();
        }

        public void rbB_Click(object sender, EventArgs e)
        {
            int i = arr[currentRow];  
            columnsCount = dv2.Table.Columns.Count;
            string[] slabel = new string[columnsCount];
            slabel[5] = dv2.Table.Rows[i].ItemArray[5].ToString();
            c += Convert.ToInt32(slabel[5]);
            Bal.Text = c.ToString();
            NextQuestion();
        }

        public void rbC_Click(object sender, EventArgs e)
        {
            int i = arr[currentRow];  
            columnsCount = dv2.Table.Columns.Count;
            string[] slabel = new string[columnsCount];
            slabel[6] = dv2.Table.Rows[i].ItemArray[6].ToString();
            c += Convert.ToInt32(slabel[6]);
            Bal.Text = c.ToString();          
            NextQuestion();
        }
        private void NextForm_Click(object sender, EventArgs e)
        {
            frmTest2 frmTest2 = new frmTest2();
            frmTest2.Ocinka1 = Convert.ToInt32(this.Ocinka.Text);
            frmTest2.ShowDialog();
            this.Hide();
            a = true;
        }

     

       

        

      
       

        

       

        

    
    }
}
