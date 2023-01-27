using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
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
        string m;
        string p;
        string f;
        string s;
        


        public NurseTab()
        {
            InitializeComponent();
            
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void rjButton1_Click(object sender, EventArgs e)

            
        {
            
            if (radioButton5.Checked == true)
            {
                f = textBox1.Text;
            }
            else
            {
                f = radioButton12.Text;
            }


           
            if(radioButton1.Checked==true)
            {
                p = radioButton1.Text;
            }
             else if (radioButton2.Checked == true)
            {
                p = radioButton2.Text;
            }
             else if (radioButton3.Checked == true)
            {
                p = radioButton3.Text;
            }
            else
            {
                p = radioButton4.Text;
            }

            if (radioButton6.Checked == true)
            {
                m = textBox6.Text;
            }
            else
            {
                m = radioButton20.Text;
            }

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
            if (radioButton13.Checked == true)
            {
                s = radioButton13.Text;
            }
            else
            {
                s = radioButton14.Text;
            }


            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-TPC7M5O;Initial Catalog=myclinic1;Integrated Security=True");
            //Replaced Parameters with Value
            string query = "insert into Patient(Patient_Name,Patient_Gender,Patient_Birth,Patient_NationalID,Patient_Address,Patient_Height,Patient_Weight, Patient_Chronic1, Patient_Chronic2,Patient_Chronic3,Patient_Chronic4,Patient_Med,Patient_pregnant,Supplements,Smoker,Foodallergies)values(@Patient_Name,@Patient_Gender,@Patient_Birth,@Patient_NationalID,@Patient_Address,@Patient_Height,@Patient_Weight, @Patient_Chronic1, @Patient_Chronic2,@Patient_Chronic3,@Patient_Chronic4,@Patient_Med,@Patient_pregnant,@Supplements,@Smoker,@Foodallergies)";
            SqlCommand cmd = new SqlCommand(query, con);

            //Pass values to Parameters
            cmd.Parameters.AddWithValue("@Patient_Name", TextboxNa.Text);
            cmd.Parameters.AddWithValue("@Patient_Gender", g);
            cmd.Parameters.AddWithValue("@Patient_Birth", dateTimePicker1.Value.Date.ToString("yyyyMMdd"));
            cmd.Parameters.AddWithValue("@Patient_NationalID", Nationalid.Text);
            cmd.Parameters.AddWithValue("@Patient_Address", Address.Text);
            cmd.Parameters.AddWithValue("@Patient_Height", HeightN.Text);
            cmd.Parameters.AddWithValue("@Patient_Weight", Weightn.Text);
            cmd.Parameters.AddWithValue("@Patient_Chronic1", n);
            cmd.Parameters.AddWithValue("@Patient_Chronic2", n2);
            cmd.Parameters.AddWithValue("@Patient_Chronic3", n3);
            cmd.Parameters.AddWithValue("@Patient_Chronic4", textBox3.Text);
            cmd.Parameters.AddWithValue("@Patient_Med", m);
            cmd.Parameters.AddWithValue("@Patient_pregnant", p);
            cmd.Parameters.AddWithValue("@Supplements", textBox2.Text);
            cmd.Parameters.AddWithValue("@Smoker", s);
            cmd.Parameters.AddWithValue("@Foodallergies", f);




            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                Console.WriteLine("Records Inserted Successfully");
            }
            catch (SqlException exx)
            {
                Console.WriteLine("Error Generated. Details: " + exx.ToString());
            }
            finally
            {
                con.Close();
                Console.ReadKey();
            }
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

        private void radioButton12_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label34_Click(object sender, EventArgs e)
        {

        }

        private void rjButton2_Click(object sender, EventArgs e)
        {
            Application.Restart();
            Environment.Exit(0);

        }

        
    }
}
