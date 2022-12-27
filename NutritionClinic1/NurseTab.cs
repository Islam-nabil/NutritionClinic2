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
        string checkbox;
       
        public NurseTab()
        {
            InitializeComponent();
            
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void rjButton1_Click(object sender, EventArgs e)

            
        {
            checkbox = "";
            for(int x = 0; x < checkedListBox2.Items.Count; x++)
            {
                if (checkedListBox2.SelectedItems == checkedListBox2.Items[x])
                {
                    if(checkbox == "")
                    {
                        checkbox = checkedListBox2.Items[x].ToString();
                    }
                    else
                    {
                        checkbox +=","+ checkedListBox2.Items[x].ToString();
                    }
                }
            }



            if(radioButtonM.Checked==true)
            {
                g = "Male";
            }
            else
            {
                g = "Female";
            }

            SqlConnection con = new SqlConnection("Data Source=DESKTOP-TPC7M5O;Initial Catalog=myclinic1;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into Patinet(Patinet_Name,Patinet_Gender,Patinet_Birth,Patinet_NationalID,Patinet_Address,Patinet_Height,Patinet_Weight,Patinet_Bloodtype,Patinet_Chronic)values('"+TextboxNa.Text+"','"+g+"','"+ dateTimePicker1.Value.Date.ToString("yyyyMMdd") + "' ,'"+Nationalid.Text+"','"+Address.Text+"','"+HeightN.Text+"','"+Weightn.Text+"','"+Bloodn+"','"+checkbox+"')",con);;
            int i = cmd.ExecuteNonQuery();
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
