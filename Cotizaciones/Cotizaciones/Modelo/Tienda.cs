using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cotizaciones.Modelo
{
    class Tienda
    {
        public string nombre;
        public string direccion;
        public List<Prenda> prendasDisponibles = new List<Prenda>();
    }
}
