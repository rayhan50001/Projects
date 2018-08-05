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
    public partial class Form4 : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(local)\SQLEXPRESS;Initial Catalog=sis;Integrated Security=True;Pooling=False;");
        public Form4()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into Student_info values ('"+textBox2.Text+"','"+textBox11.Text+"','"+textBox1.Text+"','"+textBox3.Text+"','"+textBox4.Text+"','"+textBox5.Text+"','"+textBox6.Text+"','"+textBox7.Text+"','"+textBox8.Text+"','"+textBox9.Text+"','"+textBox14.Text+"','"+textBox10.Text+"','"+textBox12.Text+"','" +textBox15.Text+"','" +textBox13.Text+"')";
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Student Information Inserted Succesfully");
        }
        private void button2_Click(object sender, EventArgs e)
        {
            textBox15.Text = comboBox1.SelectedItem.ToString();
        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {
            textBox15.Text = comboBox1.SelectedItem.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox14.Text = comboBox2.SelectedItem.ToString();
        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {
            textBox14.Text = comboBox2.SelectedItem.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox5.Text = comboBox3.SelectedItem.ToString() + "/" + comboBox4.SelectedItem.ToString() + "/" +comboBox5.SelectedItem.ToString();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            textBox5.Text = comboBox3.SelectedItem.ToString() + "/" + comboBox4.SelectedItem.ToString() + "/" + comboBox5.SelectedItem.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
            textBox9.Clear();
            textBox10.Clear();
            textBox11.Clear();
            textBox12.Clear();
            textBox13.Clear();
            textBox14.Clear();
            textBox15.Clear();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f2 = new Form2();
            f2.Show();
        }
    }
}
