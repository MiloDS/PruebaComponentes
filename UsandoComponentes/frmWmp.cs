using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UsandoComponentes
{
    public partial class frmWmp : Form
    {
        public frmWmp()
        {
            InitializeComponent();
        }

        private void frmWmp_Load(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = Application.StartupPath + "\\Rick Astley - Never Gonna Give You Up (video oficial) __ Español.mp4";
        }

        private void frmWmp_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form1 form1 = new Form1(); 
            form1.Show();
            this.Dispose();
        }
    }
}
