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
    public partial class frmWeb : Form
    {
        public frmWeb()
        {
            InitializeComponent();
        }

        private void frmWeb_Load(object sender, EventArgs e)
        {
            wbbDuck.Navigate("https://duckduckgo.com");
        }

        private void frmWeb_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Dispose();
        }
    }
}
