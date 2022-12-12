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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form7 requ = new Form7();
            requ.Show();
            Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form6 diet = new Form6();
            diet.Show();
            Visible= false;
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form9 Emr = new Form9();
            Emr.Show();
            Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form8 Inbody = new Form8();
            Inbody.Show();
            Visible = false;
        }
    }
}
