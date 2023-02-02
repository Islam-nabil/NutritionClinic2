using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NutritionClinic1
{
    public partial class SignUp : Form
    {
        SqlCommand cmd = new SqlCommand();
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-TPC7M5O;Initial Catalog=myclinic1;Trusted_Connection=True;");

        public SignUp()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "insert into Login(Name,PhoneNumber,Username,Password,UserType)values(@Name,@PhoneNumber,@Username,@Password,@UserType)";
            cmd = new SqlCommand(query, con);


            cmd.Parameters.AddWithValue("Name", textBox1.Text);
            cmd.Parameters.AddWithValue("PhoneNumber", textBox2.Text);
            cmd.Parameters.AddWithValue("UserType", comboBox1.SelectedItem);
            cmd.Parameters.AddWithValue("Password", textBox4.Text);
            cmd.Parameters.AddWithValue("Username", textBox5.Text);


            

            cmd.ExecuteNonQuery();
            MessageBox.Show("Saved Successfuly");
            con.Close();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (textBox3.Text == textBox4.Text)
            {
                label8.ForeColor = Color.Green;
                label8.Text = "Correct Password";

            }
            else
            {
                label8.ForeColor = Color.Red;
                label8.Text = "Wrong Password";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Login f1 = new Login();
            f1.Show();
            this.Hide();
        }
    }
}
