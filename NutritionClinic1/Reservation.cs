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
    public partial class Form11 : Form
    {
        Button button = new Button();
        Button button1 = new Button();
        Button button2 = new Button();
        DateTimePicker dateTimePicker1 = new DateTimePicker();

        SqlConnection con = new SqlConnection(@"Data Source = DESKTOP - TPC7M5O; Initial Catalog = myclinic1; Integrated Security = True;");

        public Form11()
        {
            InitializeComponent();
        }

        private void Form11_Load(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand NID = new SqlCommand("SELECT NID FROM patient;", con);
            SqlDataReader Myreader = NID.ExecuteReader();
            int i = 0;
            while (Myreader.Read())
            {
                string menue = Myreader["NID"].ToString();
                comboBox1.Items.Add(menue);
                i++;
            }
            Myreader.Close();
            con.Close();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {

        }
    }
}
       
