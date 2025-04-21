using Core.Erp.Business.General;
using DevExpress.XtraReports.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Core.Erp.Reportes.Compras
{
    public partial class XCOMP_Rpt010_frm : Form
    {
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();

        public XCOMP_Rpt010_frm()
        {
            InitializeComponent();
        }

        private void ucCom_Menu_Reportes1_event_btnsalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
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

        private void ucCom_Menu_Reportes1_event_btnRefrescar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (ucCom_Menu_Reportes1.bei_sucursal.EditValue == null)
                {
                    MessageBox.Show("Seleccione la sucursal!", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                if (ucCom_Menu_Reportes1.bei_proveedor.EditValue == null)
                {
                    MessageBox.Show("Seleccione el proveedor!", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                XCOMP_Rpt010_Rpt Reporte = new XCOMP_Rpt010_Rpt();
                Reporte.RequestParameters = false;
                ReportPrintTool pt = new ReportPrintTool(Reporte);
                pt.AutoShowParametersPanel = false;
                    
                Reporte.Parameters["IdEmpresa"].Value = param.IdEmpresa;
                Reporte.Parameters["IdSucursal"].Value = ucCom_Menu_Reportes1.bei_sucursal.EditValue == null ? 0 : Convert.ToInt32(ucCom_Menu_Reportes1.bei_sucursal.EditValue);
                Reporte.Parameters["Fecha_Desde"].Value = ucCom_Menu_Reportes1.dtp_fechaIni.EditValue == null ? param.InfoEmpresa.em_fechaInicioContable : Convert.ToDateTime(ucCom_Menu_Reportes1.dtp_fechaIni.EditValue);
                Reporte.Parameters["Fecha_Hasta"].Value = ucCom_Menu_Reportes1.dtp_fechaFin.EditValue == null ? DateTime.Now.Date : Convert.ToDateTime(ucCom_Menu_Reportes1.dtp_fechaFin.EditValue);
                Reporte.Parameters["IdProveedor"].Value = ucCom_Menu_Reportes1.bei_proveedor.EditValue == null ? 0 : Convert.ToInt32(ucCom_Menu_Reportes1.bei_proveedor.EditValue);
                Reporte.Parameters["IdOrdenCompra"].Value = ucCom_Menu_Reportes1.bei_num_oc.EditValue == null ? 0 : Convert.ToInt32(ucCom_Menu_Reportes1.bei_num_oc.EditValue);
                Reporte.Parameters["MostrarAnuladas"].Value = ucCom_Menu_Reportes1.bei_check1.EditValue == null ? false : Convert.ToBoolean(ucCom_Menu_Reportes1.bei_check1.EditValue);
                Reporte.Parameters["MostrarConSaldo"].Value = ucCom_Menu_Reportes1.bei_check2.EditValue == null ? false : Convert.ToBoolean(ucCom_Menu_Reportes1.bei_check2.EditValue);
                Reporte.Parameters["IdCentroCosto"].Value = ucCom_Menu_Reportes1.bei_CentroCosto.EditValue == null ? "" : Convert.ToString(ucCom_Menu_Reportes1.bei_CentroCosto.EditValue);
                Reporte.Parameters["NomSucursal"].Value = param.InfoSucursal.Su_Descripcion;
                Reporte.Parameters["FechaImpresion"].Value = param.Fecha_Transac;
                Reporte.Parameters["IdUsuario"].Value = param.IdUsuario;

                printControl1.PrintingSystem = Reporte.PrintingSystem;
                Reporte.CreateDocument();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void XCOMP_Rpt008_frm_Load(object sender, EventArgs e)
        {
            try
            {
                ucCom_Menu_Reportes1.Cargar_combos();
                ucCom_Menu_Reportes1.bei_sucursal.EditValue = param.InfoSucursal.IdSucursal;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}