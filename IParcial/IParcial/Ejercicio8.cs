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
    public partial class Ejercicio8 : Form
    {
        public Ejercicio8()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //llamamos la funcion con los parametros de valor inicial y final
            RecorrerDeUnoEnUno(1, 100);
        }

        //FUNCION RECURSIVA
        private void RecorrerDeUnoEnUno(int valInicia, int valFinal)
        {
            // en parentesisi ese va a hacer el valor inicial a mostrar
            listBox1.Items.Add(valInicia);

            //condicion para que no sea infinito y termine al valor final
            if (valInicia < valFinal) //cuando el valor sea menor a 100 va a seguir hasta llegar a 100 < 100 y termina
            {
                //para que sea recursiva llamamos la misma funcion
                //y ponemos valInicial +1 porque cuando se llama va a sumar 1 al valor inicial y asi susesivamente
                //porque se vuelve a llamar la funcion
                RecorrerDeUnoEnUno(valInicia + 1, valFinal);
            }

        }
    }
}
