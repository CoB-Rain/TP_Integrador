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
    public partial class CrearAlquiler: Form
    {
        private Polideportivo _pAlquiler = new Polideportivo();

        public Polideportivo pAlquiler
        {
            get { return _pAlquiler; }
            set { _pAlquiler = value; }
        }

        public CrearAlquiler()
        {
            InitializeComponent();
        }

        private void CrearAlquiler_Load(object sender, EventArgs e)
        {

        }
    }
}
