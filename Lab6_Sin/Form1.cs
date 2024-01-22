using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TaylorSinus;

namespace Lab6_Sin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double x = double.Parse(textBox1.Text)*(Math.PI/180);

            label3.Text = Convert.ToString(TaylorSin.CalculateSinTaylor(x, int.Parse(textBox2.Text)));

        }


    }
}
