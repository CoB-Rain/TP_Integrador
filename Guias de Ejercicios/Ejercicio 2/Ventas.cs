using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_2
{
    public partial class Ventas: Form
    {
        public Ventas()
        {
            InitializeComponent();
        }

        private Estacion _estacionVentas = new Estacion();

        public Estacion EstacionVentas
        {
            get { return _estacionVentas; }
            set { _estacionVentas = value; }
        }

        Surtidor surtidorTemp = new Surtidor();
        
        void CargarSurtidores()
        {
            this.cmbSurtidor.Items.Add(EstacionVentas.Surtidor1);
            this.cmbSurtidor.Items.Add(EstacionVentas.Surtidor2);
            this.cmbSurtidor.Items.Add(EstacionVentas.Surtidor3);
            this.cmbSurtidor.DisplayMember = $"Numero";
        }

        public void CargarInformacion()
        {
            surtidorTemp = cmbSurtidor.SelectedItem as Surtidor;
            txtSurtidores.Text =
                $"Surtidor N°{surtidorTemp.Numero.ToString()}" + Environment.NewLine +
                $"Tipo de nafta: {surtidorTemp.Nafta.Tipo.ToString()}" + Environment.NewLine +
                $"Nivel: {surtidorTemp.Nivel.ToString()}";
        }

        private void Cliente_Load(object sender, EventArgs e)
        {
            CargarSurtidores();
        }

        private void btnVender_Click(object sender, EventArgs e)
        {
            if (cmbSurtidor.SelectedItem != null && !string.IsNullOrWhiteSpace(txtLitros.Text))
            {
                //verdadero
                Surtidor surtidor = cmbSurtidor.SelectedItem as Surtidor;
                int flagRecargas = surtidor.CantidadRecargas;
                if (surtidor.Cargar(int.Parse(txtLitros.Text)))
                {
                    //verdadero
                    MessageBox.Show("La venta se ha realizado con exito!","Venta realizada exitosamente",MessageBoxButtons.OK);
                    if(surtidor.CantidadRecargas > flagRecargas)
                    {
                        //verdadero
                        MessageBox.Show("El surtidor llego a cero, se realizo la carga de nafta automaticamente", "Recarga automatica exitosa");
                    }
                }
                else
                {
                    //falso
                    MessageBox.Show("El surtidor no tiene el nivel de nafta suficiente.", "Error de operación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                //falso
                MessageBox.Show("Por favor, seleccione el número de surtidor e ingrese la cantidad de litros.", "Error de selección", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void cmbSurtidor_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarInformacion();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Administración frmAdministracion = new Administración();
            frmAdministracion.estacion = EstacionVentas;
            frmAdministracion.Show();
            this.Close();
        }
    }
}