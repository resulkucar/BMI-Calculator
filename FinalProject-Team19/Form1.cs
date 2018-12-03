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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        
        private const int cSize = 100;
        public string[] mUserName = new string[cSize];
        private string[] mPassword = new string[cSize];
        private int mIndex = 0;
        StreamReader SR = null;
        private string mFileName = Path.Combine(Application.StartupPath, "User.txt");

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f2 = new Form2();
            f2.ShowDialog();
            this.Show();
           
        }

        private void DisplayMessage(string msg)
        {
            MessageBox.Show(msg, Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }

        private bool ValidateInput()
        {
            string username = txtUserName.Text;
            string password = txtPassword.Text;

            if (username == "")
            {
                DisplayMessage("Please enter a username.");
                txtUserName.Focus();
                return false;
            }

            if (password == "")
            {
                DisplayMessage("Please enter a password.");
                txtPassword.Focus();
                return false;
            }

            return true;
        }
        private bool CredentialCheck()
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

            bool flag = false;
            for (int i = 0; i < mIndex; i++)
            {
                if (txtUserName.Text == mUserName[i] && txtPassword.Text == mPassword[i])
                {
                    flag = true;
                    break;
                }
            }
            return flag;
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(ValidateInput()==false)
            {
                return;
            }
            if(CredentialCheck() == false)
            {
                DisplayMessage("Please check your credentials.");
                return;
            }
            this.Hide();
            Form3 f3 = new Form3();
            f3.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        /*private void Form1_Load(object sender, EventArgs e)
        {
            if(File.Exists(mFileName) == false)
            {
                File.Create(mFileName);
            }
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
