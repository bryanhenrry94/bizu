using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bizu.Application.General;
using Bizu.Domain.General;
using Bizu.Domain.Inventario;
using Bizu.Application.Inventario;
using Bizu.Application.SeguridadAcceso;
using Bizu.Domain.SeguridadAcceso;

namespace Bizu.Presentation.Inventario
{
    public partial class frmIn_motivo_guia_remision_Cons : DevExpress.XtraEditors.XtraForm
    {             
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();        
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;        
        frmIn_motivo_guia_remision_Mant frm;        
        in_GuiaRemision_Motivo_Info Motivo_GuiaRemision_Info = new in_GuiaRemision_Motivo_Info();
        List<in_GuiaRemision_Motivo_Info> Lista_Motivo_Venta = new List<in_GuiaRemision_Motivo_Info>();
        in_GuiaRemision_Motivo_Bus MotivoVenta_Bus = new in_GuiaRemision_Motivo_Bus();

        public frmIn_motivo_guia_remision_Cons()
        {
            InitializeComponent();

            ucGe_Menu_Mantenimiento_Motivo.event_btnNuevo_ItemClick += ucGe_Menu_Mantenimiento_Motivo_event_btnNuevo_ItemClick;
            ucGe_Menu_Mantenimiento_Motivo.event_btnModificar_ItemClick += ucGe_Menu_Mantenimiento_Motivo_event_btnModificar_ItemClick;
            ucGe_Menu_Mantenimiento_Motivo.event_btnconsultar_ItemClick += ucGe_Menu_Mantenimiento_Motivo_event_btnconsultar_ItemClick;
            ucGe_Menu_Mantenimiento_Motivo.event_btnAnular_ItemClick += ucGe_Menu_Mantenimiento_Motivo_event_btnAnular_ItemClick;
            ucGe_Menu_Mantenimiento_Motivo.event_btnImprimir_ItemClick += ucGe_Menu_Mantenimiento_Motivo_event_btnImprimir_ItemClick;
            ucGe_Menu_Mantenimiento_Motivo.event_btnSalir_ItemClick += ucGe_Menu_Mantenimiento_Motivo_event_btnSalir_ItemClick;
            ucGe_Menu_Mantenimiento_Motivo.event_btnBuscar_Click += ucGe_Menu_Mantenimiento_Motivo_event_btnBuscar_Click;
        }

        void ucGe_Menu_Mantenimiento_Motivo_event_btnBuscar_Click(object sender, EventArgs e)
        {
            LLenar_Grid();            
        }
       
        void ucGe_Menu_Mantenimiento_Motivo_event_btnSalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        void ucGe_Menu_Mantenimiento_Motivo_event_btnImprimir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.gridControl_MotivoVenta.ShowPrintPreview();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show("Error comunicarse con Sistemas " + ex.Message + " ", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void ucGe_Menu_Mantenimiento_Motivo_event_btnAnular_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                //asigna un valor a una variable para realizar la busqueda
                Motivo_GuiaRemision_Info = (in_GuiaRemision_Motivo_Info)this.gridViewMotivoVenta.GetFocusedRow();
                //Pregunta si esta seleccionado un registro
                if (Motivo_GuiaRemision_Info == null)
                    MessageBox.Show("Por Favor seleccione un registro.", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    if (Motivo_GuiaRemision_Info.Estado != "I")
                        Preparar_Formulario(Cl_Enumeradores.eTipo_action.Anular);
                    else
                        MessageBox.Show("El registro seleccionado ya se encuentra anulado.\n\n Por favor seleccione otro registro.", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show("Error comunicarse con Sistemas " + ex.Message + " ", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }    
        }

        void ucGe_Menu_Mantenimiento_Motivo_event_btnconsultar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                //asigna un valor a una variable para realizar la busqueda
                Motivo_GuiaRemision_Info = (in_GuiaRemision_Motivo_Info)this.gridViewMotivoVenta.GetFocusedRow();
                //Pregunta si esta seleccionado un registro
                if (Motivo_GuiaRemision_Info == null)
                    MessageBox.Show("Por Favor seleccione un registro.", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    Preparar_Formulario(Cl_Enumeradores.eTipo_action.consultar);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show("Error comunicarse con Sistemas " + ex.Message + " ", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }  
        }

        void ucGe_Menu_Mantenimiento_Motivo_event_btnModificar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                //asigna un valor a una variable para realizar la busqueda
                Motivo_GuiaRemision_Info = (in_GuiaRemision_Motivo_Info)this.gridViewMotivoVenta.GetFocusedRow();
                //Pregunta si esta seleccionado un registro
                if (Motivo_GuiaRemision_Info == null)
                    MessageBox.Show("Por Favor seleccione un registro.", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    Preparar_Formulario(Cl_Enumeradores.eTipo_action.actualizar);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show("Error comunicarse con Sistemas " + ex.Message + " ", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }       
        }

        void ucGe_Menu_Mantenimiento_Motivo_event_btnNuevo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                Preparar_Formulario(Cl_Enumeradores.eTipo_action.grabar);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show("Error comunicarse con Sistemas " + ex.Message + " ", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void LLenar_Grid()
        {
            try
            {               
                Lista_Motivo_Venta = MotivoVenta_Bus.Get_List_motivo(param.IdEmpresa);
                gridControl_MotivoVenta.DataSource = Lista_Motivo_Venta;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show("Error comunicarse con Sistemas " + ex.Message + " ", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Preparar_Formulario(Cl_Enumeradores.eTipo_action Accion)
        {
            try
            {
                frm = new frmIn_motivo_guia_remision_Mant();
                frm.MdiParent = this.MdiParent;
                frm.event_frmIn_motivo_guia_remision_Mant_FormClosing += frm_event_frmIn_motivo_guia_remision_Mant_FormClosing;

                if (Accion != Cl_Enumeradores.eTipo_action.grabar)
                    frm.Set_Info(Motivo_GuiaRemision_Info);

                frm.Set_Accion(Accion);
                frm.Show();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show("Error comunicarse con Sistemas " + ex.Message + " ", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void frm_event_frmIn_motivo_guia_remision_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                LLenar_Grid();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show("Error comunicarse con Sistemas " + ex.Message + " ", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }        

        private void frmIn_motivo_guia_remision_Cons_Load(object sender, EventArgs e)
        {
            try
            {
                LLenar_Grid();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show("Error comunicarse con Sistemas " + ex.Message + " ", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }      

        private void gridViewMotivoVenta_RowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
        {
            try
            {
                var data = gridViewMotivoVenta.GetRow(e.RowHandle) as in_GuiaRemision_Motivo_Info;
                if (data == null)
                    return;
                if (data.Estado == "I")
                    e.Appearance.ForeColor = Color.Red;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
    }
}
