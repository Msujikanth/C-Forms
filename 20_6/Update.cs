using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace _20_6
{
    public partial class Update : Form
    {
        public Update()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string user = txt1.Text;
            string update = txt2.Text;
            string phone = textBox1.Text;
            //int phone = int.Parse(textBox1.Text);

            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\C#\10020376\Spot-test\Database\Signup.mdf;Integrated Security=True;Connect Timeout=30");
            string del = "UPDATE id SET name= '" + update + "' , phonenum = '" + phone + "' WHERE Idnumber = '" + user + "'";
            SqlCommand cmd = new SqlCommand(del, con);

            try
            {
                
                con.Open();
                int rowAlt= cmd.ExecuteNonQuery();
                MessageBox.Show("Data Deleted Successfully");
                
                
            }
            catch (SqlException se)
            {
                MessageBox.Show("Error Inserting Data :" + se);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 fm = new Form1();
            fm.Show();
            this.Hide();
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 fm = new Form1();
            fm.Show();
            this.Hide();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Delete fm = new Delete();
            fm.Show();
            this.Hide();
        }
    }
}
