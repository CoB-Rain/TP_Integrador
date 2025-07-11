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
    public partial class Administracion: Form
    {
        public Administracion()
        {
            InitializeComponent();
        }

        private void Administracion_Load(object sender, EventArgs e)
        {

        }

        private Observatorio _obsAdministracion = new Observatorio();

        public Observatorio observatorioAdm
        {
            get { return _obsAdministracion; }
            set { _obsAdministracion = value; }
        }

    }
}
