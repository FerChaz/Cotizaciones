using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cotizaciones.Modelo;
using Cotizaciones.Control;

namespace Cotizaciones
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            

            Vendedor vendedor = new Vendedor();
            vendedor.nombre = "Juan";
            vendedor.apellido = "Perez";
            vendedor.codigoVendedor = "123A";

            Tienda tienda = new Tienda();
            tienda.nombre = "Ropitas";
            tienda.direccion = "Patrono 546 - Ciudad";

            Pantalon pantalonesComunesStd = new Pantalon();
            pantalonesComunesStd.calidad = "Standard";
            pantalonesComunesStd.stock = 250;

            Pantalon pantalonesComunesPremium = new Pantalon();
            pantalonesComunesPremium.calidad = "Premium";
            pantalonesComunesPremium.stock = 250;

            Pantalon pantalonesChupinesStd = new Pantalon();
            pantalonesChupinesStd.calidad = "Standard";
            pantalonesChupinesStd.stock = 750;
            pantalonesChupinesStd.esChupin = true;

            Pantalon pantalonesChupinesPremium = new Pantalon();
            pantalonesChupinesPremium.calidad = "Premium";
            pantalonesChupinesPremium.stock = 750;
            pantalonesChupinesPremium.esChupin = true;


            Camisa camisaComunMangaLargaStd = new Camisa();
            camisaComunMangaLargaStd.calidad = "Standard";
            camisaComunMangaLargaStd.stock = 175;

            Camisa camisaComunMangaLargaPremium = new Camisa();
            camisaComunMangaLargaPremium.calidad = "Premium";
            camisaComunMangaLargaPremium.stock = 175;

            Camisa camisaMaoMangaLargaStd = new Camisa();
            camisaMaoMangaLargaStd.calidad = "Standard";
            camisaMaoMangaLargaStd.stock = 75;
            camisaMaoMangaLargaStd.esCuelloMao = true;

            Camisa camisaMaoMangaLargaPremium = new Camisa();
            camisaMaoMangaLargaPremium.calidad = "Premium";
            camisaMaoMangaLargaPremium.stock = 75;
            camisaMaoMangaLargaPremium.esCuelloMao = true;


            Camisa camisaComunMangaCortaStd = new Camisa();
            camisaComunMangaCortaStd.calidad = "Standard";
            camisaComunMangaCortaStd.stock = 150;
            camisaComunMangaCortaStd.esMangaCorta = true;

            Camisa camisaComunMangaCortaPremium = new Camisa();
            camisaComunMangaCortaPremium.calidad = "Premium";
            camisaComunMangaCortaPremium.stock = 150;
            camisaComunMangaCortaPremium.esMangaCorta = true;

            Camisa camisaMaoMangaCortaStd = new Camisa();
            camisaMaoMangaCortaStd.calidad = "Standard";
            camisaMaoMangaCortaStd.stock = 100;
            camisaMaoMangaCortaStd.esMangaCorta = true;
            camisaMaoMangaCortaStd.esCuelloMao = true;

            Camisa camisaMaoMangaCortaPremium = new Camisa();
            camisaMaoMangaCortaPremium.calidad = "Premium";
            camisaMaoMangaCortaPremium.stock = 100;
            camisaMaoMangaCortaPremium.esMangaCorta = true;
            camisaMaoMangaCortaPremium.esCuelloMao = true;

            tienda.prendasDisponibles.Add(pantalonesComunesStd);
            tienda.prendasDisponibles.Add(pantalonesComunesPremium);
            tienda.prendasDisponibles.Add(pantalonesChupinesStd);
            tienda.prendasDisponibles.Add(pantalonesChupinesPremium);

            tienda.prendasDisponibles.Add(camisaComunMangaLargaStd);
            tienda.prendasDisponibles.Add(camisaComunMangaLargaPremium);
            tienda.prendasDisponibles.Add(camisaMaoMangaLargaStd);
            tienda.prendasDisponibles.Add(camisaMaoMangaLargaPremium);

            tienda.prendasDisponibles.Add(camisaComunMangaCortaStd);
            tienda.prendasDisponibles.Add(camisaComunMangaCortaPremium);
            tienda.prendasDisponibles.Add(camisaMaoMangaCortaStd);
            tienda.prendasDisponibles.Add(camisaMaoMangaCortaPremium);

            Controlador.InicializarVentana(tienda, vendedor);



        }
    }
}
