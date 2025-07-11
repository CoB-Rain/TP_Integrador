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
    public partial class AdministraciónHotel: Form
    {
        public AdministraciónHotel()
        {
            InitializeComponent();
        }

        private void AdministraciónHotel_Load(object sender, EventArgs e)
        {

        }

        private HotelTuristico _hotelAdm = new HotelTuristico();

        public HotelTuristico HotelAdm
        {
            get { return _hotelAdm; }
            set { _hotelAdm = value;
                InicializarGrillas();
            }
        }

        private void btnCalcularRecaudacion_Click(object sender, EventArgs e)
        {
            DateTime inicio = dtInicio.SelectionStart;
            DateTime fin = dtFin.SelectionStart;
            if(inicio < fin && fin <= DateTime.Now)
            {
                txtRecaudacion.Text = $"$ {_hotelAdm.RecaudacionPorFecha(inicio, fin)}";
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un rango entre fechas valido..", "Error de selección", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            txtHuesped.Text = _hotelAdm.MostrarHuespedMasVecesHospedado().ToString();
        }

        private void btnCalcularHabitacion_Click(object sender, EventArgs e)
        {
            DateTime inicio = dtInicioHabitacion.SelectionStart;
            DateTime fin = dtFinHabitacion.SelectionStart;
            if (inicio < fin && fin <= DateTime.Now)
            {
                txtHabitacionMasSolicitada.Text = _hotelAdm.MostrarHabitacionMasSolicitada(inicio, fin).ToString();
            }
        }

        private void btnCalcularRecaudacionHotel_Click(object sender, EventArgs e)
        {
            txtRecaudacionTotal.Text = $"$ {_hotelAdm.Recaudacion}";
        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
            Reserva r = ReservaActual();
            if(DateTime.Now.Day == r.CheckOut.Day)
            {
                if (!_hotelAdm.RegistrarPago(r))
                {
                    MessageBox.Show("Se ha realizado el pago con exito!", "Operación Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("El pago de esta reserva ya esta abonado. Pago rechazado", "Operación Rechazada", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            else
            {
                MessageBox.Show("Todavia no ha llegado el dia de checkout. Pago rechazado", "Operación Rechazada", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void InicializarGrillas()
        {
            dgvReservas.DataSource = null;
            dgvReservas.DataSource = _hotelAdm.reservas.ToList();

            MostrarDatosReservas();
        }

        public void MostrarDatosReservas()
        {
            if (dgvReservas.SelectedCells.Count > 0)
            {
                Reserva reservaActual = ReservaActual();
                dgvIntegrantes.DataSource = null;
                dgvAdicionales.DataSource = null;

                dgvIntegrantes.DataSource = reservaActual.Integrantes.ToList();
                if (reservaActual is ReservaConAdicional rAd)
                {
                    dgvAdicionales.DataSource = rAd.adicionales.ToList();
                }
            }
        }

        public Reserva ReservaActual()
        {
            if (dgvReservas.SelectedCells.Count > 0)
            {
                var celda = dgvReservas.SelectedCells[0];
                var fila = dgvReservas.Rows[celda.RowIndex];
                Reserva reservaActual = fila.DataBoundItem as Reserva;
                return reservaActual;
            }
            else
                return null;
        }
    }
}
