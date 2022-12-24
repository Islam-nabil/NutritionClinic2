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
    public partial class DocView : Form
    {
        public DocView()
        {
            InitializeComponent();
        }

        private void DocView_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'myclinic1DataSet2.Drugs' table. You can move, or remove it, as needed.
            this.drugsTableAdapter.Fill(this.myclinic1DataSet2.Drugs);

        }
    }
}
