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
    public partial class frmDovidka : Form
    {
        public frmDovidka()
        {
            InitializeComponent();
        }

        private void frmDovidka_Load(object sender, EventArgs e)
        {
            webBrowser1.Navigate(Application.StartupPath + "\\frmHello\\0.htm");
        }

    }
}
