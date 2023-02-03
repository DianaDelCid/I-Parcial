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
    public partial class Ejercicio4 : Form
    {
        public Ejercicio4()
        {
            InitializeComponent();
        }

        private void EjecutarButton_Click(object sender, EventArgs e)
        {
            DateTime fecha = FechaDateTimePicker.Value;

            DiaTextBox.Text = fecha.Day.ToString();
            //para devolver el mes:
            //MesTextBox.Text = fecha.Month.ToString();

            //de esta manera entramos a los formateadores del toString
            MesTextBox.Text = fecha.ToString("MMMM");
            AñioTextBox.Text = fecha.Year.ToString();
            SemanaTextBox.Text = fecha.ToString("dddd");

            int numeroDias = Convert.ToInt32(DiasTextBox.Text);
            DateTime fechaActual = DateTime.Now;

            CitaTextBox.Text = fechaActual.AddDays(numeroDias).ToShortDateString();

            int diasresta = Convert.ToInt32(DiasRestarTextBox.Text);
            NuevaFechaTextBox.Text = fecha.AddDays(-diasresta).ToLongDateString();

            MessageBox.Show("La edad es: " + DevolverEdad(fecha), "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            DevolverEdad(fecha);
        }

        private int DevolverEdad(DateTime FechaNacimiento)
        {
            DateTime fechaActual = DateTime.Now;

            int edad = 0;

            if (FechaNacimiento >= fechaActual)
            {
                return 0;
            }
            else
            {
                edad = fechaActual.Year - FechaNacimiento.Year;
                if (FechaNacimiento.Month > fechaActual.Month)
                {
                    //es restar una unidad a la edad porque aun no llega el mes
                    --edad;
                    //edad = edad - 1;
                    //edad -= 1;
                }
                return edad;
            }

        }

    }
}
