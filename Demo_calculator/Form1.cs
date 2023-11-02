using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo_calculator
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        public void button1_Click(object sender, EventArgs e)
        {
            answerlabel.Text = calculator.add(System.Convert.ToInt32(textBox1.Text), System.Convert.ToInt32(textBox2.Text)).ToString();
        }

        public void button4_Click(object sender, EventArgs e)
        {
            answerlabel.Text = calculator.multiply(System.Convert.ToInt32(textBox1.Text), System.Convert.ToInt32(textBox2.Text)).ToString();

        }

        public void button2_Click(object sender, EventArgs e)
        {
            answerlabel.Text = calculator.subtract(System.Convert.ToInt32(textBox1.Text), System.Convert.ToInt32(textBox2.Text)).ToString();

        }

        public void button3_Click(object sender, EventArgs e)
        {
            answerlabel.Text = calculator.divide(System.Convert.ToInt32(textBox1.Text), System.Convert.ToInt32(textBox2.Text)).ToString();

        }
    }
}
