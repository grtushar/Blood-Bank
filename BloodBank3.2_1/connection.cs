using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace BloodBank3._2_1
{
    class connection
    {
        public void insert(string name, string pro, string dob, string add, string em, string ph, string bg, string dod)
        {
            string conStr = "Data Source=.;Initial Catalog=bloodbank3.2_1;Integrated Security=True";
            SqlConnection con = new SqlConnection(conStr);
            con.Open();
            string comStr = "insert into donor_info values('" + name + "', '" + pro + "', '" + dob + "', '" + add + "', '" + em + "', '" + ph + "', '" + bg + "', '" + dod + "')";
            SqlCommand com = new SqlCommand(comStr, con);
            com.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Data Inserted");
        }

        public void update(int id, string name, string pro, string dob, string add, string em, string ph, string bg, string dod)
        {
            string conStr = "Data Source=.;Initial Catalog=bloodbank3.2_1;Integrated Security=True";
            SqlConnection con = new SqlConnection(conStr);
            con.Open();
            string comStr = "update donor_info set name = '" + name + "', pro = '" + pro + "', dob = '" + dob + "', addr = '" + add + "', email = '" + em + "', phone = '" + ph + "', bg = '" + bg + "', dod = '" + dod + "' where id = '"+id+"'";
            SqlCommand com = new SqlCommand(comStr, con);
            com.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Data Updated");
        }

        public void delete(int id)
        {
            string conStr = "Data Source=.;Initial Catalog=bloodbank3.2_1;Integrated Security=True";
            SqlConnection con = new SqlConnection(conStr);
            con.Open();
            string comStr = "Delete from donor_info where id = '"+id+"' ";
            SqlCommand com = new SqlCommand(comStr, con);
            com.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Data Deleted");
        }

        public DataSet showData(int i)
        {
            string conStr = "Data Source=.;Initial Catalog=bloodbank3.2_1;Integrated Security=True";
            SqlConnection con = new SqlConnection(conStr);
            con.Open();
            string comStr = null;
            if (i == 1) comStr = "select * from donor_info";
            if (i == 2) comStr = "select * from donor_info";
            if (i == 3) comStr = "select * from donor_info";
            SqlCommand com = new SqlCommand(comStr, con);
            DataSet ds = new DataSet();
            SqlDataAdapter sda = new SqlDataAdapter(com);
            sda.Fill(ds);
            con.Close();
            return ds;
        }

        public DataSet getData(int i, int id)
        {
            string conStr = "Data Source=.;Initial Catalog=bloodbank3.2_1;Integrated Security=True";
            SqlConnection con = new SqlConnection(conStr);
            con.Open();
            string comStr = null;
            if (i == 1) comStr = "select * from donor_info where id = '"+id+"'";
            if (i == 2) comStr = "select * from donor_info";
            if (i == 3) comStr = "select * from donor_info";
            SqlCommand com = new SqlCommand(comStr, con);
            DataSet ds = new DataSet();
            SqlDataAdapter sda = new SqlDataAdapter(com);
            sda.Fill(ds);
            con.Close();
            return ds;
        }

        public bool varifyAdmin(string un, string pass)
        {
            string conStr = "Data Source=.;Initial Catalog=bloodbank3.2_1;Integrated Security=True";
            SqlConnection con = new SqlConnection(conStr);
            con.Open();
            string comStr = "select * from admin_info where userName='" + un + "' and pass='" + pass + "'";
            SqlCommand com = new SqlCommand(comStr, con);
            SqlDataReader sdr = com.ExecuteReader();
            while (sdr.Read())
            {
                con.Close();
                return true;
            }
            MessageBox.Show("Invalid Username/Password");
            con.Close();
            return false;
        }
    }
}
