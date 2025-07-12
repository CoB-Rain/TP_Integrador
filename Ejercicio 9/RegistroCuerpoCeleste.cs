using ObservatorioDLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_9
{
    public partial class RegistroCuerpoCeleste: Form
    {
        public RegistroCuerpoCeleste()
        {
            InitializeComponent();
        }

        private void RegistroCuerpoCeleste_Load(object sender, EventArgs e)
        {

        }

        private Observatorio _obsRegistroCuerpoCeleste = new Observatorio();

        public Observatorio observatorioRegistroCuerpoCeleste
        {
            get { return _obsRegistroCuerpoCeleste; }
            set { _obsRegistroCuerpoCeleste = value;
                InicializarMenuCarga();
            }
        }

        public CuerpoCeleste CuerpoCelesteActual()
        {
            if (dgvObjetosEncontrados.SelectedCells.Count > 0)
            {
                var celda = dgvObjetosEncontrados.SelectedCells[0];
                var fila = dgvObjetosEncontrados.Rows[celda.RowIndex];
                CuerpoCeleste objetoActual = fila.DataBoundItem as CuerpoCeleste;
                return objetoActual;
            }
            else
            {
                txtCuerpoCelesteAEditar.Clear();
                return null;
            }
        }

        public void InicializarMenuCarga()
        {
            dgvObjetosEncontrados.DataSource = null;
            dgvObjetosEncontrados.DataSource = _obsRegistroCuerpoCeleste.objetosEncontrados.ToArray();

            cmbCuerpoCelesteCarga.Items.Clear();
            cmbCuerpoCelesteCarga.Items.Add("Estrella");
            cmbCuerpoCelesteCarga.Items.Add("Planeta");
            cmbCuerpoCelesteCarga.Items.Add("Satelite");

            cmbObservadorCarga.DataSource = null;
            cmbObservadorCarga.DataSource = _obsRegistroCuerpoCeleste.descubridores.ToArray();
        }

        bool bloquearTabCarga = false;
        bool bloquearTabEstrella = true;
        bool bloquearTabPlaneta = true;
        bool bloquearTabSatelite = true;


        private void PrepararEdicionEstrella()
        {
            bloquearTabCarga = true;
            bloquearTabEstrella = false;
            tabControl1.SelectTab(tabEditarEstrella);
        }

        private void PrepararEdicionPlaneta()
        {
            bloquearTabCarga = true;
            bloquearTabPlaneta = false;
            tabControl1.SelectTab(tabEditarPlaneta);
        }

        private void PrepararEdicionSatelite()
        {
            bloquearTabCarga = true;
            bloquearTabSatelite = false;
            tabControl1.SelectTab(tabEditarSatelite);
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            if(cmbObservadorCarga.SelectedItem == null)
            {
                MessageBox.Show("Por favor, indique qué descubridor encontró el cuerpo celeste.", "Error de selección", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(cmbCuerpoCelesteCarga.SelectedItem == null)
            {
                MessageBox.Show("Por favor, indique qué cuerpo celeste se encontró.", "Error de selección", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrWhiteSpace(txtNombre.Text)
                    || string.IsNullOrWhiteSpace(txtEdad.Text)
                    || string.IsNullOrWhiteSpace(txtMasa.Text))
            {
                MessageBox.Show("Por favor, completar los campos de datos del objeto encontrado", "Error de selección", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if(cmbCuerpoCelesteCarga.SelectedItem is "Estrella")
                {
                    PrepararEdicionEstrella();
                }
                else if (cmbCuerpoCelesteCarga.SelectedItem is "Planeta")
                {
                    PrepararEdicionPlaneta();
                }
                if (cmbCuerpoCelesteCarga.SelectedItem is "Satelite")
                {
                    PrepararEdicionSatelite();
                }
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            
        }

        private void tabControl1_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if (bloquearTabCarga && e.TabPage == tabCargaCuerpoCeleste)
            {
                e.Cancel = true;
                MessageBox.Show("Esta pestaña está deshabilitada", "Error de Operación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            if (bloquearTabEstrella && e.TabPage == tabEditarEstrella)
            {
                e.Cancel = true;
                MessageBox.Show("Esta pestaña está deshabilitada", "Error de Operación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            if (bloquearTabPlaneta && e.TabPage == tabEditarPlaneta)
            {
                e.Cancel = true;
                MessageBox.Show("Esta pestaña está deshabilitada", "Error de Operación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            if (bloquearTabSatelite && e.TabPage == tabEditarSatelite)
            {
                e.Cancel = true;
                MessageBox.Show("Esta pestaña está deshabilitada", "Error de Operación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void dgvObjetosEncontrados_SelectionChanged(object sender, EventArgs e)
        {
            CuerpoCeleste objetoActual = CuerpoCelesteActual();
            if(objetoActual != null)
            {
                txtCuerpoCelesteAEditar.Text = objetoActual.ToString();
            }
        }
    }
}
