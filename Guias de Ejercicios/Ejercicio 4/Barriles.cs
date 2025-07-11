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
    public partial class Barriles: Form
    {
        private AfterOffice _afterBarriles = new AfterOffice();

        public AfterOffice AfterBarriles
        {
            get { return _afterBarriles; }
            set { _afterBarriles = value;
                CargarInfoBasica();
            }
        }

        void CargarInfoBasica()
        {
            dgvBarriles.DataSource = null;
            
            var datosBarriles = _afterBarriles.Barriles.Select(b => new
            {
                Número = b.Numero,
                Contenido = b.Contenido.Sabor,
                Origen = b.Contenido.Origen,
                Capacidad = b.Capacidad,
                Nivel = b.Nivel
            }).ToList();

            dgvBarriles.DataSource = datosBarriles;
        }


        public void InicializarSabores()
        {
            cmbCervezaOrigen.DataSource = null;
            cmbCervezaOrigen.Items.Add(Origen.Nacional);
            cmbCervezaOrigen.Items.Add(Origen.Extranjero);

            cmbCervezaSabor.DataSource = null;
            cmbCervezaSabor.Items.Add(Sabor.Rubia);
            cmbCervezaSabor.Items.Add(Sabor.Negra);
        }

        public Barriles()
        {
            InitializeComponent();
        }

        private void Barriles_Load(object sender, EventArgs e)
        {
            InicializarSabores();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (cmbCervezaSabor.SelectedItem != null && cmbCervezaOrigen.SelectedItem != null)
            {
                if(!(cmbCervezaSabor.SelectedItem.Equals(Sabor.Negra) && cmbCervezaOrigen.SelectedItem.Equals(Origen.Extranjero)))
                {
                    //falso
                    Cerveza cerveza;
                    if(cmbCervezaSabor.SelectedItem.Equals(Sabor.Negra))
                    {
                        cerveza = _afterBarriles.NegraNacional;
                    }
                    else if(cmbCervezaOrigen.SelectedItem.Equals(Origen.Nacional))
                    {
                        cerveza = _afterBarriles.RubiaNacional;
                    }
                    else
                    {
                        cerveza = _afterBarriles.RubiaExtranjero;
                    }

                    Barril nuevoBarril = new Barril(cerveza);
                    _afterBarriles.Barriles.Add(nuevoBarril);
                    CargarInfoBasica();
                }
                else
                {
                    //verdadero
                    MessageBox.Show($"No existe el tipo de cerveza 'Negra Extranjero'.{Environment.NewLine}Por favor, seleccione otro tipo de cerveza", "Error de Selección", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione el tipo de cerveza que tendrá el barril.", "Error de Selección", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void cmbCervezaSabor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCervezaOrigen.SelectedItem != null)
            {
                if (cmbCervezaSabor.SelectedItem.Equals(Sabor.Negra))
                {
                    if(!cmbCervezaOrigen.SelectedItem.Equals(Origen.Extranjero))
                    {
                        txtPrecio.Text = $"$ {_afterBarriles.NegraNacional.Precio}";
                    }
                    else
                    {
                        txtPrecio.Text = "$ 0.0";
                    }
                }
                else
                {
                    if (cmbCervezaOrigen.SelectedItem.Equals(Origen.Nacional))
                    {
                        txtPrecio.Text = $"$ {_afterBarriles.RubiaNacional.Precio}";
                    }
                    else
                    {
                        txtPrecio.Text = $"$ {_afterBarriles.RubiaExtranjero.Precio}";
                    }
                }
            }
            else
            {
                txtPrecio.Text = "$ 0.0";
            }
        }

        private void cmbCervezaOrigen_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbCervezaSabor.SelectedItem != null)
            {
                if (cmbCervezaOrigen.SelectedItem.Equals(Origen.Extranjero))
                {
                    if (!cmbCervezaSabor.SelectedItem.Equals(Sabor.Negra))
                    {
                        txtPrecio.Text = $"$ {_afterBarriles.RubiaExtranjero.Precio}";
                    }
                    else
                    {
                        txtPrecio.Text = "$ 0.0";
                    }
                }
                else if(cmbCervezaSabor.SelectedItem.Equals(Sabor.Rubia))
                {
                    txtPrecio.Text = $"$ {_afterBarriles.RubiaNacional.Precio}";
                }
                else
                {
                    txtPrecio.Text = $"$ {_afterBarriles.NegraNacional.Precio}";
                }
            }
            else
            {
                txtPrecio.Text = "$ 0.0";
            }
        }

        private void btnRecargar_Click(object sender, EventArgs e)
        {
            if(dgvBarriles.CurrentRow != null)
            {
                int index = dgvBarriles.CurrentRow.Index;
                Barril barrilSeleccionado = _afterBarriles.Barriles[index];

                if(barrilSeleccionado.Recargar())
                {
                    MessageBox.Show($"Barril {barrilSeleccionado.Numero} recargado.", "Recarga Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarInfoBasica();
                }
                else
                {
                    MessageBox.Show("El barril que estas intentando recargar tiene el nivel máx.", "Error de operación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione el barril que desea recargar", "Error de selección", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            groupBox3.Visible = true;
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            dgvInformacionAvanzada.DataSource = null;

            _afterBarriles.CalcularPorcentajeVentaBarriles();
            _afterBarriles.CalcularPorcentajeRecaudacionBarriles();

            var datosAvanzados = _afterBarriles.Barriles.Select(a => new
            {
                Número = a.Numero,
                Contenido = a.Contenido.Sabor,
                a.Contenido.Origen,
                a.Contenido.Precio,
                a.Capacidad,
                a.Nivel,
                Ingreso = a.FechaIngreso,
                Recaudacion = a.RecaudacionBarril,
                TotalVentas = a.CantidadVentas,
                Recargas = a.CantidadRecargas,
                a.LitrosServidos,
                pVenta = a.PorcentajeVenta,
                pRecaudacion = a.PorcentajeRecaudacion
            }).ToList();

            dgvInformacionAvanzada.DataSource = datosAvanzados;
        }

        private void btnMostrarBasica_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
        }

        private void btnAgregarFecha_Click(object sender, EventArgs e)
        {
            if (cmbCervezaSabor.SelectedItem != null && cmbCervezaOrigen.SelectedItem != null)
            {
                if (!(cmbCervezaSabor.SelectedItem.Equals(Sabor.Negra) && cmbCervezaOrigen.SelectedItem.Equals(Origen.Extranjero)))
                {
                    //falso
                    Cerveza cerveza;
                    if (cmbCervezaSabor.SelectedItem.Equals(Sabor.Negra))
                    {
                        cerveza = _afterBarriles.NegraNacional;
                    }
                    else if (cmbCervezaOrigen.SelectedItem.Equals(Origen.Nacional))
                    {
                        cerveza = _afterBarriles.RubiaNacional;
                    }
                    else
                    {
                        cerveza = _afterBarriles.RubiaExtranjero;
                    }

                    Barril nuevoBarril2 = new Barril(cerveza, dateTimePicker1.Value);
                    _afterBarriles.Barriles.Add(nuevoBarril2);
                    CargarInfoBasica();
                }
                else
                {
                    //verdadero
                    MessageBox.Show($"No existe el tipo de cerveza 'Negra Extranjero'.{Environment.NewLine}Por favor, seleccione otro tipo de cerveza", "Error de Selección", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione el tipo de cerveza que tendrá el barril.", "Error de Selección", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
