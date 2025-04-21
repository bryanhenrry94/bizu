using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.Erp.Business.CuentasxCobrar;
using Core.Erp.Info.CuentasxCobrar;
using Core.Erp.Business.General;
using Core.Erp.Info.General;
using Core.Erp.Winform.General;
using Core.Erp.Business.SeguridadAcceso;
using Core.Erp.Info.SeguridadAcceso;
//Derek 23/01/2014
//Ult.Mod:04/02/2014
namespace Core.Erp.Winform.CuentasxCobrar
{
    public partial class Cxc_anticipo_clientes_Por_Conciliar_Cons : DevExpress.XtraEditors.XtraForm
    {
        seg_Menu_bus Busseg = new seg_Menu_bus();
        List<seg_Menu_info> Infoseg = new List<seg_Menu_info>();
        cxc_cobro_x_Anticipo_Bus cxcCABus = new cxc_cobro_x_Anticipo_Bus();
        List<cxc_cobro_x_Anticipo_Info> cxcCA = new List<cxc_cobro_x_Anticipo_Info>();
        cxc_cobro_x_Anticipo_Info info = new cxc_cobro_x_Anticipo_Info();
        //Derek 04022014
        List<cxc_cobro_x_Anticipo_det_Info> infodet = new List<cxc_cobro_x_Anticipo_det_Info>();
        cxc_cobro_x_Anticipo_det_Bus infodetBus = new cxc_cobro_x_Anticipo_det_Bus();
        
        List<cxc_cobro_Info> cxcinfoList = new List<cxc_cobro_Info>();
        cxc_cobro_Bus cxcBus = new cxc_cobro_Bus();
        //
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        frmCxc_anticipo_clientes_Mant mant = new frmCxc_anticipo_clientes_Mant();

        //DEREK MEJIA 13/03/2014
        string mensaje = "";
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        int IdSucursal = 0;


        public Cxc_anticipo_clientes_Por_Conciliar_Cons()
        {
            try
            {
                InitializeComponent();
                ucGe_Menu_Mantenimiento_x_usuario.event_btnNuevo_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnNuevo_ItemClick;
                ucGe_Menu_Mantenimiento_x_usuario.event_btnconsultar_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnconsultar_ItemClick;
                ucGe_Menu_Mantenimiento_x_usuario.event_btnAnular_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnAnular_ItemClick;
                ucGe_Menu_Mantenimiento_x_usuario.event_btnImprimir_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnImprimir_ItemClick;
                ucGe_Menu_Mantenimiento_x_usuario.event_btnSalir_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnSalir_ItemClick;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        void ucGe_Menu_Mantenimiento_x_usuario_event_btnSalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                Close();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void ucGe_Menu_Mantenimiento_x_usuario_event_btnImprimir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                gridControlAnticipo.ShowPrintPreview();
                gridControlAnticipoDiarioContable.ShowPrintPreview();

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void ucGe_Menu_Mantenimiento_x_usuario_event_btnAnular_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (info == null)
                {
                    MessageBox.Show("Seleccione una fila", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                if (info.Estado == "I")
                {
                    MessageBox.Show("El registro seleccionado se encuentra anulado", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                if (Anular(info) == false)
                {
                    MessageBox.Show("No se anulo en registro", "Operación Cancelada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else
                {
                    MessageBox.Show("Se anulo el registro", "Operación Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void ucGe_Menu_Mantenimiento_x_usuario_event_btnconsultar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                llama_frm(Cl_Enumeradores.eTipo_action.consultar);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void ucGe_Menu_Mantenimiento_x_usuario_event_btnNuevo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                llama_frm(Cl_Enumeradores.eTipo_action.grabar);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void llama_frm(Cl_Enumeradores.eTipo_action Accion)
        {
            try
            {
                mant = new frmCxc_anticipo_clientes_Mant();
                mant.event_frmcxc_anticipo_clientes_Mant_FormClosing += new frmCxc_anticipo_clientes_Mant.delegate_frmcxc_anticipo_clientes_Mant_FormClosing(frm_event_frmcxc_anticipo_clientes_Mant_FormClosing);
                mant.MdiParent = this.MdiParent;

                if (Accion != Cl_Enumeradores.eTipo_action.grabar)
                {
                    mant.SETINFO_ = info;
                }
                mant.set_Accion(Accion);
                mant.Show();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frm_event_frmcxc_anticipo_clientes_Mant_FormClosing()
        {
            try
            {
                load();
            }
            catch (Exception ex)
            {                
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        public void load() {
            try
            {

                List<vwcxc_anticipos_x_cruzar_Info> List_Anticipo = new List<vwcxc_anticipos_x_cruzar_Info>();
                List<vwcxc_anticipos_x_cruzar_Info> List_AnticipoDiarioContable = new List<vwcxc_anticipos_x_cruzar_Info>();
                List<vwcxc_cobros_Pendientes_x_conciliar_Info>  List_CreDeb = new List<vwcxc_cobros_Pendientes_x_conciliar_Info>();
                vwcxc_anticipos_x_cruzar_Info Info = new vwcxc_anticipos_x_cruzar_Info();
                vwcxc_anticipos_x_cruzar_Bus Bus_Anticipo = new vwcxc_anticipos_x_cruzar_Bus();
                BindingList<vwcxc_anticipos_x_cruzar_Info> DataSource_Anticipo = new BindingList<vwcxc_anticipos_x_cruzar_Info>();

                Info.IdEmpresa = param.IdEmpresa;


                //Anticipos
                List_Anticipo = Bus_Anticipo.Get_List_anticipos_x_cruzar_Todos(Info);
                
                gridControlAnticipo.DataSource = List_Anticipo;


                //Anticipos por diario contable
                List_AnticipoDiarioContable = Bus_Anticipo.Get_List_anticipos_x_cruzar_Pendientes_de_Diario(Info);

                List_AnticipoDiarioContable = List_AnticipoDiarioContable.FindAll(p => p.IdCobro_cobro != 1019 && p.IdCobro_cobro != 3432);

                gridControlAnticipoDiarioContable.DataSource = List_AnticipoDiarioContable;

                //Notas de crédito Débito Pendiente
                vwcxc_cobros_Pendientes_x_conciliar_Bus Bus_CreDeb = new vwcxc_cobros_Pendientes_x_conciliar_Bus();
                Cl_Enumeradores.TipoConciliacion IdTipoConciliacion;
                IdTipoConciliacion = Cl_Enumeradores.TipoConciliacion.NT_CR_DB;
                IdSucursal = Convert.ToInt32(ucIn_Sucursal_Bodega1.cmb_sucursal.EditValue);

                List_CreDeb = Bus_CreDeb.Get_List_cobros_Pendientes_x_conciliar_CreDeb_Saldo_Todos(param.IdEmpresa, IdSucursal, IdTipoConciliacion, ref mensaje);
                gridControlDeb_Cre.DataSource = List_CreDeb;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Cxc_anticipo_clientes_Por_Conciliar_Cons_Load(object sender, EventArgs e)
        {
            try
            {
                //Control de Usuario
                Infoseg = Busseg.Get_List_Menu_x_Empresa_x_Usuario_Control(param.IdEmpresa, param.IdUsuario, "CuentasxCobrar.Cxc_anticipo_clientes_Por_Conciliar_Cons");
                foreach (var item in Infoseg)
                {
                    if (item.Eliminacion == false)
                    {
                        ucGe_Menu_Mantenimiento_x_usuario.btnAnular.Enabled = false;
                    }
                    if (item.Escritura == false)
                    {
                        ucGe_Menu_Mantenimiento_x_usuario.btnModificar.Enabled = false;
                    }
                }
                load();
            }
            catch (Exception ex)
            {                
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }            
        }

  
           
  

        private void gridViewAnticipo_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                //info = new cxc_cobro_x_Anticipo_Info();
                //info = (cxc_cobro_x_Anticipo_Info)gridViewAnticipo.GetFocusedRow();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void gridViewAnticipo_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            try
            {
                var data = gridViewAnticipo.GetRow(e.RowHandle) as cxc_cobro_x_Anticipo_Info;
                if (data == null)
                    return;
                if (data.Estado == "I")
                    e.Appearance.ForeColor = Color.Red;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        public Boolean Anular(cxc_cobro_x_Anticipo_Info info)
        {
            try
            {
                //Motivo por Anulación
                string motiAnulacion = "";
                FrmGe_MotivoAnulacion fr = new FrmGe_MotivoAnulacion();
                fr.ShowDialog();
                motiAnulacion = fr.motivoAnulacion;
                info.MotiAnula = motiAnulacion;
                info.Fecha_Transac = param.Fecha_Transac.Date;
                info.Fecha_UltAnu = DateTime.Now.Date;
                info.Fecha_UltMod = DateTime.Now.Date;
                info.nom_pc = param.nom_pc;
                info.ip = param.ip;

                info.IdUsuario = param.IdUsuario;
                info.Estado = "I";
                infodet = new List<cxc_cobro_x_Anticipo_det_Info>(infodetBus.Get_List_cobro_x_Anticipo_det(info.IdEmpresa, Convert.ToInt32(info.IdAnticipo),ref mensaje));
                if (infodet==null)
                {
                    return false;
                }
                cxcinfoList = new List<cxc_cobro_Info>();
                foreach (var item in infodet)
                {
                    cxc_cobro_Info cxcinfo = new cxc_cobro_Info();
                    item.Fecha_Transac = param.Fecha_Transac.Date;
                    item.Fecha_UltAnu = DateTime.Now.Date;
                    item.Fecha_UltMod = DateTime.Now.Date;
                    item.nom_pc = param.nom_pc;
                    item.ip = param.ip;

                    item.IdUsuario = param.IdUsuario;
                    item.Estado = "I";
                    
                    cxcinfo = cxcBus.Get_Info_cobro_x_cliente(item.IdEmpresa, Convert.ToInt32(item.IdSucursal_cobro), Convert.ToInt32(item.IdCobro_cobro), Convert.ToInt32(info.IdCliente));
                    if (cxcinfo == null)
                    {
                        return false;
                    }
                    else
                    {
                        if (cxcBus.AnularDB(cxcinfo)== false)
                        {
                            return false;
                        }
                    }
                }

                if (cxcCABus.ModificarDB(info,ref mensaje)==false)
                {
                    return false;
                }

                if (infodetBus.ModificarD (infodet,ref mensaje) == false)
                {
                    return false;
                }                
                return true;              
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void mnu_Modificar_Click(object sender, EventArgs e)
        {

        }

        private void ucGe_Menu_Mantenimiento_x_usuario_Load(object sender, EventArgs e)
        {

        }

        private void ucGe_Menu_Mantenimiento_x_usuario_event_btnBuscar_Click(object sender, EventArgs e)
        {
            load();
        }

        private void ucGe_Menu_Mantenimiento_x_usuario_event_btnImprimir_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //gridControlAnticipo.ShowPrintPreview();
        }
    }
}