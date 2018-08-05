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
    public partial class Form5 : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(local)\SQLEXPRESS;Initial Catalog=sis;Integrated Security=True;Pooling=False;");
        int c1 = 0;
        int c2 = 0;
        public Form5()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = comboBox1.SelectedItem.ToString();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.Text = comboBox1.SelectedItem.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text.ToString() == "Student Name")
                {
                    con.Open();
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "update Student_info set st_name='" + textBox3.Text + "' where st_id='" + textBox2.Text + "'";
                    cmd.ExecuteNonQuery();
                    try
                    {

                        MessageBox.Show("Data Successfully Updated.");
                    }
                    catch { MessageBox.Show("Error!"); }
                    con.Close();

                }
                else if (textBox1.Text.ToString() == "Student Password")
                {
                    con.Open();
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "update Student_info set st_pass='" + textBox3.Text + "' where st_id='" + textBox2.Text + "'";
                    cmd.ExecuteNonQuery();
                    try
                    {

                        MessageBox.Show("Data Successfully Updated.");
                    }
                    catch { MessageBox.Show("Error!"); }
                    con.Close();

                }
                else if (textBox1.Text.ToString() == "Fathers Name")
                {
                    con.Open();
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "update Student_info set F_name='" + textBox3.Text + "' where st_id='" + textBox2.Text + "'";
                    cmd.ExecuteNonQuery();
                    try
                    {

                        MessageBox.Show("Data Successfully Updated.");
                    }
                    catch { MessageBox.Show("Error!"); }
                    con.Close();

                }
                else if (textBox1.Text.ToString() == "Mothers Name")
                {
                    con.Open();
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "update Student_info set F_name='" + textBox3.Text + "' where st_id='" + textBox2.Text + "'";
                    cmd.ExecuteNonQuery();
                    try
                    {

                        MessageBox.Show("Data Successfully Updated.");
                    }
                    catch { MessageBox.Show("Error!"); }
                    con.Close();

                }
                else if (textBox1.Text.ToString() == "Date Of Birth")
                {
                    con.Open();
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "update Student_info set DOB='" + textBox3.Text + "' where st_id='" + textBox2.Text + "'";
                    cmd.ExecuteNonQuery();
                    try
                    {

                        MessageBox.Show("Data Successfully Updated.");
                    }
                    catch { MessageBox.Show("Error!"); }
                    con.Close();


                }
                else if (textBox1.Text.ToString() == "Nationality")
                {
                    con.Open();
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "update Student_info set Nationality='" + textBox3.Text + "' where st_id='" + textBox2.Text + "'";
                    cmd.ExecuteNonQuery();
                    try
                    {

                        MessageBox.Show("Data Successfully Updated.");
                    }
                    catch { MessageBox.Show("Error!"); }
                    con.Close();

                }
                else if (textBox1.Text.ToString() == "Religion")
                {
                    con.Open();
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "update Student_info set Religion='" + textBox3.Text + "' where st_id='" + textBox2.Text + "'";
                    cmd.ExecuteNonQuery();
                    try
                    {

                        MessageBox.Show("Data Successfully Updated.");
                    }
                    catch { MessageBox.Show("Error!"); }
                    con.Close();

                }
                else if (textBox1.Text.ToString() == "Gender")
                {
                    con.Open();
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "update Student_info set Gender='" + textBox3.Text + "' where st_id='" + textBox2.Text + "'";
                    cmd.ExecuteNonQuery();
                    try
                    {

                        MessageBox.Show("Data Successfully Updated.");
                    }
                    catch { MessageBox.Show("Error!"); }
                    con.Close();

                }
                else if (textBox1.Text.ToString() == "Mobile Number")
                {
                    con.Open();
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "update Student_info set Mobile_num='" + textBox3.Text + "' where st_id='" + textBox2.Text + "'";
                    cmd.ExecuteNonQuery();
                    try
                    {

                        MessageBox.Show("Data Successfully Updated.");
                    }
                    catch { MessageBox.Show("Error!"); }
                    con.Close();

                }
                else if (textBox1.Text.ToString() == "HSC Result")
                {
                    con.Open();
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "update Student_info set HSC_reslut='" + textBox3.Text + "' where st_id='" + textBox2.Text + "'";
                    cmd.ExecuteNonQuery();
                    try
                    {

                        MessageBox.Show("Data Successfully Updated.");
                    }
                    catch { MessageBox.Show("Error!"); }
                    con.Close();

                }
                else if (textBox1.Text.ToString() == "SSC Result")
                {
                    con.Open();
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "update Student_info set SSC_reslut='" + textBox3.Text + "' where st_id='" + textBox2.Text + "'";
                    cmd.ExecuteNonQuery();
                    try
                    {

                        MessageBox.Show("Data Successfully Updated.");
                    }
                    catch { MessageBox.Show("Error!"); }
                    con.Close();

                }
                else if (textBox1.Text.ToString() == "Address")
                {
                    con.Open();
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "update Student_info set Address='" + textBox3.Text + "' where st_id='" + textBox2.Text + "'";
                    cmd.ExecuteNonQuery();
                    try
                    {

                        MessageBox.Show("Data Successfully Updated.");
                    }
                    catch { MessageBox.Show("Error!"); }
                    con.Close();

                }
                else if (textBox1.Text.ToString() == "CGPA")
                {
                    con.Open();
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "update Student_info set cgpa='" + textBox3.Text + "' where st_id='" + textBox2.Text + "'";
                    cmd.ExecuteNonQuery();
                    try
                    {

                        MessageBox.Show("Data Successfully Updated.");
                    }
                    catch { MessageBox.Show("Error!"); }
                    con.Close();

                }
                textBox2.Clear();
                textBox1.Clear();
                textBox3.Clear();
            }
            catch
            {
                MessageBox.Show("Insert Id Correctly :(");
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form16 f16 = new Form16();
            f16.Show();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (c1 == 0)
            {
                textBox2.Clear();
                c1++;
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (c2 == 0)
            {
                textBox3.Clear();
                c2++;
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }
    }
}
