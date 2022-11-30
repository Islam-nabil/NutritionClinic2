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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            UC_Addresrev uc = new UC_Addresrev();
            addUserControl(uc);

        }
        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(userControl);
            userControl.BringToFront();

        }



            private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            UC_Addresrev uc = new UC_Addresrev();
            addUserControl(uc);
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            UC_Addpatinet uc = new UC_Addpatinet();
            addUserControl(uc);
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            UC_ViewAp uc = new UC_ViewAp();
            addUserControl(uc);
        }
    }
    }
