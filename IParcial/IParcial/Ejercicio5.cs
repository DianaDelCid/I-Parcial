using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IParcial
{
    public partial class Ejercicio5 : Form
    {
        public Ejercicio5()
        {
            InitializeComponent();
        }

        private void HornearButton_Click(object sender, EventArgs e)
        {
            //Llamamos las funciones
            HornearPizza();
            MessageBox.Show("Mensaje Normal");
        }

        private void HornearPizza()
        {
            //Detiene la aplicacion y en ()<-dentro pasomos los milisegundos
            //Esto es emular
            Thread.Sleep(10000); 
        }

        //Metodo Asincrono
        private Task HornearPizzaAsync()
        {
            //emula los mismo segundos con la clase Task con .DeLay
            return Task.Delay(10000);
        }

        private void HornearAzincronoButton_Click(object sender, EventArgs e)
        {
            //Llamamos la funcion 
            HornearPizzaAsync();
            MessageBox.Show("Mensaje Asincrono");
        }

        private async void CalcularButton_Click(object sender, EventArgs e)
        {
            decimal num1 = Convert.ToDecimal(Numero1TextBox.Text);
            decimal num2 = Convert.ToDecimal(Numero2TextBox.Text);

            decimal total = await SumarAsync(num1, num2);
            MessageBox.Show($"La Suma es: {total}");
        }

        //Metodo asincrono que permita calcular la suma de los dos textbox
        private async Task<decimal> SumarAsync(decimal n1, decimal n2)
        {
            decimal suma = await Task.Run(() =>
            {
                return n1 + n2;
            });
            return suma;
        }
    }
}
