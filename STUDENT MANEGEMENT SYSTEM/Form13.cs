using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace STUDENT_MANEGEMENT_SYSTEM
{
    public partial class Form13 : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(local)\SQLEXPRESS;Initial Catalog=sis;Integrated Security=True;Pooling=False;");
        String prev;
        public Form13(String s)
        {
            prev = s;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String now = textBox1.Text.ToString();
            if (prev == now)
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "update Student_info set st_pass='" + textBox2.Text + "' where st_id='" + textBox1.Text + "'";
                cmd.ExecuteNonQuery();
                try
                {

                    MessageBox.Show("Password Successfully Updated.");
                }
                catch
                {
                    MessageBox.Show("Enter Your Id Correctly");
                }
                con.Close();
            }
            else
            {
                MessageBox.Show("Your Previous Entered Id and Present Enter Id Doesn't Matched :) :D ");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form12 f12 = new Form12();
            f12.Show();
        }
    }
}
