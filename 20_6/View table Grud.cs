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
    public partial class View_table_Grud : Form
    {
        public View_table_Grud()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string constring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\C#\10020376\Spot-test\Database\Signup.mdf;Integrated Security=True;Connect Timeout=30";
            string qry = "SELECT * FROM SignUP";

            SqlDataAdapter da = new SqlDataAdapter(qry, constring);
            DataSet ds = new DataSet();

            da.Fill(ds, "SignUP");
            dataGridView1.DataSource = ds.Tables["SignUP"];
        }
    }
}
