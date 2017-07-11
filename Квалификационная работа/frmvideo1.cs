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
    public partial class frmvideo1 : Form
    {
        public frmvideo1()
        {
            InitializeComponent();
        }

        private void frmvideo1_Load(object sender, EventArgs e)
        {
            string path;
            path = Application.StartupPath + "\\video\\0.mp4";
            axWindowsMediaPlayer1.URL = path;
        }

        private void frmvideo1_FormClosed(object sender, FormClosedEventArgs e)
        {
            axWindowsMediaPlayer1.close();
        }

    }
}
