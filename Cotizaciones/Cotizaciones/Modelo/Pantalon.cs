using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cotizaciones.Modelo
{
    class Pantalon : Prenda
    {
        public bool esChupin = false;

        public static float CotizacionPantalon(Pantalon pantalon, float precio)
        {
            float precioFinal = precio;

            if (pantalon.esChupin) precioFinal -= precio * 0.12f;
            if (pantalon.calidad == "Premium") precioFinal += precio * 0.30f;

            return precioFinal;
        }
    }
}
