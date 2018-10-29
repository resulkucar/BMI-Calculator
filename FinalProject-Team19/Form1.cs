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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.ShowDialog();
            this.Close();
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

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(ValidateInput()==false)
            {
                return;
            }

            int ctr;

            this.Hide();
            Form3 f3 = new Form3();
            f3.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
