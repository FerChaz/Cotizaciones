using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cotizaciones.Modelo
{
    class Cotizacion
    {
        public int numeroID;
        public DateTime fechaHora;
        public string codigoVendedor;
        public int cantidadUnidadesCotizadas;
        public float resultadoCotizacion;

        public Prenda prendaCotizada;

        public static Cotizacion Cotizar(Prenda prendaACotizar, int cantidadACotizar, float precio, string codigoVendedor, int cantidadCotizacionesVendedor)
        {
            Cotizacion nuevaCotizacion = new Cotizacion();

            nuevaCotizacion.codigoVendedor = codigoVendedor;
            nuevaCotizacion.numeroID = cantidadCotizacionesVendedor + 1;
            nuevaCotizacion.fechaHora = DateTime.Now;

            
            nuevaCotizacion.cantidadUnidadesCotizadas = cantidadACotizar;

            float precioCotizado = 0;
            if (prendaACotizar is Camisa)
            {
                precioCotizado = Camisa.CotizacionCamisa((Camisa)prendaACotizar, precio);
                nuevaCotizacion.prendaCotizada = (Camisa)prendaACotizar;
            } else
            {
                precioCotizado = Pantalon.CotizacionPantalon((Pantalon)prendaACotizar, precio);
                nuevaCotizacion.prendaCotizada = (Pantalon)prendaACotizar;
            }

            nuevaCotizacion.resultadoCotizacion = precioCotizado * cantidadACotizar;

            return nuevaCotizacion;
        }
    }
}
