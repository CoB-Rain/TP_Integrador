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
    public partial class Form1: Form
    {
        #region Consigna
        /*
        Un after office vende diferentes tipos de cerveza tiradas de barril,
        las mismas se describen a continuación:
            • Rubia de origen nacional, cuyo valor por litro es de $50.
            • Negra de origen nacional, cuyo valor por litro es de $58.
            • Rubia de origen extranjero cuyo valor por litro es de $65.

        Cada barril puede tener un solo tipo de cerveza, y dada las dimensiones del negocio,
        el sistema debe contemplar el agregado de barriles en función del tiempo.

        Cada venta se ve afectada por un cálculo de incremento de valor de la cerveza
        en un 5%, que depende del tipo de vaso donde se sirve:
            • Chopp de 3/4 litros
            • Vaso de 1/2 litro
            • Jara de 3 litros

        Desarrollar una aplicación Orientada a Objetos utilizando C# que permita:
        1) Calcular la recaudación total del after. {OK}
        2) Obtener el barril más y menos cerveza sirvió, y mostrar las cantidades. {OK}
        3) Obtener el barril que más dinero recaudó. {OK}
        4) Mostrar la cerveza más vendida. {OK}
        5) Mostrar la cerveza que generó más ganancia. {OK}
        6) Obtener la cerveza que se vendió mayor cantidad de litros. {OK}
        7) Obtener la cerveza que se vendió menor cantidad de litros. {OK}
        8) Obtener el tipo de vaso que más se solicitó. {OK}
        9) Calcular el porcentaje de venta de cada tipo de cerveza. {OK}
        10) Calcular el porcentaje de recaudación de cada tipo de cerveza. {OK}
        11) Calcular el porcentaje de venta de cada barril. {OK}
        12) Calcular el porcentaje de recaudación de cada barril. {OK}
        */
        #endregion

        private AfterOffice _afterPrincipal = new AfterOffice();

        public AfterOffice AfterPrincipal
        {
            get { return _afterPrincipal; }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void salirToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void vistaClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VistaCliente frmVistaCliente = new VistaCliente();
            frmVistaCliente.AfterCliente = _afterPrincipal;
            frmVistaCliente.MdiParent = this;
            frmVistaCliente.Show();
        }

        private void afterOfficeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Administracion frmAdm = new Administracion();
            frmAdm.AfterAdministracion = _afterPrincipal;
            frmAdm.MdiParent = this;
            frmAdm.Show();
        }

        private void barrilesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Barriles frmBarriles = new Barriles();
            frmBarriles.AfterBarriles = _afterPrincipal;
            frmBarriles.MdiParent = this;
            frmBarriles.Show();
        }

    }
}
