using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cotizaciones.Control;

namespace Cotizaciones
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float _precio;
            int _cantidad;

            if (!float.TryParse(this.precio.Text, out _precio) || !int.TryParse(this.cantidad.Text, out _cantidad))
            {
                MessageBox.Show("Precio y Cantidad deben ser números válidos.");
                return;
            }

            if (_precio < 0 || _cantidad < 0)
            {
                MessageBox.Show("Precio y Cantidad deben ser números válidos.");
                return;
            }

            Controlador.Cotizar(_precio, _cantidad);
        }
    }
}
