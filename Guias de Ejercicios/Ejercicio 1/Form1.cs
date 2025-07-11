using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_1
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Libreria miLibreria = new Libreria();
        int i = 0;

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btnRealizarVenta_Click(object sender, EventArgs e)
        {
            i++;
            var nuevaVenta = new Ventas()
            {
                subtotalVenta = miLibreria.subtotalVenta,
                cantProductos = miLibreria.cantProductos
            };

            miLibreria.RegistrarVenta(nuevaVenta);
            lstVentas.Items.Add(nuevaVenta.ToString());
            lstVentas.Items[i-1] = $"#{i} Venta";
            btnTotalRecaudado.Enabled = true;
            btnTotalProductosVendidos.Enabled = true;
            btnMostrarSubtotal.Enabled = false;
            btnRealizarVenta.Enabled = false;

        }

        private void btnTotalRecaudado_Click(object sender, EventArgs e)
        {
            double totalRecaudado = 0.0;

            for (int i = 0; i < miLibreria.RegistroVentas.Count; i++)
            {
                var venta = miLibreria.RegistroVentas[i];
                totalRecaudado += venta.subtotalVenta;
            }

            MessageBox.Show($"El total recaudado de la libreria es de: ${totalRecaudado}");
        }


        private void btnCrearProducto_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNombre.Text != "" && txtCdb1.Text != "" && txtDesc.Text != "" && txtPrecio.Text != "")
                {
                    if (Convert.ToDouble(txtPrecio.Text) > 0)
                    {
                        //Producto nuevoProducto = new Producto(txtCdb1.Text, txtNombre.Text, txtDesc.Text, Convert.ToDouble(txtPrecio.Text));
                        Producto nuevoProducto = new Producto()
                        {
                            nombre = txtNombre.Text,
                            codigoBarras = txtCdb1.Text,
                            descripcion = txtDesc.Text,
                            precio = Convert.ToDouble(txtPrecio.Text)
                        };
                        
                        miLibreria.CrearProducto(nuevoProducto);
                        dgvLibreria.Rows.Add(nuevoProducto.codigoBarras, nuevoProducto.nombre, nuevoProducto.descripcion, nuevoProducto.precio);
                        txtNombre.Text = "";
                        txtCdb1.Text = "";
                        txtDesc.Text = "";
                        txtPrecio.Text = "";
                        btnAgregarProducto.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show("El precio del producto debe ser mayor a cero!");
                    }

                }
                else
                {
                    MessageBox.Show("Uno o mas campos no estan completos");
                }

            }
            catch (FormatException)
            {
                MessageBox.Show("Debes poner un valor numerico en la celda Precio");
            }
        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            if (txtCdb2.Text != "")
            {
                var producto = miLibreria.lstProductos.Find(i => i.codigoBarras == txtCdb2.Text);
                if (producto != null)
                {
                    miLibreria.AgregarProductoAVenta(producto, Convert.ToInt32(numCantidad1.Value));
                    MessageBox.Show("Se agrego el/los productos correctamente!");
                    txtCdb2.Text = "";
                    numCantidad1.Value = 1;
                    btnMostrarSubtotal.Enabled = true;
                    btnRealizarVenta.Enabled = true;
                }
                else
                {
                    MessageBox.Show("El producto que usted desea vender no se encuentra en la libreria");
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingresar codigo de barras");
            }
        }

        private void btnMostrarSubtotal_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Subtotal de la venta actual: ${miLibreria.subtotalVenta.ToString()}");
        }

        private void btnTotalProductosVendidos_Click(object sender, EventArgs e)
        {
            int totalProductosVendidos = 0;

            for (int i = 0; i < miLibreria.RegistroVentas.Count; i++)
            {
                var venta = miLibreria.RegistroVentas[i];
                totalProductosVendidos += venta.cantProductos;
            }

            MessageBox.Show($"El total de productos vendidos es de: {totalProductosVendidos}");
        }

        /*
         * Una librería necesita un programa que le permita gestionar sus ventas de sus respectivos productos.
         * De cada producto se registran las siguientes características:
         * • Código de Barras
         * • Nombre del producto
         * • Descripción
         * • Precio
         * Desarrollar una aplicación Orientada a Objetos utilizando C# que permita:
         * 1) Recuperar bajo demanda la recaudación total de la librería.
         * 2) Mostrar el subtotal de la venta.
         * 3) Controlar la carga de datos.
         * 4) Mostrar la cantidad total de productos vendidos.
         */


    }
}
