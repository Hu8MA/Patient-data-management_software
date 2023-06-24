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
namespace HIT
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection cn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\code\App_database\HIT\HIT\D2.mdf;Integrated Security=True");

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("insert into T2 values ('"+textBox1.Text+"','"+textBox2.Text+"',"+textBox3.Text+",'"+comboBox1.Text+"','"+textBox4.Text+"',"+textBox5.Text+")", cn);
            cmd.ExecuteNonQuery();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cn.Open();
            MessageBox.Show("The DB for IRQ is open ");

            comboBox1.Items.Add("Natural");
            
            comboBox1.Items.Add("Middle");


            comboBox1.Items.Add("Critical");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            cn.Close();
            MessageBox.Show("The DB for IRQ is close ");

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * from T2",cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            

                

            
        }

        private void button6_Click(object sender, EventArgs e)
        {
         
            SqlCommand cmd = new SqlCommand("select count(*)from T2",cn);

            int a = int.Parse(cmd.ExecuteScalar().ToString()); 

            MessageBox.Show(a.ToString()+"عدد الفاحصين");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("select count(*)from T2 where  Health_Status ='Critical' ", cn);

            int a = int.Parse(cmd.ExecuteScalar().ToString());
            MessageBox.Show(a.ToString() + "عددالاصابات الخطرة");

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
             
            SqlDataAdapter da = new SqlDataAdapter("Select * from T2 where pantintname = '" + textBox6.Text + "' ", cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            
            SqlDataAdapter da = new SqlDataAdapter("Select * from T2 where Home_Adress = '" + textBox7.Text + "' ", cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        { 
            SqlDataAdapter da = new SqlDataAdapter("Select * from T2 where  Health_Status = '" + textBox8.Text + "' ", cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
