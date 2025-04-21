using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraReports.Parameters;
using DevExpress.XtraReports.UI;
using Core.Erp.Business.Compras;
using Core.Erp.Info.Compras;
using Core.Erp.Business.General;

namespace Core.Erp.Reportes.Compras
{
    public partial class XCOMP_Rpt013_frm : Form
    {
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();

        public XCOMP_Rpt013_frm()
        {
            InitializeComponent();
        }
        
        private void XCOMP_Rpt004_frm_Load(object sender, EventArgs e)
        {
            ucGe_Menu.event_btnRefrescar_ItemClick += UcGe_Menu_event_btnRefrescar_ItemClick;
            ucGe_Menu.event_btnImprimir_ItemClick += UcGe_Menu_event_btnImprimir_ItemClick;
            ucGe_Menu.event_btnsalir_ItemClick += UcGe_Menu_event_btnsalir_ItemClick;
            ucGe_Menu.Cargar_combos();
        }

        private void UcGe_Menu_event_btnsalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void UcGe_Menu_event_btnImprimir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.PVGrid_orden_compra.ShowRibbonPrintPreview();
        }

        private void UcGe_Menu_event_btnRefrescar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            cargar_datos_grid_pivot();
        }

        private void cargar_datos_grid_pivot()
        {
            try
            {
                XCOMP_Rpt013_Bus obus = new XCOMP_Rpt013_Bus();
                DateTime fechaini = DateTime.Now;
                DateTime fechafin = DateTime.Now;

                fechaini = Convert.ToDateTime(ucGe_Menu.dtp_fechaIni.EditValue);
                fechafin = Convert.ToDateTime(ucGe_Menu.dtp_fechaFin.EditValue);

                List<XCOMP_Rpt013_Info> List_Data = obus.Cargar_data(param.IdEmpresa, param.IdSucursal,
                        Convert.ToDecimal(ucGe_Menu.bei_producto.EditValue),
                        Convert.ToInt32(ucGe_Menu.bei_proveedor.EditValue),
                        Convert.ToString(ucGe_Menu.bei_Categoria.EditValue),
                        Convert.ToInt32(ucGe_Menu.bei_Linea.EditValue),
                        Convert.ToString(ucGe_Menu.bei_CentroCosto.EditValue),
                        fechaini,
                        fechafin
                    );


                if (ucGe_Menu.bei_num_oc.EditValue != null)
                    List_Data = List_Data.Where(q => q.IdOrdenCompra == Convert.ToDecimal(ucGe_Menu.bei_num_oc.EditValue)).ToList();

                // Mostrar Anuladas
                if (!Convert.ToBoolean(ucGe_Menu.bei_check1.EditValue))
                    List_Data = List_Data.Where(q => q.Estado == "A").ToList();

                this.PVGrid_orden_compra.DataSource = List_Data;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dockPanelMenu_Izquierdo_Click(object sender, EventArgs e)
        {

        }

        private void dockPanel1_Container_Paint(object sender, PaintEventArgs e)
        {

        }

        private void navBarControl1_Click(object sender, EventArgs e)
        {

        }

        private void dockPanel2_Click(object sender, EventArgs e)
        {

        }

        private void dockPanel2_Container_Paint(object sender, PaintEventArgs e)
        {

        }

        private void chartControl1_Click(object sender, EventArgs e)
        {

        }

        private void PVGrid_orden_compra_Click(object sender, EventArgs e)
        {

        }

        private void xCOMPRpt004InfoBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void bttnImprimir_Click(object sender, EventArgs e)
        {

        }

        private void xtraTabControlData_Click(object sender, EventArgs e)
        {

        }

        private void xtraTabPage_Matriz_pivot_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ucGe_Menu_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
