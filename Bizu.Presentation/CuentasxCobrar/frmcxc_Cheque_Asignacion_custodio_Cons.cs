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
using Bizu.Application.SeguridadAcceso;
using Bizu.Domain.SeguridadAcceso;

namespace Bizu.Presentation.CuentasxCobrar
{
    public partial class frmcxc_Cheque_Asignacion_custodio_Cons : DevExpress.XtraEditors.XtraForm
    {
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        seg_Menu_bus Busseg = new seg_Menu_bus();
        List<seg_Menu_info> Infoseg = new List<seg_Menu_info>();

        public frmcxc_Cheque_Asignacion_custodio_Cons()
        {
            InitializeComponent();
            frmMant.event_frmcxc_Cheque_Asignacion_custodio_Mant_FormClosing+=frmMant_event_frmcxc_Cheque_Asignacion_custodio_Mant_FormClosing;

        }

        frmCxc_Cheque_Asignacion_custodio_Mant frmMant = new frmCxc_Cheque_Asignacion_custodio_Mant();
        

        void frmMant_event_frmcxc_Cheque_Asignacion_custodio_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
            //cargagrid();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            try
            {
                frmMant = new frmCxc_Cheque_Asignacion_custodio_Mant(Cl_Enumeradores.eTipo_action.grabar);
                frmMant.event_frmcxc_Cheque_Asignacion_custodio_Mant_FormClosing += frmMant_event_frmcxc_Cheque_Asignacion_custodio_Mant_FormClosing;
                frmMant.Text = frmMant.Text + " ***NUEVO REGISTRO***";
                frmMant.Show();
            }
            catch (Exception ex)
            {

            }      
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmcxc_Cheque_Asignacion_custodio_Cons_Load(object sender, EventArgs e)
        {
            //Control de Usuario
            Infoseg = Busseg.Get_List_Menu_x_Empresa_x_Usuario_Control(param.IdEmpresa, param.IdUsuario, "CuentasxCobrar.frmcxc_Cheque_Asignacion_custodio_Cons");
            foreach (var item in Infoseg)
            {
                if (item.Eliminacion == false)
                {
                    btnAnular.Enabled = false;
                }
                if (item.Escritura == false)
                {
                    btnModificar.Enabled = false;
                }
            }
        }

    }
}
