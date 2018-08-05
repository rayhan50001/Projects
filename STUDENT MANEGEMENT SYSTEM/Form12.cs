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
    public partial class Form12 : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(local)\SQLEXPRESS;Initial Catalog=sis;Integrated Security=True;Pooling=False;");
        public Form12()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select count(*) from student_info where st_id='" + textBox3.Text + "' and Secuirity_ques='" + textBox1.Text + "' and Secuirity_ques_ans='"+textBox2.Text+"'",con);
            DataTable dt = new DataTable();
            String n = textBox3.Text.ToString();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                this.Hide();
                Form13 f13 = new Form13(n);
                f13.Show();
            }
            else{ MessageBox.Show("Enter Your Id or Security Question or Answer Correclty :("); }
            con.Close();
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = comboBox1.SelectedItem.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.Text = comboBox1.SelectedItem.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form9 f9 = new Form9();
            f9.Show();
        }
    }
}
