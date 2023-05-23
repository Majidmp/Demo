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

namespace National_Address
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-9CB9E1C\\SQLTEST;Initial Catalog=nationaladdress;Integrated Security=True");
        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtcustomercode.Text == "" || txtclientdescription.Text == "" || txttrnnumber.Text == "" || txtbuildingnumber.Text == "" || txtpostalcode.Text == "" || txtstreetname.Text == "" || txtdistrictname.Text == "" || txtcityname.Text == "" || txtstreet.Text == "" || txtdistrict.Text == "" || txtcityname.Text == "" || txtstreet.Text == "" || txtdistrict.Text == "" || txtcityarabicname.Text == "" || txtclient.Text == "||")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    con.Open();
                    string query = "insert into customernationaladdress values('" + txtcustomercode.Text + "','" + txtclientdescription.Text + "','" + txttrnnumber.Text + "','" + txtcrnumber.Text + "','" + txtbuildingnumber.Text + "','" + txtpostalcode.Text + "','" + txtstreetname.Text + "','" + txtdistrictname.Text + "','" + txtcityname.Text + "',N'" + txtstreet.Text + "', N'" + txtdistrict.Text + "',N'" + txtcityarabicname.Text + "',N'" + txtclient.Text + "','" + dateTimePicker1.Value + "')";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    txtcustomercode.Text = "";
                    txtclientdescription.Text = "";
                   txttrnnumber.Text="";
                    txtcrnumber.Text = "";
                    txtbuildingnumber.Text = "";
                    txtpostalcode.Text = "";
                    txtstreetname.Text = "";
                    txtdistrictname.Text = "";
                    txtcityname.Text = "";
                    txtstreet.Text = "";
                    txtdistrict.Text = "";
                    txtcityarabicname.Text = "";
                    txtclient.Text="";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
    }
    
    
}
