using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Core.Erp.Business.General;
using Core.Erp.Info.General;
using Core.Erp.Business.SeguridadAcceso;
using Core.Erp.Info.SeguridadAcceso;

namespace Core.Erp.Winform.Controles
{
    public partial class UCGe_Menu_Comprobantes_Recibidos : UserControl
    {
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;

        public delegate void delegate_btnAceptar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e);
        public event delegate_btnAceptar_ItemClick event_btnAceptar_ItemClick;

        public delegate void delegate_beiBuscar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e);
        public event delegate_beiBuscar_ItemClick event_beiBuscar_ItemClick;

        public delegate void delegate_btnProvisionarFactura_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e);
        public event delegate_btnProvisionarFactura_ItemClick event_btnProvisionarFactura_ItemClick;

        public delegate void delegate_btnEliminar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e);
        public event delegate_btnEliminar_ItemClick event_btnEliminar_ItemClick;

        public delegate void delegate_btnSalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e);
        public event delegate_btnSalir_ItemClick event_btnSalir_ItemClick;

        public delegate void delegate_btnImprimir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e);
        public event delegate_btnImprimir_ItemClick event_btnImprimir_ItemClick;

        public Boolean Visible_Grupo_Acciones
        {
            get { return this.Grupo_Acciones.Visible; }
            set { this.Grupo_Acciones.Visible = value; }
        }

        public Boolean Visible_Grupo_Filtro
        {
            get { return this.Grupo_Filtro.Visible; }
            set { this.Grupo_Filtro.Visible = value; }
        }

        public Boolean Visible_Grupo_CxP
        {
            get { return this.Grupo_CxP.Visible; }
            set { this.Grupo_CxP.Visible = value; }
        }

        public DevExpress.XtraBars.BarItemVisibility Visible_FechaInicio
        {
            get { return this.beiFechaIni.Visibility; }
            set { this.beiFechaIni.Visibility = value; }
        }

        public DevExpress.XtraBars.BarItemVisibility Visible_FechaFin
        {
            get { return this.beiFechaFin.Visibility; }
            set { this.beiFechaFin.Visibility = value; }
        }

        public DevExpress.XtraBars.BarItemVisibility Visible_TipoComprobante
        {
            get { return this.beiTipoComprobante.Visibility; }
            set { this.beiTipoComprobante.Visibility = value; }
        }

        public DevExpress.XtraBars.BarItemVisibility Visible_btnImprimir
        {
            get { return this.btnImprimir.Visibility; }
            set { this.btnImprimir.Visibility = value; }
        }

        public DevExpress.XtraBars.BarItemVisibility Visible_btnAceptar
        {
            get { return this.btnAceptar.Visibility; }
            set { this.btnAceptar.Visibility = value; }
        }

        public DevExpress.XtraBars.BarItemVisibility Visible_btnEliminar
        {
            get { return this.btnEliminar.Visibility; }
            set { this.btnEliminar.Visibility = value; }
        }

        public UCGe_Menu_Comprobantes_Recibidos()
        {
            InitializeComponent();

            event_beiBuscar_ItemClick += UCGe_Menu_Comprobantes_Recibidos_event_beiBuscar_ItemClick;
            event_btnProvisionarFactura_ItemClick += UCGe_Menu_Comprobantes_Recibidos_event_btnProvisionarFactura_ItemClick;
            event_btnAceptar_ItemClick += UCGe_Menu_Comprobantes_Recibidos_event_btnAceptar_ItemClick;
            event_btnEliminar_ItemClick += UCGe_Menu_Comprobantes_Recibidos_event_btnEliminar_ItemClick;
            event_btnSalir_ItemClick += UCGe_Menu_Comprobantes_Recibidos_event_btnSalir_ItemClick;
            event_btnImprimir_ItemClick += UCGe_Menu_Comprobantes_Recibidos_event_btnImprimir_ItemClick;
        }

        void UCGe_Menu_Comprobantes_Recibidos_event_btnImprimir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        void UCGe_Menu_Comprobantes_Recibidos_event_btnEliminar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        void UCGe_Menu_Comprobantes_Recibidos_event_btnSalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        void UCGe_Menu_Comprobantes_Recibidos_event_btnAceptar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        void UCGe_Menu_Comprobantes_Recibidos_event_btnProvisionarFactura_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        void UCGe_Menu_Comprobantes_Recibidos_event_beiBuscar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void beiBuscar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            event_beiBuscar_ItemClick(sender, e);
        }

        private void btnProvisionarFactura_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            event_btnProvisionarFactura_ItemClick(sender, e);
        }

        private void btnAceptar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            event_btnAceptar_ItemClick(sender, e);
        }

        private void btnSalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            event_btnSalir_ItemClick(sender, e);
        }

        private void btnEliminar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            event_btnEliminar_ItemClick(sender, e);
        }

        private void UCGe_Menu_Comprobantes_Recibidos_Load(object sender, EventArgs e)
        {
            try
            {
                // Obtener la fecha actual
                DateTime fechaActual = DateTime.Now;

                
                // Obtener la fecha inicial del mes
                DateTime fechaInicialMes = new DateTime(fechaActual.Year, fechaActual.Month, 1);

                beiFechaIni.EditValue = fechaInicialMes;
                beiFechaFin.EditValue = fechaActual;

                List<TipoComprobante> List_TipoComprobante = new List<TipoComprobante>();
                List_TipoComprobante.Add(new TipoComprobante("01", "Factura"));
                List_TipoComprobante.Add(new TipoComprobante("03", "Liquidación de compra de bienes y prestación de servicios"));
                List_TipoComprobante.Add(new TipoComprobante("04", "Nota de Crédito"));
                List_TipoComprobante.Add(new TipoComprobante("05", "Nota de Débito"));
                List_TipoComprobante.Add(new TipoComprobante("07", "Comprobantes de Retención"));

                cmb_TipoComprobante.DataSource = List_TipoComprobante;
                beiTipoComprobante.EditValue = "01"; //TODOS POR DEFAULT
                
                List<EstadoComprobante> ListEstadoComprobante = new List<EstadoComprobante>();
                ListEstadoComprobante.Add(new EstadoComprobante("Pendiente"));
                ListEstadoComprobante.Add(new EstadoComprobante("Error"));
                ListEstadoComprobante.Add(new EstadoComprobante("Valido"));
                ListEstadoComprobante.Add(new EstadoComprobante("Provisionada"));

                cmbEstado.DataSource = ListEstadoComprobante;
                beiEstado.EditValue = "Valido"; //TODOS POR DEFAULT
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnImprimir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            event_btnImprimir_ItemClick(sender, e);
        }

        public void Validar_Permisos_Usuario(string nombre_formulario)
        {
            try
            {
                seg_Menu_bus Busseg = new seg_Menu_bus();
                List<seg_Menu_info> Infoseg = new List<seg_Menu_info>();

                //Control de Usuario
                Infoseg = Busseg.Get_List_Menu_x_Empresa_x_Usuario_Control(param.IdEmpresa, param.IdUsuario, nombre_formulario);

                this.btnAceptar.Enabled = true;
                this.btnEliminar.Enabled = true;
                this.btnImprimir.Enabled = true;
                this.btnProvisionarFactura.Enabled = true;

                foreach (var item in Infoseg)
                {
                    if (item.Eliminacion == true)
                    {
                        this.btnEliminar.Enabled = true;
                    }
                    if (item.Escritura == true)
                    {
                        this.btnAceptar.Enabled = true;
                        this.btnProvisionarFactura.Enabled = true;
                    }
                    if (item.Lectura == true)
                    {
                        this.btnImprimir.Enabled = true;
                    }
                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name + " " + this.Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private class TipoComprobante
        {
            public string TipoDocumento { get; set; }
            public string NombreTipoDocumento { get; set; }

            public TipoComprobante(string TipoDocumento, string NombreTipoDocumento)
            {
                this.TipoDocumento = TipoDocumento;
                this.NombreTipoDocumento = NombreTipoDocumento;
            }
        }

        private class EstadoComprobante
        {
            public string Descripcion { get; set; }

            public EstadoComprobante(string Descripcion)
            {
                this.Descripcion = Descripcion;
            }
        }
    }
}