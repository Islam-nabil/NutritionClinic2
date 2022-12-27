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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace NutritionClinic1
{
    public partial class DocView : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-TPC7M5O;Initial Catalog=myclinic1;Integrated Security=True");
        SqlDataAdapter da = new SqlDataAdapter();
        SqlCommand cmd = new SqlCommand();
        public DocView()
        {
            InitializeComponent();
        }

        private void DocView_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'myclinic1DataSet2.Drugs' table. You can move, or remove it, as needed.
            //this.drugsTableAdapter.Fill(this.myclinic1DataSet2.Drugs);

            try
            {
                comboBox1.Items.Clear();
                con.Open();
                String id = "SELECT Patinet_ID FROM Patinet ORDER BY Patinet_ID";
                da = new SqlDataAdapter(id,con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                con.Close();

                foreach(DataRow dr in dt.Rows)
                {
                    comboBox1.Items.Add(dr["Patinet_ID"]);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
            comboBox1.ResetText();
            textBox1.Clear();
            textBox3.Clear();
            textBox2.Clear();
            textBox4.Clear();
            textBox8.Clear();
            textBox7.Clear();

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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                String si = comboBox1.SelectedItem.ToString();
                con.Open();
                String query = "SELECT * FROM Patinet WHERE Patinet_ID = '" + si + "'";
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
                    textBox7.Text = R.GetValue(8).ToString();


                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
        }
    }
}
