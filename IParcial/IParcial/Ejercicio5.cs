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
        }

    }
}
