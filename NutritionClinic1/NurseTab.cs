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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;


namespace NutritionClinic1
{
    public partial class NurseTab : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source = DESKTOP - TPC7M5O; Initial Catalog = myclinic1; Integrated Security = True");
        SqlDataAdapter da = new SqlDataAdapter();
        SqlCommand cmd = new SqlCommand();
        string g;       
        string n = "";
        string n2 = "";
        string n3 = "";


        public NurseTab()
        {
            InitializeComponent();
            
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void rjButton1_Click(object sender, EventArgs e)

            
        {
           


            if(radioButtonM.Checked==true)
            {
                g = "Male";
            }
            else
            {
                g = "Female";
            }
            
            if (checkBox1.Checked == true)
            {
                n = "Heart diseases";
            }
            if (checkBox2.Checked == true)
            {
                n2 = "High Blood Pressure";
            }
            if (checkBox3.Checked == true)
            {
                n3 = "Diabetes";
            }


            SqlConnection con = new SqlConnection("Data Source=DESKTOP-TPC7M5O;Initial Catalog=myclinic1;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into Patient(Patient_Name,Patient_Gender,Patient_Birth,Patient_NationalID,Patient_Address,Patient_Height,Patient_Weight, Patient_Chronic1, Patient_Chronic2,Patient_Chronic3,Patient_Chronic4)values('"+ TextboxNa.Text+"','"+g+"','"+ dateTimePicker1.Value.Date.ToString("yyyyMMdd") + "' ,'"+Nationalid.Text+"','"+Address.Text+"','"+HeightN.Text+"','"+Weightn.Text+ "' , '" +n+ "','" +n2+ "','" +n3+ "','"+textBox3.Text+"')", con);
            //SqlCommand cnd = new SqlCommand("insert into Patient(Patient_Chronic1,Patient_Chronic2,Patient_Chronic3,Patient_Chronic4)values('" + n + "','" + n2 + "','" + n3 + "','" + textBox3.Text + "')", con);
            

            int i = cmd.ExecuteNonQuery();
            //cnd.ExecuteNonQuery();
            if (i != 0) 
            {
                MessageBox.Show("Saved");

            }
            else
            {
                MessageBox.Show("error");
            }
            con.Close();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click_1(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker1.CustomFormat = "dd/MM/yyyy";
        }

        private void dateTimePicker1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode== Keys.Back) {

                dateTimePicker1.CustomFormat = "";
            }
        }

        private void radioButton10_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkedListBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
