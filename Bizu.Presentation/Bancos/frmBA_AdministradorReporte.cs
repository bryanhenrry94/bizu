using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Bizu.Application.General;
using Bizu.Domain.General;
using Bizu.Presentation.Controles;

namespace Bizu.Presentation.Bancos
{
    public partial class frmBA_AdministradorReporte : DevExpress.XtraEditors.XtraForm
    {
        #region DATA
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        tb_modulo_Bus busModulo = new tb_modulo_Bus();
        List<tb_modulo_Info> lstModulo = new List<tb_modulo_Info>();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        #endregion DATA
        public frmBA_AdministradorReporte()
        {
            InitializeComponent();
        }

        private void frmBA_AdministradorReporte_Load(object sender, EventArgs e)
        {
            try
            {
                lstModulo = busModulo.Get_list_Modulo("BAN");
                ucGe_Admin.FormMain = this.MdiParent;
                ucGe_Admin.set_UCGe_Administrador_Reporte(lstModulo);

            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void ucGe_Admin_event_ucGe_Menu_event_btnSalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }
    }
}
