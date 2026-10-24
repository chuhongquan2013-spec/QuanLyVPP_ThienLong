using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChuDucthuy_2024611075.GUI
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void bánHàngPOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPOS frmPOS = new FormPOS();
            frmPOS.Show();
        }
    }
}
