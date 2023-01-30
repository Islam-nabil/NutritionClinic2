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

        private void rjButton4_Click(object sender, EventArgs e)
        {
            button.Text = "9:00";
            button.Size = new Size(70, 50);

            button.Location = new Point(185, 234);
            button.AutoSize = true;
            button.Font = new Font("Century Gothic", 14);
            button.Padding = new Padding(6);

            button.Visible = true;
            this.Controls.Add(button);
            this.button.Click += new System.EventHandler(this.button_Click);


            button1.Text = "10:00";
            button1.Size = new Size(70, 50);

            button1.Location = new Point(306, 234);
            button1.AutoSize = true;
            button1.Font = new Font("Century Gothic", 14);
            button1.Padding = new Padding(6);


            button1.Visible = true;
            this.Controls.Add(button1);
            this.button1.Click += new System.EventHandler(this.button_Click1);
            button2.Text = "11:00";

            button2.Size = new Size(70, 50);
            button2.Location = new Point(423, 234);
            button2.AutoSize = true;
            button2.Font = new Font("Century Gothic", 14);
            button2.Padding = new Padding(6);

            button2.Visible = true;
            this.Controls.Add(button2);
            this.button2.Click += new System.EventHandler(this.button_Click2);
        }
        private void button_Click(object sender, EventArgs e)
        {
            int Patient_ID = int.Parse(textBox1.Text);
            String time = "9:00";
            string Date = dateTimePicker1.Value.ToString("yyyy-MM-dd");
            int i = 0;
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT Time,Date FROM Appointment");
            cmd.Connection = con;
            SqlDataReader reader = cmd.ExecuteReader();
            string[] Time = new string[10];
            string[] DateArray = new string[10];

            while (reader.Read() == true)
            {
                Time[i] = reader["Time"].ToString();
                DateArray[i] = reader["Date"].ToString();
                i++;
            }
            con.Close();

            for (int x = 0; x < Time.Length; x++)
            {
                if (Time[x] == "9:00" && DateArray[x] == Date)
                {
                    MessageBox.Show("Time Not Available ");
                }
                else
                {
                    using (SqlConnection connection = new SqlConnection(@"Data Source = DESKTOP - TPC7M5O; Initial Catalog = myclinic1; Integrated Security = True;"))
                    {
                        String query = "INSERT INTO Appointment (Patient_ID,Date,Time) VALUES (@Patient_ID,@Date,@Time)";
                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@Patient_ID", "Patient_ID");
                            command.Parameters.AddWithValue("@Date", "Date");
                            command.Parameters.AddWithValue("@time", "time");
                            connection.Open();
                            int result = command.ExecuteNonQuery();

                            // Check Error
                            if (result < 0)
                                Console.WriteLine("Error inserting data into Database!");
                        }
                    }
                }
                Close();
            }
        }
        private void button_Click1(object sender, EventArgs e)
        {
            int Patient_ID = int.Parse(textBox1.Text);
            String time = "10:00";
            string Date = dateTimePicker1.Value.ToString("yyyy-MM-dd");
            Console.WriteLine(Date);
            int i = 0;
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT Time,Date FROM Appointment");
            cmd.Connection = con;
            SqlDataReader reader = cmd.ExecuteReader();
            string[] Time = new string[10];
            string[] DateArray = new string[10];

            while (reader.Read() == true)
            {
                Time[i] = reader["Time"].ToString();
                DateArray[i] = reader["Date"].ToString();
                i++;
            }
            con.Close();

            for (int x = 0; x < Time.Length; x++)
            {
                if (Time[x] == "10:00" && DateArray[x] == Date)
                {
                    MessageBox.Show("Time OR Date Not Available");
                }
                else
                {
                    using (SqlConnection connection = new SqlConnection(@"Data Source = DESKTOP - TPC7M5O; Initial Catalog = myclinic1; Integrated Security = True;"))
                    {
                        String query = "INSERT INTO Appointment (Patient_ID,Date,Time) VALUES (@Patient_ID,@Date,@Time)";

                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@Patient_ID", "Patient_ID");
                            command.Parameters.AddWithValue("@Date", "Date");
                            command.Parameters.AddWithValue("@time", "time");

                            connection.Open();
                            int result = command.ExecuteNonQuery();

                            // Check Error
                            if (result < 0)
                                Console.WriteLine("Error inserting data into Database!");
                        }
                    }

                }

                Close();
            }

        }
        private void button_Click2(object sender, EventArgs e)
        {
            int Patient_ID = int.Parse(textBox1.Text);
            String time = "11:00";
            string Date = dateTimePicker1.Value.ToString("yyyy-MM-dd");
            int i = 0;
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT Time,Date FROM Appointment");
            cmd.Connection = con;
            SqlDataReader reader = cmd.ExecuteReader();
            string[] Time = new string[10];
            string[] DateArray = new string[10];

            while (reader.Read() == true)
            {
                Time[i] = reader["Time"].ToString();
                DateArray[i] = reader["Date"].ToString();
                i++;
            }
            con.Close();

            for (int x = 0; x < Time.Length; x++)
            {
                if (Time[x] == "11:00" && DateArray[x] == Date)
                {
                    MessageBox.Show("Time Or Date Not Available ");
                }
                else
                {
                    using (SqlConnection connection = new SqlConnection(@"Data Source = DESKTOP - TPC7M5O; Initial Catalog = myclinic1; Integrated Security = True;"))
                    {
                        String query = "INSERT INTO Appointment (Patient_ID,Date,Time) VALUES (@Patient_ID,@Date,@Time)";

                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@Patient_ID", "Patient_ID");
                            command.Parameters.AddWithValue("@Date", "Date");
                            command.Parameters.AddWithValue("@time", "time");

                            connection.Open();
                            int result = command.ExecuteNonQuery();

                            // Check Error
                            if (result < 0)
                                Console.WriteLine("Error inserting data into Database!");
                        }
                    }

                }

                Close();
            }
        }
    }
}
       
