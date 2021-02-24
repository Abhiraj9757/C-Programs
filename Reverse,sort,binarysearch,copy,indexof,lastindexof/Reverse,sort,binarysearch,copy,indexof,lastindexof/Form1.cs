using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            string varuser, reserve = "";
            int Length = 0;
            varuser = textBox1.Text;
            Length = varuser.Length - 1;
            while (Length >= 0)
            {
                reserve = reserve + varuser[Length];
                Length--;
            }
            textBox3.Text = reserve;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            char temp;
            string varuser = textBox1.Text;
            string var = varuser.ToLower();
            char[] charstr = var.ToCharArray();
            for (int i = 1; i < charstr.Length; i++)
            { 
            for(int j=0;j<charstr.Length -1;j++)
                {
                    if (charstr[j] > charstr[j + 1])
                    {
                        temp = charstr[j];
                        charstr[j] = charstr[j + 1];
                        charstr[j + 1] = temp;
                    }
                }
            }
            string result = new string(charstr);
            textBox3.Text = result;

        }

        private void button7_Click(object sender, EventArgs e)
        {
            string s1 = textBox1.Text;
            string[] array = s1.Split(' ');
            string x = textBox3.Text;
            int result = BinarySearch(array, x);

            if (result == -1)
                MessageBox.Show("Element is not Present");
            else
                MessageBox.Show("Element is present at " + result);
        }

        static int BinarySearch(String[] arr, String x)
        { 
        int l=0,r=arr.Length-1;
        while (l <= r)
        {
            int m = 1 + (r - 1) / 2;
            int res = x.CompareTo(arr[m]);
            if (res == 0)
                return m;
            if (res > 0)
                l = m + 1;
            else
                r = m - 1;


        }
        return -1;
        }

        private void button6_Click(object sender, EventArgs e)
        {
             string s1 = textBox1.Text;
             string s2 = string.Copy(s1);
             textBox3.Text = s2;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string s1 = textBox1.Text;
            int index = s1.IndexOf(textBox3.Text);
            string s2 = index.ToString();
            textBox3.Text = s2;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string s1 = textBox1.Text;
            int index = s1.LastIndexOf(textBox3.Text);
            string s2 = index.ToString();
            textBox3.Text = s2;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
