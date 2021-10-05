using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace looping
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for(int i = 1; i<101; i++)
            {
                listBox1.Items.Add(i);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for(int i = 100; i>0; i--)
            {
                listBox2.Items.Add(i);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int i = 1;
            while (i < 101)
            {
                listBox3.Items.Add(i);
                i+=5;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int i = 100;
            do
            {
                listBox4.Items.Add(i);
                i-=10;
            } while (i > 0);
        }
    }
}
