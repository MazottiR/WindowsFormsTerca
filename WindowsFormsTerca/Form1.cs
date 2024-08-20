using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsTerca
{
    public partial class Form1 : Form
    {
        double total;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nome = textBox1.Text;

            double total2;

            double qntd = double.Parse(textBox2.Text);
            double valor = double.Parse(textBox3.Text);

            total2 = Convert.ToDouble(valor) * Convert.ToDouble(qntd);

            textBox4.Text += nome + " / " + "R$" + Convert.ToString(total2) + "\r\n";
                

            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            total = 0;
            label5.Text = total.ToString("C");

            textBox4.Clear();
        }
    }
}
