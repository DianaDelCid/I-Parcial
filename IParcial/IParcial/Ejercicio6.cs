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
    public partial class Ejercicio6 : Form
    {
        public Ejercicio6()
        {
            InitializeComponent();
        }

        private void ArreglosButton_Click(object sender, EventArgs e)
        {
            //Vectores
            //Inicializamos vector 
            int[] vector = new int[5]; //almacena 5 valores 

            //Asignamos
            vector[0] = 10; //asigna un valor a la posicion o indice 0
            vector[1] = 20;
            vector[2] = 30;
            vector[3] = 40;
            vector[4] = 50;

            //Otra manera,pero esta se declara y se asigna de directamente
            int[] vector2 = new int[5] {10, 20, 30, 40, 50};

            //no colocado el tamaño del vector pero este detecta el tamano segun los valores asignados
            int[] vector3 = new int[] { 10, 20, 30, 40, 50, 60 };

            //esta manera declara y asigna de un solo sin new int
            int[] vector4 = { 10, 20, 30, 40, 50 };

            //Vector de tipo String
            String[] vector5 = { "Maria", "Marta", "Juan", "Luis", "Esteban" };

            //MOSTRAR EL VECTOR EN PANTALLA EN EL LISTBOX
            for (int i = 0; i < vector5.Length; i++)
            {
                listBox1.Items.Add(vector5[i]); //Agregamos al listBox los valores en cada una de las posiciones
            }

            //SICLO UN POCO MAS AVANZADO
            foreach (String item in vector5)
            {
                comboBox1.Items.Add(item); //Agregamos al comobox
            }
        }

       
    }
}
