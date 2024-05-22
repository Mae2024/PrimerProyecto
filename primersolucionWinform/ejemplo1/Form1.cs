using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejemplo1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("bienvenido capo");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string texto = textBox1.Text;
            lblsaludo.Text = "hola " + textBox1.Text;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string apell = textBox2.Text;
            lblsaludo2.Text = "tu apellido es " + textBox2.Text;
        }

    
    }
}
