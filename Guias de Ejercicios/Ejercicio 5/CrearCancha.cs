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
    public partial class CrearCancha: Form
    {
        private Polideportivo _pCancha;

        public Polideportivo pCancha
        {
            get { return _pCancha; }
            set { _pCancha = value; }
        }

        public CrearCancha()
        {
            InitializeComponent();
        }

        private void CrearCancha_Load(object sender, EventArgs e)
        {

        }
    }
}
