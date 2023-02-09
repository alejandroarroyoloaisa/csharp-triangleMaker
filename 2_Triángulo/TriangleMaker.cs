using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2_Triángulo
{
    public partial class mainWindow : Form
    {
        public mainWindow()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "")
            {

                float a = float.Parse(textBox1.Text);
                float b = float.Parse(textBox2.Text);
                float c = float.Parse(textBox3.Text);

                if ( a > 0 && b > 0 && c > 0 )
                {
                    if ( a + b > c && a + c > b && c + b > a )
                    {
                        //SI ES EQUILÁTERO
                        if (a == b && b == c)
                        {
                            checkBox.Checked = true;
                            textBox6.Text = "Equilátero";

                            float perimetro = a + b + c;
                            textBox4.Text = "" + perimetro;

                            double area = Math.Sqrt(perimetro * (perimetro - a) * (perimetro - b) * (perimetro - c));
                            textBox5.Text = "" + area;
                        }
                        ////SI ES ESCALENO
                        else if (a != b && a != c && b != c)
                        {

                            checkBox.Checked = true;
                            textBox6.Text = "Escaleno";

                            float perimetro = a + b + c;
                            textBox4.Text = "" + perimetro;

                            double area = Math.Sqrt(perimetro * (perimetro - a) * (perimetro - b) * (perimetro - c));
                            textBox5.Text = "" + area;
                        }
                        ////SI ES ISOSCELES
                        else if (((a == b) && (a != c)) || ((a == c) && (a != b)) || ((b == c) && (b != a)))
                        {
                            checkBox.Checked = true;
                            textBox6.Text = "Isósceles";

                            float perimetro = a + b + c;
                            textBox4.Text = "" + perimetro;

                            double area = Math.Sqrt(perimetro * (perimetro - a) * (perimetro - b) * (perimetro - c));
                            textBox5.Text = "" + area;
                        }
                    }
                }
            }
        }

        //BOTÓN DE LIMPIAR LA PANTALLA DE LA APLICACIÓN
        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            checkBox.Checked = false;
        }


        //BOTON DE CERRAR LA APLICACIÓN
        private void leaveButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //SOLO ACEPTAR NUMEROS, COMA Y OPERACIONES DE CONTROL EN LA CAJA DE TEXTO
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (e.KeyChar == ',')
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        //SOLO ACEPTAR NUMEROS, COMA Y OPERACIONES DE CONTROL EN LA CAJA DE TEXTO
        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (e.KeyChar == ',')
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        //SOLO ACEPTAR NUMEROS, COMA Y OPERACIONES DE CONTROL EN LA CAJA DE TEXTO
        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (e.KeyChar == ',')
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
    }
}
