using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject_Team19
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void DisplayMesssage(string msg)
        {
            MessageBox.Show(msg, Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }

        private void radWeight_CheckedChanged(object sender, EventArgs e)
        {
            lbl1.Visible = true;
            lbl2.Visible = true;
            txt1.Visible = true;
            txt2.Visible = true;
            lbl3.Visible = false;
            txt3.Visible = false;
            txt1.Focus();
            txt1.Clear();
            txt2.Clear();
            txt3.Clear();

            lbl1.Text = "kg = ";
            lbl2.Text = "lb = ";
        }

        private void radHeight_CheckedChanged(object sender, EventArgs e)
        {
            lbl1.Visible = true;
            lbl2.Visible = true;
            lbl3.Visible = true;
            txt1.Visible = true;
            txt2.Visible = true;
            txt3.Visible = true;
            txt1.Focus();
            txt1.Clear();
            txt2.Clear();
            txt3.Clear();

            lbl1.Text = "m = ";
            lbl2.Text = "ft = ";
            lbl3.Text = "in = ";
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {

            if (radHeight.Checked == true)
            {
                if (txt1.Text == "")
                {
                    DisplayMesssage("Please enter your height in metres.");
                    return;
                }
                double m = double.Parse(txt1.Text);
                double total_inch = m * 39.37;
                int ft = (int)total_inch / 12;
                int inch = (int)(total_inch - (ft * 12));
                txt2.Text = ft.ToString();
                txt3.Text = inch.ToString();

            }
            else if (radWeight.Checked == true)
            {
                if (txt1.Text == "")
                {
                    DisplayMesssage("Please enter your weight in kilograms.");
                    return;
                }
                double kg = double.Parse(txt1.Text);
                double lb = kg * 2.205;
                txt2.Text = lb.ToString("n");
            }
            else
            {
                MessageBox.Show("Please select a quantity.", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            radHeight.Checked = false;
            radWeight.Checked = false;
            txt1.Clear();
            txt2.Clear();
            txt3.Clear();

        }
    }
}
