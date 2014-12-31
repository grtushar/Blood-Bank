using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BloodBank3._2_1
{
    public partial class donorData : UserControl
    {
        public donorData()
        {
            InitializeComponent();            
        }

        private insertForm insf;
        private editForm edf;
        private deleteForm delf;

        public void getObj(insertForm insf, editForm edf, deleteForm delf)
        {
            this.insf = insf;
            this.edf = edf;
            this.delf = delf;
        }        

        private int pointer;

        public void getData(int i)
        {
            this.pointer = i;
            connection con = new connection();            
            DataSet ds = con.showData(pointer);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {            
            if (pointer == 1)
            {   
                int id = -1;
                if(Convert.ToInt32(e.RowIndex.ToString()) > -1) id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                if(id > -1) loadInfo(id);
            }
        }

        private void loadInfo(int id)
        {
            connection con = new connection();
            DataSet ds = con.getData(pointer, id);            
            if (edf.Visible == true) edf.loadData(ds.Tables[0].Rows[0][0].ToString(), ds.Tables[0].Rows[0][1].ToString(), ds.Tables[0].Rows[0][2].ToString(), ds.Tables[0].Rows[0][3].ToString(), ds.Tables[0].Rows[0][4].ToString(), ds.Tables[0].Rows[0][5].ToString(), ds.Tables[0].Rows[0][6].ToString(), ds.Tables[0].Rows[0][7].ToString(), ds.Tables[0].Rows[0][8].ToString());
            if (delf.Visible == true) delf.loadData(ds.Tables[0].Rows[0][0].ToString(), ds.Tables[0].Rows[0][1].ToString(), ds.Tables[0].Rows[0][2].ToString(), ds.Tables[0].Rows[0][3].ToString(), ds.Tables[0].Rows[0][4].ToString(), ds.Tables[0].Rows[0][5].ToString(), ds.Tables[0].Rows[0][6].ToString(), ds.Tables[0].Rows[0][7].ToString(), ds.Tables[0].Rows[0][8].ToString());
        }

    }
}
