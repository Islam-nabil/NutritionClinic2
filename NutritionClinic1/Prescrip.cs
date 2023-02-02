using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace NutritionClinic1
{
    public partial class Form10 : Form

    {
        
        String f;
        
        string t;
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-TPC7M5O;Initial Catalog=myclinic1;Trusted_Connection=True;");
        SqlDataAdapter da = new SqlDataAdapter();
        SqlCommand cmd = new SqlCommand();
        public Form10()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form10_Load(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand currentP = new SqlCommand("SELECT * from patient where active = 1;", con);
            SqlDataReader NIDreader = currentP.ExecuteReader();
            long NID = 0;
            
            while (NIDreader.Read())
            {

                NID = long.Parse(NIDreader["NID"].ToString());
                
            }
            NIDreader.Close();
            SqlCommand npres = new SqlCommand("insert into prescription(PNID, drugAmount,active, perDate) values(@PNID, 0, @active, @perDate);", con);
            npres.Parameters.Add("@PNID", NID);
            npres.Parameters.Add("@active", 1);

            npres.Parameters.Add("@perDate", DateTime.Now.Date.ToString("M/d/yyyy"));
            npres.ExecuteNonQuery();
            con.Close();

        }




        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void rjButton1_Click(object sender, EventArgs e)

        {
           
            f = "";

            if(radioButton1.Checked == true)
            {
                f = radioButton1.Text;
            }
             else if (radioButton2.Checked == true)
            {
                f= radioButton2.Text;
            }
            else if (radioButton3.Checked == true)
            {
                f=radioButton3.Text;
            }
            else
            {
                 f = radioButton4.Text;
            }

            
            con.Open();
            SqlCommand prescription = new SqlCommand("SELECT * from prescription where active = 1;", con);
            SqlDataReader presReader = prescription.ExecuteReader();
            int presID = 0;
            int drugAmount = 0;
            //string flag = "";
            while (presReader.Read())
            {
                presID = int.Parse(presReader["PNO"].ToString());
                drugAmount = int.Parse(presReader["drugAmount"].ToString());

            }
            presReader.Close();
            try
            {

               
                SqlCommand medication = new SqlCommand("insert into drugs(prsID, Drug_Name,Drug_dose, Drug_frequncy,Drug_Type) values(@prsID, @Drug_Name,  @Drug_dose, @Drug_frequncy, @Drug_Type);", con);
                medication.Parameters.Add("@prsID", presID);
                medication.Parameters.Add("Drug_Name", textBox1.Text);
                medication.Parameters.Add("@Drug_dose", int.Parse(Dose.Value.ToString()));
                medication.Parameters.Add("@Drug_frequncy", f);
                medication.Parameters.Add("@Drug_Type", comboBox2.SelectedItem.ToString());
                medication.ExecuteNonQuery();
                SqlCommand drugNum = new SqlCommand("UPDATE prescription set drugAmount = @drugAmount where active = 1;", con);
                drugNum.Parameters.Add("@drugAmount", drugAmount + 1);
                drugNum.ExecuteNonQuery();
                MessageBox.Show("Drug Added Successfully.");
                textBox1.Text = "";
               
                Dose.Value = 0;
                

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message + " values provided are not in a correct format or there are missing values");
            }




            con.Close();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void drug_IDComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Drugtype_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void rjButton2_Click(object sender, EventArgs e)
        {
            
        }
    }
}
