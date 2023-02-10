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
    public partial class Ejercicio7 : Form
    {
        public Ejercicio7()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //PARA LIMPIAR EL LISTBOX DESPUES DE CADA CLICK
            listBox1.Items.Clear();

            //MATRIZ
            //declaramos una matriz ponemos coma dentro corchetes y despues ponemos primero las filas y segundo valor columnas
            int[,] matriz1 = new int[3, 3] { 
                                             { 3, 6, 3 }, 
                                             { 6, 9, 7 }, 
                                             { 8, 9, 4 } 
                                           };


            //MATRIZ LLENADA con dimensiones ingresadas por el usuario
            Random random = new Random();

            int valorFila = Convert.ToInt32(filastextBox.Text);
            int valorColumna = Convert.ToInt32(columnastextBox.Text);

            int[,] matriz2 = new int[valorFila, valorColumna];

            //Llenando la matriz ASIGNANDO
            //FILAS recorrer indices
            for (int fila = 0; fila < matriz2.GetLength(0); fila++) //.getlength porqueno conocemos el tamaño
            {
                //COLUMNAS recorre indices
                for (int columna = 0; columna < matriz2.GetLength(1); columna++) //la dimension seria la 1 para la columna
                {
                    //Llenar la matriz con valores aleatorios
                    matriz2[fila, columna] = random.Next(1, 100); //aqui es asignarles valores aleatorios
                }
            }

            //MOSTRANDO LOS VALORES DE LA MATRIZ EN EL LISTBOX
            for (int fila = 0; fila < matriz2.GetLength(0); fila++) 
            {
                for (int columna = 0; columna < matriz2.GetLength(1); columna++) //la dimension seria la 1 para la columna
                {
                    //Items es propiedad, y add es la funcion       concatenamos los idices y luego los valores a mostrar
                    listBox1.Items.Add("La posición : [" + fila + "," + columna + "] = " + matriz2[fila, columna]);
                }
            }

            textBox1.Text = matriz2.GetLength(0).ToString() + "x" + matriz2.GetLength(1).ToString();
        }
    }
}
