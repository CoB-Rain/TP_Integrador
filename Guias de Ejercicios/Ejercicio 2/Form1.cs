using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Ejercicio_2
{
    public partial class Administración : Form
    {
        public Administración()
        {
            InitializeComponent();
        }
        /*
         * Una estación de servicio necesita un programa que le permita administrar sus ventas, para ello
         * cuenta con 3 surtidores, cada surtidor en su interior estará cargado con 1 tipo de nafta.
         * Los tipos de naftas junto con sus tarifas por litro son:
         * • Normal: $17.20
         * • Súper: $18.85
         * • Premium: $21.30
         * Desarrollar una aplicación Orientada a Objetos utilizando C# que permita:
         * 1) Obtener la recaudación total de la estación de servicio. {OK}
         * 2) Obtener la recaudación total de un surtidor. {OK}
         * 3) Obtener el surtidor que más recaudó. {OK}
         * 4) Obtener el surtidor que menos recaudó. {OK}
         * 5) Obtener el surtidor que más clientes tuvo. {OK}
         * 6) Calcular el porcentaje de venta de cada tipo de nafta. {OK}
         * 7) Calcular el porcentaje de recaudación de cada tipo de nafta. {OK}
         * 8) Recargar el surtidor cuando éste haya quedado vacío. {OK}
         * 9) Mostrar el surtidor con mayor cantidad recargas. {OK}
         * 10) Calcular el promedio de ventas por surtidor. {OK}
         * 11) Calcular el promedio de recaudación por surtidor. {OK}
         */

        private void Form1_Load(object sender, EventArgs e)
        {
            #region "Datos Estacion"
            estacion.Normal.Tipo = "Normal";
            estacion.Super.Tipo = "Super";
            estacion.Premium.Tipo = "Premium";
            estacion.Normal.Precio = 17.20;
            estacion.Super.Precio = 18.85;
            estacion.Premium.Precio = 21.30;

            estacion.Surtidor1.Numero = 1;
            estacion.Surtidor1.Capacidad = 1000;
            estacion.Surtidor2.Numero = 2;
            estacion.Surtidor2.Capacidad = 1000;
            estacion.Surtidor3.Numero = 3;
            estacion.Surtidor3.Capacidad = 1000;
            #endregion
            CargarNaftas();
            CargarSurtidores();
        }

        //Estacion estacion = new Estacion();
        private Estacion _estacion = new Estacion();

        public Estacion estacion
        {
            get { return _estacion; }
            set { _estacion = value; }
        }

        Surtidor surtidorTemp = new Surtidor();
        Nafta naftaTemp = new Nafta();

        void CargarNaftas()
        {
            lstNafta.Items.Clear();
            this.lstNafta.Items.Add(estacion.Normal);
            this.lstNafta.Items.Add(estacion.Super);
            this.lstNafta.Items.Add(estacion.Premium);
            this.lstNafta.DisplayMember = "Tipo";

            this.cmbAsignarNafta.Items.Add(estacion.Normal);
            this.cmbAsignarNafta.Items.Add(estacion.Super);
            this.cmbAsignarNafta.Items.Add(estacion.Premium);
            this.cmbAsignarNafta.DisplayMember = "Tipo";
        }


        void CargarSurtidores()
        {
            lstSurtidores.Items.Clear();
            this.lstSurtidores.Items.Add(estacion.Surtidor1);
            this.lstSurtidores.Items.Add(estacion.Surtidor2);
            this.lstSurtidores.Items.Add(estacion.Surtidor3);
            this.lstSurtidores.DisplayMember = "Numero";

            this.cmbSurtidor.Items.Add(estacion.Surtidor1);
            this.cmbSurtidor.Items.Add(estacion.Surtidor2);
            this.cmbSurtidor.Items.Add(estacion.Surtidor3);
            this.cmbSurtidor.DisplayMember = $"Numero";
        }

        private void btnAsignarNafta_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(cmbAsignarNafta.Text) && lstSurtidores.SelectedItem != null)
            {
                //verdadero
                if (surtidorTemp != null)
                {
                    //verdadero
                    surtidorTemp.Nafta = (Nafta)cmbAsignarNafta.SelectedItem;
                }
            }
            else
            {
                //falso
                MessageBox.Show("Por favor, seleccione el tipo de nafta y el número de surtidor.", "Error de selección", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void lstSurtidores_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbAsignarNafta.SelectedItem = null;
            surtidorTemp = (Surtidor)lstSurtidores.SelectedItem;
            txtNumero.Text = surtidorTemp.Numero.ToString();
            txtCapacidad.Text = surtidorTemp.Capacidad.ToString();
            if (surtidorTemp.Nafta != null)
            {
                //verdadero
                cmbAsignarNafta.SelectedItem = surtidorTemp.Nafta;
            }
        }

        private void lstNafta_SelectedIndexChanged(object sender, EventArgs e)
        {
            naftaTemp = (Nafta)lstNafta.SelectedItem;
            txtNombre.Text = naftaTemp.Tipo.ToString();
            txtPrecio.Text = "$ " + naftaTemp.Precio.ToString();
        }

        private void btnInspeccionar_Click(object sender, EventArgs e)
        {
            if (cmbSurtidor.SelectedItem != null)
            {
                //verdadero
                txtSurtidorData.Text = string.Empty;
                surtidorTemp = cmbSurtidor.SelectedItem as Surtidor;
                //surtidorTemp = (Surtidor)cmbSurtidor.SelectedItem;
                if(surtidorTemp.Nafta != null)
                {
                    txtSurtidorData.Text =
                        $"Tipo de nafta: {surtidorTemp.Nafta.Tipo.ToString()}" + Environment.NewLine +
                        $"Capacidad: {surtidorTemp.Capacidad.ToString()}" + Environment.NewLine +
                        $"Nivel: {surtidorTemp.Nivel.ToString()}" + Environment.NewLine +
                        $"Total recaudado: ${surtidorTemp.TotalRecaudado.ToString()}" + Environment.NewLine +
                        $"Cantidad de clientes: {surtidorTemp.CantidadClientes.ToString()}" + Environment.NewLine +
                        $"Cantidad de recargas: {surtidorTemp.CantidadRecargas.ToString()}" + Environment.NewLine +
                        $"";
                }
                else
                {
                    MessageBox.Show("No has asignado un tipo de nafta a este surtidor...", "Error de asignación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione el número de surtidor.", "Error de selección", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnRecargar_Click(object sender, EventArgs e)
        {
            if (cmbSurtidor.SelectedItem != null)
            {
                //verdadero
                Surtidor surtidor = cmbSurtidor.SelectedItem as Surtidor;
                if (surtidor.Nafta != null)
                {
                    //verdadero
                    surtidor.Recargar();
                }
                else
                {
                    //falso
                    MessageBox.Show("No has asignado un tipo de nafta a este surtidor...", "Error de asignación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                //falso
                MessageBox.Show("Por favor, seleccione el número de surtidor.", "Error de selección", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnEstadisticas_Click(object sender, EventArgs e)
        {
            txtEstadisticas.Text = string.Empty;
            if (estacion.Surtidor1.Nafta != null && estacion.Surtidor2.Nafta != null && estacion.Surtidor3.Nafta != null)
            {
                //verdadero
                txtEstadisticas.Text =
                    $"Recaudación total de la estación: ${estacion.CalcularRecaudacionTotal()}" + Environment.NewLine +
                    $"Surtidor que más recaudo: Surtidor {estacion.DevolverSurtidorMayorRecaudacion().Numero}" + Environment.NewLine +
                    $"Surtidor que menos recaudo: Surtidor {estacion.DevolverSurtidorMenorRecaudacion().Numero}" + Environment.NewLine +
                    $"Surtidor que mas clientes tuvo: Surtidor {estacion.DevolverSurtidorMasClientes().Numero}" + Environment.NewLine +
                    $"Surtidor que mas recargas tuvo: Surtidor {estacion.DevolverSurtidorMayorRecargas().Numero}" + Environment.NewLine +
                    Environment.NewLine +
                    $"Porcentaje de venta por nafta: " + Environment.NewLine +
                    $"{estacion.Normal.Tipo}: %{estacion.CalcularPorcentajeVentaNafta(estacion.Normal)}" + Environment.NewLine +
                    $"{estacion.Super.Tipo}: %{estacion.CalcularPorcentajeVentaNafta(estacion.Super)}" + Environment.NewLine +
                    $"{estacion.Premium.Tipo}: %{estacion.CalcularPorcentajeVentaNafta(estacion.Premium)}" + Environment.NewLine +
                    Environment.NewLine +
                    $"Porcentaje de recaudacion por nafta: " + Environment.NewLine +
                    $"{estacion.Normal.Tipo}: %{estacion.CalcularPorcentajeRecaudacionNafta(estacion.Normal)}" + Environment.NewLine +
                    $"{estacion.Super.Tipo}: %{estacion.CalcularPorcentajeRecaudacionNafta(estacion.Super)}" + Environment.NewLine +
                    $"{estacion.Premium.Tipo}: %{estacion.CalcularPorcentajeRecaudacionNafta(estacion.Premium)}" + Environment.NewLine +
                    Environment.NewLine +
                    $"Promedio de ventas de los surtidores: {estacion.CalcularPromedioVentasSurtidor()}" + Environment.NewLine +
                    $"Promedio de recaudación de los surtidores: ${estacion.CalcularPromedioRecaudacionSurtidor()}";

            }
            else
            {
                //falso
                MessageBox.Show("No se asignó la información requerida a alguno de los surtidores..", "Error de asignación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnRealizarVentas_Click(object sender, EventArgs e)
        {
            if (estacion.Surtidor1.Nafta != null && estacion.Surtidor2.Nafta != null && estacion.Surtidor3.Nafta != null)
            {
                //verdadero
                Ventas frmVentas = new Ventas();
                frmVentas.EstacionVentas = estacion;
                frmVentas.Show();
                this.Hide();
            }
            else
            {
                //falso
                MessageBox.Show("No se asignó la información requerida a alguno de los surtidores..", "Error de asignación", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }
    }
}
