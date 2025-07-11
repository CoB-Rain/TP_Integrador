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
            set { _obsRegistroCuerpoCeleste = value; }
        }
    }
}
