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

namespace NutritionClinic1
{
    public partial class Form10 : Form

    {
        string f;
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
            try
            {
                comboBox2.Items.Clear();
                con.Open();
                String id = "SELECT Drug_Name FROM Drugs ORDER BY Drug_Name";
                da = new SqlDataAdapter(id, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                con.Close();

                foreach (DataRow dr in dt.Rows)
                {
                    comboBox2.Items.Add(dr["Drug_Name"]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
            comboBox2.ResetText();


            


        }


        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                f = radioButton1.Text;
            }
            else if (radioButton2.Checked == true)
            {
                f = radioButton2.Text;
            }
            else if (radioButton3.Checked == true)
            {
                f = radioButton3.Text;
            }
            else if (radioButton4.Checked == true)
            {
                f = radioButton4.Text;
            }
            else
            {
                f = "";
                MessageBox.Show("Missing frequncey");
            }

            

            string query = "Update Drugs(Drug_Name,Drug_Dose,Drug_Frequnecy,Drug_type)values(@Druge_Name,@Drug_Dose,@Drug_Frequnecy,@Drug_type)";
            SqlCommand cmd = new SqlCommand(query, con);
            
            //Pass values to Parameters
            cmd.Parameters.AddWithValue("@Druge_Name",textBox1.Text);
            cmd.Parameters.AddWithValue(@"Drug_Dose", Dose.Value);
            cmd.Parameters.AddWithValue("@Drug_Frequnecy", f);
            cmd.Parameters.AddWithValue("@Druge_type", comboBox2.SelectedItem);

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Records Inserted Successfully");
            }
            catch (SqlException exx)
            {
                MessageBox.Show("Error Generated. Details: " + exx.ToString());
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
    }
}
