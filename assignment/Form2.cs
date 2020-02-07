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
    public partial class frmArea : Form
    {
        public frmArea()
        {
            InitializeComponent();
            lbl_1.Visible = false;
            lbl_2.Visible = false;
            txt1.Visible = false;
            txt2.Visible = false;
            lblEquation.Visible = false;
            lblArea.Visible = false;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbShape.SelectedIndex == 0)
            {
                lbl_2.Visible = true;
                txt2.Visible = true;
                lbl_1.Visible = false;
                txt1.Visible = false;
                lblEquation.Visible = true;
                lblEquation.Text = "A = Length * Length";
                lbl_2.Text = "Length :";
            }
            else if (cmbShape.SelectedIndex == 1)
            {
                lbl_1.Visible = true;
                txt1.Visible = true;
                lbl_2.Visible = true;
                txt2.Visible = true;
                lblEquation.Visible = true;
                lblEquation.Text = "A = Length * Width";
                lbl_1.Text = "Length :";
                lbl_2.Text = "Width :";
            }
            
            else if (cmbShape.SelectedIndex == 2)
            {
                lbl_1.Visible = true;
                txt1.Visible = true;
                lbl_2.Visible = true;
                txt2.Visible = true;
                lblEquation.Visible = true;
                lblEquation.Text = "A = (1/2)*Base * Altitude";
                lbl_1.Text = "Base :";
                lbl_2.Text = "Altitude :";
            }
            else
            {
                
                lbl_2.Visible = true;
                txt2.Visible = true;
                lbl_1.Visible = false;
                txt1.Visible = false;
                lblEquation.Visible = true;
                lblEquation.Text = "A = pi*Radius^2";
                lbl_2.Text = "Radius :";
               
            }

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMain main = new frmMain();
            main.ShowDialog();
            
        }

        private void frmArea_Load(object sender, EventArgs e)
        {
            
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            lbl_1.Visible = false;
            lbl_2.Visible = false;
            lblArea.Visible = false;
            txt1.Visible = false;
            txt2.Visible = false;
            lblEquation.Visible = false;
            cmbShape.SelectedItem="";

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double area, x, y;
            try { 

            if (cmbShape.SelectedIndex == 0)
            {
                x = Convert.ToDouble(txt2.Text);
                area = x * x;
                lblArea.Visible = true;
                lblArea.Text = Convert.ToString(area);
            }
            else if (cmbShape.SelectedIndex == 1)
            {
                x = Convert.ToDouble(txt1.Text);
                y = Convert.ToDouble(txt2.Text);
                area = x * y;
                lblArea.Visible = true;
                lblArea.Text = Convert.ToString(area);
            }

            else if (cmbShape.SelectedIndex == 2)
            {
                x = Convert.ToDouble(txt1.Text);
                y = Convert.ToDouble(txt2.Text);
                area = x * y / 2;
                lblArea.Visible = true;
                lblArea.Text = Convert.ToString(area);
            }
            else
            {

                y = Convert.ToDouble(txt2.Text);
                area = Math.PI * y * y;
                lblArea.Visible = true;
                lblArea.Text = Convert.ToString(area);

            }
        }
         catch (Exception)
            {
                MessageBox.Show("Enter a valid input. Don't leave empty fields.");
            }
}
    }
}
