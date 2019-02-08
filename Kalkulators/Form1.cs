using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kalkulators
{
    public partial class Form1 : Form
    {
        string skIevads1 = "";

        string operation = "";

        public Form1()
        {
            InitializeComponent();



            textBox1.Text = "0";
            butt0.Click += butt0_Click;
            butt1.Click += butt1_Click;
            butt2.Click += butt2_Click;
            butt3.Click += butt3_Click;
            butt4.Click += butt4_Click;
            butt5.Click += butt5_Click;
            butt6.Click += butt6_Click;
            butt7.Click += butt7_Click;
            butt8.Click += butt8_Click;
            butt9.Click += butt9_Click;
            buttEqual.Click += buttEqual_Click;
            buttPlus.Click += buttPlus_Click;
            buttMinus.Click += buttMinus_Click;
            buttTimes.Click += buttTimes_Click;
            buttDivide.Click += buttDivide_Click;

        }

        private void number_Clicked(int num)
        {

            if (textBox1.Text == "0")
            {
                textBox1.Text = "";
            }
            textBox1.Text = num.ToString();
        }


        private void operation_Click(string op)
        {


        }

        private void button15_Click(object sender, EventArgs e)
        {
            
        }

        private void butt7_Click(object sender, EventArgs e)
        {
            number_Clicked(7);
        }

        private void butt8_Click(object sender, EventArgs e)
        {
            number_Clicked(8);

        }

        private void butt9_Click(object sender, EventArgs e)
        {
            number_Clicked(9);

        }

        private void buttDivide_Click(object sender, EventArgs e)
        {

        }

        private void butt4_Click(object sender, EventArgs e)
        {
            number_Clicked(4);

        }

        private void butt5_Click(object sender, EventArgs e)
        {
            number_Clicked(5);

        }

        private void butt6_Click(object sender, EventArgs e)
        {
            number_Clicked(6);

        }

        private void buttTimes_Click(object sender, EventArgs e)
        {

        }

        private void butt1_Click(object sender, EventArgs e)
        {
            number_Clicked(1);

        }

        private void butt2_Click(object sender, EventArgs e)
        {
            number_Clicked(2);

        }

        private void buttMinus_Click(object sender, EventArgs e)
        {

        }

        private void buttErase_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void butt0_Click(object sender, EventArgs e)
        {
            number_Clicked(0);

        }

        private void buttEqual_Click(object sender, EventArgs e)
        {

        }

        private void buttPlus_Click(object sender, EventArgs e)
        {

        }

        private void butt3_Click(object sender, EventArgs e)
        {
            number_Clicked(3);

        }
    }
}
