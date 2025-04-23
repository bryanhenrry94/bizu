using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Bizu.Application.General;
using DevExpress.XtraReports.Parameters;
using DevExpress.XtraReports.UI;
using Bizu.Application.Inventario;
using Bizu.Domain.Inventario;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;

namespace Bizu.Reports.Facturacion
{
    public partial class XFAC_Rpt014_frm : Form
    {
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;   

        public XFAC_Rpt014_frm()
        {
            InitializeComponent();

            ucFa_Menu.event_btnConsultar_ItemClick += ucFa_Menu_event_btnConsultar_ItemClick;
            ucFa_Menu.event_btnSalir_ItemClick += ucFa_Menu_event_btnSalir_ItemClick;
        }
       
        void ucFa_Menu_event_btnSalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
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

        void ucFa_Menu_event_btnConsultar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                ConsultarDatos();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void ConsultarDatos()
        {
            try                           
            {
                XFAC_Rpt014_Rpt Reporte = new XFAC_Rpt014_Rpt();

                Reporte.RequestParameters = false;
                ReportPrintTool pt = new ReportPrintTool(Reporte);

                pt.AutoShowParametersPanel = false;

                Reporte.Parameters["IdEmpresa"].Value = param.IdEmpresa;
                Reporte.Parameters["IdSucursal"].Value = (ucFa_Menu.cmbSucursal.EditValue == null) ? 0 : ucFa_Menu.cmbSucursal.EditValue;
                Reporte.Parameters["FechaIni"].Value = ucFa_Menu.dtpDesde.EditValue;
                Reporte.Parameters["FechaFin"].Value = ucFa_Menu.dtpHasta.EditValue;
                Reporte.Parameters["IdUsuario"].Value = param.IdUsuario;
                Reporte.Parameters["nomCliente"].Value = ucFa_Menu.cmbCliente.Edit.GetDisplayText(ucFa_Menu.cmbCliente.EditValue);
                Reporte.Parameters["nom_sucursal"].Value = ucFa_Menu.cmbSucursal.Edit.GetDisplayText(ucFa_Menu.cmbSucursal.EditValue);
                Reporte.Parameters["IdCliente"].Value = (ucFa_Menu.cmbCliente.EditValue == null) ? 0 : ucFa_Menu.cmbCliente.EditValue;

                Reporte.List_IdMarca = ucFa_Menu.Get_list_Marca_Cheked();
                Reporte.List_IdCliente = ucFa_Menu.Get_list_Clientes_Cheked();

                printControlReporte.PrintingSystem = Reporte.PrintingSystem;
                Reporte.CreateDocument();               
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void XFAC_Rpt014_frm_Load(object sender, EventArgs e)
        {
            
        }

        private void ucFa_Menu_Load(object sender, EventArgs e)
        {

        }

    }
}
