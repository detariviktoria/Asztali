using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2025._01._31._FormAlapok
{
    public partial class Csinald : Form
    {
        public Csinald()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //items egy osszetett szerkezet amibe beletettük az elemeket 
            MuveletCombo.Text = ""+ MuveletCombo.Items[0];
        }

        private void szinezoBox_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Aqua;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //numericUpDown1.Value + numericUpDown2.Value
            decimal szam = Szamitas(numericUpDown1.Value, numericUpDown2.Value);
            label2.Text = szam.ToString();
        }

        private decimal Szamitas(decimal n1, decimal n2)
        {
            decimal szam = 0;
            string c = MuveletCombo.Text;
            if (c == "*")
            {
                szam = n1 * n2;
            }
            else if (c == "+")
            {
                szam = n1 + n2;
            }
            else if (c == "/")
            {
                szam = n1 / n2;
            }
            else if(c == "-")
            {
                szam = n1 - n2;
            }
            else if(c == "maradek")
            {
                szam = n2-((n2 - n1)*n1);
            }
            else if(c== "hatvany")
            {
                szam = (decimal)Math.Pow((double)n1, (double) 2);
            }
            return szam;

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            this.BackColor = Color.Blue;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            this.BackColor = Color.Red;
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            this.BackColor = Color.Green;
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            foreach (var item in this.Controls)
            {
                item.Equals(this);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            var item = listBox1.Items.Contains(textBox1.Text);
            if(item)
                listBox1.Items.Add(textBox1.Text);

        }
    }
}
