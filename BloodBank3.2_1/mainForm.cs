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
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
            insForm.getObj(donorData1);
            editForm1.getObj(donorData1);
            deleteForm1.getObj(donorData1);
            donorData1.getObj(insForm, editForm1, deleteForm1);
        }

        public void getData(int i)
        {
            donorData1.getData(i);
        }

        private void donButton_Click(object sender, EventArgs e)
        {            
            if (donPanel2.Visible == false)
            {
                donPanel2.Visible = true;
                this.strPanel1.Location = new System.Drawing.Point(12, 108);
                if (strPanel2.Visible == true) this.cliPanel1.Location = new System.Drawing.Point(12, 219);
                else this.cliPanel1.Location = new System.Drawing.Point(12,126);
            }
            else
            {               
                donPanel2.Visible = false;
                this.strPanel1.Location = new System.Drawing.Point(12, 35);
                if (strPanel2.Visible == true) this.cliPanel1.Location = new System.Drawing.Point(12,146);
                else this.cliPanel1.Location = new System.Drawing.Point(12,53);
            }
            getData(1);
        }        

        private void strButton_Click(object sender, EventArgs e)
        {
            if (strPanel2.Visible == true)
            {
                strPanel2.Visible = false;
                int x = strPanel1.Location.X;
                int y = strPanel1.Location.Y;
                this.cliPanel1.Location = new System.Drawing.Point(x, y+18);
            }
            else
            {
                strPanel2.Visible = true;
                int x = strPanel1.Location.X;
                int y = strPanel1.Location.Y;
                this.cliPanel1.Location = new System.Drawing.Point(x, y+111);
            }
            getData(2);
        }         

        private void cliButton_Click(object sender, EventArgs e)
        {
            if (cliPanel2.Visible == false)
                cliPanel2.Visible = true;
            else
                cliPanel2.Visible = false;
            getData(3);
        }

        private void newDonorButton_Click(object sender, EventArgs e)
        {
            editForm1.clearText();
            editForm1.disableEdit();
            editForm1.Visible = false;
            deleteForm1.clearText();
            deleteForm1.Visible = false;
            insForm.Visible = true;
        }

        private void editDonorButton_Click(object sender, EventArgs e)
        {
            insForm.clearText();
            insForm.Visible = false;
            deleteForm1.clearText();
            deleteForm1.Visible = false;
            editForm1.Visible = true;
        }

        private void deleteDonorButton_Click(object sender, EventArgs e)
        {
            insForm.clearText();
            insForm.Visible = false;
            editForm1.clearText();
            editForm1.disableEdit();
            editForm1.Visible = false;
            deleteForm1.Visible = true;
        }
    }
}
