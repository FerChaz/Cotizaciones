﻿using System;
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
        static Tienda _tienda;
        static Vendedor _vendedor;
        public static void InicializarVentana(Tienda tienda, Vendedor vendedor)
        {
            _tienda = tienda;
            _vendedor = vendedor;

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            ventana = new Form1();
            ventana.Controls["nombreTienda"].Text = tienda.nombre;
            ventana.Controls["direccionTienda"].Text = tienda.direccion;
            ventana.Controls["nombreVendedor"].Text = vendedor.nombre + " " + vendedor.apellido;
            ventana.Controls["idVendedor"].Text = vendedor.codigoVendedor;
            Application.Run(ventana);
        }

        public static void Cotizar(float precio, int cantidad)
        {
            string calidad = ((RadioButton)ventana.Controls["calidad"].Controls["standard"]).Checked ? "Standard" : "Premium";
            string prenda = ((RadioButton)ventana.Controls["prenda"].Controls["camisa"]).Checked ? "camisa" : "pantalon"; 
            bool esMao = false;
            bool esMangaCorta = false;
            bool esChupin = false;

            Prenda prendaObj = null;

            if (((CheckBox)ventana.Controls["prenda"].Controls["cuelloMao"]).Checked)
            {
                if (prenda == "pantalon")
                {
                    MessageBox.Show("Los pantalones no pueden tener CUELLO MAO.");
                    return;
                }
                esMao = true;
            }
            if (((CheckBox)ventana.Controls["prenda"].Controls["mangaCorta"]).Checked)
            {
                if (prenda == "pantalon")
                {
                    MessageBox.Show("Los pantalones no pueden tener MANGA CORTA.");
                    return;
                }
                esMangaCorta = true;
            }
            if (((CheckBox)ventana.Controls["prenda"].Controls["chupin"]).Checked)
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
                prendaObj = _tienda.prendasDisponibles.Find(camisa => camisa is Camisa && camisa.calidad == calidad && ((Camisa)camisa).esCuelloMao == esMao && ((Camisa)camisa).esMangaCorta == esMangaCorta);
            }

            if (prenda == "pantalon")
            {
                prendaObj = _tienda.prendasDisponibles.Find(pantalon => pantalon is Pantalon && pantalon.calidad == calidad && ((Pantalon)pantalon).esChupin == esChupin);
            }

            if (prendaObj.stock < cantidad)
            {
                MessageBox.Show("La cantidad a cotizar no puede ser mayor al stock disponible.");
                return;
            }


            Cotizacion nuevaCotizacion = Cotizacion.Cotizar(prendaObj, cantidad, precio, _vendedor.codigoVendedor, _vendedor.historialCotizaciones.Count);

            _vendedor.historialCotizaciones.Add(nuevaCotizacion);


            ventana.Controls["resultado"].Text = nuevaCotizacion.resultadoCotizacion.ToString();
        }
    }
}
