﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

/*=====================================================
 * Group Members:
 * Aditya Arole (aarole@purdue.edu)
 * Charushi Tibrewal (ctibrewa@purdue.edu)
 * Niket Panjwani (npanjwan@purdue.edu)
 * Resul Ucar (rucar@purdue.edu)
 * 
 * Program Description:
 * This program allows the user to enter their details and get their BMI and weight classification as output.
 * We have also included a login and register page that will save the new user's details in a file.
 * =====================================================*/
namespace FinalProject_Team19
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private const int cSize = 100;
        private string[] mFirst = new string[cSize];
        private string[] mLast = new string[cSize];
        private double[] mHeight = new double[cSize];
        private double[] mWeight = new double[cSize];
        private string[] mAge = new string[cSize];
        private double[] mBMI = new double[cSize];
        private string[] mClass = new string[cSize];
        private int mIndex = 0;
        private int mAgeCtr1 = 0; //<18
        private int mAgeCtr2 = 0; //18-40
        private int mAgeCtr3 = 0; //41-65
        private int mAgeCtr4 = 0; //>65
        private int mWeightCtr1 = 0; //<70
        private int mWeightCtr2 = 0; //70-120
        private int mWeightCtr3 = 0; //>120
        private string mFileName = Path.Combine(Application.StartupPath, "UserData.txt");

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearInput();
            lstOut.Items.Clear();
            txtFirst.Focus();
        }

        private void DisplayMessage(string msg)
        {
            MessageBox.Show(msg, Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }

        private bool ValidateInput()
        {
            string first = txtFirst.Text;
            string last = txtLast.Text;
            double height;
            double weight;

            if(first=="")
            {
                DisplayMessage("Please enter your first name.");
                txtFirst.Focus();
                return false;
            }

            if(last=="")
            {
                DisplayMessage("Please enter your last name.");
                txtLast.Focus();
                return false;
            }

            if(double.TryParse(txtHeight1.Text, out height)==false)
            {
                DisplayMessage("Please enter a real number in height.");
                txtHeight1.Focus();
                return false;
            }

            if(double.TryParse(txtWeight.Text, out weight)==false)
            {
                DisplayMessage("Please enter a real number in weight.");
                txtWeight.Focus();
                return false;
            }

            if(height <= 0)
            {
                DisplayMessage("Please enter a height greater than 0.");
                txtHeight1.Focus();
                return false;
            }

            if(weight <= 0)
            {
                DisplayMessage("Please enter a weight greater than 0.");
                txtWeight.Focus();
                return false;
            }

            if(cboAge.SelectedIndex == -1)
            {
                DisplayMessage("Please select your age category.");
                return false;
            }

            if (radM.Checked == false && radS.Checked == false)
            {
                DisplayMessage("Please select a unit.");
                return false;
            }

            return true;
        }

        private void ClearInput()
        {
            txtFirst.Clear();
            txtLast.Clear();
            txtHeight1.Clear();
            txtHeight2.Clear();
            txtWeight.Clear();
            txtSearch.Clear();
            cboAge.SelectedIndex = -1;
            radM.Checked = false;
            radS.Checked = false;
            radFirst.Checked = false;
            radLast.Checked = false;
            lblW1.Text = "";
            lblHeight1.Text = "";
            txtHeight2.Visible = false;
            lblIN.Visible = false;
            txtFirst.Focus();
        }

        private void AgeStats()
        {
            if(cboAge.SelectedIndex == 0)
            {
                mAgeCtr1++;
            }

            else if (cboAge.SelectedIndex == 1)
            {
                mAgeCtr2++;
            }

            else if (cboAge.SelectedIndex == 2)
            {
                mAgeCtr3++;
            }

            else
            {
                mAgeCtr4++;
            }
        }

        private void WeightStats(double weight)
        {
            if(weight < 70)
            {
                mWeightCtr1++;
            }
            else if(weight < 120)
            {
                mWeightCtr2++;
            }
            else
            {
                mWeightCtr3++;
            }
        }

        private void CalculateBMI()
        {
            int ctr;

            for(ctr = 0; ctr < mIndex; ctr++)
            {
                mBMI[ctr] = mWeight[ctr] / Math.Pow(mHeight[ctr], 2);
                if(mBMI[ctr] > 25)
                {
                    mClass[ctr] = "Overweight";
                }
                else if(mBMI[ctr] > 18.5)
                {
                    mClass[ctr] = "Healthy";
                }
                else
                {
                    mClass[ctr] = "Underweight";
                }
            }

            return;
        }

       

        private void btnEnter_Click(object sender, EventArgs e)
        {
            lstOut.Items.Clear();

            if(ValidateInput() == false)
            {
                return;
            }

            string first = txtFirst.Text;
            string last = txtLast.Text;
            double height = double.Parse(txtHeight1.Text);
            double weight = double.Parse(txtWeight.Text);
            string age = cboAge.Text;

            mFirst[mIndex] = first;
            mLast[mIndex] = last;
            mAge[mIndex] = age;

            if(radS.Checked==true)
            {
                int ft = int.Parse(txtHeight1.Text);
                int inch = int.Parse(txtHeight2.Text);
                height = (ft / 3.281) + (inch / 39.37);
                weight /= 2.205;
            }

            WeightStats(weight);

            mWeight[mIndex] = weight;
            
            mHeight[mIndex] = height;
            mIndex++;

            AgeStats();

            ClearInput();

            txtFirst.Focus();

            if(mIndex == cSize)
            {
                DisplayMessage("The array is full.");
                btnEnter.Enabled = false;
            }
        }

        private void btnAStats_Click(object sender, EventArgs e)
        {
            lstOut.Items.Clear();

            lstOut.Items.Add("User classification on the basis of age:");
            lstOut.Items.Add("---------------------------------------------------------------------------");
            lstOut.Items.Add("< 18: ".PadRight(15) + mAgeCtr1.ToString());
            lstOut.Items.Add("18 - 40: ".PadRight(15) + mAgeCtr2.ToString());
            lstOut.Items.Add("41 - 65: ".PadRight(15) + mAgeCtr3.ToString());
            lstOut.Items.Add("> 65: ".PadRight(15) + mAgeCtr4.ToString());
        }

        private void btnWStats_Click(object sender, EventArgs e)
        {
            lstOut.Items.Clear();

            lstOut.Items.Add("User classification on the basis of weight:");
            lstOut.Items.Add("---------------------------------------------------------------------------");
            lstOut.Items.Add("< 70: ".PadRight(15) + mWeightCtr1.ToString());
            lstOut.Items.Add("70 - 120: ".PadRight(15) + mWeightCtr2.ToString());
            lstOut.Items.Add("> 120: ".PadRight(15) + mWeightCtr3.ToString());
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            lstOut.Items.Clear();

            lstOut.Items.Add("First Name".PadRight(15) + "Last Name".PadRight(15) + "Age".PadRight(15) + "Height(m)".PadRight(15) + "Weight(kg)");
            lstOut.Items.Add("---------------------------------------------------------------------------");

            int ctr;
            for (ctr = 0; ctr < mIndex; ctr++)
            {
                lstOut.Items.Add(mFirst[ctr].PadRight(15) + mLast[ctr].PadRight(15) + mAge[ctr].PadRight(15) + mHeight[ctr].ToString("n").PadRight(15) + mWeight[ctr].ToString("n"));
            }
        }

        private void btnBMI_Click(object sender, EventArgs e)
        {
            lstOut.Items.Clear();

            lstOut.Items.Add("First Name".PadRight(15) + "Last Name".PadRight(15) + "BMI(kg/m^2)".PadRight(15) + "Classification");
            lstOut.Items.Add("---------------------------------------------------------------------------");

            CalculateBMI();

            int ctr;

            for(ctr = 0; ctr < mIndex; ctr++)
            {
                lstOut.Items.Add(mFirst[ctr].PadRight(15) + mLast[ctr].PadRight(15) + mBMI[ctr].ToString("n").PadRight(15) + mClass[ctr]);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            lstOut.Items.Clear();

            if (mIndex == 0)
            {
                DisplayMessage("The array is empty.");
                return;
            }

            if (radFirst.Checked == false && radLast.Checked == false)
            {
                DisplayMessage("Please select one search selection.");
                return;
            }

            if (txtSearch.Text == "")
            {
                DisplayMessage("Please enter something in the search box.");
                return;
            }

            string search = txtSearch.Text.ToUpper();

            bool flag1 = false;
            bool flag2 = false;

            int ctr;

            for (ctr = 0; ctr < mIndex; ctr++)
            {
                if (radFirst.Checked == true && search == mFirst[ctr].ToUpper())
                {
                    flag1 = true;
                    break;
                }

                if (radLast.Checked == true && search == mLast[ctr].ToUpper())
                {
                    flag2 = true;
                    break;
                }
            }

            if (flag1 == true)
            {
                lstOut.Items.Add("Discovered First Name: " + mFirst[ctr]);
                lstOut.Items.Add("First Name".PadRight(15) + "Last Name");
                lstOut.Items.Add("---------------------------------------------------------------------------");
                lstOut.Items.Add(mFirst[ctr].PadRight(15) + mLast[ctr]);
            }
            else if (flag2 == true)
            {
                lstOut.Items.Add("Discovered Last Name: " + mLast[ctr]);
                lstOut.Items.Add("First Name".PadRight(15) + "Last Name");
                lstOut.Items.Add("---------------------------------------------------------------------------");
                lstOut.Items.Add(mFirst[ctr].PadRight(15) + mLast[ctr]);
            }
            else
            {
                DisplayMessage("Search term not found.");
                return;
            }
        }

        private void lstOut_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index;
            if (lstOut.SelectedIndex >= 2)
            {
                index = lstOut.SelectedIndex - 2;
            }
            else
            {
                return;
            }
            txtFirst.Text = mFirst[index];
            txtLast.Text = mLast[index];
            txtHeight1.Text = mHeight[index].ToString("n");
            txtWeight.Text = mWeight[index].ToString("n");
            radM.Checked = true;
            if (mAge[index] == "< 18")
            {
                cboAge.SelectedIndex = 0;
            }
            else if (mAge[index] == "18 - 40")
            {
                cboAge.SelectedIndex = 1;
            }
            else if (mAge[index] == "41 - 65")
            {
                cboAge.SelectedIndex = 2;
            }
            else
            {
                cboAge.SelectedIndex = 3;
            }
        }

        private void radS_CheckedChanged(object sender, EventArgs e)
        {
            lblHeight1.Text = "ft";
            lblW1.Text = "lb";
            lblIN.Visible = true;
            txtHeight2.Visible = true;
        }

        private void radM_CheckedChanged(object sender, EventArgs e)
        {
            lblHeight1.Text = "m";
            lblW1.Text = "kg";
            lblIN.Visible = false;
            txtHeight2.Visible = false;
        }

        private void cboAge_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cboAge.SelectedIndex == 0 || cboAge.SelectedIndex == 3)
            {
                DisplayMessage("BMI calculation is not ideal for your age");
                return;
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            //Form_Load
            if(File.Exists(mFileName) == false)
            {
                return;
            }
            StreamReader SR = null;
            try
            {
                SR = new StreamReader(mFileName);
                while(SR.Peek() != -1)
                {
                    string line = SR.ReadLine();
                    string[] parts = line.Split('\t');
                    mFirst[mIndex] = parts[0];
                    mLast[mIndex] = parts[1];
                    mHeight[mIndex] = double.Parse(parts[2]);

                    mWeight[mIndex] = double.Parse(parts[3]);
                    if (mWeight[mIndex] < 70)
                    {
                        mWeightCtr1++;
                    }
                    else if (mWeight[mIndex] < 120)
                    {
                        mWeightCtr2++;
                    }
                    else
                    {
                        mWeightCtr3++;
                    }

                    mAge[mIndex] = parts[4];
                    if (mAge[mIndex] == "< 18")
                    {
                        mAgeCtr1++;
                    }

                    else if (mAge[mIndex] == "18 - 40")
                    {
                        mAgeCtr2++;
                    }

                    else if (mAge[mIndex] == "41 - 65")
                    {
                        mAgeCtr3++;
                    }

                    else
                    {
                        mAgeCtr4++;
                    }

                    mBMI[mIndex] = double.Parse(parts[5]);
                    mClass[mIndex] = parts[6];
                    mIndex++;
                }
            }
            catch(Exception ex)
            {
                DisplayMessage(ex.Message);
            }
            finally
            {
                if(SR != null)
                {
                    SR.Close();
                }
            }
        }

        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Form_Closing
            StreamWriter SW = null;
            if (MessageBox.Show("Do you want to exit?", Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
                txtFirst.Focus();
                return;
            }
            else
            {
                try
                {
                    SW = new StreamWriter(mFileName);
                    for (int ctr = 0; ctr < mIndex; ctr++)
                    {
                        SW.WriteLine(mFirst[ctr] + '\t' + mLast[ctr] + '\t' + mHeight[ctr] + '\t' + mWeight[ctr] + '\t' + mAge[ctr] + '\t' + mBMI[ctr].ToString("n") + '\t' + mClass[ctr]);
                    }
                }
                catch (Exception ex)
                {
                    DisplayMessage(ex.Message);
                }
                finally
                {
                    if (SW != null)
                    {
                        SW.Close();
                    }
                }
            }
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 f4 = new Form4();
            f4.ShowDialog();
            this.Show();
        }
    }
}
