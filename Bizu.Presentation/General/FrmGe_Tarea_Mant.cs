using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bizu.Domain.General;
using Bizu.Application.General;
using Bizu.Domain.SeguridadAcceso;
using Bizu.Application.SeguridadAcceso;

namespace Bizu.Presentation.General
{
    public delegate void Notify();  // delegate

    public partial class FrmGe_Tarea_Mant : Form
    {
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;

        private tb_Catalogo_Bus bus_catalogo = new tb_Catalogo_Bus();
        private seg_usuario_bus bus_usuario = new seg_usuario_bus();
        private tb_tarea_equipo_Bus bus_tarea_equipo = new tb_tarea_equipo_Bus();
        
        private List<tb_Catalogo_Info> list_tarea_estado = new List<tb_Catalogo_Info>();
        private List<tb_Catalogo_Info> list_tarea_prioridad = new List<tb_Catalogo_Info>();
        private List<seg_usuario_info> list_usuario = new List<seg_usuario_info>();
        private BindingList<tb_tarea_equipo_Info> bindinglist_tarea_equipo = new BindingList<tb_tarea_equipo_Info>();

        private tb_tarea_Bus bus_tarea = new tb_tarea_Bus();
        private tb_tarea_Info Info_Tarea;

        public Cl_Enumeradores.eTipo_action Accion;

        public delegate void delegate_FrmGe_Tarea_Mant_FormClosing(object sender, FormClosingEventArgs e);
        public event delegate_FrmGe_Tarea_Mant_FormClosing event_FrmGe_Tarea_Mant_FormClosing;

        public FrmGe_Tarea_Mant()
        {
            InitializeComponent();

            ucGe_Menu.event_btnGuardar_Click += UcGe_Menu_event_btnGuardar_Click;
            ucGe_Menu.event_btnGuardar_y_Salir_Click += UcGe_Menu_event_btnGuardar_y_Salir_Click;
            ucGe_Menu.event_btnAnular_Click += UcGe_Menu_event_btnAnular_Click;
            ucGe_Menu.event_btnSalir_Click += UcGe_Menu_event_btnSalir_Click;

            event_FrmGe_Tarea_Mant_FormClosing += FrmGe_Tarea_Mant_event_FrmGe_Tarea_Mant_FormClosing;
        }

        private void FrmGe_Tarea_Mant_event_FrmGe_Tarea_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void UcGe_Menu_event_btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UcGe_Menu_event_btnAnular_Click(object sender, EventArgs e)
        {
            anular();
        }

        private void UcGe_Menu_event_btnGuardar_y_Salir_Click(object sender, EventArgs e)
        {
            if (this.grabarBD()) this.Close();
        }

        private void UcGe_Menu_event_btnGuardar_Click(object sender, EventArgs e)
        {
            if (this.grabarBD()) this.limpiar();
        }

        private void FrmGe_Tarea_Mant_Load(object sender, EventArgs e)
        {
            try
            {
                dtp_fechaIni.EditValue = DateTime.Now;
                dtp_fechaFin.EditValue = DateTime.Now;

                this.bindinglist_tarea_equipo = new BindingList<tb_tarea_equipo_Info>();
                this.gridControl_colaborativo.DataSource = this.bindinglist_tarea_equipo;

                this.cargar_combos();

                cmb_tarea_estado.EditValue = Cl_Enumeradores.eTipoEstado_Tarea.PEND;
                cmb_tarea_asignado.EditValue = param.IdUsuario;
                cmb_tarea_prioridad.EditValue = Cl_Enumeradores.eTipoPrioridad_Tarea.MEDIA;

                setAccion_In_Control();

                txt_titulo.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cargar_combos()
        {
            try
            {
                this.list_tarea_estado = this.bus_catalogo.Get_CatalogoPorTipo(28);
                this.cmb_tarea_estado.Properties.DataSource = this.list_tarea_estado;

                this.list_tarea_prioridad = this.bus_catalogo.Get_CatalogoPorTipo(29);
                this.cmb_tarea_prioridad.Properties.DataSource = this.list_tarea_prioridad;

                string msg = "";
                this.list_usuario = bus_usuario.Get_List_Usuario_x_Empresa(param.IdEmpresa, ref msg);
                this.cmb_tarea_asignado.Properties.DataSource = list_usuario;
                this.cmb_usuario.DataSource = this.list_usuario;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void setAccion(Cl_Enumeradores.eTipo_action _Accion)
        {
            this.Accion = _Accion;
        }

        public void setInfo(tb_tarea_Info _Info_Tarea)
        {
            this.Info_Tarea = _Info_Tarea;
        }

        private void setAccion_In_Control()
        {
            try
            {
                switch (this.Accion)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:
                        ucGe_Menu.Visible_btnGuardar = DevExpress.XtraBars.BarItemVisibility.Always;
                        ucGe_Menu.Visible_bntGuardar_y_Salir = DevExpress.XtraBars.BarItemVisibility.Always;
                        ucGe_Menu.Visible_bntAnular = DevExpress.XtraBars.BarItemVisibility.Never;
                        ucGe_Menu.Visible_bntSalir = DevExpress.XtraBars.BarItemVisibility.Always;
                        break;

                    case Cl_Enumeradores.eTipo_action.actualizar:
                        ucGe_Menu.Visible_btnGuardar = DevExpress.XtraBars.BarItemVisibility.Always;
                        ucGe_Menu.Visible_bntGuardar_y_Salir = DevExpress.XtraBars.BarItemVisibility.Always;
                        ucGe_Menu.Visible_bntAnular = DevExpress.XtraBars.BarItemVisibility.Always;
                        ucGe_Menu.Visible_bntSalir = DevExpress.XtraBars.BarItemVisibility.Always;
                        setInfo_In_Control();
                        break;

                    case Cl_Enumeradores.eTipo_action.Anular:
                        ucGe_Menu.Visible_btnGuardar = DevExpress.XtraBars.BarItemVisibility.Never;
                        ucGe_Menu.Visible_bntGuardar_y_Salir = DevExpress.XtraBars.BarItemVisibility.Never;
                        ucGe_Menu.Visible_bntAnular = DevExpress.XtraBars.BarItemVisibility.Always;
                        ucGe_Menu.Visible_bntSalir = DevExpress.XtraBars.BarItemVisibility.Always;
                        setInfo_In_Control();
                        break;

                    case Cl_Enumeradores.eTipo_action.consultar:
                        ucGe_Menu.Visible_btnGuardar = DevExpress.XtraBars.BarItemVisibility.Never;
                        ucGe_Menu.Visible_bntGuardar_y_Salir = DevExpress.XtraBars.BarItemVisibility.Never;
                        ucGe_Menu.Visible_bntAnular = DevExpress.XtraBars.BarItemVisibility.Never;
                        ucGe_Menu.Visible_bntSalir = DevExpress.XtraBars.BarItemVisibility.Always;
                        setInfo_In_Control();
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void setInfo_In_Control()
        {
            try
            {
                if (this.Info_Tarea != null)
                {
                    txt_id.EditValue = this.Info_Tarea.IdTarea;
                    txt_titulo.EditValue = this.Info_Tarea.Titulo;
                    txt_descripcion.EditValue = this.Info_Tarea.Descripcion;
                    dtp_fechaIni.EditValue = this.Info_Tarea.FechaIni;
                    dtp_fechaFin.EditValue = this.Info_Tarea.FechaFin;
                    chk_activo.Checked = this.Info_Tarea.Estado == "A" ? true : false;
                    cmb_tarea_estado.EditValue = this.Info_Tarea.EstadoTarea;
                    cmb_tarea_asignado.EditValue = this.Info_Tarea.IdUsuarioUltAsignacion;
                    cmb_tarea_prioridad.EditValue = this.Info_Tarea.Prioridad;
                    txt_fechaCreacion.EditValue = this.Info_Tarea.FechaCreacion;
                    txt_usuarioCreacion.EditValue = this.Info_Tarea.IdUsuarioCreacion;
                    txt_fechaUltMod.EditValue = this.Info_Tarea.FechaUltMod;
                    txt_usuarioUltMod.EditValue = this.Info_Tarea.IdUsuarioUltMod;

                    this.Info_Tarea.List_Tarea_Equipo = this.bus_tarea_equipo.Get_List(this.Info_Tarea.IdEmpresa, this.Info_Tarea.IdTarea);
                    this.bindinglist_tarea_equipo = new BindingList<tb_tarea_equipo_Info>(this.Info_Tarea.List_Tarea_Equipo);
                    this.gridControl_colaborativo.DataSource = this.bindinglist_tarea_equipo;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dtp_fechaIni_EditValueChanged(object sender, EventArgs e)
        {
            validar_fechas();
        }

        private void dtp_fechaFin_EditValueChanged(object sender, EventArgs e)
        {
            validar_fechas();
        }

        private void validar_fechas()
        {
            DateTime fechaIni = Convert.ToDateTime(dtp_fechaIni.EditValue).Date;
            DateTime fechaFin = Convert.ToDateTime(dtp_fechaIni.EditValue).Date;

            if (fechaIni > fechaFin)
            {
                dtp_fechaFin.EditValue = fechaIni;
            }
        }

        private bool validar()
        {
            try
            {
                if (txt_titulo.EditValue == null)
                {
                    MessageBox.Show("El campo titulo es requerido!", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txt_titulo.Focus();
                    return false;
                }

                if (cmb_tarea_estado.EditValue == null)
                {
                    MessageBox.Show("El campo estado es requerido!", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    cmb_tarea_estado.Focus();
                    return false;
                }

                if (cmb_tarea_prioridad.EditValue == null)
                {
                    MessageBox.Show("El campo prioridad es requerido!", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    cmb_tarea_prioridad.Focus();
                    return false;
                }

                if (dtp_fechaIni.EditValue == null)
                {
                    MessageBox.Show("El campo fecha inicio es requerido!", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    dtp_fechaIni.Focus();
                    return false;
                }

                if (dtp_fechaFin.EditValue == null)
                {
                    MessageBox.Show("El campo fecha fin es requerido!", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    dtp_fechaFin.Focus();
                    return false;
                }

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void chk_activo_CheckedChanged(object sender, EventArgs e)
        {
            lbl_anulado.Visible = chk_activo.Checked ? false : true;
        }

        private bool anular()
        {
            try
            {
                if (MessageBox.Show("¿Esta seguro de anular la tarea?", param.Nombre_sistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) return false;

                this.getInfo();
                this.Info_Tarea.Estado = "I";
                this.Info_Tarea.IdUsuarioUltAnu = param.IdUsuario;
                this.Info_Tarea.FechaUltAnu = param.Fecha_Transac;
                this.Info_Tarea.MotivoAnu = "*** ANULADO ***";

                if (bus_tarea.AnularBD(this.Info_Tarea))
                {
                    MessageBox.Show("Tarea anulada con éxito!", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Accion = Cl_Enumeradores.eTipo_action.consultar;
                    setAccion_In_Control();
                    return true;
                }
                else
                {
                    MessageBox.Show("Ocurrio un error al anular el registro!", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private bool grabarBD()
        {
            try
            {
                if (!this.validar()) return false;

                switch (this.Accion)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:
                        this.getInfo();
                        this.Info_Tarea.IdUsuarioCreacion = param.IdUsuario;
                        this.Info_Tarea.FechaCreacion = param.Fecha_Transac;

                        if (!bus_tarea.GrabarBD(this.Info_Tarea))
                        {
                            MessageBox.Show("Ocurrio un error al anular el registro!", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            return false;
                        }

                        MessageBox.Show("Tarea registrada con éxito!", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.limpiar();
                        break;

                    case Cl_Enumeradores.eTipo_action.actualizar:
                        this.getInfo();
                        this.Info_Tarea.IdUsuarioUltMod = param.IdUsuario;
                        this.Info_Tarea.FechaUltMod = param.Fecha_Transac;

                        if (!bus_tarea.ModificarBD(this.Info_Tarea))
                        {
                            MessageBox.Show("Ocurrio un error al anular el registro!", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            return false;
                        }

                        MessageBox.Show("Tarea registrada con éxito!", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.limpiar();
                        break;
                }

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void getInfo()
        {
            try
            {
                this.Info_Tarea = new tb_tarea_Info();
                this.Info_Tarea.IdEmpresa = param.IdEmpresa;
                this.Info_Tarea.IdTarea = Convert.ToDecimal(txt_id.EditValue);
                this.Info_Tarea.Titulo = Convert.ToString(txt_titulo.EditValue);
                this.Info_Tarea.Descripcion = Convert.ToString(txt_descripcion.EditValue);
                this.Info_Tarea.FechaIni = Convert.ToDateTime(dtp_fechaIni.EditValue);
                this.Info_Tarea.FechaFin = Convert.ToDateTime(dtp_fechaFin.EditValue);
                this.Info_Tarea.Estado = chk_activo.Checked == true ? "A" : "I";
                this.Info_Tarea.EstadoTarea = Convert.ToString(cmb_tarea_estado.EditValue);
                this.Info_Tarea.IdUsuarioUltAsignacion = Convert.ToString(cmb_tarea_asignado.EditValue);
                this.Info_Tarea.Prioridad = Convert.ToString(cmb_tarea_prioridad.EditValue);
                this.Info_Tarea.List_Tarea_Equipo = new List<tb_tarea_equipo_Info>(bindinglist_tarea_equipo);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void limpiar()
        {
            try
            {
                this.Accion = Cl_Enumeradores.eTipo_action.actualizar;
                this.setAccion_In_Control();

                txt_id.EditValue = null;
                txt_titulo.EditValue = null;
                txt_descripcion.EditValue = null;
                cmb_tarea_estado.EditValue = null;
                cmb_tarea_asignado.EditValue = null;
                cmb_tarea_prioridad.EditValue = null;
                dtp_fechaIni.EditValue = DateTime.Now;
                dtp_fechaFin.EditValue = DateTime.Now;
                chk_activo.Checked = true;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmGe_Tarea_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
            event_FrmGe_Tarea_Mant_FormClosing(sender, e);
        }

        private void set_ReadOnly_controls(bool value)
        {
            try
            {
                txt_titulo.Properties.ReadOnly = value;
                txt_descripcion.Properties.ReadOnly = value;
                cmb_tarea_asignado.Properties.ReadOnly = value;
                cmb_tarea_estado.Properties.ReadOnly = value;
                cmb_tarea_prioridad.Properties.ReadOnly = value;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}