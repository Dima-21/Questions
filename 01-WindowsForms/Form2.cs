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
    public partial class Form2 : Form
    {
        List<Question> q = new List<Question>();
        int num = 0;
        int correctanswers;
        public Form2()
        {
            InitializeComponent();
            q.Add(new Question("2+2*2=", 2, "2", "4", "6", "8"));
            q.Add(new Question("Сколько байтов занимает int?", 1, "8", "4", "3", "6"));
            q.Add(new Question("Сколько лет Чумаку?", 3, "18", "27", "25", "26"));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button1.Visible = true;
            button2.Visible = false;
            groupBox1.Visible = true;
            button1_Click(sender, e);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked && q[num--].correct == 1)
                correctanswers++;
            else if (radioButton1.Checked && q[num--].correct == 2)
                correctanswers++;
            else if (radioButton1.Checked && q[num--].correct == 3)
                correctanswers++;
            else if (radioButton1.Checked && q[num--].correct == 4)
                correctanswers++;
            groupBox1.Text = q[num].question;
            radioButton1.Text = q[num].answers[0];
            radioButton2.Text = q[num].answers[1];
            radioButton3.Text = q[num].answers[2];
            radioButton4.Text = q[num].answers[3];
            if (q.Capacity == num)
                Finish();
            else
                num++;
        }
        private void Finish()
        {
            MessageBox.Show($"Правильных ответов: {correctanswers}");
        }

     
    }
}
