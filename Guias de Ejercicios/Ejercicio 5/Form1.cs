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
    public partial class Form1: Form
    {
        #region Consigna
        /*
            Un polideportivo necesita un sistema que le permita administrar los alquileres de sus diferentes canchas.
            Cada cancha posee un valor de base por hora, y en algunos casos pueden tener agregados, se detalla a continuación:

                • Canchas de tenis:
                    o Valor: $200.
                    o Opcional: 1 árbitro, adiciona $100 al valor de la cancha y la ganancia del juez es de $50.
                • Canchas de fútbol 5:
                    o Valor: $500
                    o No posee adicionales.
                • Canchas de fútbol 7:
                    o Valor: $650.
                    o Opcional: 1 árbitro, adiciona $100 al valor de la cancha y la ganancia del juez es de $50.
                • Canchas de fútbol 11:
                    o Valor: $800.
                    o Opcional 1: 1 árbitro, adiciona $100 al valor de la cancha y la ganancia del juez es de $50.
                    o Opcional 2: Agregando el “opcional 1” se puede agregar 2 jueces de línea al alquiler,
                                  incrementando $90 al costo total, y la recaudación de cada juez de línea es de $35.
            
            De cada juez se registra, el nombre, apellido y el legajo.

            Desarrollar una aplicación Orientada a Objetos utilizando C# que permita:
            1) Obtener la recaudación total del polideportivo.
            2) Obtener la ganancia total del polideportivo (Descontando los gastos de los jueces).
            3) Obtener la cancha que más se alquiló.
            4) Obtener la cancha que más recaudó.
            5) Obtener el juez que más partidos dirigió.
            6) Obtener el juez que con mayor recaudación.
            7) No permitir que un juez pueda dirigir 2 partidos en simultáneo.
            8) No permitir que los alquileres de las canchas se superpongan, administrarlos por horarios.
        */
        #endregion

        private Polideportivo _pPrincipal = new Polideportivo();

        public Polideportivo pPrincipal
        {
            get { return _pPrincipal; }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ElementosDefault();
        }

        private void ElementosDefault()
        {
            Cancha cancha = new Cancha(TipoCancha.tennis);
            _pPrincipal.canchas.Add(cancha);

            cancha = new Cancha(TipoCancha.futbol5);
            _pPrincipal.canchas.Add(cancha);

            cancha = new Cancha(TipoCancha.futbol7);
            _pPrincipal.canchas.Add(cancha);

            cancha = new Cancha(TipoCancha.futbol11);
            _pPrincipal.canchas.Add(cancha);

            Juez juez = new Juez()
            {
                Nombre = "Juez",
                Apellido = "Default"
            };
            _pPrincipal.arbitros.Add(juez);
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void canchaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CrearCancha frmCrearCancha = new CrearCancha();
            frmCrearCancha.MdiParent = this;
            frmCrearCancha.pCancha = _pPrincipal;
            frmCrearCancha.Show();
        }

        private void juezToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CrearJuez frmCrearJuez = new CrearJuez();
            frmCrearJuez.MdiParent = this;
            frmCrearJuez.pJuez = _pPrincipal;
            frmCrearJuez.Show();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CrearAlquiler frmCrearAlquiler = new CrearAlquiler();
            frmCrearAlquiler.MdiParent = this;
            frmCrearAlquiler.pAlquiler = _pPrincipal;
            frmCrearAlquiler.Show();
        }

        private void polideportivoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdministrarPolideportivo frmAdmPol = new AdministrarPolideportivo();
            frmAdmPol.MdiParent = this;
            frmAdmPol.pAdministracion = _pPrincipal;
            frmAdmPol.Show();
        }
    }
}
