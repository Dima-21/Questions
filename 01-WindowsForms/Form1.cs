using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01_WindowsForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private bool Check()
        {
            if (textBox1.Text.Length == 0 || textBox2.Text.Length == 0 || !radioButton1.Checked && !radioButton2.Checked)
            {
                if (textBox1.Text.Length == 0)
                    label5.Visible = true;
                else
                    label5.Visible = false;
                if (textBox2.Text.Length == 0)
                    label6.Visible = true;
                else
                    label6.Visible = false;
                if (!radioButton1.Checked && !radioButton2.Checked)
                    label7.Visible = true;
                else
                    label7.Visible = false;
                return false;
            }

            return true;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (!Check())
                return;
            string mw = String.Empty;
            if (radioButton1.Checked)
                mw = radioButton1.Text;
            else if (radioButton2.Checked)
                mw = radioButton2.Text;

            StringBuilder category = new StringBuilder(100);
            if (!checkBox1.Checked && !checkBox2.Checked && !checkBox3.Checked && !checkBox4.Checked)
                category.Append("у тебя нет категорий");
            else
            {
                category.Append("у тебя есть такие категории:");
                if (checkBox1.Checked)
                    category.Append($"{checkBox1.Text} ");
                if (checkBox2.Checked)
                    category.Append($"{checkBox2.Text} ");
                if (checkBox3.Checked)
                    category.Append($"{checkBox3.Text} ");
                if (checkBox4.Checked)
                    category.Append($"{checkBox4.Text} ");
            }
            MessageBox.Show($"Привет, {textBox1.Text} {textBox2.Text}, ты {mw}, {category}.");
        }
    }
}
