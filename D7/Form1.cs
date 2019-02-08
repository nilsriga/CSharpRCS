using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace D7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            labelCount.Text = "Skaits: ";
            buttonAdd.Click += ButtonAdd_Click;
            inputNumber.Text = "1";
            button2.Click += button2_Click;
            button1.Click += button1_Click;

        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            /* int skaitlis = int.Parse(inputNumber.Text);
             skaitlis++;
             inputNumber.Text = skaitlis.ToString(); */

            inputNumber.Text = "1";
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            inputNumber.Text = (int.Parse(inputNumber.Text) - 1).ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            inputNumber.Text = (int.Parse(inputNumber.Text) + 1).ToString();

        }


        private void button1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
