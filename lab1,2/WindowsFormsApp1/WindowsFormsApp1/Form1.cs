using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        float a, result;
        int count;
        bool znak = true;
       


        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }
        private void button2_Click_1(object sender, EventArgs e)
        {
            textBox1.Clear();
        }


        private void button21_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0)
            {
                a = float.Parse(textBox1.Text);
            textBox1.Clear();
            znak = true;
            textBox2.Text += a.ToString() + " + ";
            calculate();
            count = 1;
            }
            else
            {
                textBox2.Text = result + " + ";
                textBox1.Text = " ";

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            result = 0;
            count = 0;

        }


        private void button22_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0)
            {
                a = float.Parse(textBox1.Text);
                textBox2.Clear();
                calculate();
                textBox1.Text = result.ToString();
                result = 0;
            }
            else
            {
               textBox1.Clear();
                textBox2.Clear();
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 1;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 2;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 3;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 4;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 5;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 6;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 7;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 8;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 9;
        }

        private void button19_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 0;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0)
            {
                a = float.Parse(textBox1.Text);
            textBox1.Clear();
            znak = true;
                textBox2.Text += a.ToString() + " - ";
                calculate();
            count = 2;
                if (a < 0)
                    znak = false;
                else
                    znak = true;
            }
            else
            {
                textBox2.Text = result +  " - ";
                textBox1.Text = " ";
                count = 2;

            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0)
            {
                a = float.Parse(textBox1.Text); textBox1.Clear();
            textBox1.Clear();
            znak = true;
            textBox2.Text += a.ToString() + " * ";
            calculate();
                count = 3;   
                if (a < 0)
                    znak = false;
                else
                    znak = true;
            }
            else
            {
                textBox2.Text = result + " * ";
                textBox1.Text = " ";
                count = 3;
                a = 0;

            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0)
            {
                a = float.Parse(textBox1.Text);
            
            
                textBox1.Clear();
                znak = true;
                textBox2.Text += a.ToString() + " / ";
                calculate();
                count = 4;
                if (a < 0)
                    znak = false;
                else
                    znak = true;
            }
            else
            {
                textBox2.Text = result + " / ";
                textBox1.Text = " ";
                count = 4;
                a = 0;

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int lenght = textBox1.Text.Length - 1;
            string text = textBox1.Text;
            textBox1.Clear();
            for (int i = 0; i < lenght; i++)
            {
                textBox1.Text = textBox1.Text + text[i];
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (znak == true)
            {
                textBox1.Text = "-" + textBox1.Text;
                znak = false;
            }
            else if (znak == false)
            {
                textBox1.Text = textBox1.Text.Replace("-", "");
                znak = true;
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            int c = textBox1.TextLength;
            int flag = 0;
            string text = textBox1.Text;
            for (int i = 0; i < c; i++)
            {
                if (text[i].ToString() == ",")
                {
                    flag = 1; break;
                }
                else
                {
                    flag = 0;
                }
            }
            if (flag == 0)
            {
                textBox1.Text = textBox1.Text + ",";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0)
            {
                result = (a * float.Parse(textBox1.Text)) / 100;
                textBox1.Text = result.ToString();
               
            }

        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0)
            {
                a = (float)Math.Sqrt(double.Parse(textBox1.Text));
                textBox1.Text = a.ToString();
                
            }
        }

        private void button23_Click(object sender, EventArgs e)
        {
            const string name = "WindowsFormsApp1";

            string ExePath = System.Windows.Forms.Application.ExecutablePath;
            RegistryKey reg;
            reg = Registry.CurrentUser.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run\\");
            reg.SetValue(name, ExePath);      
    }

        private void button24_Click(object sender, EventArgs e)
        {
            const string name = "WindowsFormsApp1";
            string ExePath = System.Windows.Forms.Application.ExecutablePath;
            RegistryKey reg;
            reg = Registry.CurrentUser.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run\\");
            reg.DeleteValue(name);
        }

        private void calculate()
        {
            switch (count)
            {
                case 0:
                    result = a;
                    break;
                case 1:
                    result += a;
                    break;
                case 2:
                    result -= a;
                    break;
                case 3:
                    result *= a;
                    break;
                case 4:
                    if (a == 0)
                    {
                        MessageBox.Show("Деление на ноль невозможно");
                    }
                    else
                        result /= a;
                    break;

                default:
                    break;
            }
            count = 111;
        }
    }
}
