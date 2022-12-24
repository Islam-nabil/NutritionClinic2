using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace NutritionClinic1
{
    public partial class UC_Per : UserControl
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-TPC7M5O;Initial Catalog=myclinic1;Trusted_Connection=True;");
        public UC_Per()
        {
            InitializeComponent();
        }

        private void UC_Per_Load(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
             string conStr = ConfigurationManager.ConnectionStrings["db"].ToString();

             using (SqlConnection sqlcon = new SqlConnection(conStr))
             {
                 SqlDataAdapter sqldataadapter = new SqlDataAdapter("select * from DRUGS", sqlcon);
                 DataTable dataTable = new DataTable();
                 sqldataadapter.Fill(dataTable);
                 dataGridView1.DataSource = dataTable;
             }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
           

        }

        private void comboBox2_SelectedIndexChanged_1(object sender, EventArgs e)
        {



        }

        

       

        private void comboBox2_SelectedIndexChanged_4(object sender, EventArgs e)
        {

        }

    }
}

