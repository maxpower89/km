using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using km.client;

namespace km
{
    public partial class Login : Form
    {
        // Connectie database
        KmConnection con = new KmConnection("http://localhost/km/");
        public Login()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if (con.auth(userName.Text, password.Text))
            {
                MessageBox.Show("gelukt");
                KmUser user = new KmUser(con, 1);
                //textBox3.Text = user.email;
                //textBox4.Text = user.fullName;
            }
            else
            {
                MessageBox.Show("mislukt");
            }
        }
    }
}
