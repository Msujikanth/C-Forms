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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string id;
            id = txt1.Text;
            string name;
            name = txt2.Text;
            string phone;
            phone = txt3.Text;

            if (!string.IsNullOrEmpty(id) && !string.IsNullOrEmpty(name) && !string.IsNullOrEmpty(phone))
            {
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\C#\10020376\Spot-test\Database\Signup.mdf;Integrated Security=True;Connect Timeout=30");
                string qry = "INSERT INTO id (Idnumber,name,phonenum) VALUES ('" + id + "','" + name + "','" + phone + "')";
                SqlCommand cmd = new SqlCommand(qry, con);
                try
                {
                    con.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data inserted Successfully");
                }
                catch (SqlException se)
                {
                    MessageBox.Show("Error Inserting Data " + se);
                }
            }
            else
            {
                MessageBox.Show("Fill all fields");
            }
            txt1.Clear();
            txt2.Clear();
            txt3.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txt1.Clear();
            txt2.Clear();
            txt3.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Update fm = new Update();
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
