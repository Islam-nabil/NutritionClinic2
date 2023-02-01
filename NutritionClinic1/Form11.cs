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
            dateTimePicker1.Location = new Point(262, 140);
            dateTimePicker1.Size = new Size(220, 150);
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Name = "MyPicker";
            dateTimePicker1.Font = new Font("Comic Sans MS", 12);
            dateTimePicker1.Visible = true;
            this.Controls.Add(dateTimePicker1);
        }

        
    }
}
       
