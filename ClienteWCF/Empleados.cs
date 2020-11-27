using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ClienteWCF
{
    public partial class Empleados : Form
    {
        public Empleados()
        {
            InitializeComponent();
        }

        private void bntBuscar_Click(object sender, EventArgs e)
        {
            var i = txtIdentificacion.Text;
            using (ServiceConsumoDatos.Service1Client client = new ServiceConsumoDatos.Service1Client())
            {
                var persona = client.GetNumeroEmpleado(i);
                var nombre = persona.Nombre;
                var txtnom = (textBox1.Text = persona.Nombre);
                var txtapp = (textBox2.Text = persona.ApellidoP);
                var txtapm = (textBox3.Text = persona.ApellidoM);
                var txtpuesto = (textBox4.Text = persona.Puesto);
                var txtsalario = (textBox5.Text = persona.Salarario);
                MessageBox.Show("Actalizacion de datos Completada");

                //(textBox1.Text, textBox2.Text,textBox3.Text,textBox4.Text,textBox5.Text);
            }
            //p.Agregar(codigo.Text, nombre.Text, genero.Text, Convert.ToChar(clasificacion.Text), Convert.ToInt32(duracion.Text), director.Text)
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtIdentificacion.Clear();
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
           
        }
    }
}
