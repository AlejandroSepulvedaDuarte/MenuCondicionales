using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MenuCondicionales
{
    public partial class Ejercicio1 : Form
    {
        public Ejercicio1()
        {
            InitializeComponent();
        }

        private void btnEvaluar_Click(object sender, EventArgs e)
        {
            double numero1, numero2;
            numero1 = double.Parse(txtNumero1.Text);
            numero2 = double.Parse(txtNumero2.Text);

            if (numero1 > numero2) {
                lblrespuesta.Text = "El primer número es el mayor";
            }
            else if(numero2 > numero1) 
            {
                lblrespuesta.Text = "El segundo número es el mayor";
            }
            else
            {
                lblrespuesta.Text = "Los números son iguales";
            }

            lblrespuesta.Visible = true;
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
            this.Dispose();

        }
    }
}
