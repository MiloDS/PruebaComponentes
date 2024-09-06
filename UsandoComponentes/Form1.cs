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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnWeb_Click(object sender, EventArgs e)
        {
            frmWeb frmWeb = new frmWeb(); 
            this.Hide();
            frmWeb.ShowDialog();
        }

        private void btnWmp_Click(object sender, EventArgs e)
        {
            frmWmp frmWmp = new frmWmp();
            this.Hide();
            frmWmp.ShowDialog();
        }

        private void btnPdf_Click(object sender, EventArgs e)
        {
            frmPdf frmPdf = new frmPdf();
            this.Hide();
            frmPdf.ShowDialog();
        }
    }
}
