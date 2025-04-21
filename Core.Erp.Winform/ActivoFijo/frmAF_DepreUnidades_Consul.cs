using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.Erp.Business.General;
using Core.Erp.Info.General;
using Core.Erp.Business.SeguridadAcceso;
using Core.Erp.Info.SeguridadAcceso;

namespace Core.Erp.Winform.ActivoFijo
{
    public partial class frmAF_DepreUnidades_Consul : DevExpress.XtraEditors.XtraForm
    {
        seg_Menu_bus Busseg = new seg_Menu_bus();
        List<seg_Menu_info> Infoseg = new List<seg_Menu_info>();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;

        public frmAF_DepreUnidades_Consul()
        {
            InitializeComponent();
        }

        private void frmAF_DepreUnidades_Consul_Load(object sender, EventArgs e)
        {
            //Control de Usuario
            Infoseg = Busseg.Get_List_Menu_x_Empresa_x_Usuario_Control(param.IdEmpresa, param.IdUsuario, "ActivoFijo.frmAF_DepreUnidades_Consul");
            foreach (var item in Infoseg)
            {
                if (item.Eliminacion == false)
                {
                    ucGe_Menu.btnAnular.Enabled = false;
                }
                if (item.Escritura == false)
                {
                    ucGe_Menu.btnModificar.Enabled = false;

                }
            }
        }
    }
}
