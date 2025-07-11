using HotelDLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_6
{
    public partial class Form1 : Form
    {
        #region Consigna
        /*
        Un hotel turístico requiere de un programa que le permita
        administrar y gestionar las reservas de las diferentes habitaciones que maneja.
        De cada habitación se conoce el número, los diferentes artefactos que posee
        (televisión, aire, frigo bar, etc.), y se categorizan por:
            • Habitación Simple: Posee una cama de una plaza y tiene un costo de $200 por Noche.
            • Habitación Doble Matrimonial: Tiene un costo de $350 por noche y posee una cama de dos plazas.
            • Habitación Triple: Tiene un costo de $550 por noche y posee una cama matrimonial plus y una cama extra.
            • Habitación Cuádruple: Tiene un costo de $700 por noche y posee una cama matrimonial y cama-cucheta.
        
        Hay habitaciones que poseen vista al mar que carecen en un 15% el valor de la misma.
        El adicional de la reserva de la cuna añade $50 por noche.
        
        Desarrollar una aplicación Orientada a Objetos utilizando C# que permita:
        1) Registrar una reserva por habitación con cada uno de los integrantes,
        de los integrantes se conoce el nombre, apellido, la fecha de nacimiento, el DNI y la edad. {OK}
        2) Registrar la ocupación de la habitación
        (Primero se realiza la reserva y después tiene que tener otro mecanismo que concrete dicha reserva). {OK}
        3) Cargar el depósito de la reserva, el mismo será a partir como mínimo un 10% del total del paquete contratado. {OK}
        4) Formulario de cancelación de reserva teniendo en cuenta los siguientes puntos:
            a) Si la cancelación de la reserva es inferior a los dos días el valor del depósito se pierde
            (sólo el 10% de mínimo) el resto se devuelve.
            b) Si se encuentra dentro de la semana, se reintegra el 50% del mínimo más el excedente de ese depósito.
            c) Si es mayor de una semana se reintegra el total del valor depositado. {OK}
        5) Cada reserva debe registrar la fecha de checkin, la fecha del checkout, la habitación,
        los integrantes y los adicionales (Por ejemplo: la cuna, el consumo del frigobar, otros consumos). {OK}
        6) Los pagos de todos los totales se imputan a la hora de registrar el checkout. {OK}
        7) Mostrar que habitación se solicitó más en el lapso de un periodo de fechas. {OK}
        8) Mostrar el integrante que se hospedó mayor cantidad de veces en el hotel. {OK}
        9) Obtener la recaudación total del hotel filtrada por períodos de fechas. {OK}
        10) Obtener la habitación que se ocupó mayor cantidad de veces total y filtrada por fechas. {OK}
        11) Controlar que las reservas no se superpongan. {OK}
        */
        #endregion

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private HotelTuristico _hotelPrincipal = new HotelTuristico();

        public HotelTuristico HotelPrincipal
        {
            get { return _hotelPrincipal; }
        }

        public void AgregarReserva(List<Huesped> integrantes, Habitacion habitacion, DateTime inicio, int duracion, float deposito)
        {
            Reserva r = new Reserva(integrantes, habitacion, inicio, duracion, deposito);
            bool ok = _hotelPrincipal.RegistrarReserva(r);
            if(ok)
            {
                MessageBox.Show("Se registro la reserva con exito");
            }
            else
            {
                MessageBox.Show("La habitacion que se esta intentando reservar ya esta ocupada");
            }
        }

        public void AgregarReservaConAdicional(List<Huesped> integrantes, Habitacion habitacion, DateTime inicio, int duracion, float deposito, List<Adicional> adicionales)
        {
            Reserva rAd = new ReservaConAdicional(integrantes, habitacion, inicio, duracion, deposito, adicionales);
            bool ok = _hotelPrincipal.RegistrarReserva(rAd);
            if(ok)
            {
                MessageBox.Show("Se registro la reserva con sus adicionales");
            }
            else
            {
                MessageBox.Show("La habitacion que se esta intentando reservar ya esta ocupada");
            }
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(!(MessageBox.Show("Realmente desea salir?", "Salir de la Aplicacion", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.Cancel))
            {
                Application.Exit();
            }
        }

        private void administracionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdministraciónHotel frmAdmHotel = new AdministraciónHotel();
            frmAdmHotel.HotelAdm = _hotelPrincipal;
            frmAdmHotel.MdiParent = this;
            frmAdmHotel.Show();
        }

        private void huespedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GestionHuespedes frmgHuespedes = new GestionHuespedes();
            frmgHuespedes.gHuespedes = _hotelPrincipal;
            frmgHuespedes.MdiParent = this;
            frmgHuespedes.Show();
        }

        private void habitacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GestionHabitaciones frmgHabitaciones = new GestionHabitaciones();
            frmgHabitaciones.gHabitaciones = _hotelPrincipal;
            frmgHabitaciones.MdiParent = this;
            frmgHabitaciones.Show();
        }

        private void reservaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GestionReservas frmgReservas = new GestionReservas();
            frmgReservas.gReservas = _hotelPrincipal;
            frmgReservas.MdiParent = this;
            frmgReservas.Show();
        }
    }
}