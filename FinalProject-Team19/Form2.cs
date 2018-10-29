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


        private void btnSignUp_Click(object sender, EventArgs e)
        {
            if (ValidateInput()==false)
            {
                return;
            }

            string name = txtName.Text;
            string username = txtUserName.Text;
            string password = txtPassword.Text;

            mName[mIndex] = name;
            mUserName[mIndex] = username;
            mPassword[mIndex] = password;
            mIndex++;

            if(mIndex==cSize)
            {
                DisplayMessage("The array is full.");
                btnSignUp.Enabled = false;
            }

            this.Close();
            Form1 f1 = new Form1();
            f1.ShowDialog();
        }

        private void DisplayMessage(string msg)
        {
            MessageBox.Show(msg, Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
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
    }
}
