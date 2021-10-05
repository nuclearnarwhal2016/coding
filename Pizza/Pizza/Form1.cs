using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizza
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();

        }
        public void clear()
        {
            //clears the listbox and sets all the buttons to false
            listBox1.Items.Clear();
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
            checkBox5.Checked = false;
            checkBox6.Checked = false;
            checkBox7.Checked = false;
            checkBox8.Checked = false;
            checkBox9.Checked = false;
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
        }

        public double price = 0;
        public double sum = 0;
        public double prevsum;
        public bool chek = false;

        private void Form1_Load(object sender, EventArgs e)
        {
            clear();
        }
     
        public void typeadd(string type, bool chek)
        {
            //adds the type of pizza to the top of the listBox
            if (chek == true)
            {
                listBox1.Items.Insert(0,type);
                prevsum = sum;
                listBox1.Items.Remove(prevsum);
                sum += price;
                listBox1.Items.Add(sum);

            }
            if (chek == false)
            {
                listBox1.Items.Remove(type);
                prevsum = sum;
                listBox1.Items.Remove(prevsum);
                sum -= price;
                listBox1.Items.Add(sum);
            }
        }
      
        public void listadd(string type, bool chek)
        {
            //adds the toppings to the listBox
            if (chek == true)
            {
                listBox1.Items.Add(type);
                prevsum = sum;
                listBox1.Items.Remove(prevsum);
                sum += price;
                listBox1.Items.Add(sum);
         
            }
            if (chek == false)
            {
                listBox1.Items.Remove(type);
                prevsum = sum;
                listBox1.Items.Remove(prevsum);
                sum -= price;
                listBox1.Items.Add(sum);
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            price = 15.00;
            string type = "Neopolitan - $15";
         
            
            if (radioButton1.Checked)
            {
                chek = true;
            }
            else
            {
                chek = false;
            }
            typeadd(type, chek);
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            price = 12.00;
            string type = "Sicilian - $12";
            if (radioButton2.Checked)
            {
                chek = true;
            }
            else
            {
                chek = false;
            }
            typeadd(type, chek);
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            price = 16.00;
            string type = "Margarita - $16";
            if (radioButton3.Checked)
            {
                chek = true;
            }
            else
            {
                chek = false;
            }
            typeadd(type, chek);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            price = 1.50;
            string type = "Pepperoni - $1.50";
            if (checkBox1.Checked)
            {
                chek = true;
            }
            else
            {
                chek = false;
            }
            listadd(type, chek);
        }
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            price = 1.75;
            string type = "Pineapple - $1.75";
            if (checkBox2.Checked)
            {
                chek = true;
            }
            else
            {
                chek = false;
            }
            listadd(type, chek);
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            price = 1.25;
            string type = "Extra Cheese - $1.25";
            if (checkBox3.Checked)
            {
                chek = true;
            }
            else
            {
                chek = false;
            }
            listadd(type, chek);
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            price = 1.00;
            string type = "Olives - $1";
            if (checkBox4.Checked)
            {
                chek = true;
            }
            else
            {
                chek = false;
            }
            listadd(type, chek);
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            price = 1.25;
            string type = "Italian Sausage - $1.25";
            if (checkBox5.Checked)
            {
                chek = true;
            }
            else
            {
                chek = false;
            }
            listadd(type, chek);
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            price = 1.50;
            string type = "Salami - $1.50";
            if (checkBox6.Checked)
            {
                chek = true;
            }
            else
            {
                chek = false;
            }
            listadd(type, chek);
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            price = 2.00;
            string type = "Ham - $2";
            if (checkBox7.Checked)
            {
                chek = true;
            }
            else
            {
                chek = false;
            }
            listadd(type, chek);
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            price = 2.25;
            string type = "Bacon - $2.25";
            if (checkBox8.Checked)
            {
                chek = true;
            }
            else
            {
                chek = false;
            }
            listadd(type, chek);
        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {
            price = 1.00;
            string type = "Green Peppers - $1";
            if (checkBox9.Checked)
            {
                chek = true;
            }
            else
            {
                chek = false;
            }
            listadd(type, chek);
        }
     
        private void button1_Click(object sender, EventArgs e)
        {
            clear();

        }

        
    }
}
