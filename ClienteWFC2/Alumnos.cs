using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ClienteWFC2
{
    public partial class Alumnos : Form
    {
        private object textbox1;

        public Alumnos()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var x = Convert.ToInt32(txtIdentificacion.Text);
            using (ServiceConsumoDatos2.Service1Client client = new ServiceConsumoDatos2.Service1Client())
            {
                var alumno = client.GetObtenerAlumno(x);
                var nombre = (textBox1.Text = alumno.Nombre);
                var Ap = (textBox2.Text = alumno.AP_Paterno);
                var Am = (textBox3.Text = alumno.AP_Materno);
                var prom = (textBox4.Text = alumno.Especialidad);

            }
        }
    }
}
