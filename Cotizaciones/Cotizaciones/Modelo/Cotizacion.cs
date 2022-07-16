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
    }
}
