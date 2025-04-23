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
    public partial class XINV_Rpt029_frm : Form
    {
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        List<tb_Sucursal_Info> listSucursal = new List<tb_Sucursal_Info>();
        tb_Sucursal_Bus buSucursal = new tb_Sucursal_Bus();
        List<tb_Bodega_Info> listBodega = new List<tb_Bodega_Info>();
        tb_Bodega_Bus busBodega = new tb_Bodega_Bus();

        public XINV_Rpt029_frm()
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

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void XINV_Rpt029_frm_Load(object sender, EventArgs e)
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
    }
}
