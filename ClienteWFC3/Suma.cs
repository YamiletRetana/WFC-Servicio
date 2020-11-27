using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ClienteWFC3
{
    public partial class Suma : Form
    {
        public Suma()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var x = Convert.ToInt32(txtIdentificador.Text);
            using (ServiceConsumoDatos3.Service1Client client = new ServiceConsumoDatos3.Service1Client())
            {
                var numero = client.GetObtenerSuma(x);
                var num1 = (textBox2.Text = numero.Numero1);
                var num2 = (textBox3.Text = numero.Numero2);
                var num3 = (textBox4.Text = numero.Numero3);

                //int a = Convert.ToInt32(numero.Numero1);
                //int b = Convert.ToInt32(numero.Numero2);
                //int c = Convert.ToInt32(numero.Numero3);

                //int suma = a + b + c;
                //var resultado = (textBox5.Text = suma.ToString());


            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var x = Convert.ToInt32(txtIdentificador.Text);
            using (ServiceConsumoDatos3.Service1Client client = new ServiceConsumoDatos3.Service1Client())
            {
                var numero = client.GetObtenerSuma(x);
                int a = Convert.ToInt32(numero.Numero1);
                int b = Convert.ToInt32(numero.Numero2);
                int c = Convert.ToInt32(numero.Numero3);

                int suma = a + b + c;
                var resultado = (textBox5.Text = suma.ToString());

                //ServiceConsumoDatos4.Service1Client client = new ServiceConsumoDatos4.Service1Client();
                //textBox1.Text = client.conversionDolares(Convert.ToDouble(textBox2.Text)).ToString();

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ServiceConsumoDatos3.Service1Client service = new ServiceConsumoDatos3.Service1Client();
            textBox5.Text = service.GetSuma(Convert.ToInt32(textBox2.Text), Convert.ToInt32(textBox3.Text), Convert.ToInt32(textBox4.Text)).ToString();
        }
    }
}
