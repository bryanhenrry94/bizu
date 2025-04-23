using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bizu.Presentation.General;
using Bizu.Application.General;
using Bizu.Domain.CuentasxPagar;
using Bizu.Application.CuentasxPagar;

namespace Bizu.Presentation.CuentasxPagar
{
    public partial class frmCp_Proveedor_Calificacion_Mant : DevExpress.XtraEditors.XtraForm
    {
        public delegate void delegate_frmCp_Proveedor_Calificacion_Mant_FormClosing(object sender, FormClosingEventArgs e);
        public event delegate_frmCp_Proveedor_Calificacion_Mant_FormClosing event_frmCp_Proveedor_Calificacion_Mant_FormClosing;
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        cp_proveedor_Calificacion_Info Info = new cp_proveedor_Calificacion_Info();
        cp_proveedor_Calificacion_Bus Bus_Calificacion_Prov = new cp_proveedor_Calificacion_Bus();        
        cp_proveedor_Bus Bus_Proveedor = new cp_proveedor_Bus();
        List<cp_proveedor_Info> List_Proveedor = new List<cp_proveedor_Info>();
        BindingList<cp_proveedor_Calificacion_Info> BindingList_Calificacion = new BindingList<cp_proveedor_Calificacion_Info>();
        List<cp_proveedor_Calificacion_Info> List_Calificacion = new List<cp_proveedor_Calificacion_Info>();

        public frmCp_Proveedor_Calificacion_Mant()
        {
            InitializeComponent();
            event_frmCp_Proveedor_Calificacion_Mant_FormClosing += frmCp_Proveedor_Calificacion_Mant_event_frmCp_Proveedor_Calificacion_Mant_FormClosing;
            ucGe_Menu_Superior_Mant.event_btnGuardar_y_Salir_Click += ucGe_Menu_Superior_Mant_event_btnGuardar_y_Salir_Click;
            ucGe_Menu_Superior_Mant.event_btnSalir_Click += ucGe_Menu_Superior_Mant_event_btnSalir_Click;
            ucGe_Menu_Superior_Mant.event_btnAnular_Click += ucGe_Menu_Superior_Mant_event_btnAnular_Click;
            ucGe_Menu_Superior_Mant.event_btnImprimir_Click += ucGe_Menu_Superior_Mant_event_btnImprimir_Click;
        }

        void ucGe_Menu_Superior_Mant_event_btnImprimir_Click(object sender, EventArgs e)
        {
            gridControlCalificacion.ShowPrintPreview();
        }

        void ucGe_Menu_Superior_Mant_event_btnAnular_Click(object sender, EventArgs e)
        {
            Anular();
        }

        public Boolean Anular()
        {
            try
            {
                cp_proveedor_Calificacion_Info Info = (cp_proveedor_Calificacion_Info)gridViewCalificacion.GetFocusedRow();

                if (Info != null)
                {
                    if (MessageBox.Show("¿Está seguro que desea anular la calificación #:" + Info.IdCalificacion + " ?", "Anulación ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        FrmGe_MotivoAnulacion fr = new FrmGe_MotivoAnulacion();
                        fr.ShowDialog();

                        string mensaje = string.Empty;                        

                        Info.IdUsuarioAnulacion = param.IdUsuario;
                        Info.MotivoAnulacion = fr.motivoAnulacion;

                        bool resultado = Bus_Calificacion_Prov.Anular(Info);
                        if (resultado)
                        {
                            MessageBox.Show("Se ha anulado correctamente la calificacion # : " + Info.IdCalificacion, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            Log_Error_bus.Log_Error(mensaje.ToString());
                            MessageBox.Show("Error " + mensaje, "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }                    
                }
                else
                {
                    MessageBox.Show("Seleccione un registro!!", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                return true;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                return false;
            }
        }

        void ucGe_Menu_Superior_Mant_event_btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void ucGe_Menu_Superior_Mant_event_btnGuardar_y_Salir_Click(object sender, EventArgs e)
        {
            Grabar();
        }

        void frmCp_Proveedor_Calificacion_Mant_event_frmCp_Proveedor_Calificacion_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void frmCp_Proveedor_Calificacion_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
            event_frmCp_Proveedor_Calificacion_Mant_FormClosing(sender, e);
        }

        private void frmCp_Proveedor_Calificacion_Mant_Load(object sender, EventArgs e)
        {
            try
            {
                cargar_combo();

                List_Calificacion = Bus_Calificacion_Prov.GetAll(param.IdEmpresa);
                BindingList_Calificacion = new BindingList<cp_proveedor_Calificacion_Info>(List_Calificacion);

                gridControlCalificacion.DataSource = BindingList_Calificacion;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());                
            }
        }

        private void cargar_combo()
        {
            try
            {
                List_Proveedor = Bus_Proveedor.Get_List_proveedor(param.IdEmpresa);
                cmb_proveedor.DataSource = List_Proveedor;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());              
            }
        }

        private Boolean Grabar()
        {
            try
            {
                if (MessageBox.Show("¿Desea grabar el registro?", "Anulación ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    GetInfo();

                    if (Bus_Calificacion_Prov.Grabar(List_Calificacion))
                    {
                        MessageBox.Show("Registro grabado con éxito!!", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        cargar_grid();
                    }
                }

                return true;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                return false;
            }
        }

        private void GetInfo()
        {
            try
            {              
                List_Calificacion = new List<cp_proveedor_Calificacion_Info>(BindingList_Calificacion);
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());                
            }
        }

        private void gridViewCalificacion_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
                cp_proveedor_Calificacion_Info Info = (cp_proveedor_Calificacion_Info) gridViewCalificacion.GetFocusedRow();

                if (Info != null)
                {
                    if (e.Column == colCalificacion)
                    {
                        if (Info.Calificacion >= 60)
                        {
                            gridViewCalificacion.SetFocusedRowCellValue(colLiberado, true);
                        }
                        else
                        {
                            gridViewCalificacion.SetFocusedRowCellValue(colLiberado, false);
                        }
                        
                        gridViewCalificacion.SetFocusedRowCellValue(colModificado, true);
                    }
                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void cargar_grid()
        {
            try
            {
                List_Calificacion = Bus_Calificacion_Prov.GetAll(param.IdEmpresa);
                BindingList_Calificacion = new BindingList<cp_proveedor_Calificacion_Info>(List_Calificacion);

                gridControlCalificacion.DataSource = BindingList_Calificacion;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }
    }
}
