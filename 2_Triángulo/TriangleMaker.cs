using System;

using System.Drawing;

using System.Windows.Forms;


namespace _2_Triángulo
{
    public partial class mainWindow : Form
    {

        Graphics gp;
        Point[] points;

        public mainWindow()
        {
            InitializeComponent();
            gp = triangleViewer.CreateGraphics();

        }


        //TO SHOW THE RESULTS OF THE NEW TRIANGLE
        private void button1_Click(object sender, EventArgs e)
        {
            checkBox.Checked = false;
            gp.Clear(Color.White);

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
            gp.Clear(Color.White);
            triVieLabel.Text = "";
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

        //TO DRAW THE TRIANGLE GENERATED
        private void drawButton_MouseClick(object sender, MouseEventArgs e)
        {
            if (checkBox.Checked)
            {

                int a = int.Parse(textBox1.Text)*3;
                int b = int.Parse(textBox2.Text)*3;
                int c = int.Parse(textBox3.Text)*3;

                int x = ((c * c) - (b * b) - (a*a)) / (-2 * a);
                int y = (int)Math.Sqrt((b * b) - Math.Pow(((c * c) - (b * b) - (a * a)) / (-2 * a), 2));

                //TO GENERATE THE TRIANGLE INSIDE THE PANEL
                if ( x < 0 )
                {
                    x = -x;
                }
                if ( y < 0 )
                {
                    y = -y;
                }

                Pen blackPen = new Pen(Color.Black, 3);
                int auxiliar = 50;
                gp.DrawLine(blackPen, new Point(0+auxiliar, 0 + auxiliar), new Point(a + auxiliar, 0 + auxiliar));
                gp.DrawLine(blackPen, new Point(a + auxiliar, 0 + auxiliar), new Point(x + auxiliar, y + auxiliar));
                gp.DrawLine(blackPen, new Point(x + auxiliar, y + auxiliar), new Point(0 + auxiliar, 0 + auxiliar));

                points = new[] { new Point(0 + auxiliar, 0 + auxiliar), 
                                 new Point(a + auxiliar, 0 + auxiliar),
                                 new Point(x + auxiliar, y + auxiliar)
                                };

                triVieLabel.Text = "TRIÁNGULO RESULTANTE";
            }
        }


        //TO FILL THE TRIANGLE DRAWN
        private void fillButton_Click(object sender, EventArgs e)
        {
            if (checkBox.Checked)
            {
                ColorDialog colorDialog = new ColorDialog();
                colorDialog.ShowDialog();
                SolidBrush sb = new SolidBrush(colorDialog.Color);
                gp.FillPolygon(sb, points);
            }
        }
    }
}
