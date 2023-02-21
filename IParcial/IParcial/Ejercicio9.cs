using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using POO; //AGREGARLO para acceder a la clase Coche

namespace IParcial
{
    public partial class Ejercicio9 : Form
    {
        public Ejercicio9()
        {
            InitializeComponent();
            MarcaTextBox.Focus(); //activa el focus en la caja marca 
        }

        //declarar el objeto global para usarlo global
        Coche miCoche = null; //null significa que no esta instanciado esta nulo, no tiene nada
        
        //lista de objetos de la clase coche
        List<Coche> listaCoches = new List<Coche>(); //para declarar una lista de objetos


        private void button1_Click(object sender, EventArgs e)
        {
            ////Instanciar objeto
            ////con constructor vacio
            //Coche miCoche = new Coche(); //aqui instaciamos y no debe llevar la primera letra mayuscula

            ////con constructor 2 parametros y asi mismo pasamos la marca y modelo
            //Coche miCoche2 = new Coche("Toyota", "22");

            //Declarar variables 
            string marca = MarcaTextBox.Text;
            string modelo = ModeloTextBox.Text;
            decimal precio;
            //condicion si usuario no ingresa valor de pecrio
            if (PrecioTextBox.Text == string.Empty)
            {
                precio = 0; //asigna el valor de 0
            }
            else
            {
                precio = Convert.ToDecimal(PrecioTextBox.Text);
            }

            //operador ternario es codigo en una sola linea
            int km = KilometrosTextBox.Text == string.Empty ? 0 : Convert.ToInt32(KilometrosTextBox.Text);

            miCoche = new Coche(); //Instanciamos la clase coche con constructor vacio

            //asignado a las propiedades las variables 
            miCoche.Marca = marca; //aqui utilizamos el metodo set
            miCoche.Modelo = modelo;
            miCoche.Precio = precio;   
            miCoche.Kilometros = km;

            //MessageBox.Show("Objeto Coche -> Marca: "+ miCoche.Marca + " Modelo: " + miCoche.Modelo); //aqui el metodo get de marca y modelo

            listaCoches.Add(miCoche); //agrega a la lista los datos de la clase miCoche
            CochesDataGridView.DataSource = null; //limpiamos el data y luego asignamos con lo de abajo
            CochesDataGridView.DataSource = listaCoches; //pasamos la lista todo lo almacenado en el datagripview

            LimpiarControles(); //llamamos el procedimiento
            MarcaTextBox.Focus(); //para que el focus vuelva a la caja de marca
        }

        //procedimiento para limpiar las cajas y es tipo void porque no va a devolver nada
        private void LimpiarControles()
        {
            MarcaTextBox.Clear();
            ModeloTextBox.Text = string.Empty;
            PrecioTextBox.Text = "";
            KilometrosTextBox.Clear();
        }

        //evento al momento de iniciar el formulario
        private void Ejercicio9_Load(object sender, EventArgs e)
        {
            MarcaTextBox.Focus(); //activa el focus en la caja marca 
        }
    }
}
