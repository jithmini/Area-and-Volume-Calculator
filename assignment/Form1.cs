using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assignment
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnArea_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmArea area_form = new frmArea();
            area_form.ShowDialog();
        }

        private void btnVol_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmVol vol_form = new frmVol();
            vol_form.ShowDialog();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }
    }
}
