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
    public partial class Form9 : Form
    {
        int c = 0;
        int f = 0;
        public Form9()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form12 f12 = new Form12();
            f12.Show();
        }
        private void button3_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(local)\SQLEXPRESS;Initial Catalog=sis;Integrated Security=True;Pooling=False;");
            SqlDataAdapter sda = new SqlDataAdapter("Select count(*) from Student_info where st_id='" + textBox1.Text + "' and st_pass='" + textBox2.Text + "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                this.Hide();
                Form3 f3 = new Form3();
                f3.Show();
            }
            else
            {
                MessageBox.Show("Enter Student Id and Password Correctly :( if you won't registered please complete your registration through admin");
            }
        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {
            if (f == 0)
            {
                textBox2.Clear();
                f++;
            }
            else
            {
                textBox2.UseSystemPasswordChar = true;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox2.UseSystemPasswordChar = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (c == 0)
            {
                textBox1.Clear();
                c++;
            }
        }
    }
}
