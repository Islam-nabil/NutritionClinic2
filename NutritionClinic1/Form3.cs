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
    public partial class Form3 : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-TPC7M5O;Initial Catalog=myclinic1;Trusted_Connection=True;");

        public Form3()
        {
            InitializeComponent();
            panelcontainer.Controls.Clear();
            DocView frm11 = new DocView();
            frm11.TopLevel = false;
            panelcontainer.Controls.Add(frm11);
            frm11.Show();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void rjButton6_Click(object sender, EventArgs e)
        {

        }
        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panelcontainer.Controls.Clear();
            panelcontainer.Controls.Add(userControl);
            userControl.BringToFront();



        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            panelcontainer.Controls.Clear();
            DocView frm11 = new DocView();
            frm11.TopLevel = false  ;
            panelcontainer.Controls.Add(frm11);
            frm11.Show();
        }

        private void rjButton1_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            panelcontainer.Controls.Clear();
            Form10 frm12 = new Form10();
            frm12.TopLevel = false;
            panelcontainer.Controls.Add(frm12);
            frm12.Show();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
           
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
          
        }

        private void button8_Click_1(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            Form1 Back_6 = new Form1();
            Back_6.Show();
            Visible = false;
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            panelcontainer.Controls.Clear();
            Form10 frm10 = new Form10();
            frm10.TopLevel = false;
            panelcontainer.Controls.Add(frm10);
            frm10.Show();

            

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void uC_Per1_Load(object sender, EventArgs e)
        {

        }
    }
}
