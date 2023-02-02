using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace NutritionClinic1
{
    public partial class DocView : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-TPC7M5O;Initial Catalog=myclinic1;Integrated Security=True");
        SqlDataAdapter da = new SqlDataAdapter();
        SqlCommand cmd = new SqlCommand();
        Image img;
        public DocView()
        {
            InitializeComponent();
        }

        private void DocView_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'myclinic1DataSet4.Patient' table. You can move, or remove it, as needed.
            this.patientTableAdapter.Fill(this.myclinic1DataSet4.Patient);
            // TODO: This line of code loads data into the 'myclinic1DataSet2.Drugs' table. You can move, or remove it, as needed.
            //this.drugsTableAdapter.Fill(this.myclinic1DataSet2.Drugs);
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT patient_Name,NId,aptdate FROM Patient order by aptdate" , con);
            DataSet ds = new DataSet();
            da.Fill(ds, "Patient");
            dataGridView1.DataSource = ds.Tables["Patient"].DefaultView;
            con.Close();

           /* try
            {
                comboBox1.Items.Clear();
                con.Open();
                String id = "SELECT Patient_ID FROM Patient ORDER BY Patient_ID";
                da = new SqlDataAdapter(id,con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                con.Close();

                foreach(DataRow dr in dt.Rows)
                {
                    comboBox1.Items.Add(dr["Patient_ID"]);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
            comboBox1.ResetText();
            textBox1.Clear();
            textBox3.Clear();
            //textBox2.Clear();
            textBox4.Clear();
            textBox8.Clear();

            try
            {
                comboBox4.Items.Clear();
                con.Open();
                String id = "SELECT Patient_ID FROM Patient ORDER BY Patient_ID";
                da = new SqlDataAdapter(id, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                con.Close();

                foreach (DataRow dr in dt.Rows)
                {
                    comboBox4.Items.Add(dr["Patient_ID"]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
            comboBox4.ResetText();
            textBox6.Clear();*/



        }


        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void rjButton3_Click(object sender, EventArgs e)
        {

        }

        private void guna2RadioButton23_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void guna2RadioButton22_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void guna2RadioButton19_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void guna2RadioButton20_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox12_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox15_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox14_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void guna2RadioButton21_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void guna2RadioButton18_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label34_Click(object sender, EventArgs e)
        {

        }

        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void guna2RadioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void guna2RadioButton5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void guna2RadioButton6_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void guna2RadioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void guna2RadioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void guna2RadioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void guna2ComboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void guna2ComboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void guna2ComboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void guna2ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void guna2RadioButton16_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label26_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void rjButton2_Click(object sender, EventArgs e)
        {

        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label33_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2ComboBox7_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label32_Click(object sender, EventArgs e)
        {

        }

        private void label30_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label29_Click(object sender, EventArgs e)
        {

        }

        private void label28_Click(object sender, EventArgs e)
        {

        }

        private void guna2RadioButton17_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label25_Click(object sender, EventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void label31_Click(object sender, EventArgs e)
        {

        }

        private void label24_Click(object sender, EventArgs e)
        {

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }

        private void label27_Click(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void guna2TabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void rjButton1_Click(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void guna2ComboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void guna2RadioButton13_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void guna2RadioButton14_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void guna2RadioButton15_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void guna2RadioButton10_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void guna2RadioButton11_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void guna2RadioButton12_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void guna2RadioButton7_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void guna2RadioButton8_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void guna2RadioButton9_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void drugsBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void btsearch_Click(object sender, EventArgs e)
        {

            string f, d, p, m;
            f = "Heart diseases";
            d = "High Blood Pressure";
            p = "Diabetes";

            try
            { 
            con.Open();

            SqlCommand activ = new SqlCommand("UPDATE patient set active = 1 where NID = @NID;", con);
            activ.Parameters.Add("@NID", long.Parse(textBox11.Text));
            activ.ExecuteNonQuery();
            textBox11.Text = "";
            SqlCommand c = new SqlCommand("SELECT * from patient where active = 1;", con);
            SqlDataReader s = c.ExecuteReader();
            while (s.Read())

            {
                    textBox2.Text = s["NID"].ToString();
                textBox1.Text = s["patient_Name"].ToString();
                textBox3.Text = s["patient_Gender"].ToString();
                // textBox2.Text = s["patient_Name"].ToString();
                dateTimePicker1.Text = s["Patient_Birth"].ToString();
                textBox4.Text = s["patient_Weight"].ToString();
                textBox8.Text = s["patient_Height"].ToString();
                    textBox6.Text = s["patient_Name"].ToString();
                    textBox9.Text = s["Supplements"].ToString();
                    if (f.Equals(s["Patient_chronic1"].ToString()))
                    {
                        checkBox16.Checked = true;
                    }
                    else
                    {
                        checkBox16.Checked = false;
                    }
                    if (d.Equals(s["Patient_chronic2"].ToString()))
                    {
                        checkBox13.Checked = true;
                    }
                    else
                    {
                        checkBox13.Checked = false;
                    }
                    if (p.Equals(s["Patient_chronic3"].ToString()))
                    {
                        checkBox11.Checked = true;
                    }
                    else
                    {
                        checkBox11.Checked = false;
                    }
                    textBox5.Text = s["Patient_chronic4"].ToString();

                    if (radioButton7.Text.Equals(s["Patient_Med"]))
                    {
                        radioButton7.Checked = true;
                        textBox7.Clear();

                    }
                    else
                    {
                        radioButton7.Checked = false;
                        radioButton6.Checked = true;
                        textBox7.Text = s["Patient_Med"].ToString();

                    }

                    if (radioButton1.Text.Equals(s["Patient_pregnant"]))
                    {
                        radioButton1.Checked = true;
                        radioButton2.Checked = false;
                        radioButton3.Checked = false;
                        radioButton4.Checked = false;
                    }
                    else if (radioButton2.Text.Equals(s["Patient_pregnant"]))
                    {
                        radioButton2.Checked = true;
                        radioButton1.Checked = false;
                        radioButton3.Checked = false;
                        radioButton4.Checked = false;
                    }
                    else if (radioButton3.Text.Equals(s["Patient_pregnant"]))
                    {
                        radioButton3.Checked = true;
                        radioButton2.Checked = false;
                        radioButton1.Checked = false;
                        radioButton4.Checked = false;

                    }
                    else
                    {
                        radioButton4.Checked = true;
                        radioButton2.Checked = false;
                        radioButton3.Checked = false;
                        radioButton1.Checked = false;
                    }

                    if (radioButton13.Text.Equals(s["Smoker"].ToString()))
                    {
                        radioButton13.Checked = true;
                        radioButton14.Checked = false;

                    }
                    else
                    {
                        radioButton14.Checked = true;
                        radioButton13.Checked = false;
                    }


                    if (radioButton12.Text.Equals(s["Foodallergies"]))
                    {
                        radioButton12.Checked = true;
                        radioButton5.Checked = false;
                        textBox10.Clear();

                    }
                    else
                    {


                        radioButton12.Checked = false;
                        radioButton5.Checked = true;
                        textBox10.Text = s["Foodallergies"].ToString();

                    }





                }
            con.Close();
        }
            catch (Exception ex)
            {
                MessageBox.Show("National Id Is not avaliable try again" + ex);
            }





        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           /* try
            {
                String si = comboBox1.SelectedItem.ToString();
                con.Open();
                String query = "SELECT * FROM Patient WHERE active =1'";
                cmd = new SqlCommand(query, con);
                SqlDataReader R = cmd.ExecuteReader();

                while (R.Read())
                {
                    textBox1.Text = R.GetValue(1).ToString();
                    textBox3.Text = R.GetValue(3).ToString();
                    textBox2.Text = R.GetValue(5).ToString();
                    dateTimePicker1.Text = R.GetValue(4).ToString();
                    textBox4.Text = R.GetValue(7).ToString();
                    textBox8.Text = R.GetValue(6).ToString();
                    
                    
                    


                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }*/
        }

        private void label8_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void checkBox11_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox13_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox16_CheckedChanged(object sender, EventArgs e)
        {

        }

        /*private void rjButton1_Click_1(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-TPC7M5O;Initial Catalog=myclinic1;Integrated Security=True");
            
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT Patient_Name, Patient_Chronic1,Patient_Chronic2,Patient_Chronic3 FROM Patient ORDER BY Patient_ID");
                cmd.Parameters.AddWithValue("Patient_ID", textBox7.Text);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    textBox6.Text = dr.GetValue(1).ToString();
                    if (dr["Patient_Chronic1"].ToString() == "Heart Disease")
                    {
                        checkBox16.Checked = true;
                    }
                    else
                    {
                        checkBox16.Checked= false;
                    }
                }
                dr.Close();
                con.Close();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }*/



        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            //imoppp
            /*string f, d, p , m;
            f = "Heart diseases";
            d = "High Blood Pressure";
            p = "Diabetes";
            


            try
            {
                String si = comboBox4.SelectedItem.ToString();
                con.Open();
                String query = "SELECT * FROM Patient WHERE Patient_ID = '" + si + "'";
                cmd = new SqlCommand(query, con);
                SqlDataReader R = cmd.ExecuteReader();

                while (R.Read())
                {
                    textBox6.Text = R.GetValue(1).ToString();
                    textBox9.Text=R.GetValue(14).ToString();
                    if (f.Equals(R.GetValue(8).ToString()))
                    {
                        checkBox16.Checked = true;
                    }
                    else
                    {
                        checkBox16.Checked = false;
                    }
                    if (d.Equals(R.GetValue(9).ToString()))
                    {
                        checkBox13.Checked = true;
                    }
                    else
                    {
                        checkBox13.Checked = false;
                    }
                    if (p.Equals(R.GetValue(10).ToString()))
                    {
                        checkBox11.Checked = true;
                    }
                    else
                    {
                        checkBox11.Checked = false;
                    }
                    textBox5.Text = R.GetValue(11).ToString();

                    if (radioButton7.Text.Equals( R.GetValue(12)))
                    {
                        radioButton7.Checked = true;
                        textBox7.Clear();

                    }
                    else
                    {
                        radioButton7.Checked = false;
                        radioButton6.Checked = true;
                        textBox7.Text = R.GetValue(12).ToString();

                    }

                    if(radioButton1.Text.Equals(R.GetValue(13)))
                    {
                        radioButton1.Checked = true;
                        radioButton2.Checked = false;
                        radioButton3.Checked = false;
                        radioButton4.Checked = false;
                    }
                    else if(radioButton2.Text.Equals(R.GetValue(13)))
                    {
                     radioButton2.Checked = true;
                        radioButton1.Checked = false;
                        radioButton3.Checked = false;
                        radioButton4.Checked = false;
                    }
                    else if(radioButton3.Text.Equals(R.GetValue(13)))
                    {
                        radioButton3.Checked= true;
                        radioButton2.Checked = false;
                        radioButton1.Checked = false;
                        radioButton4.Checked = false;

                    }
                    else
                    {
                        radioButton4.Checked= true;
                        radioButton2.Checked = false;
                        radioButton3.Checked = false;
                        radioButton1.Checked = false;
                    }

                    if (radioButton13.Text.Equals(R.GetValue(15)))
                    {
                        radioButton13.Checked= true;
                        radioButton14.Checked = false;
                        
                    }
                    else
                    {
                        radioButton14.Checked = true;
                        radioButton13.Checked = false;
                    }
                                  

                    if (radioButton12.Text.Equals(R.GetValue(16)))
                    {
                        radioButton12.Checked = true;
                        radioButton5.Checked = false;
                        textBox10.Clear();

                    }
                    else
                    {
                        
                        
                       radioButton12.Checked = false;
                        radioButton5.Checked = true;
                        textBox10.Text = R.GetValue(16).ToString();

                    }



                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }*/
        }

        private void label13_Click_1(object sender, EventArgs e)
        {

        }

        private void label24_Click_1(object sender, EventArgs e)
        {

        }

        private void radioButton14_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void radioButton12_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label23_Click_1(object sender, EventArgs e)
        {

        }

        private void radioButton13_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label26_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void radioButton19_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton20_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rjButton2_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label12_Click_1(object sender, EventArgs e)
        {

        }

        private void label11_Click_1(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void tabPage3_Click_1(object sender, EventArgs e)
        {

        }

        private void label15_Click_1(object sender, EventArgs e)
        {

        }

        private void tabPage4_Click_1(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox11_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
           
        }




        /*private void rjButton1_Click_1(object sender, EventArgs e)
        {
            checkBox16.Checked = false;
            checkBox13.Checked = false;
            checkBox11.Checked = false;

            //SqlCommand cmd= new SqlCommand(query, con);
            //SqlDataReader dr = cmd.ExecuteReader();
            con.Open();
            
            SqlCommand query = new SqlCommand( "SELECT * FROM Patient WHERE Patient_ID = '" + comboBox2 + "'");
            
            SqlDataReader dr = query.ExecuteReader();
            if (dr.Read())
            {
                string aa = dr["Patient_Chronic1"].ToString();
                string[] a = aa.Split(' ');
                foreach (Control cc in this.Controls)
                {
                    if (cc is CheckBox)
                    {
                        CheckBox b = (CheckBox)cc;
                        for (int j = 0; j < a.Length; j++)
                        {
                            if (a[j].ToString() == b.Text)
                            {
                                b.Checked = true;
                            }
                        }
                    }
                }
            }
            con.Close();
        }*/
    }
}
