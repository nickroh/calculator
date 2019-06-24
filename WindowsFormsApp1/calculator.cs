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
    public partial class calculator : Form
    {
        private double savedValue;  
        private bool newButton;   
        private char myOperator;
        private bool easter=true;

        public calculator()
        {
            InitializeComponent();
        }

     
        private void hello_Click(object sender, EventArgs e)
        {
            if(easter==true)
            {
                hello.Text = "Nick's Calculator";
                easter = false;
            }
            else
            {
                hello.Text = "click here";
                easter = true;
            }
        }

        private void calculator_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button button1 = sender as Button;
            string number = button1.Text;
            if(result.Text == "0" || newButton== true)
            {
                newButton = false;
                result.Text = number;
            }
            else
            {
                result.Text = result.Text + number;
            }
        }

        private void result_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Button button1 = sender as Button;
            string number = button1.Text;
            if (result.Text == "0" || newButton == true)
            {
                newButton = false;
                result.Text = number;
            }
            else
            {
                result.Text = result.Text + number;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Button button1 = sender as Button;
            string number = button1.Text;
            if (result.Text == "0" || newButton == true)
            {
                newButton = false;
                result.Text = number;
            }
            else
            {
                result.Text = result.Text + number;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Button button1 = sender as Button;
            string number = button1.Text;
            if (result.Text == "0" || newButton == true)
            {
                newButton = false;
                result.Text = number;
            }
            else
            {
                result.Text = result.Text + number;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Button button1 = sender as Button;
            string number = button1.Text;
            if (result.Text == "0" || newButton == true)
            {
                newButton = false;
                result.Text = number;
            }
            else
            {
                result.Text = result.Text + number;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Button button1 = sender as Button;
            string number = button1.Text;
            if (result.Text == "0" || newButton == true)
            {
                newButton = false;
                result.Text = number;
            }
            else
            {
                result.Text = result.Text + number;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Button button1 = sender as Button;
            string number = button1.Text;
            if (result.Text == "0" || newButton == true)
            {
                newButton = false;
                result.Text = number;
            }
            else
            {
                result.Text = result.Text + number;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Button button1 = sender as Button;
            string number = button1.Text;
            if (result.Text == "0" || newButton == true)
            {
                newButton = false;
                result.Text = number;
            }
            else
            {
                result.Text = result.Text + number;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Button button1 = sender as Button;
            string number = button1.Text;
            if (result.Text == "0" || newButton == true)
            {
                newButton = false;
                result.Text = number;
            }
            else
            {
                result.Text = result.Text + number;
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;

            savedValue = double.Parse(result.Text);// string의 첫번째 요소 값
            myOperator = btn.Text[0];
            newButton = true;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;

            savedValue = double.Parse(result.Text);// string의 첫번째 요소 값
            myOperator = btn.Text[0];
            newButton = true;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (myOperator == '+')
                result.Text = (savedValue + double.Parse(result.Text)).ToString();
            else if (myOperator == '-')
                result.Text = (savedValue - double.Parse(result.Text)).ToString();
            else if (myOperator == '×')
                result.Text = (savedValue * double.Parse(result.Text)).ToString();
            else if (myOperator == '÷')
        result.Text = (savedValue / double.Parse(result.Text)).ToString();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            result.Text = "0";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;

            savedValue = double.Parse(result.Text);// string의 첫번째 요소 값
            myOperator = btn.Text[0];
            newButton = true;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;

            savedValue = double.Parse(result.Text);// string의 첫번째 요소 값
            myOperator = btn.Text[0];
            newButton = true;
        }
    }
}
