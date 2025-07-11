using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_4
{
    public partial class Administracion: Form
    {
        private AfterOffice _afterAdministracion = new AfterOffice();

        public AfterOffice AfterAdministracion
        {
            get { return _afterAdministracion; }
            set { _afterAdministracion = value; }
        }

        public Administracion()
        {
            InitializeComponent();
        }

        private void Administracion_Load(object sender, EventArgs e)
        {

        }

        private void btnMostrarAfter_Click(object sender, EventArgs e)
        {
            if (_afterAdministracion.Barriles.Count > 0)
            {
                ActualizarInfoAfter();
            }
            else
            {
                MessageBox.Show("El after no cuenta con ningun barril por el momento", "Error de operación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void ActualizarInfoAfter()
        {
            txtAfter.Text = string.Empty;
            txtAfter.Text = $"La recaudacion total del after es: ${_afterAdministracion.RecaudacionTotal}" + Environment.NewLine +
                $"El barril que mas cerveza sirvió es: {_afterAdministracion.MostrarBarrilMasCervezaSirvio()}" + Environment.NewLine +
                $"El barril que menos cerveza sirvió es: {_afterAdministracion.MostrarBarrilMenosCervezaSirvio()}" + Environment.NewLine +
                $"La cerveza mas vendida es: {_afterAdministracion.MostrarCervezaMasVendida()}" + Environment.NewLine +
                $"La cerveza que mas ganancia genero es: {_afterAdministracion.MostrarCervezaMayorGanancia()}" + Environment.NewLine +
                $"La cerveza que mas litros vendió es: {_afterAdministracion.MostrarCervezaMasLitrosVendidos()}" + Environment.NewLine +
                $"La cerveza que menos litros vendió es: {_afterAdministracion.MostrarCervezaMenosLitrosVendidos()}" + Environment.NewLine +
                $"El vaso más solicitado fue: {_afterAdministracion.MostrarVasoMasSolicitado()}" + Environment.NewLine +
                $"";
        }

        private void btnMostrarVasos_Click(object sender, EventArgs e)
        {
            ActualizarInfoVasos();
        }

        private void ActualizarInfoVasos()
        {
            dgvVasos.DataSource = null;

            List<Vaso> datosVasos = new List<Vaso>();
            datosVasos.Add(_afterAdministracion.Chopp);
            datosVasos.Add(_afterAdministracion.Vaso);
            datosVasos.Add(_afterAdministracion.Jarra);

            dgvVasos.DataSource = datosVasos;
        }

        private void btnMostrarCerveza_Click(object sender, EventArgs e)
        {
            ActualizarInfoCerveza();
        }

        private void ActualizarInfoCerveza()
        {
            dgvCerveza.DataSource = null;

            List<Cerveza> datosCervezas = new List<Cerveza>();
            datosCervezas.Add(_afterAdministracion.RubiaNacional);
            datosCervezas.Add(_afterAdministracion.NegraNacional);
            datosCervezas.Add(_afterAdministracion.RubiaExtranjero);

            foreach(Cerveza c in datosCervezas)
            {
                c.PorcentajeVenta = _afterAdministracion.CalcularPorcentajeVentaCerveza(c);
                c.PorcentajeRecaudacion = _afterAdministracion.CalcularPorcentajeRecaudacionCerveza(c);
            }

            dgvCerveza.DataSource = datosCervezas;
        }
    }
}
