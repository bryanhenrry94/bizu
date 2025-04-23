using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraReports.Parameters;
using DevExpress.XtraReports.UI;
using Bizu.Application.General;
using Bizu.Domain.General;
using Bizu.Application.Inventario;
using Bizu.Domain.Inventario;

namespace Bizu.Reports.Inventario
{
    public partial class XINV_Rpt033_frm : Form
    {
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        List<tb_Sucursal_Info> listSucursal = new List<tb_Sucursal_Info>();
        tb_Sucursal_Bus buSucursal = new tb_Sucursal_Bus();
        List<tb_Bodega_Info> listBodega = new List<tb_Bodega_Info>();
        tb_Bodega_Bus busBodega = new tb_Bodega_Bus();

        public XINV_Rpt033_frm()
        {
            InitializeComponent();
            ucInv_Menu.event_btnSalir_ItemClick += ucInv_Menu_event_btnSalir_ItemClick;
            ucInv_Menu.event_tnConsultar_ItemClick += ucInv_Menu_event_tnConsultar_ItemClick;
        }

        void ucInv_Menu_event_tnConsultar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                CargarGrid();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void ucInv_Menu_event_btnSalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception ex)    
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void CargarGrid()
        {
            try
            {

                XINV_Rpt033_rpt Reporte_Edehsa = new XINV_Rpt033_rpt();

                Reporte_Edehsa.RequestParameters = false;
                ReportPrintTool pt_edehsa = new ReportPrintTool(Reporte_Edehsa);
                pt_edehsa.AutoShowParametersPanel = false;

                Reporte_Edehsa.Parameters["IdEmpresa"].Value = param.IdEmpresa;
                Reporte_Edehsa.Parameters["IdSucursal"].Value = (ucInv_Menu.cmbSucursal.EditValue == null) ? 0 : ucInv_Menu.cmbSucursal.EditValue;
                Reporte_Edehsa.Parameters["IdSucursalFin"].Value = (ucInv_Menu.cmbSucursal.EditValue == null || Convert.ToInt32(ucInv_Menu.cmbSucursal.EditValue) == 0) ? 99999 : Convert.ToInt32(ucInv_Menu.cmbSucursal.EditValue);
                Reporte_Edehsa.Parameters["IdBodega"].Value = (ucInv_Menu.cmbBodega.EditValue == null || Convert.ToInt32(ucInv_Menu.cmbBodega.EditValue) == 0) ? 0 : ucInv_Menu.cmbBodega.EditValue;
                Reporte_Edehsa.Parameters["IdBodegaFin"].Value = (ucInv_Menu.cmbBodega.EditValue == null || Convert.ToInt32(ucInv_Menu.cmbBodega.EditValue) == 0) ? 99999 : Convert.ToInt32(ucInv_Menu.cmbBodega.EditValue);
                Reporte_Edehsa.Parameters["FechaIni"].Value = ucInv_Menu.dtpDesde.EditValue;
                Reporte_Edehsa.Parameters["FechaFin"].Value = ucInv_Menu.dtpHasta.EditValue;
                Reporte_Edehsa.PIdCategoria.Value = ucInv_Menu.cmbCategoria.EditValue;
                Reporte_Edehsa.PIdLinea.Value = ucInv_Menu.cmbLinea.EditValue;
                Reporte_Edehsa.Parameters["nom_Sucursal"].Value = ucInv_Menu.cmbSucursal.Edit.GetDisplayText(ucInv_Menu.cmbSucursal.EditValue);
                Reporte_Edehsa.Parameters["nom_Bodega"].Value = ucInv_Menu.cmbBodega.Edit.GetDisplayText(ucInv_Menu.cmbBodega.EditValue);
                Reporte_Edehsa.PRegistro_Cero.Value = ucInv_Menu.beiCheck1.EditValue;
                Reporte_Edehsa.P_IdProducto.Value = ucInv_Menu.cmbProducto.EditValue == null ? 0 : Convert.ToDecimal(ucInv_Menu.cmbProducto.EditValue);
                Reporte_Edehsa.P_toma_física.Value = ucInv_Menu.beiCheck2.EditValue;
                printControl1.PrintingSystem = Reporte_Edehsa.PrintingSystem;

                Reporte_Edehsa.List_Bodegas = ucInv_Menu.Get_list_bodega_chk();
                Reporte_Edehsa.List_Lineas = ucInv_Menu.Get_list_Linea_Cheked();

                Reporte_Edehsa.CreateDocument();

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void XINV_Rpt033_frm_Load(object sender, EventArgs e)
        {
            try
            {
                ucInv_Menu.dtpHasta.EditValue = DateTime.Now;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ucInv_Menu_event_btnImprimir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string msg = "";
            XINV_Rpt009_Bus Bus = new XINV_Rpt009_Bus();
            List<XINV_Rpt009_Info> lista = new List<XINV_Rpt009_Info>();

            int IdEmpresa = 0;
            int IdBodega = 0;
            int IdSucursal = 0;
            string IdCategoria = "";
            int IdLinea = 0;
            decimal IdProducto = 0;
            Boolean Registro_Cero = false;
            DateTime Fecha_corte = DateTime.Now;

            IdEmpresa = param.IdEmpresa;
            IdSucursal = (ucInv_Menu.cmbSucursal.EditValue == null) ? 0 : Convert.ToInt32(ucInv_Menu.cmbSucursal.EditValue);
            IdBodega = (ucInv_Menu.cmbBodega.EditValue == null || Convert.ToInt32(ucInv_Menu.cmbBodega.EditValue) == 0) ? 0 : Convert.ToInt32(ucInv_Menu.cmbBodega.EditValue);
            IdCategoria = Convert.ToString(ucInv_Menu.cmbCategoria.EditValue);
            IdLinea = Convert.ToInt32(ucInv_Menu.cmbLinea.EditValue);
            Registro_Cero = Convert.ToBoolean(ucInv_Menu.beiCheck1.EditValue);
            Fecha_corte = Convert.ToDateTime(ucInv_Menu.dtpHasta.EditValue);
            IdProducto = ucInv_Menu.cmbProducto.EditValue == null ? 0 : Convert.ToDecimal(ucInv_Menu.cmbProducto.EditValue);

            lista = Bus.Get_data(IdEmpresa, IdSucursal, IdBodega, IdCategoria, IdLinea, Registro_Cero, Fecha_corte, IdProducto, ref msg);

            gridControlCbteBanDep.DataSource = lista;
            gridControlCbteBanDep.ShowPrintPreview();
        }
    }
}
