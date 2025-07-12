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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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

            bloquearTabCarga = false;
            bloquearTabEstrella = true;
            bloquearTabPlaneta = true;
            bloquearTabSatelite = true;
            tabControl1.SelectTab(tabCargaCuerpoCeleste);
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

            cmbColorEstrella.Items.Clear();
            cmbColorEstrella.Items.Add(ObservatorioDLL.Color.Rojo);
            cmbColorEstrella.Items.Add(ObservatorioDLL.Color.Naranja);
            cmbColorEstrella.Items.Add(ObservatorioDLL.Color.Amarillo);
            cmbColorEstrella.Items.Add(ObservatorioDLL.Color.Blanco);
            cmbColorEstrella.Items.Add(ObservatorioDLL.Color.Azul);

            cmbTipoEstrella.Items.Clear();
            cmbTipoEstrella.Items.Add(TipoEstrella.Enana);
            cmbTipoEstrella.Items.Add(TipoEstrella.Gigante);
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

        bool esCarga = false;

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
                esCarga = true;
                if (cmbCuerpoCelesteCarga.SelectedItem is "Estrella")
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
            if(string.IsNullOrWhiteSpace(txtNombreAEditar.Text)
                || string.IsNullOrWhiteSpace(txtEdadAEditar.Text)
                || string.IsNullOrWhiteSpace(txtMasaAEditar.Text))
            {
                MessageBox.Show("Por favor, completar los campos de datos del objeto que quieres editar", "Error de selección", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(!(int.TryParse(txtEdadAEditar.Text,out int numero)
                && int.TryParse(txtMasaAEditar.Text,out int numero2)))
            {
                MessageBox.Show("Los valores no son numericos", "Error de operación", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (CuerpoCelesteActual() == null)
            {
                MessageBox.Show("Por favor, seleccionar un objeto de la tabla para editarlo", "Error de operación", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                esCarga = false;
                CuerpoCeleste objetoAEditar = CuerpoCelesteActual();

                if (objetoAEditar is Estrella)
                {
                    PrepararEdicionEstrella();
                }
                else if (objetoAEditar is Planeta)
                {
                    PrepararEdicionPlaneta();
                }
                if (objetoAEditar is Satelite)
                {
                    PrepararEdicionSatelite();
                }
            }
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
            if (objetoActual != null)
            {
                txtCuerpoCelesteAEditar.Text = objetoActual.ToString();
            }
        }

        private void btnEditarEstrella_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txtTemperaturaEstrella.Text)
                || string.IsNullOrWhiteSpace(txtDiametroEstrella.Text)
                || string.IsNullOrWhiteSpace(txtConstelacion.Text))
            {
                MessageBox.Show("Por favor, completar los campos de datos de la estrella", "Error de selección", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(cmbColorEstrella.SelectedItem == null)
            {
                MessageBox.Show("Por favor, seleccione un color", "Error de selección", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(cmbTipoEstrella.SelectedItem == null)
            {
                MessageBox.Show("Por favor, seleccione un  tipo", "Error de selección", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(!(double.TryParse(txtTemperaturaEstrella.Text, out double numero)
                && int.TryParse(txtDiametroEstrella.Text, out int numero2)))
            {
                MessageBox.Show("Los valores no son numericos", "Error de operación", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if(esCarga)
                {
                    CuerpoCeleste nuevaEstrella = new Estrella(txtNombre.Text, Convert.ToInt32(txtEdad.Text), Convert.ToInt32(txtMasa.Text), Convert.ToDouble(txtTemperaturaEstrella.Text), Convert.ToInt32(txtDiametroEstrella.Text), (ObservatorioDLL.Color)cmbColorEstrella.SelectedItem, (TipoEstrella)cmbTipoEstrella.SelectedItem)
                    {
                        nombreConstelacion = txtConstelacion.Text
                    };
                    _obsRegistroCuerpoCeleste.objetosEncontrados.Add(nuevaEstrella);
                    MessageBox.Show("Se guardó la nueva estrella con éxito!", "Operación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    InicializarMenuCarga();
                }
                else
                {
                    if (_obsRegistroCuerpoCeleste.objetosEncontrados.Contains(CuerpoCelesteActual()))
                    {
                        int indice = _obsRegistroCuerpoCeleste.objetosEncontrados.FindIndex(o => o.id == CuerpoCelesteActual().id);
                        _obsRegistroCuerpoCeleste.objetosEncontrados[indice] = new Estrella(txtNombreAEditar.Text, Convert.ToInt32(txtEdadAEditar.Text), Convert.ToInt32(txtMasaAEditar.Text), Convert.ToDouble(txtTemperaturaEstrella.Text), Convert.ToInt32(txtDiametroEstrella.Text), (ObservatorioDLL.Color)cmbColorEstrella.SelectedItem, (TipoEstrella)cmbTipoEstrella.SelectedItem)
                        {
                            nombreConstelacion = txtConstelacion.Text
                        };
                        MessageBox.Show("Se editó la estrella con éxito!", "Operación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        InicializarMenuCarga();
                    }
                }
            }
        }

        private void checkConstelacion_CheckedChanged(object sender, EventArgs e)
        {
            if(checkConstelacion.Checked == true)
            {
                groupBox5.Visible = true;
            }
            else
            {
                groupBox5.Visible = false;
            }
        }

        private void btnCrearConstelacion_Click(object sender, EventArgs e)
        {
            if (!lstConstelaciones.Items.Contains(txtNuevaConstelacion.Text))
            {
                lstConstelaciones.Items.Add(txtNuevaConstelacion.Text);
            }
            else
            {
                MessageBox.Show("Ya existe esta constelación", "Error de operación", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAsignarConstelación_Click(object sender, EventArgs e)
        {
            if(lstConstelaciones.SelectedItem != null)
            {
                txtConstelacion.Text = txtNuevaConstelacion.Text;
            }
            else
            {
                MessageBox.Show("Por favor, selecciona una constelación de la lista", "Error de selección", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void rdEstrella_CheckedChanged(object sender, EventArgs e)
        {
            if(rdEstrella.Checked == true)
            {
                List<Estrella> listaFiltrada = (from Estrella estrella in _obsRegistroCuerpoCeleste.objetosEncontrados
                                                     orderby estrella.id ascending
                                                     select estrella).ToList();
                dgvObjetosEncontrados.DataSource = listaFiltrada;
            }
        }

        private void rdPlaneta_CheckedChanged(object sender, EventArgs e)
        {
            if (rdPlaneta.Checked == true)
            {
                List<Planeta> listaFiltrada = (from Planeta planeta in _obsRegistroCuerpoCeleste.objetosEncontrados
                                               orderby planeta.id ascending
                                               select planeta).ToList();
                dgvObjetosEncontrados.DataSource = listaFiltrada;

            }
        }

        private void rdSatelite_CheckedChanged(object sender, EventArgs e)
        {
            if (rdSatelite.Checked == true)
            {
                List<Satelite> listaFiltrada = (from Satelite satelite in _obsRegistroCuerpoCeleste.objetosEncontrados
                                                orderby satelite.id ascending
                                                select satelite).ToList();
                dgvObjetosEncontrados.DataSource = listaFiltrada;
            }
        }

        private void rdDefault_CheckedChanged(object sender, EventArgs e)
        {
            if(rdDefault.Checked == true)
            {
                InicializarMenuCarga();
            }
        }
    }
}
