using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bizu.Application.Inventario;
using Bizu.Domain.Inventario;
using Bizu.Application.General;
using Bizu.Domain.General;
using Bizu.Presentation.General;

namespace Bizu.Presentation.Inventario
{
    public partial class frmIn_motivo_guia_remision_Mant : DevExpress.XtraEditors.XtraForm
    {        

        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        in_GuiaRemision_Motivo_Info GuiaRemision_Motivo_Info = new in_GuiaRemision_Motivo_Info();
        in_GuiaRemision_Motivo_Bus Bus_MotivoGuiaRemision = new in_GuiaRemision_Motivo_Bus();
        private Cl_Enumeradores.eTipo_action Accion;
        string mensaje;
      
        public delegate void delegate_motivo_venta_Consulta_FormClosing(object sender, FormClosingEventArgs e);        
        public event delegate_motivo_venta_Consulta_FormClosing event_frmIn_motivo_guia_remision_Mant_FormClosing;

        public frmIn_motivo_guia_remision_Mant()
        {
            InitializeComponent();            
        }

        public void Set_Accion(Cl_Enumeradores.eTipo_action iAccion)
        {
            try
            {
                Accion = iAccion;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }
        }

        public void Set_Info(in_GuiaRemision_Motivo_Info Motivo)
        {
            try
            {
                GuiaRemision_Motivo_Info = Motivo;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }
        }

        public void Get_Info()
        {
            try
            {
                GuiaRemision_Motivo_Info = new in_GuiaRemision_Motivo_Info();
                GuiaRemision_Motivo_Info.IdEmpresa = param.IdEmpresa;
                GuiaRemision_Motivo_Info.IdMotivo = Convert.ToInt32(txt_IdMotivo.Text);
                GuiaRemision_Motivo_Info.Codigo = txtCodigo.Text;
                GuiaRemision_Motivo_Info.Descripcion = txtDescripcion.Text;
                GuiaRemision_Motivo_Info.Estado = (chkEstado.Checked == true) ? "A" : "I";
                if(chkEstado.Checked)
                    lbl_Estado.Visible=false;
                else
                    lbl_Estado.Visible=true;                
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                mensaje = ex.Message.ToString();
                MessageBox.Show("Error " + mensaje, "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                throw;
            }
        }

        public void Set_Action_In_Control()
        {
            try
            {
                txt_IdMotivo.Text = GuiaRemision_Motivo_Info.IdMotivo.ToString();
                txtCodigo.Text = GuiaRemision_Motivo_Info.Codigo.ToString();
                txtDescripcion.Text = GuiaRemision_Motivo_Info.Descripcion.ToString();
                chkEstado.Checked = (GuiaRemision_Motivo_Info.Estado == "A") ? true : false;
                if (chkEstado.Checked)
                    lbl_Estado.Visible = false;
                else
                    lbl_Estado.Visible = true;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                mensaje = ex.Message.ToString();
                MessageBox.Show("Error " + mensaje, "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                throw;
            }
        }

        public void Limpiar()
        {
            try
            {
                txt_IdMotivo.Text = "0";
                txtCodigo.Text = "";
                txtDescripcion.Text = "";
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.Message);
            }
        }

        public Boolean Validar()
        {
            try
            {
                if (txtCodigo.Text == "" || txtCodigo.EditValue == null)
                {
                    MessageBox.Show("Por favor ingrese código", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }

                if (txtDescripcion.Text == "" || txtDescripcion.EditValue == null)
                {
                    MessageBox.Show("Por favor ingrese descripción", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }
                return true;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public Boolean Anular()
        {
            try
            {
                Get_Info();

                if (GuiaRemision_Motivo_Info.Estado == "I")
                {
                    MessageBox.Show("El registro ya se encuentra anulado", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                else
                {
                    if (MessageBox.Show("¿Está seguro que desea anular el motivo #:" + txt_IdMotivo.Text.Trim() + " ?", "Anulación de Mantenimiento", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        bool resultado = Bus_MotivoGuiaRemision.Anular(GuiaRemision_Motivo_Info, ref mensaje);

                        if (resultado)
                        {
                            MessageBox.Show(mensaje, "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.ucGe_Menu_Superior_Mant1.Visible_bntGuardar_y_Salir = DevExpress.XtraBars.BarItemVisibility.Never;
                            this.ucGe_Menu_Superior_Mant1.Visible_btnGuardar = DevExpress.XtraBars.BarItemVisibility.Never;
                        }
                        else
                        {
                            Log_Error_bus.Log_Error(mensaje.ToString());
                            MessageBox.Show("Error " + mensaje, "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        return true;
                    }
                    else
                        return false;
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public Boolean Guardar()
        {
            bool resultado = false;

            try
            {                
                mensaje="";
                int id = 0;

                Get_Info();
               
                if (Bus_MotivoGuiaRemision.Get_List_in_motivo_guia_remision_Existe(GuiaRemision_Motivo_Info, ref mensaje))
                {
                    MessageBox.Show("el codigo ingresado: " + GuiaRemision_Motivo_Info.Codigo.ToString() + " ya existe.\nPor favor ingrese un codigo diferente");                    
                }

                resultado = Bus_MotivoGuiaRemision.Grabar(GuiaRemision_Motivo_Info, ref id, ref mensaje);                

                if (resultado == true)
                {
                    txt_IdMotivo.Text = id.ToString();

                    MessageBox.Show(mensaje, " Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.ucGe_Menu_Superior_Mant1.Visible_bntGuardar_y_Salir = DevExpress.XtraBars.BarItemVisibility.Always;
                    this.ucGe_Menu_Superior_Mant1.Visible_btnGuardar = DevExpress.XtraBars.BarItemVisibility.Always;
                }
                else
                {
                    Log_Error_bus.Log_Error(mensaje.ToString());
                    MessageBox.Show("Error " + mensaje, "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                return resultado;
            }
            catch (Exception ex)
            {
               Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public Boolean Modificar()
        {
            bool resultado = false;

            try
            {                                
                mensaje = "";
                
                Get_Info();

                resultado = Bus_MotivoGuiaRemision.Modificar(GuiaRemision_Motivo_Info, ref mensaje);

                if (resultado == true)
                {
                    MessageBox.Show(mensaje, "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.ucGe_Menu_Superior_Mant1.Visible_btnGuardar = DevExpress.XtraBars.BarItemVisibility.Never;
                    this.ucGe_Menu_Superior_Mant1.Visible_bntGuardar_y_Salir = DevExpress.XtraBars.BarItemVisibility.Never;
                }
                else
                {
                    Log_Error_bus.Log_Error(mensaje.ToString());
                    MessageBox.Show("Error " + mensaje, "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                return resultado;
            }
            catch (Exception ex)
            {
               Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public Boolean Guardar_Datos()
        {
            bool resultado = false;

            try
            {
                if (Validar())
                {
                    switch (Accion)
                    {
                        case Cl_Enumeradores.eTipo_action.grabar:
                            resultado = Guardar();
                            break;

                        case Cl_Enumeradores.eTipo_action.actualizar:
                            resultado = Modificar();
                            break;
                    }
                }
            
                return resultado;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.Message);
                return false;
            }
        }        

        private void ucGe_Menu_Superior_Mant1_event_btnSalir_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                mensaje = ex.Message.ToString();
                MessageBox.Show("Error " + mensaje, "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                throw;
            }
        }

        private void ucGe_Menu_Superior_Mant1_event_btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Guardar_Datos())
                    Limpiar();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                mensaje = ex.Message.ToString();
                MessageBox.Show("Error " + mensaje, "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                throw;
            }
        }

        private void ucGe_Menu_Superior_Mant1_event_btnlimpiar_Click(object sender, EventArgs e)
        {
            try
            {
                Limpiar();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                mensaje = ex.Message.ToString();
                MessageBox.Show("Error " + mensaje, "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                throw;
            }
        }

        private void ucGe_Menu_Superior_Mant1_event_btnGuardar_y_Salir_Click(object sender, EventArgs e)
        {
            try
            {
                if (Guardar_Datos())
                    this.Close();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                mensaje = ex.Message.ToString();
                MessageBox.Show("Error " + mensaje, "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                throw;
            }
        }

        private void ucGe_Menu_Superior_Mant1_event_btnAnular_Click(object sender, EventArgs e)
        {
            try
            {
                Get_Info();

                if (Anular())
                    MessageBox.Show("El registro se anuló satisfactoriamente", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("El registro se no se anuló.Consulte con su departamento de Sistemas", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                mensaje = ex.Message.ToString();
                MessageBox.Show("Error " + mensaje, "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                throw;
            }
        }

        private void frmIn_motivo_guia_remision_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
            event_frmIn_motivo_guia_remision_Mant_FormClosing(sender, e);
        }

        private void frmIn_motivo_guia_remision_Mant_Load(object sender, EventArgs e)
        {
            try
            {               
                switch (Accion)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:
                        ucGe_Menu_Superior_Mant1.Visible_bntAnular = DevExpress.XtraBars.BarItemVisibility.Never;                        
                        chkEstado.Checked = true;
                        break;
                    case Cl_Enumeradores.eTipo_action.actualizar:
                        ucGe_Menu_Superior_Mant1.Visible_bntAnular = DevExpress.XtraBars.BarItemVisibility.Never;
                        ucGe_Menu_Superior_Mant1.Visible_bntLimpiar = DevExpress.XtraBars.BarItemVisibility.Never;                                                
                        Set_Action_In_Control();
                        break;
                    case Cl_Enumeradores.eTipo_action.consultar:
                        ucGe_Menu_Superior_Mant1.Visible_bntAnular = DevExpress.XtraBars.BarItemVisibility.Never;
                        ucGe_Menu_Superior_Mant1.Visible_bntLimpiar = DevExpress.XtraBars.BarItemVisibility.Never;
                        ucGe_Menu_Superior_Mant1.Visible_btnGuardar = DevExpress.XtraBars.BarItemVisibility.Never;
                        ucGe_Menu_Superior_Mant1.Visible_bntGuardar_y_Salir = DevExpress.XtraBars.BarItemVisibility.Never;                        
                        txtCodigo.Enabled = false;
                        txtDescripcion.Enabled = false;
                        chkEstado.Enabled = false;
                        Set_Action_In_Control();
                        break;
                    case Cl_Enumeradores.eTipo_action.Anular:
                        ucGe_Menu_Superior_Mant1.Enabled_bntAnular = true;
                        ucGe_Menu_Superior_Mant1.Visible_btnGuardar = DevExpress.XtraBars.BarItemVisibility.Never;
                        ucGe_Menu_Superior_Mant1.Visible_bntGuardar_y_Salir = DevExpress.XtraBars.BarItemVisibility.Never;
                        ucGe_Menu_Superior_Mant1.Visible_bntLimpiar = DevExpress.XtraBars.BarItemVisibility.Never;
                        txt_IdMotivo.Enabled = false;
                        txtCodigo.Enabled = false;
                        txtDescripcion.Enabled = false;
                        chkEstado.Enabled = false;
                        Set_Action_In_Control();
                        break;
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                mensaje = ex.Message.ToString();
                MessageBox.Show("Error " + mensaje, "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                throw;
            }
        }
    }
}
