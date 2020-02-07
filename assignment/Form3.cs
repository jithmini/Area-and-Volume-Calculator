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
    public partial class frmVol : Form
    {
        public frmVol()
        {
            InitializeComponent();
            lbl1.Visible = false;
            lbl2.Visible = false;
            lbl3.Visible = false;
            txt1.Visible = false;
            txt2.Visible = false;
            txt3.Visible = false;
            lblEquation.Visible = false;
            lblVolume.Visible = false;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMain main = new frmMain();
            main.ShowDialog();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                lbl1.Visible = true;
                txt1.Visible = true;
                lbl2.Visible = true;
                txt2.Visible = true;
                lbl3.Visible = true;
                txt3.Visible = true;
                txt1.Text = "";
                txt2.Text = "";
                txt3.Text = "";
                lblEquation.Visible = true;
                lblEquation.Text = "V = Length * Width * Height";
                lbl1.Text = "Length :";
                lbl2.Text = "Width :";
                lbl3.Text = "Height :";
                lblVolume.Visible = false;
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                lbl1.Visible = true;
                txt1.Visible = true;
                lbl2.Visible = true;
                txt2.Visible = true;
                lbl3.Visible = false;
                txt3.Visible = false;
                txt1.Text = "";
                txt2.Text = "";
                lblEquation.Visible = true;
                lblEquation.Text = "V = pi * (Radius)^2 * Height";
                lbl1.Text = "Radius :";
                lbl2.Text = "Height :";
                lblVolume.Visible = false;
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                lbl1.Visible = true;
                txt1.Visible = true;
                lbl2.Visible = true;
                txt2.Visible = true;
                lbl3.Visible = false;
                txt3.Visible = false;
                txt1.Text = "";
                txt2.Text = "";
                lblEquation.Visible = true;
                lblEquation.Text = "V = (1/3) * pi * (Radius)^2 * Height";
                lbl1.Text = "Radius :";
                lbl2.Text = "Height :";
                lblVolume.Visible = false;
            }
            
            else
            {

                lbl1.Visible = false;
                txt1.Visible = false;
                lbl2.Visible = true;
                txt2.Visible = true;
                lbl3.Visible = false;
                txt3.Visible = false;
                txt2.Text = "";
                lblEquation.Visible = true;
                lblEquation.Text = "V = (4/3) * pi * (Radius)^3";
                lbl2.Text = "Radius :";
                lblVolume.Visible = false;

            }
        }

        private void btnCal_Click(object sender, EventArgs e)
        {
            double vol, x, y, z;
            try
            {
                if (comboBox1.SelectedIndex == 0)
                {
                    x = Convert.ToDouble(txt1.Text);
                    y = Convert.ToDouble(txt2.Text);
                    z = Convert.ToDouble(txt3.Text);
                    vol = x * y * z;
                    lblVolume.Visible = true;
                    lblVolume.Text = Convert.ToString(vol);
                }
                else if (comboBox1.SelectedIndex == 1)
                {
                    x = Convert.ToDouble(txt1.Text);
                    y = Convert.ToDouble(txt2.Text);
                    vol = Math.PI * x * x * y;
                    lblVolume.Visible = true;
                    lblVolume.Text = Convert.ToString(vol);
                }

                else if (comboBox1.SelectedIndex == 2)
                {
                    x = Convert.ToDouble(txt1.Text);
                    y = Convert.ToDouble(txt2.Text);
                    vol = Math.PI * x * x * y / 3;
                    lblVolume.Visible = true;
                    lblVolume.Text = Convert.ToString(vol);
                }
                else
                {

                    y = Convert.ToDouble(txt2.Text);
                    vol = 4 * Math.PI * y * y * y;
                    lblVolume.Visible = true;
                    lblVolume.Text = Convert.ToString(vol);

                }
            }
            catch (Exception)
            {
                MessageBox.Show("Enter a valid input. Don't leave empty fields.");
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            comboBox1.SelectedItem = "";
            lbl1.Visible = false;
            lbl2.Visible = false;
            lbl3.Visible = false;
            lblVolume.Visible = false;
            txt1.Visible = false;
            txt2.Visible = false;
            txt3.Visible = false;
            lblEquation.Visible = false;
        }
    }
}
