using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_5
{
    public partial class CrearJuez: Form
    {
        private Polideportivo _pJuez = new Polideportivo();

        public Polideportivo pJuez
        {
            get { return _pJuez; }
            set
            {
                _pJuez = value;
                InicializarJueces();
            }
        }

        public CrearJuez()
        {
            InitializeComponent();
        }

        private void CrearJuez_Load(object sender, EventArgs e)
        {

        }

        private void InicializarJueces()
        {
            dgvJueces.DataSource = null;
            var datosJueces = _pJuez.arbitros.Select(j => new
            {
                j.Legajo,
                j.Nombre,
                j.Apellido
            }).ToList();
            dgvJueces.DataSource = datosJueces;
        }

        private void btnContratar_Click(object sender, EventArgs e)
        {

        }

        private void btnDespedir_Click(object sender, EventArgs e)
        {
            if(dgvJueces.SelectedCells.Equals(null))
                MessageBox.Show("No has seleccionado el Juez que deseas eliminar.", "Error de Selección", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else
            {

            }
        }
    }
}
