using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            double textone = Convert.ToDouble(textBox1.Text);
            double texttwo = Convert.ToDouble(textBox2.Text);

            double sum = textone / texttwo;

            textBox3.Text = sum.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double textone = Convert.ToDouble(textBox1.Text);
            double texttwo = Convert.ToDouble(textBox2.Text);

            double sum = textone + texttwo;

            textBox3.Text = sum.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            double textone = Convert.ToDouble(textBox1.Text);
            double texttwo = Convert.ToDouble(textBox2.Text);

            double sum = textone - texttwo;

            textBox3.Text = sum.ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            double textone = Convert.ToDouble(textBox1.Text);
            double texttwo = Convert.ToDouble(textBox2.Text);

            double sum = textone * texttwo;

            textBox3.Text = sum.ToString();
        }
    }
}
