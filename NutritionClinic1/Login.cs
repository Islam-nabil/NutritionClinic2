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
    public partial class Login : Form
    {
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter da = new SqlDataAdapter();
        public Login()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-TPC7M5O;Initial Catalog=myclinic1;Trusted_Connection=True;");
        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            SignUp f2 = new SignUp();
            f2.ShowDialog();
        }

        private void rjButton1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "SELECT * FROM Login WHERE Username='" + textBox1.Text + "' and Password = '" + textBox2.Text + "'";
            cmd = new SqlCommand(query, con);
            da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            int i = ds.Tables[0].Rows.Count;
            if (i == 1)
            {
                
                SqlDataReader dr = cmd.ExecuteReader();
                dr.Read();
                if (dr[5].ToString() == "Doctor")
                {
                    Docpanel dc = new Docpanel();
                    dc.Show();
                    this.Hide();
                }
                else if (dr[5].ToString() == "Nurse")
                {
                    NursePanel ns = new NursePanel();
                    ns.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Please Check Your Username Or Password", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
            con.Close();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
