using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week_9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void UsernameTextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            Debug.WriteLine("Username: "+UsernameTextbox.Text);
            Debug.WriteLine("Password: "+PasswordTextbox.Text);
            this._clearForm();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void _clearForm()
        {
            UsernameTextbox.Clear();
            PasswordTextbox.Clear();
        }

        private void UsernameTextbox_Leave(object sender, EventArgs e)
        {
            if (UsernameTextbox.TextLength < 6)
            {
                LoginMessage.Text = "Username too short";
                LoginMessage.ForeColor = Color.Red;
            }
            else
            {
                LoginMessage.Text = "Please login";
                LoginMessage.ForeColor = Color.Black;
            }
        }

        private void PasswordTextbox_Leave(object sender, EventArgs e)
        {
            if (PasswordTextbox.TextLength < 6)
            {
                LoginMessage.Text = "Password too short";
                LoginMessage.ForeColor = Color.Red;
            }
            else
            {
                LoginMessage.Text = "Please login";
                LoginMessage.ForeColor = Color.Black;
            }
        }
    }
}
