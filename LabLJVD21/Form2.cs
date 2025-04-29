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
    public partial class Form2 : Form  
    {
        static int seleccionFila;
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            object[] registrarDatos =
           {
                    textBox1.Text,
                    textBox2.Text,
                    textBox3.Text,
                    textBox4.Text,
                    textBox5.Text,
                    textBox6.Text,
                    textBox7.Text,
                    textBox8.Text,
                    textBox9.Text,
                    textBox10.Text,

            };
            dataGridView1.Rows.Add(registrarDatos);
            MessageBox.Show("Registro correcto");

            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
            textBox9.Text = "";
            textBox10.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (seleccionFila >= 0)
                    dataGridView1.Rows.RemoveAt(seleccionFila);
                else
                    MessageBox.Show("No hay citas", "Colegio SDB", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception)
            {
                MessageBox.Show("No hay citas ", "Colegio SDB", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form3 Creditos = new Form3();
            Creditos.ShowDialog();

        }
    }
}
