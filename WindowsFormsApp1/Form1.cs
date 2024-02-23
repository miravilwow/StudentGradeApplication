using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string user = textBox1.Text;
            double english = Convert.ToDouble(textBox2.Text);
            double math = Convert.ToDouble(textBox3.Text);
            double science = Convert.ToDouble(textBox4.Text);
            double filipino = Convert.ToDouble(textBox5.Text);
            double history = Convert.ToDouble(textBox6.Text);
            double sum = english + math + science + filipino + history;
            double grades = sum / 5;

            double totalAverage = grades;

            string result = totalAverage >= 75 ? "The student passed \nThe general average of " + user + " is " + totalAverage : "Student failed exam";
            label9.Text = result;
        }
    }
}
