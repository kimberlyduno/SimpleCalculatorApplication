using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleCalculatorApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {

            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            GetAnswer delegateAnswer = new GetAnswer(Formula.getSum);

            int num1 = Int32.Parse(textBox1.Text);
            int num2 = Int32.Parse(textBox2.Text);
            MessageBox.Show("Answer:"+delegateAnswer(num1, num2).ToString());
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            GetAnswer delegateAnswer = new GetAnswer(Formula.getSub);

            int num1 = Int32.Parse(textBox1.Text);
            int num2 = Int32.Parse(textBox2.Text);
            MessageBox.Show("Answer:"+delegateAnswer(num1, num2).ToString());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            GetAnswer delegateAnswer = new GetAnswer(Formula.getMul);

            int num1 = Int32.Parse(textBox1.Text);
            int num2 = Int32.Parse(textBox2.Text);
            MessageBox.Show("Answer:"+ delegateAnswer(num1, num2).ToString());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            GetAnswer delegateAnswer = new GetAnswer(Formula.getDiv);

            int num1 = Int32.Parse(textBox1.Text);
            int num2 = Int32.Parse(textBox2.Text);
            MessageBox.Show("Answer:"+delegateAnswer(num1, num2).ToString());
        }
    }
}
