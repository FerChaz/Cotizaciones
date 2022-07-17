using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cotizaciones.Modelo;

namespace Cotizaciones.Control
{
    class Controlador
    {
        static Form1 ventana;
        public static void InicializarVentana(Tienda tienda, Vendedor vendedor)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            ventana = new Form1();
            ventana.Controls["nombreTienda"].Text = tienda.nombre;
            ventana.Controls["direccionTienda"].Text = tienda.direccion;
            ventana.Controls["nombreVendedor"].Text = vendedor.nombre + " " + vendedor.apellido;
            ventana.Controls["idVendedor"].Text = vendedor.codigoVendedor;

            Application.Run(ventana);
        }

        public static void Cotizar()
        {
            string calidad = ((RadioButton)ventana.Controls["standard"]).Checked ? "standard" : "premium";
            string prenda = ((RadioButton)ventana.Controls["camisa"]).Checked ? "camisa" : "pantalon";
            bool esMao = false;
            bool esMangaCorta = false;
            bool esChupin = false;
            if (((CheckBox)ventana.Controls["cuelloMao"]).Checked)
            {
                if (prenda == "pantalon")
                {
                    MessageBox.Show("Los pantalones no pueden tener CUELLO MAO.");
                    return;
                }
                esMao = true;
            }
            if (((CheckBox)ventana.Controls["mangaCorta"]).Checked)
            {
                if (prenda == "pantalon")
                {
                    MessageBox.Show("Los pantalones no pueden tener MANGA CORTA.");
                    return;
                }
                esMangaCorta = true;
            }
            if (((CheckBox)ventana.Controls["chupin"]).Checked)
            {
                if (prenda == "camisa")
                {
                    MessageBox.Show("Las camisas no pueden ser CHUPINES.");
                    return;
                }
                esChupin = true;
            }


            if (prenda == "camisa")
            {

            }
        }
    }
}
