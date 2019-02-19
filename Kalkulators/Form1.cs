using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kalkulators
{
    public partial class Form1 : Form
    {
        string enteredNumber = "";

        string operation = "";

        bool isOperationClicked = false;

        public Form1()
        {
            InitializeComponent();

            textBox1.Text = "0";

        }

        private void number_Clicked(int num)
        {
            if (isOperationClicked)
            {
                textBox1.Text = "";
                isOperationClicked = false;
            }


            if (textBox1.Text == "0")
            {
                textBox1.Text = "";
                textBox1.Text = num.ToString();
            }
            else if (textBox1.Text != "" || textBox1.Text != "0")
            {
                textBox1.Text += num.ToString();
            }


        }


        private void operation_clicked(string op)
        {
            if(isOperationClicked)
            {
                operation = op;
                return;
            }

            if (String.IsNullOrEmpty(enteredNumber))
            {
                enteredNumber = textBox1.Text;

                operation = op;

            }
            else
            {
                buttEqual_Click(null, null);

            }
            isOperationClicked = true;
            


            /*if (op == "=")
            {
                enteredNumber = textBox1.Text;

                operation = op;

                isOperationClicked = true;

                int enteredNumber2 = Convert.ToInt32(enteredNumber);

                //int sk2 = int.Parse(Console.ReadLine());

                float result = 0;

                switch (op)
                {
                    case "*":
                        result = enteredNumber1 * enteredNumber2;
                        break;
                    case "/":
                        result = enteredNumber1 / enteredNumber2;
                        break;
                    case "+":
                        result = enteredNumber1 + enteredNumber2;
                        break;
                    case "-":
                        result = enteredNumber1 - enteredNumber2;
                        break;
                }

                textBox1.Text = result.ToString();
            }*/





            /*
            string firstNumber = textBox1.Text;
            textBox1.Text = "";
            string operation = textBox1.Text;
            textBox1.Text = "";
            string secondNumber = textBox1.Text;
            Console.WriteLine(firstNumber);
            */

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
            operation_clicked("/");
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
            operation_clicked("*");

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
            operation_clicked("-");

        }

        private void buttErase_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            enteredNumber = "";
            operation = "";
            isOperationClicked = false;
        }

        private void butt0_Click(object sender, EventArgs e)
        {
            number_Clicked(0);

        }

        private void buttEqual_Click(object sender, EventArgs e)
        {
            int number1 = int.Parse(enteredNumber);
            int number2 = int.Parse(textBox1.Text);
            var result = 0;

           switch (operation)
            {
                case "*":
                    operation = "times";
                    break;     
                case "/":      
                    operation = "divide";
                    break;     
                case "+":      
                    operation = "plus";
                    break;     
                case "-":      
                    operation = "minus";
                    break;     
            }
            


            using (HttpClient client = new HttpClient())
            {

                client.BaseAddress = new Uri("http://localhost:54945");
                var response = client.GetAsync(String.Format("api/Calculator?number1={0}&number2={1}&op={2}", number1, number2, operation)).Result;
                if (response.IsSuccessStatusCode)
                {
                    result = response.Content.ReadAsAsync<int>().Result;


                }
                else
                {
                    Console.Write("Notika neparedzēta kļūda!");
                }
                textBox1.Text = result.ToString();
                enteredNumber = textBox1.Text;
                isOperationClicked = true;

            }

        }

        private void buttPlus_Click(object sender, EventArgs e)
        {
            operation_clicked("+");

        }

        private void butt3_Click(object sender, EventArgs e)
        {
            number_Clicked(3);

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
