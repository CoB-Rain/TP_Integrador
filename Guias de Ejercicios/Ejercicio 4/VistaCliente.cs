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
    public partial class VistaCliente: Form
    {
        private AfterOffice _afterCliente = new AfterOffice();

        public AfterOffice AfterCliente
        {
            get { return _afterCliente; }
            set { _afterCliente = value; }
        }

        Vaso vasoSeleccionado;
        Barril barrilSeleccionado;

        bool bloquearTab1 = false;
        bool bloquearTab2 = true;
        bool bloquearTab3 = true;

        public VistaCliente()
        {
            InitializeComponent();
        }

        private void VistaCliente_Load(object sender, EventArgs e)
        {
            InicializarBarriles();
        }

        private void InicializarBarriles()
        {
            lstBarriles.DataSource = null;
            lstBarriles.DataSource = _afterCliente.Barriles;
        }

        private void btnSeleccionarVaso_Click(object sender, EventArgs e)
        {
            PrepararSeccionCerveza();
        }

        private void PrepararSeccionCerveza()
        {
            if (rbChopp.Checked)
            {
                vasoSeleccionado = _afterCliente.Chopp;
            }
            else if (rbVaso.Checked)
            {
                vasoSeleccionado = _afterCliente.Vaso;
            }
            else
            {
                vasoSeleccionado = _afterCliente.Jarra;
            }
            bloquearTab1 = true;
            bloquearTab2 = false;
            tabControl1.SelectTab(tabSeleccionCerveza);
            ActualizarDatosListaBarriles();
            InicializarBarriles();
        }

        private void ActualizarDatosListaBarriles()
        {
            if (lstBarriles.SelectedItem != null && vasoSeleccionado != null)
            {
                barrilSeleccionado = lstBarriles.SelectedItem as Barril;
                txtCerveza.Text = barrilSeleccionado.Contenido.Sabor.ToString() + " " + barrilSeleccionado.Contenido.Origen.ToString();
                txtPrecioCerveza.Text = $"$ {barrilSeleccionado.Contenido.CalcularVenta(vasoSeleccionado)}";
                txtNivel.Text = barrilSeleccionado.Nivel.ToString() + "ml";
            }
        }

        private void rbChopp_CheckedChanged(object sender, EventArgs e)
        {
            if(rbChopp.Checked == true)
            {
                pboxTipoVaso.Image = Properties.Resources.Chopp;
                txtCapacidad.Text = $"{_afterCliente.Chopp.Capacidad}ml";
            }
        }

        private void rbVaso_CheckedChanged(object sender, EventArgs e)
        {
            if (rbVaso.Checked == true)
            {
                pboxTipoVaso.Image = Properties.Resources.Vaso;
                txtCapacidad.Text = $"{_afterCliente.Vaso.Capacidad}ml";
            }
        }

        private void rbJarra_CheckedChanged(object sender, EventArgs e)
        {
            if (rbJarra.Checked == true)
            {
                pboxTipoVaso.Image = Properties.Resources.Jarra;
                txtCapacidad.Text = $"{_afterCliente.Jarra.Capacidad}ml";
            }
        }

        private void tabControl1_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if(bloquearTab1 && e.TabPage == tabSeleccionVaso)
            {
                e.Cancel = true;
                MessageBox.Show("Esta pestaña está deshabilitada", "Error de Operación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            if (bloquearTab2 && e.TabPage == tabSeleccionCerveza)
            {
                e.Cancel = true;
                MessageBox.Show("Esta pestaña está deshabilitada", "Error de Operación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            if(bloquearTab3 && e.TabPage == tabSeccionPago)
            {
                e.Cancel = true;
                MessageBox.Show("Esta pestaña está deshabilitada", "Error de Operación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnSeleccionarCerveza_Click(object sender, EventArgs e)
        {
            PrepararSeccionPago();
        }

        private void PrepararSeccionPago()
        {
            if (_afterCliente.Barriles.Count > 0)
            {
                if (barrilSeleccionado != null)
                {
                    bool ok = barrilSeleccionado.Nivel >= vasoSeleccionado.Capacidad;
                    if (ok)
                    {
                        bloquearTab2 = true;
                        bloquearTab3 = false;
                        tabControl1.SelectTab(tabSeccionPago);
                        txtProductoFinal.Text = $"{barrilSeleccionado.Contenido.Sabor} {barrilSeleccionado.Contenido.Origen}: {vasoSeleccionado.Capacidad}ml";
                        txtTotalAPagar.Text = $"$ {barrilSeleccionado.Contenido.CalcularVenta(vasoSeleccionado)}";
                    }
                    else
                    {
                        MessageBox.Show($"El barril no cuenta con la cantidad de litros de cerveza.{Environment.NewLine}Por favor, recargarlo.", "Error de Operación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else
                {
                    MessageBox.Show("No has seleccionado un barril para servir la cerveza.", "Error de Operación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("El after no cuenta con ningun barril por el momento", "Error de Operación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void lstBarriles_SelectedIndexChanged(object sender, EventArgs e)
        {
            ActualizarDatosListaBarriles();
        }

        private void lstBarriles_DoubleClick(object sender, EventArgs e)
        {
            InicializarBarriles();
        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
            bool ok = barrilSeleccionado.Servir(vasoSeleccionado);
            if (ok)
            {
                _afterCliente.RegistrarRecaudacionAfter();
                MessageBox.Show("Se realizo el pago con exito!", "Operación Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Ha ocurrido un error, no se realizo el pago.", "Error de Operación", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            RepetirProceso();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Se ha cancelado el pago.", "Operación Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
            RepetirProceso();
        }

        private void RepetirProceso()
        {
            vasoSeleccionado = null;
            barrilSeleccionado = null;
            bloquearTab1 = false;
            bloquearTab3 = true;
            tabControl1.SelectTab(tabSeleccionVaso);
        }
    }
}