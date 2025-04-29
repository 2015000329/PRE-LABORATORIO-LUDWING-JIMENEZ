using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabLJVD21
{
    public partial class Form1 : Form
    {
        int codigo = 1;
        static int SeleccionFila;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "12345")
            {
                MessageBox.Show("Contraseña Correcta");
                Form2 form2 = new Form2();
                form2.ShowDialog();
            }
            else
            {
                MessageBox.Show("Contraseña Incorrecta");
                textBox1.Clear();
            }
        }
    }
}
