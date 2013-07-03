using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CItest
{
    public partial class Form1 : Form
    {
        Calculator calc = new Calculator();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Operations operation = (Operations)comboBox1.SelectedIndex;
                label1.Text = calc.Eval(Double.Parse(textBox1.Text), Double.Parse(textBox2.Text), operation).ToString();
            }
            catch (Exception ex)
            {
                label1.Text = String.Empty;
                MessageBox.Show(ex.ToString());
            }

        }
    }
}
