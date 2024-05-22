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
    public partial class formPrincipal : Form
    {
        public formPrincipal()
        {
            InitializeComponent();
        }

        private void perfilPersonaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (var item in Application.OpenForms)  //esto es para evitar abrir nueva ventanas ya abiertas
            {
                if (item.GetType() == typeof(Form1))
                {
                    MessageBox.Show("ya hay una ventana abierta");
                    return;
                }
            }
            Form1 ventana = new Form1();
            ventana.Show();
            ventana.MdiParent = this;
        }
    }
}
