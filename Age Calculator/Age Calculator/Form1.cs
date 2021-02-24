using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Age_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime dob = dateTimePicker1.Value;
            DateTime CurrentDate = dateTimePicker2.Value;
            TimeSpan ts = dob- CurrentDate;
            int year = ts.Days / 365;
            MessageBox.Show("Your Age is :" + year.ToString());
        }
    }
}
