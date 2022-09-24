using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace passgen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random random = new Random();

            if (comboBox1.Text == "1) 6-10")
            {
                string alpha = "qwertyuiopasdfghjklzxcvbnm0123456789";
                //make lenght of pass and pre_pass list
                int lenght = random.Next(6, 10);
                List<string> pre_pass = new List<string>();
                
                //make cycle for generating pass
                for (int i = 0; i < lenght; i++)
                {
                    pre_pass.Add(random.Next(alpha[0], alpha[35]).ToString());
                }
                textBox1.Text = pre_pass.ToString();
            }
            if (comboBox1.Text == "2) 11-15")
            {
                textBox1.Text = "2";
            }
            if(comboBox1.Text== "3) 16-20")
            {
                textBox1.Text = "3";
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }

  
}
