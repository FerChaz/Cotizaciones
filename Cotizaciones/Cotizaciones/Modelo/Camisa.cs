using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cotizaciones.Modelo
{
    class Camisa : Prenda
    {
        public bool esMangaCorta = false;
        public bool esCuelloMao = false;


        public static float CotizacionCamisa(Camisa camisa, float precio)
        {
            float precioFinal = precio;

            if (camisa.esMangaCorta) precioFinal -= precio * 0.10f;
            if (camisa.esCuelloMao) precioFinal += precio * 0.03f;
            if (camisa.calidad == "Premium") precioFinal += precio * 0.30f;

            return precioFinal;
        }
    }
}
