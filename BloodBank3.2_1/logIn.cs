using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BloodBank3._2_1
{
    public partial class logIn : Form
    {
        public logIn()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            connection con = new connection();
            bool b = con.varifyAdmin(txtUserName.Text, txtPass.Text);            
            if (b)
            {
                MessageBox.Show("Logged In!");
                this.Hide();
                mainForm mf = new mainForm();
                mf.Show();
            }
            clearText();           
        }

        private void clearText()
        {
            txtUserName.Text = "";
            txtPass.Text = "";
        }
    }
}
