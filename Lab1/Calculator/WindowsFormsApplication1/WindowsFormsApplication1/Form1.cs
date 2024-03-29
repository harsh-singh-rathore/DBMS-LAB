﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        string input = string.Empty;
        string op1 = string.Empty;
        string op2 = string.Empty;
        char Operator;
        double res = 0.0;

        public Form1()
        {
            InitializeComponent();
            
        }
        private void num_1_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = string.Empty;
            input = input + "1";
            this.textBox1.Text += input;
        }
        private void num_2_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = string.Empty;
            input = input + "2";
            this.textBox1.Text += input;
        }
        private void num_3_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = string.Empty;
            input = input + "3";
            this.textBox1.Text += input;
        }
        private void num_4_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = string.Empty;
            input = input + "4";
            this.textBox1.Text += input;
        }
        private void num_5_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = string.Empty;
            input = input + "5";
            this.textBox1.Text += input;
        }
        private void num_6_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = string.Empty;
            input = input + "6";
            this.textBox1.Text += input;
        }
        private void num_7_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = string.Empty;
            input = input + "7";
            this.textBox1.Text += input;
        }
        private void num_8_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = string.Empty;
            input = input + "8";
            this.textBox1.Text += input;
        }
        private void num_9_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = string.Empty;
            input = input + "9";
            this.textBox1.Text += input;
        }
        private void num_0_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = string.Empty;
            input = input + "0";
            this.textBox1.Text += input;
        }

        private void cmd_add_Click(object sender, EventArgs e)
        {
            op1 = input;
            Operator = '+';
            this.results.Text = "Result: "+op1+" "+Operator+" ";
            input = string.Empty;
        }
        private void cmd_sub_Click(object sender, EventArgs e)
        {
            op1 = input;
            Operator = '-';
            this.results.Text = "Result: " + op1 + " " + Operator + " ";
            input = string.Empty;
        }
        private void cmd_mul_Click(object sender, EventArgs e)
        {
            op1 = input;
            Operator = '*';
            this.results.Text = "Result: " + op1 + " " + Operator + " ";
            input = string.Empty;
        }
        private void cmd_div_Click(object sender, EventArgs e)
        {
            op1 = input;
            Operator = '/';
            this.results.Text = "Result: " + op1 + " " + Operator + " ";
            input = string.Empty;
        }
        private void cmd_eq_Click(object sender, EventArgs e)
        {
            op2 = input;
            double num1, num2;
            double.TryParse(op1, out num1);
            double.TryParse(op2, out num2);
            this.results.Text = "Result: " + op1 + " " + Operator + " ";

            if (Operator == '+')
            {
                res = num1 + num2;
                this.textBox1.Text = res.ToString();
                input = res.ToString();
                this.results.Text += op2+" = "+res.ToString();
            }
            if (Operator == '-')
            {
                res = num1 - num2;
                this.textBox1.Text = res.ToString();
                input = res.ToString();
                this.results.Text += op2 + " = " + res.ToString();
            }
            if (Operator == '*')
            {
                res = num1 * num2;
                this.textBox1.Text = res.ToString();
                input = res.ToString();
                this.results.Text += op2 + " = " + res.ToString();
            }
            if (Operator == '/')
            {
                if (num2 != 0)
                {
                    res = num1 / num2;
                    this.textBox1.Text = res.ToString();
                    input = res.ToString();
                    this.results.Text += op2 + " = " + res.ToString();
                }
                else
                {
                    this.textBox1.Text = string.Empty;
                    input = string.Empty;
                    this.results.Text = "Division by ZERO";
                }
            }
        }

        private void point_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = string.Empty;
            input = input + ".";
            this.textBox1.Text += input;
        }

        private void clear_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = string.Empty;
            input = string.Empty;
            op1 = string.Empty;
            op2 = string.Empty;
            res = 0.0;
            this.results.Text = "Result: ";
        }
    }
}
