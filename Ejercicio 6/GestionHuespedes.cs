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
    public partial class GestionHuespedes: Form
    {
        public GestionHuespedes()
        {
            InitializeComponent();
        }

        private void GestionHuespedes_Load(object sender, EventArgs e)
        {
            
        }

        private HotelTuristico _gHuespedes = new HotelTuristico();

        public HotelTuristico gHuespedes
        {
            get { return _gHuespedes; }
            set { _gHuespedes = value;
                ActualizarDatos();
            }
        }

        private void btnCrearHuesped_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrWhiteSpace(txtNombre.Text) && !string.IsNullOrWhiteSpace(txtApellido.Text))
            {
                DateTime fechaNacimiento = dateFechaNacimiento.SelectionStart;
                Huesped nuevoHuesped = new Huesped((long)numDNI.Value, txtNombre.Text, txtApellido.Text, fechaNacimiento);
                if (nuevoHuesped.Edad >= 18)
                {
                    // Válido: puede reservar
                    bool Existe = _gHuespedes.huespedes.Any(d => d.DNI == nuevoHuesped.DNI);
                    if(!Existe)
                    {
                        _gHuespedes.huespedes.Add(nuevoHuesped);
                        ActualizarDatos();
                        MessageBox.Show("Se ha registrado el huesped con exito!", "Operación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("El huesped ya existe en nuestra BBDD", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Debe ser mayor de 18 años para registrarse.", "Error de operación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Por favor, llene todos los campos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ActualizarDatos()
        {
            dgvHuespedes.DataSource = null;
            dgvHuespedes.DataSource = _gHuespedes.huespedes.ToList();
        }
    }
}
