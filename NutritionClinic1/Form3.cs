using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NutritionClinic1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            UC_MedicalR uc = new UC_MedicalR();
            addUserControl(uc);
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
            UC_MedicalR uc = new UC_MedicalR();
            addUserControl(uc);
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
            // TODO: This line of code loads data into the 'myclinic1DataSet1.Drugs' table. You can move, or remove it, as needed.
            this.drugsTableAdapter.Fill(this.myclinic1DataSet1.Drugs);
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            UC_Diet uc = new UC_Diet();
            addUserControl(uc);
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            UC_Appo uc = new UC_Appo();
            addUserControl(uc);
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
           UC_Inbody uc = new UC_Inbody();  
            addUserControl(uc);
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
            UC_Per uc = new UC_Per();
            addUserControl(uc);
            this.drugsTableAdapter.Fill(this.myclinic1DataSet1.Drugs);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
