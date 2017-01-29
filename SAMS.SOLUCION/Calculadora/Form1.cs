using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        bool secu = true;
        string operacion, borrado; 
        double numero1, numero2, resultados;
        //numeros de la calculadora 
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void num8_Click(object sender, EventArgs e)
        {
            if (secu == true)
            {
                Pantalla.Text = "";
                Pantalla.Text = "8";
                secu = false;
            }
            else
            {
                Pantalla.Text = Pantalla.Text + "8";
            }
        }

        private void num9_Click(object sender, EventArgs e)
        {
            if (secu == true)
            {
                Pantalla.Text = "";
                Pantalla.Text = "9";
                secu = false;
            }
            else
            {
                Pantalla.Text = Pantalla.Text + "9";
            }

        }

        private void num7_Click(object sender, EventArgs e)
        {
            if (secu == true)
            {
                Pantalla.Text = "";
                Pantalla.Text = "7";
                secu = false;
            }
            else
            {
                Pantalla.Text = Pantalla.Text + "7";
            }
        }

        private void num6_Click(object sender, EventArgs e)
        {
            if (secu == true)
            {
                Pantalla.Text = "";
                Pantalla.Text = "6";
                secu = false;
            }
            else
            {
                Pantalla.Text = Pantalla.Text + "6";
            }
        }

        private void num5_Click(object sender, EventArgs e)
        {
            if (secu == true)
            {
                Pantalla.Text = "";
                Pantalla.Text = "5";
                secu = false;
            }
            else
            {
                Pantalla.Text = Pantalla.Text + "5";
            }
        }

        private void num4_Click(object sender, EventArgs e)
        {
            if (secu == true)
            {
                Pantalla.Text = "";
                Pantalla.Text = "4";
                secu = false;
            }
            else
            {
                Pantalla.Text = Pantalla.Text + "4";
            }
        }

        private void num3_Click(object sender, EventArgs e)
        {
            if (secu == true)
            {
                Pantalla.Text = "";
                Pantalla.Text = "3";
                secu = false;
            }
            else
            {
                Pantalla.Text = Pantalla.Text + "3";
            }

        }

        private void num2_Click(object sender, EventArgs e)
        {
            if (secu == true)
            {
                Pantalla.Text = "";
                Pantalla.Text = "2";
                secu = false;
            }
            else
            {
                Pantalla.Text = Pantalla.Text + "2";
            }
        }

        private void num1_Click(object sender, EventArgs e)
        {
            if (secu == true)
            {
                Pantalla.Text = "";
                Pantalla.Text = "1";
                secu = false;
            }
            else
            {
                Pantalla.Text = Pantalla.Text + "1";
            }

        }

        private void retroceder_Click(object sender, EventArgs e)
        {
            int x = 0;
            borrado = Pantalla.Text;
            x = borrado.Length - 1;
            borrado = borrado.Substring(0, x);
            Pantalla.Text = borrado;
            if (Pantalla.Text == "")
            {
                Pantalla.Text = "0";
                secu = true;
            }
            if (Pantalla.Text == "-")
            {
                Pantalla.Text = "0";
                secu = true;
            }
        }

        private void cero_Click(object sender, EventArgs e)
        {
            if (Pantalla.Text == "0")
            {
                return;
            }
            else
            {
                Pantalla.Text = Pantalla.Text + "0";
            }

        }

        private void punto_Click(object sender, EventArgs e)
        {
            Pantalla.Text = Pantalla.Text + ".";
        }
        // aqui inicia los botones de operacion 
        private void sumar_Click(object sender, EventArgs e)
        {
            operacion = "+";
            numero1 = double.Parse(Pantalla.Text);
            secu = true;

        }

        private void restar_Click(object sender, EventArgs e)
        {
            operacion = "-";
            numero1 = double.Parse(Pantalla.Text);
            secu = true;

        }

        private void multiplicar_Click(object sender, EventArgs e)
        {
            operacion = "*";
            numero1 = double.Parse(Pantalla.Text);
            secu = true;

        }

        private void dividir_Click(object sender, EventArgs e)
        {
            operacion = "/";
            numero1 = double.Parse(Pantalla.Text);
            secu = true;

        }

        private void igual_Click(object sender, EventArgs e)
        {
            numero2 = double.Parse(Pantalla.Text);
            if (operacion == "+")
            {
                resultados = numero1 + numero2;
                Pantalla.Text = resultados.ToString();
                secu = true;
            }
            if (operacion == "-")
            {
                resultados = numero1 - numero2;
                Pantalla.Text = resultados.ToString();
                secu = true;
            }
            if (operacion == "*")
            {
                resultados = numero1 * numero2;
                Pantalla.Text = resultados.ToString();
                secu = true;
            }
            if (operacion == "/")
            {
                resultados = numero1 / numero2;
                Pantalla.Text = resultados.ToString();
                secu = true;
            }
        }

        private void borrar_Click(object sender, EventArgs e)
        {
            Pantalla.Text = "0";
            numero1 = 0;
            numero2 = 0;
            secu = true;


        }

        private void raiz_Click(object sender, EventArgs e)
        {
            numero1 = double.Parse(Pantalla.Text);
            resultados = Math.Sqrt(numero1);
            Pantalla.Text = resultados.ToString();
            secu = true;

        }

        private void cuadro_Click(object sender, EventArgs e)
        {
            numero1 = double.Parse(Pantalla.Text);
            resultados = numero1 * numero1;
            Pantalla.Text = resultados.ToString();
            secu = true;

        }

        private void sALIRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void aRCHIVOToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }  
        //fin de los numeros de la calculadora 
    }
}


