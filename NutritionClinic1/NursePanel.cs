﻿using System;
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
    public partial class NursePanel : Form
    {
        public NursePanel()
        {
            InitializeComponent();
            panelContainer.Controls.Clear();
            NurseTab frm13 = new NurseTab();
            frm13.TopLevel = false;
            panelContainer.Controls.Add(frm13);
            frm13.Show();

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
            
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            panelContainer.Controls.Clear();
            NurseTab frm13 = new NurseTab();
            frm13.TopLevel = false;
            panelContainer.Controls.Add(frm13);
            frm13.Show();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
           
        }

        private void panelContainer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            Login Back_6 = new Login();
            Back_6.Show();
            Visible = false;
        }
    }
    }
