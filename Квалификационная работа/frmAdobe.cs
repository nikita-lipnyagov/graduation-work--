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
    public partial class frmAdobe : Form
    {
        public frmAdobe()
        {
            InitializeComponent();
        }

        private void frmAdobe_Load(object sender, EventArgs e)
        {
            axAcroPDF1.LoadFile(Application.StartupPath + "\\Lisova Pisnya\\Lesya_Ukrayinka_Lisova_pisnya.pdf");
        }
    }
}
