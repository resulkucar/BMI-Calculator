using System;
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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private const int cSize = 100;
        private string[] mUserName = new string[cSize];
        private string[] mPassword = new string[cSize];
        private string[] mName = new string[cSize];
        private int mIndex = 0;
        StreamWriter SW = null;
        private string mFileName = Path.Combine(Application.StartupPath, "User.txt");
        

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            if (ValidateInput()==false)
            {
                return;
            }
            if (ExistenceCheck() == false)
            {
                return;
            }

            string name = txtName.Text;
            string username = txtUserName.Text;
            string password = txtPassword.Text;
            mUserName[mIndex] = username;
            mPassword[mIndex] = password;
            mName[mIndex] = name;
            mIndex++;

            SW = new StreamWriter(mFileName, append: true);
            for (int i = 0; i < mIndex; i++)
            {
                SW.WriteLine(mUserName[i] + '\t' + mPassword[i] + '\t' + mName[i]);
            }
            SW.Close();

            if (mIndex==cSize)
            {
                DisplayMessage("The array is full.");
                btnSignUp.Enabled = false;
            }

            this.DialogResult = DialogResult.OK;
            
        }

        private void DisplayMessage(string msg)
        {
            MessageBox.Show(msg, Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }

        private bool ExistenceCheck()
        {
            Form1 f1 = new Form1();
            for (int i = 0; i < mIndex; i++)
            {
                if (txtUserName.Text == f1.mUserName[i])
                {
                    DisplayMessage("The username is already in use. Please try again with different username.");
                    return false;
                }

            }
            return true;
        }

        private bool ValidateInput()
        {
            string name = txtName.Text;
            string username = txtUserName.Text;
            string password = txtPassword.Text;

            if(name=="")
            {
                DisplayMessage("Please enter your name.");
                txtName.Focus();
                return false;
            }

            if(username=="")
            {
                DisplayMessage("Please enter a username.");
                txtUserName.Focus();
                return false;
            }

            if(password=="")
            {
                DisplayMessage("Please enter a password.");
                txtPassword.Focus();
                return false;
            }

            return true;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        /*private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }*/

        /*private void Form2_Load(object sender, EventArgs e)
        {
            SR = new StreamReader(mFileName);
            string line;
            string[] parts;
            try
            {
                while (SR.Peek() != -1)
                {
                    line = SR.ReadLine();
                    parts = line.Split('\t');
                    mUserName[mIndex] = parts[0];
                    mPassword[mIndex] = parts[1];
                    mIndex++;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                SR.Close();
            }
        }*/
    }
}
