using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    public class Coche //colocar public
    {
        //ATRIBUTOS siempre colocarlos privados
        private string marca;
        private string modelo;
        //private decimal precio;

        //PROPIEDADES
        public string Marca
        {
            get { return marca; } // sirve para obtener, retorna lo que tiene el atributo marca
            set { marca = value; } // sirve para mandarle informacion es decir establecer  pasarle la marca
        }

        //otra manera de crear propiedades
        public string Modelo { get => modelo; set => modelo = value; }

        //otra manera pero esta el atributo se va agregar directamente como propiedad
        public decimal Precio { get; set; }
        public int Kilometros { get; set; }

        //CONSTRUCTORES
        //constructor vacio
        public Coche() { }

        //constructor con parametros
        public Coche(string _marca, string _modelo) 
        {
            Marca = _marca;
            Modelo = _modelo;
        }

        public Coche(string marca, string modelo, decimal precio, int kilometros) : this(marca, modelo)
        {
            Precio = precio;
            Kilometros = kilometros;
        }

        //METODOS O ACCIONES
        public string DevolverDatosBasicos()
        {
            return "Marca: " + Marca + "Modelo: " + Modelo + "Precio: " + Precio;
        }
    }
}
