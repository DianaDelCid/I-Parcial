using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IParcial
{
    public partial class Ejercicio1 : Form
    {
        public Ejercicio1()
        {
            InitializeComponent();
        }

        decimal sumaTotal = 0;

        private void SumarButton_Click(object sender, EventArgs e)
        {
            //Variables
            decimal numero1 = Convert.ToDecimal(Numero1TextBox.Text);
            decimal numero2 = Convert.ToDecimal(Numero2TextBox.Text);

            //decimal resultado = numero1 + numero2;
            //Segunda manera> accediendo desde las propiedades
            //decimal resultado = Convert.ToDecimal(Numero1TextBox.Text) + Convert.ToDecimal(Numero2TextBox.Text);

            //string valor1 = Numero1TextBox.Text;

            //ResultadoLabel.Text = Convert.ToString(resultado);

            //MessageBox.Show("La suma es: " + resultado);

            //PARA LLAMAR PROCEDIMIENTO
            //Sumar(numero1, numero2);

            //PARA LLAMAR LA FUNCION
            sumaTotal = Sumatoria(numero1, numero2);
            MessageBox.Show("La suma es: " +sumaTotal, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }


        //Procedimiento
        private void Sumar(decimal num1, decimal num2)
        {
            sumaTotal = num1 + num2;
        }

        //Función
        private decimal Sumatoria(decimal num1, decimal num2)
        {
            //Forma para hacer la funcion con variables
            //decimal n1, n2, suma;
            //n1 = num1;
            //n2 = num2;

            //suma = n1 + n2;

            //return suma;

            //Forma mas sencilla si no hacemos tantas lineas de codigo
            return num1 + num2;
        }

    }
}
