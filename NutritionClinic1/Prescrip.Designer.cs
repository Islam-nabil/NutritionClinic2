namespace NutritionClinic1
{
    partial class Prescrip
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.drugsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.myclinic1DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.myclinic1DataSet = new NutritionClinic1.myclinic1DataSet();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.drugsTableAdapter = new NutritionClinic1.myclinic1DataSetTableAdapters.DrugsTableAdapter();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.Dose = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.drugsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.myclinic1DataSet3 = new NutritionClinic1.myclinic1DataSet3();
            this.myclinic1DataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.drugsTableAdapter1 = new NutritionClinic1.myclinic1DataSet3TableAdapters.DrugsTableAdapter();
            this.rjButton1 = new NutritionClinic1.RJButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.rjButton2 = new NutritionClinic1.RJButton();
            ((System.ComponentModel.ISupportInitialize)(this.drugsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myclinic1DataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myclinic1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.drugsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myclinic1DataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myclinic1DataSetBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // drugsBindingSource
            // 
            this.drugsBindingSource.DataMember = "Drugs";
            this.drugsBindingSource.DataSource = this.myclinic1DataSetBindingSource;
            // 
            // myclinic1DataSetBindingSource
            // 
            this.myclinic1DataSetBindingSource.DataSource = this.myclinic1DataSet;
            this.myclinic1DataSetBindingSource.Position = 0;
            // 
            // myclinic1DataSet
            // 
            this.myclinic1DataSet.DataSetName = "myclinic1DataSet";
            this.myclinic1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.radioButton3.Location = new System.Drawing.Point(452, 135);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(120, 22);
            this.radioButton3.TabIndex = 32;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Before Sleep";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.radioButton2.Location = new System.Drawing.Point(294, 135);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(135, 22);
            this.radioButton2.TabIndex = 31;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Every Morning ";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.radioButton1.Location = new System.Drawing.Point(119, 135);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(164, 22);
            this.radioButton1.TabIndex = 30;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Before Every Meal ";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Mesotherapy",
            "Radio Frequency",
            "Smart Capsule",
            "Cavitation",
            "Air massage",
            "Laser Sessions",
            "Cryotherapy"});
            this.comboBox1.Location = new System.Drawing.Point(131, 102);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(156, 21);
            this.comboBox1.TabIndex = 27;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.Info;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTextBox1.Location = new System.Drawing.Point(12, 255);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(474, 136);
            this.richTextBox1.TabIndex = 22;
            this.richTextBox1.Text = "";
            // 
            // drugsTableAdapter
            // 
            this.drugsTableAdapter.ClearBeforeFill = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.radioButton4.Location = new System.Drawing.Point(119, 175);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(146, 22);
            this.radioButton4.TabIndex = 44;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "After Every Meal";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkOrange;
            this.label6.Location = new System.Drawing.Point(305, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 18);
            this.label6.TabIndex = 45;
            this.label6.Text = "Dosage";
            // 
            // Dose
            // 
            this.Dose.Location = new System.Drawing.Point(398, 60);
            this.Dose.Name = "Dose";
            this.Dose.Size = new System.Drawing.Size(31, 20);
            this.Dose.TabIndex = 46;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.DarkOrange;
            this.label10.Location = new System.Drawing.Point(9, 101);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(116, 18);
            this.label10.TabIndex = 28;
            this.label10.Text = "Method to use:";
            this.label10.Click += new System.EventHandler(this.label4_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.DarkOrange;
            this.label11.Location = new System.Drawing.Point(9, 135);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(91, 18);
            this.label11.TabIndex = 29;
            this.label11.Text = "Frequency:";
            this.label11.Click += new System.EventHandler(this.label5_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.DarkOrange;
            this.label12.Location = new System.Drawing.Point(12, 62);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(92, 18);
            this.label12.TabIndex = 35;
            this.label12.Text = "Drug Name";
            this.label12.Click += new System.EventHandler(this.label7_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.DarkOrange;
            this.label14.Location = new System.Drawing.Point(314, 98);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(43, 18);
            this.label14.TabIndex = 48;
            this.label14.Text = "Type";
            this.label14.Click += new System.EventHandler(this.label8_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkOrange;
            this.label4.Location = new System.Drawing.Point(175, 218);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 18);
            this.label4.TabIndex = 50;
            this.label4.Text = "Notes";
            // 
            // drugsBindingSource1
            // 
            this.drugsBindingSource1.DataMember = "Drugs";
            this.drugsBindingSource1.DataSource = this.myclinic1DataSet3;
            // 
            // myclinic1DataSet3
            // 
            this.myclinic1DataSet3.DataSetName = "myclinic1DataSet3";
            this.myclinic1DataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // myclinic1DataSetBindingSource1
            // 
            this.myclinic1DataSetBindingSource1.DataSource = this.myclinic1DataSet;
            this.myclinic1DataSetBindingSource1.Position = 0;
            // 
            // drugsTableAdapter1
            // 
            this.drugsTableAdapter1.ClearBeforeFill = true;
            // 
            // rjButton1
            // 
            this.rjButton1.BackColor = System.Drawing.Color.Orange;
            this.rjButton1.BackgroundColor = System.Drawing.Color.Orange;
            this.rjButton1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjButton1.BorderRadius = 20;
            this.rjButton1.BorderSize = 0;
            this.rjButton1.FlatAppearance.BorderSize = 0;
            this.rjButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjButton1.ForeColor = System.Drawing.Color.Black;
            this.rjButton1.Location = new System.Drawing.Point(83, 407);
            this.rjButton1.Name = "rjButton1";
            this.rjButton1.Size = new System.Drawing.Size(111, 34);
            this.rjButton1.TabIndex = 43;
            this.rjButton1.Text = "Save Drugs";
            this.rjButton1.TextColor = System.Drawing.Color.Black;
            this.rjButton1.UseVisualStyleBackColor = false;
            this.rjButton1.Click += new System.EventHandler(this.rjButton1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(131, 63);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(134, 20);
            this.textBox1.TabIndex = 51;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Capsule(s)",
            "Tablet(s)",
            "Injections(s)",
            "Suppositories"});
            this.comboBox2.Location = new System.Drawing.Point(385, 99);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 52;
            // 
            // rjButton2
            // 
            this.rjButton2.BackColor = System.Drawing.Color.Orange;
            this.rjButton2.BackgroundColor = System.Drawing.Color.Orange;
            this.rjButton2.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjButton2.BorderRadius = 20;
            this.rjButton2.BorderSize = 0;
            this.rjButton2.FlatAppearance.BorderSize = 0;
            this.rjButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjButton2.ForeColor = System.Drawing.Color.Black;
            this.rjButton2.Location = new System.Drawing.Point(246, 397);
            this.rjButton2.Name = "rjButton2";
            this.rjButton2.Size = new System.Drawing.Size(111, 55);
            this.rjButton2.TabIndex = 53;
            this.rjButton2.Text = "Save Prescription";
            this.rjButton2.TextColor = System.Drawing.Color.Black;
            this.rjButton2.UseVisualStyleBackColor = false;
            this.rjButton2.Click += new System.EventHandler(this.rjButton2_Click);
            // 
            // Form10
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(979, 697);
            this.Controls.Add(this.rjButton2);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.Dose);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.radioButton4);
            this.Controls.Add(this.rjButton1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.richTextBox1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form10";
            this.Text = "Form10";
            this.Load += new System.EventHandler(this.Form10_Load);
            ((System.ComponentModel.ISupportInitialize)(this.drugsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myclinic1DataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myclinic1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.drugsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myclinic1DataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myclinic1DataSetBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.BindingSource myclinic1DataSetBindingSource;
        private myclinic1DataSet myclinic1DataSet;
        private System.Windows.Forms.BindingSource drugsBindingSource;
        private myclinic1DataSetTableAdapters.DrugsTableAdapter drugsTableAdapter;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown Dose;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.BindingSource myclinic1DataSetBindingSource1;
        private myclinic1DataSet3 myclinic1DataSet3;
        private System.Windows.Forms.BindingSource drugsBindingSource1;
        private myclinic1DataSet3TableAdapters.DrugsTableAdapter drugsTableAdapter1;
        private RJButton rjButton1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private RJButton rjButton2;
    }
}