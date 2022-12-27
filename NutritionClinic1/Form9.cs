using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NutritionClinic1
{
    public partial class Form9 : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source = DESKTOP - TPC7M5O; Initial Catalog = myclinic1; Integrated Security = True");
        SqlDataAdapter da = new SqlDataAdapter();
        SqlCommand cmd = new SqlCommand();
        public Form9()
        {
            InitializeComponent();
            
        }

        private void Form9_Load(object sender, EventArgs e)
        {

        }

        private void btnprevious_Click(object sender, EventArgs e)
        {
            Form5 Back_4 = new Form5();
            Back_4.Show();
            Visible = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void rjButton3_Click(object sender, EventArgs e)
        {
        }
    }
}
