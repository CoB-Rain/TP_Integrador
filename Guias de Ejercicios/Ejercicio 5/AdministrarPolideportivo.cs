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
    public partial class AdministrarPolideportivo: Form
    {
        private Polideportivo _pAdministracion = new Polideportivo();

        public Polideportivo pAdministracion
        {
            get { return _pAdministracion; }
            set { _pAdministracion = value; }
        }

        public AdministrarPolideportivo()
        {
            InitializeComponent();
        }

        private void AdministrarPolideportivo_Load(object sender, EventArgs e)
        {

        }
    }
}
