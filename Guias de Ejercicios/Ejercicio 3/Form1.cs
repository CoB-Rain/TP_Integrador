using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_3
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /*
        Una cafetería cuenta con varias de máquinas de preparar café.
        Cada máquina puede hacer 1 solo tipo de café. Los tipos de café con sus precios por litro son:
           • Arábigo $50.
           • Robusto: $58.
        El café se puede servir en diferentes vasos:
           • Vaso Chico: 50 cm3
           • Vaso Mediano: 100 cm3
           • Vaso Grande ¼ litro.
        Desarrollar una aplicación orientada a objetos utilizando C# que permita:
        1) Obtener la recaudación total del negocio. {OK}
        2) Obtener la recaudación por máquina de café. {OK}
        3) Mostrar la máquina que más café sirvió. {OK}
        4) Mostrar la máquina que menos café sirvió. {OK}
        5) Mostrar la máquina que más dinero recaudó. {OK}
        6) Mostrar la máquina que menos dinero recaudó. {OK}
        7) Mostrar el café que más veces se sirvió. {OK}
        8) Mostrar el café que menos veces se sirvió. {OK}
        9) Mostrar el café que dejó mayor recaudación. {OK}
        10) Mostrar el café que menos recaudación dejó. {OK}
        11) Mostrar el porcentaje de venta y recaudación de cada café. {OK}
        12) Mostrar el porcentaje de venta y recaudación de cada máquina. {OK}
        13) Informar y recargar cada vez que una máquina se encuentre vacía. {OK}
        14) Mostrar la máquina que mayor cantidad de veces se recargó. {OK}
        */

        Cafeteria cafeteria = new Cafeteria();
        MaquinaCafe maquinaTemp;
        Cafe cafeTemp;
        Vaso vasoTemp;

        public void InicializarTiposCafe()
        {
            cmbTipoCafe.Items.Clear();
            cmbTipoCafe.Items.Add(cafeteria.Arabigo);
            cmbTipoCafe.Items.Add(cafeteria.Robusto);
            cmbTipoCafe.DisplayMember = "Tipo";
        }

        public void InicializarMaquinas()
        {
            dgvMaquinasCafe.DataSource = null;
            //dgvMaquinasCafe.DataSource = cafeteria.Maquinas;
            //dgvMaquinasCafe.Columns[RecaudacionMaquina].Visible = false;
            var datosParaMostrar = cafeteria.Maquinas.Select(m => new
            {
                Número = m.Numero,
                Contenido = m.Cafe.Tipo,
                Capacidad = m.Capacidad,
                Nivel = m.Nivel
            }).ToList();

            dgvMaquinasCafe.DataSource = datosParaMostrar;

            lstMaquinasCafe.DataSource = null;  
            lstMaquinasCafe.DataSource = cafeteria.Maquinas;
        }

        public void InicializarVasos()
        {
            cmbVasos.Items.Clear();
            cmbVasos.Items.Add(cafeteria.Chico);
            cmbVasos.Items.Add(cafeteria.Mediano);
            cmbVasos.Items.Add(cafeteria.Grande);
            cmbVasos.DisplayMember = "Tipo";
            lstVasosPendientes.DisplayMember = "Tipo";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InicializarTiposCafe();
            InicializarMaquinas();
            InicializarVasos();
            lstVasosServidos.DisplayMember = "DescripcionParaLista";
        }

        private void btnAgregarMaquina_Click(object sender, EventArgs e)
        {
            if (cmbTipoCafe.SelectedItem != null)
            {
                //cafeTemp = cmbTipoCafe.SelectedItem as Cafe;
                MaquinaCafe nuevaMaquina = new MaquinaCafe(cafeTemp);
                cafeteria.Maquinas.Add(nuevaMaquina);
                InicializarMaquinas();
            }
            else
            {
                MessageBox.Show("Por favor seleccione el tipo de cafe que manipulará la maquina.", "Error de Selección", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void cmbTipoCafe_SelectedIndexChanged(object sender, EventArgs e)
        {
            cafeTemp = (Cafe)cmbTipoCafe.SelectedItem;
            txtPrecio.Text = "$ " + cafeTemp.Precio.ToString();
        }

        private void lstMaquinasCafe_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lstMaquinasCafe.SelectedItem != null)
            {
                maquinaTemp = (MaquinaCafe)lstMaquinasCafe.SelectedItem;
                txtTipoCafeCliente.Text = maquinaTemp.Cafe.Tipo.ToString();
                if (lstVasosPendientes.SelectedItem != null)
                {
                    txtPrecioCliente.Text = "$ " + (maquinaTemp.Cafe.Precio * vasoTemp.Capacidad) / 1000;
                    btnServir.Enabled = true;
                }
            }
            else
            {
                txtTipoCafeCliente.Text = "";
                txtPrecioCliente.Text = "$ ";
            }
        }

        private void btnAgregarALista_Click(object sender, EventArgs e)
        {
            if(cmbVasos.SelectedItem != null)
            {
                for (int i = 0; i < numCantidadVasos.Value; i++)
                {
                    lstVasosPendientes.Items.Add(cmbVasos.SelectedItem as Vaso);
                }
            }
            else
            {
                MessageBox.Show("Por favor seleccione el tipo de vaso que desea", "Error de Selección", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void cmbTiposVasos_SelectedIndexChanged(object sender, EventArgs e)
        {
            vasoTemp = (Vaso)cmbVasos.SelectedItem;
            txtCapacidad.Text = vasoTemp.Capacidad.ToString() + "ml";
        }

        private void lstVasosPendientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lstVasosPendientes.SelectedItem != null)
            {
                vasoTemp = lstVasosPendientes.SelectedItem as Vaso;
                if (lstMaquinasCafe.SelectedItem != null)
                {
                    maquinaTemp = (MaquinaCafe)lstMaquinasCafe.SelectedItem;
                    txtPrecioCliente.Text = "$ " + (maquinaTemp.Cafe.Precio * vasoTemp.Capacidad) / 1000;
                    btnServir.Enabled = true;
                }
            }
        }

        private void btnServir_Click(object sender, EventArgs e)
        {
            int flagRecargas = maquinaTemp.CantidadRecargas;
            VasoCafe vasoLleno = maquinaTemp.Cargar(vasoTemp);
            if(maquinaTemp.CantidadRecargas > flagRecargas)
            {
                MessageBox.Show("La máquina llego a cero, se realizó la carga de café automaticamente", "Recarga automatica exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            if (vasoLleno != null)
            {
                lstVasosServidos.Items.Add(vasoLleno);

                lstVasosPendientes.Items.Remove(vasoTemp);

                btnRealizarPedido.Enabled = true;
                btnServir.Enabled = false;

                InicializarMaquinas();
            }
            else
            {
                MessageBox.Show("La maquina de café no tiene el nivel de café suficiente para servir..", "Error de operación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnRecargarMaquina_Click(object sender, EventArgs e)
        {
            if (dgvMaquinasCafe.CurrentRow != null)
            {
                int index = dgvMaquinasCafe.CurrentRow.Index;
                MaquinaCafe maquinaSeleccionada = cafeteria.Maquinas[index];

                if(maquinaSeleccionada.Recargar())
                {
                    MessageBox.Show($"Máquina {maquinaSeleccionada.Numero} recargada.", "Recarga Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    InicializarMaquinas();
                }
                else
                {
                    MessageBox.Show("La máquina que estas intentando recargar tiene el nivel máx.", "Error de operación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione la maquina que desea recargar", "Error de selección", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnRealizarPedido_Click(object sender, EventArgs e)
        {
            if (lstVasosServidos.CheckedItems.Count > 0)
            {
                //Guardamos todos los vasos que seleccionamos en una lista
                List<VasoCafe> vasosSeleccionados = new List<VasoCafe>();

                //Utilizamos "HashSet" para almacenar en una lista
                //los cafes y maquinas usadas (sin repetirlas)
                HashSet<Cafe> cafesUsados = new HashSet<Cafe>();
                HashSet<MaquinaCafe> maquinasUsadas = new HashSet<MaquinaCafe>();

                foreach (VasoCafe vasoLleno in lstVasosServidos.CheckedItems)
                {
                    vasoLleno.RegistrarVenta();
                    vasosSeleccionados.Add(vasoLleno);

                    // Acumulamos cafés y máquinas utilizados
                    cafesUsados.Add(vasoLleno.Contenido);
                    maquinasUsadas.Add(vasoLleno.MaquinaOrigen);
                }

                // Registrar una venta por cada café distinto
                foreach (Cafe cafe in cafesUsados)
                {
                    cafe.RegistrarVentaUnitaria();
                }

                // Registrar una venta por cada máquina distinta
                foreach (MaquinaCafe maquina in maquinasUsadas)
                {
                    maquina.RegistrarCliente();
                }

                foreach (VasoCafe vaso in vasosSeleccionados)
                {
                    lstVasosServidos.Items.Remove(vaso);
                }

                txtTotal.Text = "$ 0.00";

                MessageBox.Show("Se tomo tu pedido y se realizaron las ventas correspondientes", "Venta realizada con éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Por favor, seleccione el/los cafe que desea pagar", "Error de selección", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void lstVasosServidos_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            double total = 0.0;
            foreach (VasoCafe vasoLleno in lstVasosServidos.CheckedItems)
            {
                total += (vasoLleno.Capacidad * vasoLleno.Contenido.Precio) / 1000.0;
            }

            // Sumamos o restamos el ítem que se está cambiando en este momento
            VasoCafe vasoActual = lstVasosServidos.Items[e.Index] as VasoCafe;
            if (e.NewValue == CheckState.Checked)
            {
                total += (vasoActual.Capacidad * vasoActual.Contenido.Precio) / 1000.0;
            }
            else
            {
                total -= (vasoActual.Capacidad * vasoActual.Contenido.Precio) / 1000.0;
            }

            // Convertimos el número, no el objeto, a texto
            txtTotal.Text = "$ " + total.ToString("F2");
        }

        private void btnEstadisticasMaquinas_Click(object sender, EventArgs e)
        {
            if (cafeteria.Maquinas.Count > 0)
            {
                cafeteria.CalcularPorcentajeRecaudacionMaquina();
                cafeteria.CalcularPorcentajeVentaMaquina();
                ActualizarInfoMaquinas();
            }
            else
            {
                MessageBox.Show("La cafetería no cuenta con ninguna maquina por el momento", "Error de operación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnEstadisticasCafé_Click(object sender, EventArgs e)
        {
            ActualizarInfoCafe();
        }

        private void btnEstadisticasCafeteria_Click(object sender, EventArgs e)
        {
            if (cafeteria.Maquinas.Count > 0)
            {
                ActualizarInfoCafeteria();
            }
            else
            {
                MessageBox.Show("La cafetería no cuenta con ninguna maquina por el momento", "Error de operación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void ActualizarInfoCafeteria()
        {

            txtInformacionCafeteria.Text = string.Empty;
            txtInformacionCafeteria.Text = $"Recaudación total de la cafetería: ${cafeteria.CalcularRecaudacionTotal()}" + Environment.NewLine +
            $"La máquina que más cafe sirvio es: Máquina {cafeteria.ObtenerMaquinaMasCafeSirvio().Numero}" + Environment.NewLine +
            $"La máquina que menos cafe sirvio es: Máquina {cafeteria.ObtenerMaquinaMenosCafeSirvio().Numero}" + Environment.NewLine +
            $"La máquina que más dinero recaudo es: Máquina {cafeteria.ObtenerMaquinaMayorRecaudacion().Numero}" + Environment.NewLine +
            $"La máquina que menos dinero recaudo es: Máquina {cafeteria.ObtenerMaquinaMenorRecaudacion().Numero}" + Environment.NewLine +
            $"La máquina que más veces se recargo es: Máquina {cafeteria.ObtenerMaquinaMayorRecargas().Numero}" + Environment.NewLine +
            Environment.NewLine +
            $"El café que más veces se sirvió es: Café {cafeteria.ObtenerCafeMasDemandado().Tipo}" + Environment.NewLine +
            $"El café que menos veces se sirvió es: Café {cafeteria.ObtenerCafeMenosDemandado().Tipo}" + Environment.NewLine +
            $"El café que más dinero recaudó es: Café {cafeteria.ObtenerCafeMayorRecaudacion().Tipo}" + Environment.NewLine +
            $"El café que menos dinero recaudó es: Café {cafeteria.ObtenerCafeMenorRecaudacion().Tipo}" + Environment.NewLine;
        }

        public void ActualizarInfoCafe()
        {
            txtInformacionCafe.Text = string.Empty;
            txtInformacionCafe.Text = $"Cafe: {cafeteria.Arabigo.Tipo.ToString()} | Total recaudado: ${cafeteria.Arabigo.RecaudacionCafe.ToString()} - Cantidad de ventas efectuadas: {cafeteria.Arabigo.CantidadVentas.ToString()}" + Environment.NewLine +
            $"Porcentaje de venta: %{cafeteria.CalcularPorcentajeVentaCafe(cafeteria.Arabigo).ToString()}" + Environment.NewLine +
            $"Porcentaje de recaudación: %{cafeteria.CalcularPorcentajeRecaudacionCafe(cafeteria.Arabigo).ToString()}" + Environment.NewLine +
            Environment.NewLine +
            $"Cafe: {cafeteria.Robusto.Tipo.ToString()} | Total recaudado: ${cafeteria.Robusto.RecaudacionCafe.ToString()} - Cantidad de ventas efectuadas: {cafeteria.Robusto.CantidadVentas.ToString()}" + Environment.NewLine +
            $"Porcentaje de venta: %{cafeteria.CalcularPorcentajeVentaCafe(cafeteria.Robusto).ToString()}" + Environment.NewLine +
            $"Porcentaje de recaudación: %{cafeteria.CalcularPorcentajeRecaudacionCafe(cafeteria.Robusto).ToString()}" + Environment.NewLine +

            $"";
        }


        public void ActualizarInfoMaquinas()
        {
            dgvInformacionMaquinas.DataSource = null;
            
            var datosParaMostrar = cafeteria.Maquinas.Select(m => new
            {
                Número = m.Numero,
                Contenido = m.Cafe,
                Recaudación = m.RecaudacionMaquina,
                CantClientes = m.CantidadClientes,
                CantRecargas = m.CantidadRecargas,
                CantCafeServido = m.CantidadCafeServido,
                PorcentajeVenta = m.PorcentajeVenta,
                PorcentajeRecaudación = m.PorcentajeRecaudacion
            }).ToList();
            
            dgvInformacionMaquinas.DataSource = datosParaMostrar;
        }
    }
}
