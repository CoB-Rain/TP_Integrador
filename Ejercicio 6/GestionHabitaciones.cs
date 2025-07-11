using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HotelDLL;

namespace Ejercicio_6
{
    public partial class GestionHabitaciones: Form
    {
        public GestionHabitaciones()
        {
            InitializeComponent();
        }

        private void GestionHabitaciones_Load(object sender, EventArgs e)
        {
            InicializarTipoHabitaciones();
        }

        private HotelTuristico _gHabitaciones = new HotelTuristico();

        public HotelTuristico gHabitaciones
        {
            get { return _gHabitaciones; }
            set { _gHabitaciones = value;
                InicializarHabitaciones();
            }
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            if(cmbTipoHabitacion.SelectedItem != null)
            {
                Habitacion h;
                if (rdSinVistaAlMar.Checked)
                {
                    h = new Habitacion((TipoHabitacion)cmbTipoHabitacion.SelectedItem);
                    _gHabitaciones.habitaciones.Add(h);
                    MessageBox.Show("Se ha registrado la habitacion con exito!", "Operación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    InicializarHabitaciones();
                }
                else
                {
                    h = new Habitacion((TipoHabitacion)cmbTipoHabitacion.SelectedItem, true);
                    _gHabitaciones.habitaciones.Add(h);
                    MessageBox.Show("Se ha registrado la habitacion con vista al mar con exito!", "Operación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    InicializarHabitaciones();
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un tipo de habitacion para poder crearla.", "Error de selección", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void InicializarHabitaciones()
        {
            dgvHabitaciones.DataSource = null;
            dgvHabitaciones.DataSource = _gHabitaciones.habitaciones.ToList();
        }

        private void InicializarTipoHabitaciones()
        {
            cmbTipoHabitacion.DataSource = null;
            cmbTipoHabitacion.Items.Add(TipoHabitacion.Simple);
            cmbTipoHabitacion.Items.Add(TipoHabitacion.Doble);
            cmbTipoHabitacion.Items.Add(TipoHabitacion.Triple);
            cmbTipoHabitacion.Items.Add(TipoHabitacion.Cuadruple);
        }
    }
}
