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
using Bizu.Domain.CuentasxPagar;
using Bizu.Application.CuentasxPagar;
using Bizu.Application.SeguridadAcceso;
using Bizu.Domain.SeguridadAcceso;

namespace Bizu.Presentation.CuentasxPagar
{
    public partial class frmCP_Aprobacion_Ing_Bod_x_OC_Cons : DevExpress.XtraEditors.XtraForm
    {
        #region Variables
        seg_Menu_bus Busseg = new seg_Menu_bus();
        List<seg_Menu_info> Infoseg = new List<seg_Menu_info>();
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus;
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        Cl_Enumeradores.eTipo_action Accion;
        cp_Aprobacion_Ing_Bod_x_OC_Info Info = new cp_Aprobacion_Ing_Bod_x_OC_Info();
        #endregion
       
        public frmCP_Aprobacion_Ing_Bod_x_OC_Cons()
        {
            InitializeComponent();

            ucGe_Menu_Mantenimiento_x_usuario1.event_btnSalir_ItemClick += ucGe_Menu_Mantenimiento_x_usuario1_event_btnSalir_ItemClick;
            ucGe_Menu_Mantenimiento_x_usuario1.event_btnNuevo_ItemClick += ucGe_Menu_Mantenimiento_x_usuario1_event_btnNuevo_ItemClick;       
            ucGe_Menu_Mantenimiento_x_usuario1.event_btnconsultar_ItemClick += ucGe_Menu_Mantenimiento_x_usuario1_event_btnconsultar_ItemClick;
            ucGe_Menu_Mantenimiento_x_usuario1.event_btnImprimir_ItemClick += ucGe_Menu_Mantenimiento_x_usuario1_event_btnImprimir_ItemClick;
            ucGe_Menu_Mantenimiento_x_usuario1.event_btnBuscar_Click += ucGe_Menu_Mantenimiento_x_usuario1_event_btnBuscar_Click;
                 
        }

        private void cargagrid()
        {
            try
            {
                List<cp_Aprobacion_Ing_Bod_x_OC_Info> lista = new List<cp_Aprobacion_Ing_Bod_x_OC_Info>();
                cp_Aprobacion_Ing_Bod_x_OC_Bus Bus = new cp_Aprobacion_Ing_Bod_x_OC_Bus();
                lista = Bus.Get_List_Aprobacion_Ing_Bod_x_OC(param.IdEmpresa, ucGe_Menu_Mantenimiento_x_usuario1.fecha_desde, ucGe_Menu_Mantenimiento_x_usuario1.fecha_hasta).OrderByDescending(q=>q.IdAprobacion).ToList();
                gridControlConsulta.DataSource = lista;
                      
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void ucGe_Menu_Mantenimiento_x_usuario1_event_btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                cargagrid();
            }
            catch (Exception ex)
            {
                Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void ucGe_Menu_Mantenimiento_x_usuario1_event_btnImprimir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                gridControlConsulta.ShowPrintPreview();
            }
            catch (Exception ex)
            {
                Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void ucGe_Menu_Mantenimiento_x_usuario1_event_btnconsultar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                preparar_formulario(Cl_Enumeradores.eTipo_action.consultar);            
            }
            catch (Exception ex)
            {
                Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void ucGe_Menu_Mantenimiento_x_usuario1_event_btnNuevo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                preparar_formulario(Cl_Enumeradores.eTipo_action.grabar);
            }
            catch (Exception ex)
            {
                Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void ucGe_Menu_Mantenimiento_x_usuario1_event_btnSalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                Close();
            }
            catch (Exception ex)
            {
                Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void preparar_formulario(Cl_Enumeradores.eTipo_action _Accion)
        {         
            try
            {
                frmCP_Aprobacion_Ing_Bod_x_OC_Mant frm = new frmCP_Aprobacion_Ing_Bod_x_OC_Mant();
                Info = (cp_Aprobacion_Ing_Bod_x_OC_Info)gridViewConsulta.GetFocusedRow();

                if (_Accion == Cl_Enumeradores.eTipo_action.consultar)
                {
                    if (Info != null)
                    {
                        frm.Text = frm.Text + "***CONSULTAR REGISTRO***";
                    }
                    else
                    {
                        MessageBox.Show("Seleccione un Registro a Consultar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return;
                    }
                }

                if (_Accion == Cl_Enumeradores.eTipo_action.Anular)
                {
                    if (Info != null)
                    {
                        if (param.IdCliente_Ven_x_Default == Cl_Enumeradores.eCliente_Vzen.EDEHSA)
                        {
                            cp_orden_giro_Bus OrdenGiro_B = new cp_orden_giro_Bus();
                            cp_orden_giro_Info Info_OrdenGiro = new cp_orden_giro_Info();

                            Info_OrdenGiro = OrdenGiro_B.Get_Info_orden_giro_Saldo(Convert.ToInt32(Info.IdEmpresa_Ogiro), Convert.ToInt32(Info.IdTipoCbte_Ogiro), Convert.ToDecimal(Info.IdCbteCble_Ogiro));

                            if (Info_OrdenGiro != null)
                            {
                                if (Info_OrdenGiro.Estado_Cancelacion == "PAGADA")
                                {
                                    MessageBox.Show("La Factura " + Info_OrdenGiro.co_factura + " ya está Cancelada. No puede ser anulada", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    return;
                                }
                            }
                        }

                        frm.Text = frm.Text + "***ELIMINAR REGISTRO***";
                    }
                    else
                    {
                        MessageBox.Show("Seleccione un Registro a Consultar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return;
                    }
                }

                switch (_Accion)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:
                        break;
                    case Cl_Enumeradores.eTipo_action.consultar:
                        frm._SetInfo = Info;
                        break;
                    case Cl_Enumeradores.eTipo_action.Anular:
                        frm._SetInfo = Info;
                        break;
                }

                frm.set_Accion(_Accion);
                frm.MdiParent = this.MdiParent;
                frm.event_frmCP_Aprobacion_Ing_Bod_x_OC_Mant_FormClosing += frm_event_frmCP_Aprobacion_Ing_Bod_x_OC_Mant_FormClosing;
                frm.Show();
            }
            catch (Exception ex)
            {                
                 Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }           
        }

        void frm_event_frmCP_Aprobacion_Ing_Bod_x_OC_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                cargagrid();
            }
            catch (Exception ex)
            {
                
                Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmCP_Aprobacion_Ing_Bod_x_OC_Cons_Load(object sender, EventArgs e)
        {
            try
            {
                //Control de Usuario
                Infoseg = Busseg.Get_List_Menu_x_Empresa_x_Usuario_Control(param.IdEmpresa, param.IdUsuario, "CuentasxPagar.frmCP_Aprobacion_Ing_Bod_x_OC_Cons");
                foreach (var item in Infoseg)
                {
                    if (item.Eliminacion == false)
                    {
                        ucGe_Menu_Mantenimiento_x_usuario1.btnAnular.Enabled = false;
                    }
                    if (item.Escritura == false)
                    {
                        ucGe_Menu_Mantenimiento_x_usuario1.btnModificar.Enabled = false;
                    }
                }
                 cargagrid();
            }
            catch (Exception ex)
            {
                
                 Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ucGe_Menu_Mantenimiento_x_usuario1_event_btnAnular_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                preparar_formulario(Cl_Enumeradores.eTipo_action.Anular);
            }
            catch (Exception ex)
            {
                Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}