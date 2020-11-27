using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ClienteWCF4
{
    public partial class Conversion : Form
    {
        public Conversion()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                ServiceConsumoDatos4.Service1Client client = new ServiceConsumoDatos4.Service1Client();
                textBox1.Text = client.conversionDolares(Convert.ToDouble(textBox2.Text)).ToString();
            }
        }
    }
}
